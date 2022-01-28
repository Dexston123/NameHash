using ProjectForms.SubForms.SettingsSubForms;
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

        private void OpenSubForm(Form SubForm)
        {
            this.SettingsPanel.Controls.Clear();
            SubForm.FormBorderStyle = FormBorderStyle.None;
            this.SettingsPanel.Controls.Add(SubForm);
            SubForm.Show();
        }

        private void OptionTableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void OptionLabel7_Click(object sender, EventArgs e)
        {

        }

        private void SaveSettingsButton_Click(object sender, EventArgs e)
        {   
            string Address = AddressTextBox.Text;
            string Algorythm = (string) AlgorythmComboBox.SelectedItem;
            string Coin = (string) CoinComboBox.SelectedItem;
            string Stratum = StratumTextBox.Text;
            string RigName = RigNameTextBox.Text;
            string Pass = PassTextBox.Text;
            string Username = UsernameTextBox.Text;
            string Theme = (string) ThemeComboBox.SelectedItem;
            string Language = (string) LanguageComboBox.SelectedItem;
            string Currency = (string) CurrencyComboBox.SelectedItem;
            string WorkType = (string) WorkTypeComboBox.SelectedItem;
            string ConsoleVisibility = (string) IsVisibleComboBox.SelectedItem;
            
            //Zmienić to na jedną funkcje zapisu
            DataProcessing.SetAddress(Address);
            DataProcessing.SetAlgorythm(Algorythm);
            DataProcessing.SetCoin(Coin);
            DataProcessing.SetStratum(Stratum);
            DataProcessing.SetRigName(RigName);
            DataProcessing.SetPass(Pass);
            DataProcessing.SetUsername(Username);
            DataProcessing.SetTheme(Theme);
            DataProcessing.SetLanguage(Language);
            DataProcessing.SetCurrency(Currency);
            DataProcessing.SetWorkType(WorkType);
            DataProcessing.SetIsVisible(ConsoleVisibility);
            /*DataProcessing.SetTrexUser(Address);
            DataProcessing.SetTrexAlgorythm(Algorythm);
            DataProcessing.SetTrexCoin(Coin);
            DataProcessing.SetTrexStratum(Stratum);
            DataProcessing.SetTrexRigName(RigName);
            DataProcessing.SetTrexPass(Pass);*/
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            ResetSettingsAlert resetAlert = new ResetSettingsAlert();
            resetAlert.ShowDialog();
        }

        private void AdvancedSettingsButton_Click(object sender, EventArgs e)
        {
            AdvancedSettingsAlert advancedAlert = new AdvancedSettingsAlert();
            advancedAlert.ShowDialog();
        }
    }
}
