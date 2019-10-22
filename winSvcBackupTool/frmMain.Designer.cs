namespace winSvcBackupTool
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabNavi = new System.Windows.Forms.TabControl();
            this.tabNaviPageCurrent = new System.Windows.Forms.TabPage();
            this.lstCurrentServices = new System.Windows.Forms.ListView();
            this.clmName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmStartType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmDesc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabNaviPageBackup = new System.Windows.Forms.TabPage();
            this.lstBackupServices = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAnalyze = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgress = new System.Windows.Forms.ToolStripProgressBar();
            this.btnReload = new System.Windows.Forms.Button();
            this.tabNavi.SuspendLayout();
            this.tabNaviPageCurrent.SuspendLayout();
            this.tabNaviPageBackup.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabNavi
            // 
            this.tabNavi.Controls.Add(this.tabNaviPageCurrent);
            this.tabNavi.Controls.Add(this.tabNaviPageBackup);
            this.tabNavi.Enabled = false;
            this.tabNavi.Location = new System.Drawing.Point(19, 12);
            this.tabNavi.Name = "tabNavi";
            this.tabNavi.SelectedIndex = 0;
            this.tabNavi.Size = new System.Drawing.Size(1055, 499);
            this.tabNavi.TabIndex = 0;
            // 
            // tabNaviPageCurrent
            // 
            this.tabNaviPageCurrent.Controls.Add(this.lstCurrentServices);
            this.tabNaviPageCurrent.Location = new System.Drawing.Point(8, 39);
            this.tabNaviPageCurrent.Name = "tabNaviPageCurrent";
            this.tabNaviPageCurrent.Padding = new System.Windows.Forms.Padding(3);
            this.tabNaviPageCurrent.Size = new System.Drawing.Size(1039, 452);
            this.tabNaviPageCurrent.TabIndex = 0;
            this.tabNaviPageCurrent.Text = "Current";
            this.tabNaviPageCurrent.UseVisualStyleBackColor = true;
            // 
            // lstCurrentServices
            // 
            this.lstCurrentServices.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmName,
            this.clmStartType,
            this.clmStatus,
            this.clmDesc});
            this.lstCurrentServices.FullRowSelect = true;
            this.lstCurrentServices.HideSelection = false;
            this.lstCurrentServices.LabelWrap = false;
            this.lstCurrentServices.Location = new System.Drawing.Point(11, 10);
            this.lstCurrentServices.MultiSelect = false;
            this.lstCurrentServices.Name = "lstCurrentServices";
            this.lstCurrentServices.Size = new System.Drawing.Size(1018, 434);
            this.lstCurrentServices.TabIndex = 0;
            this.lstCurrentServices.UseCompatibleStateImageBehavior = false;
            this.lstCurrentServices.View = System.Windows.Forms.View.Details;
            // 
            // clmName
            // 
            this.clmName.Text = "Service Name";
            this.clmName.Width = 212;
            // 
            // clmStartType
            // 
            this.clmStartType.Text = "Startup Type";
            this.clmStartType.Width = 218;
            // 
            // clmStatus
            // 
            this.clmStatus.Text = "Status";
            this.clmStatus.Width = 195;
            // 
            // clmDesc
            // 
            this.clmDesc.Text = "Description";
            this.clmDesc.Width = 377;
            // 
            // tabNaviPageBackup
            // 
            this.tabNaviPageBackup.Controls.Add(this.lstBackupServices);
            this.tabNaviPageBackup.Location = new System.Drawing.Point(8, 39);
            this.tabNaviPageBackup.Name = "tabNaviPageBackup";
            this.tabNaviPageBackup.Padding = new System.Windows.Forms.Padding(3);
            this.tabNaviPageBackup.Size = new System.Drawing.Size(1039, 452);
            this.tabNaviPageBackup.TabIndex = 1;
            this.tabNaviPageBackup.Text = "Backup";
            this.tabNaviPageBackup.UseVisualStyleBackColor = true;
            // 
            // lstBackupServices
            // 
            this.lstBackupServices.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lstBackupServices.FullRowSelect = true;
            this.lstBackupServices.HideSelection = false;
            this.lstBackupServices.LabelWrap = false;
            this.lstBackupServices.Location = new System.Drawing.Point(10, 9);
            this.lstBackupServices.MultiSelect = false;
            this.lstBackupServices.Name = "lstBackupServices";
            this.lstBackupServices.Size = new System.Drawing.Size(1018, 434);
            this.lstBackupServices.TabIndex = 1;
            this.lstBackupServices.UseCompatibleStateImageBehavior = false;
            this.lstBackupServices.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Service Name";
            this.columnHeader1.Width = 212;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Startup Type";
            this.columnHeader2.Width = 218;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Status";
            this.columnHeader3.Width = 195;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Description";
            this.columnHeader4.Width = 377;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnReload);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.btnAnalyze);
            this.groupBox1.Controls.Add(this.btnLoad);
            this.groupBox1.Controls.Add(this.btnCreate);
            this.groupBox1.Location = new System.Drawing.Point(19, 511);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1055, 98);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Location = new System.Drawing.Point(872, 30);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(175, 54);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAnalyze
            // 
            this.btnAnalyze.Enabled = false;
            this.btnAnalyze.Location = new System.Drawing.Point(656, 30);
            this.btnAnalyze.Name = "btnAnalyze";
            this.btnAnalyze.Size = new System.Drawing.Size(168, 54);
            this.btnAnalyze.TabIndex = 2;
            this.btnAnalyze.Text = "Analyze";
            this.btnAnalyze.UseVisualStyleBackColor = true;
            this.btnAnalyze.Click += new System.EventHandler(this.btnAnalyze_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Enabled = false;
            this.btnLoad.Location = new System.Drawing.Point(440, 30);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(168, 54);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "Load Backup";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Enabled = false;
            this.btnCreate.Location = new System.Drawing.Point(224, 30);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(168, 54);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "Create Backup";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatus,
            this.toolStripProgress});
            this.statusStrip1.Location = new System.Drawing.Point(0, 610);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1086, 42);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 2;
            // 
            // toolStripStatus
            // 
            this.toolStripStatus.AutoSize = false;
            this.toolStripStatus.Name = "toolStripStatus";
            this.toolStripStatus.Size = new System.Drawing.Size(1071, 32);
            this.toolStripStatus.Spring = true;
            this.toolStripStatus.Text = "Status:";
            this.toolStripStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripProgress
            // 
            this.toolStripProgress.AutoSize = false;
            this.toolStripProgress.Name = "toolStripProgress";
            this.toolStripProgress.Size = new System.Drawing.Size(100, 30);
            this.toolStripProgress.Visible = false;
            // 
            // btnReload
            // 
            this.btnReload.Enabled = false;
            this.btnReload.Location = new System.Drawing.Point(8, 30);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(168, 54);
            this.btnReload.TabIndex = 4;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 652);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabNavi);
            this.Name = "frmMain";
            this.Text = "Windows Service Backup Tool";
            this.Shown += new System.EventHandler(this.frmMain_Shown);
            this.tabNavi.ResumeLayout(false);
            this.tabNaviPageCurrent.ResumeLayout(false);
            this.tabNaviPageBackup.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabNavi;
        private System.Windows.Forms.TabPage tabNaviPageCurrent;
        private System.Windows.Forms.ListView lstCurrentServices;
        private System.Windows.Forms.ColumnHeader clmName;
        private System.Windows.Forms.ColumnHeader clmStartType;
        private System.Windows.Forms.ColumnHeader clmStatus;
        private System.Windows.Forms.ColumnHeader clmDesc;
        private System.Windows.Forms.TabPage tabNaviPageBackup;
        private System.Windows.Forms.ListView lstBackupServices;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAnalyze;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatus;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgress;
        private System.Windows.Forms.Button btnReload;
    }
}

