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
    public partial class AdvancedSettingsAlert : Form
    {
        public AdvancedSettingsAlert()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            AdvancedSettingsForm ASF = new AdvancedSettingsForm() { Dock = DockStyle.Fill, TopLevel = false };
            //FormHelper.OpenSubForm(ASF, );
        }

        private void DeclineButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
