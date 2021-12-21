using Newtonsoft.Json;
using ProjectLibray.Data.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLibray
{
    public static class DataProcessing
    {
        private static string GetPath(string file)
        {
            string path = Path.Combine(Environment.CurrentDirectory);
            path = path.Remove(path.Length - 15) + "Libray\\Data\\" + file;
            return path;
        }

        private static object DeserializeUserData()
        {
            string dataSerialized = File.ReadAllText(GetPath("UserData.json"));
            UserModel convertedData = JsonConvert.DeserializeObject<UserModel>(dataSerialized);
            return convertedData;
        }

        private static void SerializeUserData(object data)
        { 
            string convertedData = JsonConvert.SerializeObject(data);
            File.WriteAllText(GetPath("UserData.json"), convertedData);
        }

        public static string GetUsername()
        {
            UserModel data = (UserModel)DeserializeUserData();
            return data.Username;
        }

        public static void SetUsername(string name)
        {
            UserModel data = (UserModel)DeserializeUserData();
            data.Username = name;
            SerializeUserData(data);
        }
    }
}

