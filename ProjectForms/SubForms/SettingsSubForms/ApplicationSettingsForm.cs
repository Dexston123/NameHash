using ProjectLibray;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectForms.SubForms.SettingsSubForms
{
    public partial class ApplicationSettingsForm : Form
    {
        public ApplicationSettingsForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Theme = (string)this.comboBox1.SelectedItem;
            string Language = (string)this.comboBox2.SelectedItem;
            string Currency = (string)this.comboBox3.SelectedItem;
            string WorkType = (string)this.comboBox4.SelectedItem;
            string Coin = (string)this.comboBox5.SelectedItem;
            string ConsoleVisibility = (string)this.comboBox6.SelectedItem;
            DataProcessing.SetTheme(Theme);
            DataProcessing.SetLanguage(Language);
            DataProcessing.SetCurrency(Currency);
            DataProcessing.SetWorkType(WorkType);
            DataProcessing.SetCoin(Coin);
            DataProcessing.SetIsVisible(ConsoleVisibility);
            
        }

        private void ApplicationSettingsForm_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
