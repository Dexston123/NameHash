using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http.Headers;

namespace ProjectLibray
{ 
    public class TrexAPI
    {
        public class UserInfo
        {
            public string Username { get; set; }
            public string RigName { get; set; }

        }
        public class Hardware
        {
            public string GPU { get; set; }
            public string Temp { get; set; }
            public string GPUproducer { get; set; }
            public string FanSpeed { get; set; }
            public int GPUcount { get; set; }
        }

        public class Miner
        {   
            public string AppName { get; set; }
            public string TrexVersion { get; set; }
            public double HashRate { get; set; }
            public int PING { get; set; }
            public double Dificulty { get; set; }
            public int AcceptedShares { get; set; }
            public int RejectedShares { get; set; }
        }

        public class Stats
        {
            public decimal AvgHour { get; set; }
            public decimal AvgDay { get; set; }
        }
    }
}
