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


namespace ProjectForms
{
    public partial class MainForm : Form
    {   
        static public class Forms
        {
            static public WelcomeForm welcomeForm = new WelcomeForm() { Dock = DockStyle.Fill, TopLevel = false};
            static public MiningForm miningForm = new MiningForm() { Dock = DockStyle.Fill, TopLevel = false};
            static public CalculatorForm calcForm = new CalculatorForm() { Dock = DockStyle.Fill, TopLevel = false};
            static public SettingsForm settingsForm = new SettingsForm() { Dock = DockStyle.Fill, TopLevel = false};
            static public LogoForm logoForm = new LogoForm() { Dock = DockStyle.Fill, TopLevel = false};
        }
        public MainForm()
        { 
            InitializeComponent();
            
            try
            {
                FormHelper.OpenSubForm(Forms.welcomeForm, this.MainPanel);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Something went wrong try again", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MiningButton_Click(object sender, EventArgs e)
        {
            try
            {
                FormHelper.OpenSubForm(Forms.miningForm, this.MainPanel);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Something went wrong try again", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CalcButton_Click(object sender, EventArgs e)
        {
            try
            {
                FormHelper.OpenSubForm(Forms.calcForm, this.MainPanel);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Something went wrong try again", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void SettingsButton_Click(object sender, EventArgs e)
        { 
            try
            {
                FormHelper.OpenSubForm(Forms.settingsForm, this.MainPanel);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Something went wrong try again", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LogoButton_Click(object sender, EventArgs e)
        {
            try
            {
                FormHelper.OpenSubForm(Forms.logoForm, this.MainPanel);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Something went wrong try again", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
