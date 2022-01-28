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
    public partial class ResetSettingsAlert : Form
    {
        public ResetSettingsAlert()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            DataProcessing.SetAddress("Nic");
            DataProcessing.SetAlgorythm("Nic");
            DataProcessing.SetCoin("Nic");
            DataProcessing.SetStratum("Nic");
            DataProcessing.SetRigName("Nic");
            DataProcessing.SetPass("Nic");
            DataProcessing.SetUsername("Nic");
            DataProcessing.SetTheme("Nic");
            DataProcessing.SetLanguage("Nic");
            DataProcessing.SetCurrency("Nic");
            DataProcessing.SetWorkType("Nic");
            DataProcessing.SetIsVisible("Nic");
            /*DataProcessing.SetTrexUser("Nic");
            DataProcessing.SetTrexAlgorythm("Nic");
            DataProcessing.SetTrexCoin("Nic");
            DataProcessing.SetTrexStratum("Nic");
            DataProcessing.SetTrexRigName("Nic");
            DataProcessing.SetTrexPass("Nic");
            */
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
