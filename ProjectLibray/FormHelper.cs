using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectLibray
{
    public static class FormHelper
    {
        public static void OpenSubForm(Form SubForm, System.Windows.Forms.Panel Panel)
        {
            Panel.Controls.Clear();
            SubForm.FormBorderStyle = FormBorderStyle.None;
            Panel.Controls.Add(SubForm);
            SubForm.Show();
        }
    }
}
