using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLibray.Data.Models
{
    public class TrexApiModel
    {
        public List<GpuModel> gpus { get; set; }
        public string Name { get; set; }
        public string Version { get; set; }
        public string Hashrate { get; set; }
        public string Algorithm { get; set; }
        public string UpTime { get; set; }
        public string Hashrate_hour { get; set; }
        public string Hashrate_day { get; set; }
        public string Accepted_count { get; set; }
        public string Rejected_count { get; set; }
    }
}

