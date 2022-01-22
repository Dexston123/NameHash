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
            new LoginForm().Show();

            /*if (Hiden.Checked)
            {
                string pathHiden = Path.GetFullPath(FileCreate.FolderPath + "\\trex\\Start.vbs");
                Process.Start(pathHiden);
            }
            else
            {
                string pathShown = Path.GetFullPath(FileCreate.FolderPath + "\\trex\\eth-start.bat");
                Process.Start(pathShown);
            }*/
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
