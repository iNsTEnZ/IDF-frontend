using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Widgets
{
    public partial class Stocks : Form, IJson
    {
        public string symbol { get; set; }
        public string averageDailyVolume { get; set; }
        public string change { get; set; }
        public string daysLow { get; set; }
        public string daysHigh { get; set; }
        public string yearLow { get; set; }
        public string yearHigh { get; set; }
        public string marketCapitalization { get; set; }
        public string lastTradePriceOnly { get; set; }
        public string daysRange { get; set; }
        public string name { get; set; }
        public string volume { get; set; }
        public string stockExchange { get; set; }

        // Creates rounded corners
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect, // x-coordinate of upper-left corner
            int nTopRect, // y-coordinate of upper-left corner
            int nRightRect, // x-coordinate of lower-right corner
            int nBottomRect, // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
         );

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        // Initializes the form
        public Stocks()
        {
            InitializeComponent();

            // Add optional stocks
            cbSymbol.Items.Add("AAPL");
            cbSymbol.Items.Add("YHOO");
            cbSymbol.Items.Add("GOOG");
            cbSymbol.Items.Add("MSFT");

            // Set form and combo box corners to be round
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            this.cbSymbol.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, this.cbSymbol.Width, this.cbSymbol.Height, 5, 5));

            // Set the transperaty of the widget
            this.Opacity = 0.8;

            // Hide lables
            this.display(false);
        }

        // Parses the json recieved from the server, and updates stocks properties
        public void parse(string json)
        {
            JObject root = JObject.Parse(json);

            // Checks if the api query retrieved any results
            if (root["query"]["results"]["quote"]["Name"].ToString() != string.Empty)
            {
                this.symbol = root["query"]["results"]["quote"]["symbol"].ToString();
                this.averageDailyVolume = root["query"]["results"]["quote"]["AverageDailyVolume"].ToString();
                this.change = root["query"]["results"]["quote"]["Change"].ToString();
                this.daysLow = root["query"]["results"]["quote"]["DaysLow"].ToString();
                this.daysHigh = root["query"]["results"]["quote"]["DaysHigh"].ToString();
                this.yearLow = root["query"]["results"]["quote"]["YearLow"].ToString();
                this.yearHigh = root["query"]["results"]["quote"]["YearHigh"].ToString();
                this.marketCapitalization = root["query"]["results"]["quote"]["MarketCapitalization"].ToString();
                this.lastTradePriceOnly = root["query"]["results"]["quote"]["LastTradePriceOnly"].ToString();
                this.daysRange = root["query"]["results"]["quote"]["DaysRange"].ToString();
                this.name = root["query"]["results"]["quote"]["Name"].ToString();
                this.volume = root["query"]["results"]["quote"]["Volume"].ToString();
                this.stockExchange = root["query"]["results"]["quote"]["StockExchange"].ToString();
                this.showStats();
            }
            else
            {
                MessageBox.Show("Error! Couldn't find the desired stock.");    
            }
        }

        // Gets the response from the server for the wanted stock
        private void cbSymbol_SelectedIndexChanged(object sender, EventArgs e)
        {
            string response = Connect.SendRequest("http://localhost:8888/api/finance/?stock=" + this.cbSymbol.Text);

            // Check if there was a response
            if (response != null)
            {
                // Parse it
                parse(response);
            }
        }

        // Updates the form with thenew stats
        private void showStats()
        {
            this.lblName.Text        = this.name;
            this.lblDayHigh.Text     = this.daysHigh;
            this.lblDayLow.Text      = this.daysLow;
            this.lblYearHigh.Text    = this.yearHigh;
            this.lblYearLow.Text     = this.yearLow;
            this.lblAvgDailyVol.Text = "AVG Daily Volume: " + this.averageDailyVolume;
            this.lblChange.Text      = this.change;
            this.lblDaysRange.Text   = "Days Range: " + this.daysRange;
            this.lblLastTrade.Text   = "Last Tarde: " + this.lastTradePriceOnly;
            this.lblMarketCap.Text   = "Market Capitalization: " + this.marketCapitalization;
            this.lblStockEx.Text     = "Stock Exchange: " + this.stockExchange;
            this.lblVolume.Text      = "Volume: " + this.volume;
            this.lblYear.Text        = "in " + DateTime.Now.Year;
            this.lblDate.Text = DateTime.Now.ToShortDateString();
            this.changeColor();
            this.display(true);
        }

        // Hides or displays the labels
        private void display(bool toDis)
        {
            this.lblName.Visible        = toDis;
            this.lblDayHigh.Visible     = toDis;
            this.lblDayLow.Visible      = toDis;
            this.lblYearHigh.Visible    = toDis;
            this.lblYearLow.Visible     = toDis;
            this.lblAvgDailyVol.Visible = toDis;
            this.lblChange.Visible      = toDis;
            this.lblDaysRange.Visible   = toDis;
            this.lblLastTrade.Visible   = toDis;
            this.lblMarketCap.Visible   = toDis;
            this.lblStockEx.Visible     = toDis;
            this.lblVolume.Visible      = toDis;
            this.lblYear.Visible        = toDis;
            this.lblDate.Visible        = toDis;
        }

        // Changes the label's back color according to the change. 
        private void changeColor()
        {
            // If its a plus, changes to green
            if (this.lblChange.Text.StartsWith("+"))
            {
                this.lblChange.BackColor = System.Drawing.Color.ForestGreen;
            }
            // If its a minus, changes to red
            else
            {
                this.lblChange.BackColor = System.Drawing.Color.Maroon;
            }

            this.lblChange.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, this.lblChange.Width, this.lblChange.Height, 5, 5));
        }

        // Closes the form's process
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Drags the form according to mouse placement
        private void Stocks_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
