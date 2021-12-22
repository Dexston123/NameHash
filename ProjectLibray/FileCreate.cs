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
            string algorythm = DataProcessing.GetAlgorythm();
            string stratum = DataProcessing.GetStratum();
            string adress = DataProcessing.GetAddress();
            string rigName = DataProcessing.GetRigName();
            string pass = DataProcessing.GetPass();

            using (StreamWriter sw = File.CreateText(algorythm + "-Auto.bat"))
            {
                sw.WriteLine("t-rex.exe " + "--algo " + algorythm + " --url " + stratum + " --user " + adress + "." + rigName + " --pass " + pass);
                sw.WriteLine("pause");
            }
            using (StreamWriter silent = File.CreateText("Start.vbs"))
            {
                silent.WriteLine("Set WshShell = CreateObject(\"WScript.Shell\")");
                silent.WriteLine("WshShell.Run chr(34) & " + algorythm + " \"-Auto.bat\" & Chr(34), 0");
                silent.WriteLine("Set WshShell = Nothing");
            }

            if (!(File.Exists(FolderPath + "\\trex\\" + algorythm + "-Auto.bat")))
            {
                File.Copy(algorythm + "-Auto.bat", FolderPath + "\\trex\\" + algorythm + "-Auto.bat");
                File.Copy("Start.vbs", FolderPath + "\\trex\\" + "Start.vbs");
                File.Delete("Start.vbs");
                File.Delete(algorythm + "-Auto.bat");
                File.Delete(FolderPath + "\\t-rex.zip");
            }
        }
    }
}
