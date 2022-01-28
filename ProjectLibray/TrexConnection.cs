using Newtonsoft.Json;
using ProjectLibray.Data.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLibray
{
    public static class TrexConnection
    {
        public static TrexApiModel GetTrexModel()
        {
            WebClient client = new WebClient();
            Uri ApiAdress = new Uri("http://127.0.0.1:8008/summary?sid=hj2DGIIYQ6rWcEbtscEU0ooGQvj3101L");
            var TrexAPI = client.DownloadString(ApiAdress);
            var TrexApiDeserialized = JsonConvert.DeserializeObject<TrexApiModel>(TrexAPI);
            return TrexApiDeserialized;
        }
    }
}
