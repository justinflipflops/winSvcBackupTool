using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.ServiceProcess;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace winSvcBackupTool
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            Status($"Idle...");
            this.Update();
        }

        private void frmMain_Shown(object sender, EventArgs e)
        {
            SetGuiState(0);
        }

        private void SetGuiState(int _state)
        {
            btnReload.Enabled = true;
            btnCreate.Enabled = _state > 0 ? true : false;
            btnLoad.Enabled = _state > 0 ? true : false;
            btnAnalyze.Enabled = _state > 1 ? true : false;
            btnUpdate.Enabled = _state > 1 ? true : false;
            tabNavi.Enabled = _state > 0 ? true : false;
            lstCurrentServices.Enabled = _state > 0 ? true : false;
            lstBackupServices.Enabled = _state > 1 ? true : false;

        }

        private void Status(string szStatus = "")
        {
            toolStripStatus.Text = $"Status: {szStatus}";
            this.Update();
        }

        private string GetLocalServiceDescription(ServiceController _service)
        {
            string _result = "";
            try
            {
                ManagementObject wmiService;
                wmiService = new ManagementObject("Win32_Service.Name='" + _service.ServiceName + "'");
                wmiService.Get();
                _result = (string)wmiService["Description"];
            }
            catch
            {
                _result = "";
            }
            return _result;
        }
        private bool LoadLocalServices()
        {
            bool _result = false;
            try
            {
                lstCurrentServices.Items.Clear();
                ServiceController[] _localServices = ServiceController.GetServices();
                toolStripProgress.Minimum = 0;
                toolStripProgress.Maximum = _localServices.Count();
                toolStripProgress.Value = 0;
                toolStripProgress.Visible = true;
                this.Update();
                foreach (ServiceController _svc in _localServices)
                {
                    ListViewItem _new = new ListViewItem();
                    _new.Text = _svc.ServiceName;
                    _new.SubItems.Add(_svc.StartType.ToString());
                    _new.SubItems.Add(_svc.Status.ToString());
                    _new.SubItems.Add(GetLocalServiceDescription(_svc));
                    _new.Tag = _svc;
                    lstCurrentServices.Items.Add(_new);
                    _new = null;
                    toolStripProgress.Value++;
                    this.Update();
                }
                toolStripProgress.Visible = false;
                this.Update();
                _result = true;
            }
            catch
            {
                _result = false;
                lstCurrentServices.Items.Clear();
            }
            return _result;
        }

        private ServiceBackupModel[] ListViewToServiceBackupModel(ListView _listView)
        {
            List<ServiceBackupModel> _result = new List<ServiceBackupModel>();
            if (_listView != null && _listView.Items.Count > 0)
            {
                foreach(ListViewItem _item in _listView.Items)
                {
                    _result.Add(new ServiceBackupModel()
                    {
                        ServiceName = _item.SubItems[0].Text,
                        StartType = (ServiceStartMode)Enum.Parse(typeof(ServiceStartMode), _item.SubItems[1].Text),
                        Status = (ServiceControllerStatus)Enum.Parse(typeof(ServiceControllerStatus), _item.SubItems[2].Text),
                        Description = _item.SubItems[3].Text,
                        Tag = _item.Index
                    });
                }
            }
            return _result.ToArray();
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            SaveFileDialog _saveFile = new SaveFileDialog();
            _saveFile.Filter = "Backup JSON File|*.json";
            _saveFile.Title = "Save Backup as JSON File";
            _saveFile.CheckPathExists = true;
            _saveFile.ShowDialog();
            // If the file name is not an empty string open it for saving.
            if (_saveFile.FileName != "")
            {
                Status("Saving Backup");
                try
                {
                    JsonSerializerSettings _jsonSettings = new JsonSerializerSettings() { TypeNameHandling = TypeNameHandling.All };
                    string _jsonData = JsonConvert.SerializeObject(ListViewToServiceBackupModel(lstCurrentServices),_jsonSettings);
                    using (StreamWriter _Writer = new StreamWriter(_saveFile.FileName, false))
                    {
                        _Writer.Write(_jsonData);
                        _Writer.Flush();
                        _Writer.Close();
                    }
                    Status("Backup Saved");
                }
                catch(Exception _ex)
                {
                    _ex = _ex;
                    Status("Backuped Failed to Save");
                }
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog _openFile = new OpenFileDialog();
            _openFile.Filter = "Backup JSON File|*.json";
            _openFile.Title = "Open Backup JSON File";
            _openFile.CheckPathExists = true;
            _openFile.CheckFileExists = true;
            _openFile.ShowDialog();
            if (_openFile.FileName != "")
            {
                Status("Loading Backup");
                lstBackupServices.Items.Clear();
                try
                {
                    using (StreamReader _reader = new StreamReader(_openFile.FileName))
                    {
                        string _jsonData = _reader.ReadToEnd();
                        JsonSerializerSettings _jsonSettings = new JsonSerializerSettings() { TypeNameHandling = TypeNameHandling.All };
                        ServiceBackupModel[] _loadedServices = (ServiceBackupModel[])JsonConvert.DeserializeObject(_jsonData, _jsonSettings);
                        toolStripProgress.Value = 0;
                        toolStripProgress.Minimum = 0;
                        toolStripProgress.Maximum = _loadedServices.Count();
                        toolStripProgress.Visible = true;
                        this.Update();
                        foreach(ServiceBackupModel _svc in _loadedServices)
                        {
                            ListViewItem _new = new ListViewItem();
                            _new.Text = _svc.ServiceName;
                            _new.SubItems.Add(_svc.StartType.ToString());
                            _new.SubItems.Add(_svc.Status.ToString());
                            _new.SubItems.Add(_svc.Description);
                            lstBackupServices.Items.Add(_new);
                            _new = null;
                            toolStripProgress.Value++;
                            this.Update();
                        }
                        toolStripProgress.Visible = false;
                        Status("Loaded Backup");
                        SetGuiState(2);
                        this.Update();
                    }
                }
                catch(Exception _ex)
                {
                    lstBackupServices.Items.Clear();
                    Status("Failed to Load Backup");
                    this.Update();
                }
            }
        }

        private void btnAnalyze_Click(object sender, EventArgs e)
        {
            if (lstCurrentServices.Items.Count > 0 && lstBackupServices.Items.Count > 0)
            {
                Status("Analyzing Service Startups");
                ServiceBackupModel[] _current_services = ListViewToServiceBackupModel(lstCurrentServices);
                ServiceBackupModel[] _backup_services = ListViewToServiceBackupModel(lstBackupServices);
                toolStripProgress.Minimum = 0;
                toolStripProgress.Value = 0;
                toolStripProgress.Maximum = _current_services.Length;
                toolStripProgress.Visible = true;
                this.Update();
                foreach(ServiceBackupModel _current in _current_services)
                {
                    int _colorState = 0;
                    foreach(ServiceBackupModel _backup in _backup_services)
                    {
                        if (_current.ServiceName == _backup.ServiceName)
                        {
                            //we have a match check startup
                            if (_current.StartType == _backup.StartType)
                            {
                                //start type = the same color me green
                                _colorState = 3;
                                break;
                            }
                            else
                            {
                                // no match color me red
                                _colorState = 2;
                                break;
                            }
                        }
                    }
                    if (_colorState == 0) { _colorState = 1; }
                    switch(_colorState)
                    {
                        case 1:
                            lstCurrentServices.Items[(int)_current.Tag].BackColor = Color.Yellow;
                            break;
                        case 2:
                            lstCurrentServices.Items[(int)_current.Tag].BackColor = Color.Red;
                            break;
                        case 3:
                            lstCurrentServices.Items[(int)_current.Tag].BackColor = Color.Green;
                            break;
                    }
                    toolStripProgress.Value++;
                    this.Update();
                }
                toolStripProgress.Visible = false;
                Status("Analysis Complete.");
                this.Update();
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            SetGuiState(0);
            Status("Loading Local Services");
            if (LoadLocalServices())
            {
                Status("Loaded Local Services");
                if (lstBackupServices.Items.Count > 0)
                    SetGuiState(2);
                else
                    SetGuiState(1);
            }
            else
                Status("Failed Loading Local Services");
        }
    }
}
