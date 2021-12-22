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

        public static void SetUsername(string address)
        {
            UserModel data = (UserModel)DeserializeUserData();
            data.Address = address;
            SerializeUserData(data);
        }

        public static string GetAddress()
        {
            UserModel data = (UserModel)DeserializeUserData();
            return data.Address;
        }

        public static void SetAddress(string address)
        {
            UserModel data = (UserModel)DeserializeUserData();
            data.Address = address;
            SerializeUserData(data);
        }

        public static string GetAlgorythm()
        {
            UserModel data = (UserModel)DeserializeUserData();
            return data.Algorythm;
        }

        public static void SetAlgorythm(string algorythm)
        {
            UserModel data = (UserModel)DeserializeUserData();
            data.Algorythm = algorythm;
            SerializeUserData(data);
        }

        public static string GetStratum()
        {
            UserModel data = (UserModel)DeserializeUserData();
            return data.Stratum;
        }

        public static void SetStratum(string stratum)
        {
            UserModel data = (UserModel)DeserializeUserData();
            data.Stratum = stratum;
            SerializeUserData(data);
        }

        public static string GetRigName()
        {
            UserModel data = (UserModel)DeserializeUserData();
            return data.RigName;
        }

        public static void SetRigName(string rigName)
        {
            UserModel data = (UserModel)DeserializeUserData();
            data.RigName = rigName;
            SerializeUserData(data);
        }

        public static string GetPass()
        {
            UserModel data = (UserModel)DeserializeUserData();
            return data.Pass;
        }

        public static void SetPass(string pass)
        {
            UserModel data = (UserModel)DeserializeUserData();
            data.Pass = pass;
            SerializeUserData(data);
        }
    }
}

