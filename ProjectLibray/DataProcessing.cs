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
            UserModel convertedUserData = JsonConvert.DeserializeObject<UserModel>(dataSerialized);
            return convertedUserData;
        }

        private static object DeserializeSettingsData()
        {
            string dataSerialized = File.ReadAllText(GetPath("AppSettings.json"));
            SettingsModel convertedSettingsData = JsonConvert.DeserializeObject<SettingsModel>(dataSerialized);
            return convertedSettingsData;
        }

        private static void SerializeUserData(object data)
        { 
            string convertedUserData = JsonConvert.SerializeObject(data);
            File.WriteAllText(GetPath("UserData.json"), convertedUserData);
        }

        private static void SerializeSettingsData(object data)
        {
            string convertedSettingsData = JsonConvert.SerializeObject(data);
            File.WriteAllText(GetPath("AppSettings.json"), convertedSettingsData);
        }
        //User Data

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

        public static string GetCoin()
        {
            UserModel data = (UserModel)DeserializeUserData();
            return data.Coin;
        }

        public static void SetCoin(string Coin)
        {
            UserModel data = (UserModel)DeserializeUserData();
            data.Coin = Coin;
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

        //Application Settings

        public static string GetUsername()
        {
            SettingsModel data = (SettingsModel)DeserializeSettingsData();
            return data.Username;
        }

        public static void SetUsername(string username)
        {
            SettingsModel data = (SettingsModel)DeserializeSettingsData();
            data.Username = username;
            SerializeUserData(data);
        }

        public static string GetTheme()
        {
            SettingsModel data = (SettingsModel)DeserializeSettingsData();
            return data.Theme;
        }

        public static void SetTheme(string Theme)
        {
            SettingsModel data = (SettingsModel)DeserializeSettingsData();
            data.Theme = Theme;
            SerializeSettingsData(data);
        }

        public static string GetLanguage()
        {
            SettingsModel data = (SettingsModel)DeserializeSettingsData();
            return data.Language;
        }

        public static void SetLanguage(string Language)
        {
            SettingsModel data = (SettingsModel)DeserializeSettingsData();
            data.Language = Language;
            SerializeSettingsData(data);
        }

        public static string GetCurrency()
        {
            SettingsModel data = (SettingsModel)DeserializeSettingsData();
            return data.Currency;
        }

        public static void SetCurrency(string Currency)
        {
            SettingsModel data = (SettingsModel)DeserializeSettingsData();
            data.Currency = Currency;
            SerializeSettingsData(data);
        }
        public static string GetWorkType()
        {
            SettingsModel data = (SettingsModel)DeserializeSettingsData();
            return data.WorkType;
        }

        public static void SetWorkType(string WorkType)
        {
            SettingsModel data = (SettingsModel)DeserializeSettingsData();
            data.WorkType = WorkType;
            SerializeSettingsData(data);
        }

        public static string GetIsVisible()
        {
            SettingsModel data = (SettingsModel)DeserializeSettingsData();
            return data.IsVisible;
        }

        public static void SetIsVisible(string IsVisible)
        {
            SettingsModel data = (SettingsModel)DeserializeSettingsData();
            data.IsVisible = IsVisible;
            SerializeSettingsData(data);
        }
    }
}

