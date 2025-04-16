using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BitcoinKalkulatorArtjomSkatskov;
using Newtonsoft.Json;

namespace BitcoiniKalkulaatorArtjomSkatškov
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (currencyselector.SelectedItem.ToString() == "USD")
            {
                resultlabel.Visible = true;
                tulemuslabel.Visible = true;
                BitcoinRates newbitcoinrate = GetRates();
                float result = float.Parse(bitcoinamountinput.Text) * (float)newbitcoinrate.Data.BTCUSD.VALUE;
                resultlabel.Text = $"{result} USD (kurss: {newbitcoinrate.Data.BTCUSD.VALUE})";

            }
            else if(currencyselector.SelectedItem.ToString() == "EUR")
            {
                resultlabel.Visible = true;
                tulemuslabel.Visible = true;
                BitcoinRates newbitcoinrate = GetRates();
                float result = float.Parse(bitcoinamountinput.Text) * (float)newbitcoinrate.Data.BTCEUR.VALUE;
                resultlabel.Text = $"{result} USD (kurss: {newbitcoinrate.Data.BTCEUR.VALUE})";
            }
            else if(currencyselector.SelectedItem.ToString() == "GBP")
            {
                resultlabel.Visible = true;
                tulemuslabel.Visible = true;
                BitcoinRates newbitcoinrate = GetRates();
                float result = float.Parse(bitcoinamountinput.Text) * (float)newbitcoinrate.Data.BTCGBP.VALUE;
                resultlabel.Text = $"{result} USD (kurss: {newbitcoinrate.Data.BTCGBP.VALUE})";
            }
        }

        private BitcoinRates GetRates()
        {
            string url = "https://data-api.coindesk.com/index/cc/v1/latest/tick?market=cadli&instruments=BTC-USD,BTC-GBP,BTC-EUR&apply_mapping=true";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";

            var webResponse = request.GetResponse();
            var webStream = webResponse.GetResponseStream();

            BitcoinRates bitcoin;
            using (var responseReader = new StreamReader(webStream))
            {
                var data = responseReader.ReadToEnd();
                bitcoin = JsonConvert.DeserializeObject<BitcoinRates>(data);
            }
            return bitcoin;
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
