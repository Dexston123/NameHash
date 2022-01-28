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
    public partial class AdvancedSettingsForm : Form
    {
        public AdvancedSettingsForm()
        {
            InitializeComponent();
        }

        private void AdvancedSettingsButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
