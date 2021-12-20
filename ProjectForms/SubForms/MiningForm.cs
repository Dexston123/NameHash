using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Compression;
using System.Net;
using System.Diagnostics;
using System.IO;
using ProjectLibray;

namespace ProjectForms
{
    public partial class MiningForm : Form
    { 
        public MiningForm()
        {
            InitializeComponent();
        }

        private void MiningButton_Click(object sender, EventArgs e)
        {
            ProgressBarForm progresBarForm = new ProgressBarForm();
            progresBarForm.Show();

            using (var client = new WebClient())
            {
                DirectoryInfo di = Directory.CreateDirectory(FileCreate.FolderPath);

                if (!(File.Exists(FileCreate.FolderPath + "\\trex\\t-rex.exe")))
                { 
                        Uri uri = new Uri("https://github.com/trexminer/T-Rex/releases/download/0.24.8/t-rex-0.24.8-win.zip");
                        client.DownloadFile(uri, FileCreate.FolderPath + "\\t-rex.zip");
                        DirectoryInfo trexExtract = Directory.CreateDirectory(FileCreate.FolderPath + "\\trex");
                        ZipFile.ExtractToDirectory(FileCreate.FolderPath + "\\t-rex.zip", FileCreate.FolderPath + "\\trex");
                }
            }
            FileCreate.Save_settings();

            progresBarForm.Close();
            new LoginForm().Show();

            if (Hiden.Checked)
            {
                string pathHiden = Path.GetFullPath(FileCreate.FolderPath + "\\trex\\Start.vbs");
                Process.Start(pathHiden);
            }
            else
            {
                string pathShown = Path.GetFullPath(FileCreate.FolderPath + "\\trex\\eth-start.bat");
                Process.Start(pathShown);
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
