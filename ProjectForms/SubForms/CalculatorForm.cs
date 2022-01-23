using ProjectLibray;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;


namespace ProjectForms
{
    public partial class CalculatorForm : Form
    {
        public CalculatorForm()
        {
            InitializeComponent();
            LabelCoin.Text = "Coin Reward";
            LabelMoney.Text = "USD Reward";
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            
            int hashrate = int.Parse(TextBoxHashrate.Text);
            WebClient client = new WebClient();

            switch (CBCoins.SelectedItem.ToString())
            {
                case "Ethereum":

                    var EthereumLink = client.DownloadString("https://whattomine.com/coins/151.json?hr=" + hashrate + "&fee=5.0&span_br=1h&span_d=24");
                    var EthereumData = JsonConvert.DeserializeObject<EthereumData>(EthereumLink);

                    LabelCoin.Text = EthereumData.estimated_rewards + "ETH";
                    LabelMoney.Text = EthereumData.revenue;


                    break;
                case "Ravencoin":

                    var RavencoinLink = client.DownloadString("https://whattomine.com/coins/234.json?hr=" + hashrate + "&fee=5.0&span_br=1h&span_d=24");
                    var RavencoinData = JsonConvert.DeserializeObject<EthereumData>(RavencoinLink);

                    LabelCoin.Text = RavencoinData.estimated_rewards + "RVN";
                    LabelMoney.Text = RavencoinData.revenue;


                    break;
                case "Monero":

                    var MoneroLink = client.DownloadString("https://whattomine.com/coins/101.json?hr=" + hashrate + "&fee=5.0&span_br=1h&span_d=24");
                    var MoneroData = JsonConvert.DeserializeObject<EthereumData>(MoneroLink);

                    LabelCoin.Text = MoneroData.estimated_rewards + "XMR";
                    LabelMoney.Text = MoneroData.revenue;


                    break;
            }

        }

        public class EthereumData
        {
            public string estimated_rewards { get; set; }
            public string revenue { get; set; }
        }
        public class RavenCoin
        {
            public string estimated_rewards { get; set; }
            public string revenue { get; set; }
        }
        public class Monero
        {
            public string estimated_rewards { get; set; }
            public string revenue { get; set; }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TextBoxHashrate.Clear();
            LabelCoin.Text = "Coin Reward";
            LabelMoney.Text = "USD Reward";
        }
    }
}
