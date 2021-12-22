using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectLibray;
using System.IO.Compression;
using System.Net;
using System.Diagnostics;
using System.IO;


namespace ProjectForms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void ActivateAppButton_Click(object sender, EventArgs e)
        {
            string address = UsersAdress.Text;
            DataProcessing.SetAddress(address);
            this.Close();

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

            /*            
            ProgressBarForm progresBarForm = new ProgressBarForm();
            progresBarForm.Show
            progresBarForm.Close();
            */
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
