using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ProjectForms
{
    public partial class MainForm : Form
    {
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        public MainForm()
        {
            InitializeComponent();
            WelcomeForm welcomeForm = new WelcomeForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            OpenSubForm(welcomeForm);
        }

        private void MiningButton_Click(object sender, EventArgs e)
        {
            MiningForm miningForm = new MiningForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            OpenSubForm(miningForm);
        }

        private void CalcButton_Click(object sender, EventArgs e)
        {
            CalculatorForm calcForm = new CalculatorForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            OpenSubForm(calcForm);
        }
        
        private void SettingsButton_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            OpenSubForm(settingsForm);
        }

        private void LogoButton_Click(object sender, EventArgs e)
        {
            LogoForm logoForm = new LogoForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            OpenSubForm(logoForm);
        }

        private void OpenSubForm(Form SubForm)
        {
            this.MainPanel.Controls.Clear();
            SubForm.FormBorderStyle = FormBorderStyle.None;
            this.MainPanel.Controls.Add(SubForm);
            SubForm.Show();
        }
    }
}
