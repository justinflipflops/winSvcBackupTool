using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace winSvcBackupTool
{
    public class ServiceBackupModel
    {
        public string ServiceName { get; set; }
        public ServiceStartMode StartType { get; set; }
        public ServiceControllerStatus Status { get; set; }
        public string Description { get; set; }
        [JsonIgnore]
        public object Tag { get; set; }
    }
}
