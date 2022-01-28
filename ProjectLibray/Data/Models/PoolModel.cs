using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLibray.Data.Models
{
    public class PoolModel
    {
      public string user { get; set; } //Address
      public string url { get; set; } //Stratum
      public string pass { get; set; }  //Pass
      public string worker { get; set; } //Rig name
    }
}
