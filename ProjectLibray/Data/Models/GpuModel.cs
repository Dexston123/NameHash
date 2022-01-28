using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLibray.Data.Models
{
    public class GpuModel
    {
        public string Name { get; set; }
        public string Vendor { get; set; }
        public string Temperature { get; set; }
        public string Power { get; set; }
        public string Fan_speed { get; set; }
        public string Efficiency { get; set; }
    }
}
