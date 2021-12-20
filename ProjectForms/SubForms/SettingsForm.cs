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
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SettingsPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            General general = new General() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            OpenSubForm(general);
        }

        private void OpenSubForm(Form SubForm)
        {
            this.SettingsPanel.Controls.Clear();
            SubForm.FormBorderStyle = FormBorderStyle.None;
            this.SettingsPanel.Controls.Add(SubForm);
            SubForm.Show();
        }
    }
}
