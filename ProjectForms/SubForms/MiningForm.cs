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
            //new LoginForm().Show();

            string miningArguments = "-a " + DataProcessing.GetAlgorythm() + " -o " + DataProcessing.GetStratum() + " -u " + DataProcessing.GetAddress() + " -p " + DataProcessing.GetPass() + " --api-bind-http 127.0.0.1:8008";

            Process.Start("\\trex\\t-rex.exe", miningArguments);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.GpuModelLabelInfo.Text = TrexConnection.GetTrexModel().gpus[0].Name;
            this.GpuVendorLabelInfo.Text = TrexConnection.GetTrexModel().gpus[0].Vendor;
            this.TempLabelInfo.Text = TrexConnection.GetTrexModel().gpus[0].Temperature + "°C";
            this.PowerLabelInfo.Text = TrexConnection.GetTrexModel().gpus[0].Power + "W";
            this.FanSpeedLabelInfo.Text = TrexConnection.GetTrexModel().gpus[0].Fan_speed + "%";
            this.EfficiencyLabelInfo.Text = TrexConnection.GetTrexModel().gpus[0].Efficiency;
            //Mining
            this.TrexLabelInfo.Text = TrexConnection.GetTrexModel().Name + " " + TrexConnection.GetTrexModel().Version;
            this.AlgorythmLabelInfo.Text = TrexConnection.GetTrexModel().Algorithm;
            TimeSpan time = TimeSpan.FromSeconds(int.Parse(TrexConnection.GetTrexModel().UpTime));
            this.UpTimeLabelInfo.Text = time.Hours + "h " + time.Minutes + "min";
            this.HashRateLabelInfo.Text = Math.Round(((decimal) int.Parse(TrexConnection.GetTrexModel().Hashrate) / 1000000), 2) + "MH/s";
            this.AvgHourLabelInfo.Text = Math.Round(((decimal)int.Parse(TrexConnection.GetTrexModel().Hashrate_hour) / 1000000), 2) + "MH/s";
            this.AvgDayLabelInfo.Text = Math.Round(((decimal)int.Parse(TrexConnection.GetTrexModel().Hashrate_day) / 1000000), 2) + "MH/s";
            this.AcceptedCountLabelInfo.Text = Math.Round((100 - (((decimal) int.Parse(TrexConnection.GetTrexModel().Rejected_count) / int.Parse(TrexConnection.GetTrexModel().Accepted_count)) * 100)), 2) + "%";
        }
    }
}
