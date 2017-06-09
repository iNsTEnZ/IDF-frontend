using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Web;
using System.Xml.Linq;
using System.Xml;
using System.Text.RegularExpressions;
using System.IO;
using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Runtime.InteropServices;
using Widgets.Properties;

namespace Widgets
{
    public partial class Weather : Form, IJson
    {
        private Location location;
        private Condition condition;
        private Forecast[] forecast = new Forecast[6];
        private string lastUpdate;

        private static PictureBox[] DAYS = new PictureBox[6];

        // Represents the location for which we provide the weather for
        internal class Location
        {
            public string city { get; set; }
            public string country { get; set; }
        }

        // Represents the current weather condition 
        internal class Condition
        {
            public string code { get; set; }
            public string temp { get; set; }
            public string text { get; set; }
        }

        // Represtnts the weather for days ahead
        internal class Forecast
        {
            public string code { get; set; }
            public string day { get; set; }
            public string high { get; set; }
            public string low { get; set; }
        }

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

        // Initialiazes the form with the defualt data 
        public Weather()
        {
            InitializeComponent();

            DAYS[0] = pbCondition;
            DAYS[1] = pbForecast1;
            DAYS[2] = pbForecast2;
            DAYS[3] = pbForecast3;
            DAYS[4] = pbForecast4;
            DAYS[5] = pbForecast5;

            btnGetWeather_Click(null, null);
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            this.Opacity = 0.85;
        }

        // Updates the data displayed in the form
        private void updateForm()
        {
            lblUpdate.Text = this.lastUpdate;
            lblTemp.Text   = this.condition.temp;
            lblToday.Text  = DateTime.Now.DayOfWeek.ToString();
            lblLoc.Text    = this.location.city + "," + this.location.country;
            lblText.Text   = this.condition.text;

            // Forecast data for the next 5 days  
            lblDay1.Text  = this.forecast[1].day;
            lblDay2.Text  = this.forecast[2].day;
            lblDay3.Text  = this.forecast[3].day;
            lblDay4.Text  = this.forecast[4].day;
            lblDay5.Text  = this.forecast[5].day;
            lblHigh1.Text = this.forecast[1].high;
            lblHigh2.Text = this.forecast[2].high;
            lblHigh3.Text = this.forecast[3].high;
            lblHigh4.Text = this.forecast[4].high;
            lblHigh5.Text = this.forecast[5].high;
            lblLow1.Text  = this.forecast[1].low;
            lblLow2.Text  = this.forecast[2].low;
            lblLow3.Text  = this.forecast[3].low;
            lblLow4.Text  = this.forecast[4].low;
            lblLow5.Text  = this.forecast[5].low;

            setIcons();
        }

        // Sets the images for the next 5 days weather forecast
        private void setIcons()
        {
            object obj;

            // Set current condition icon
            obj = Resources.ResourceManager.GetObject("_" + this.condition.code);
            pbCondition.Image = (Image)obj;

            // Set forecast icons
            for (int i = 0; i < 6; i++)
            {
                obj = Resources.ResourceManager.GetObject("_" + this.forecast[i].code);
                DAYS[i].Image = (Image)obj;
            }
        }

        // Parses the jason objected recieved and updates the properties
        public void parse(string json)
        {
            JObject root = JObject.Parse(json);

            // Checks if the api query retrieved any results
            if (root["query"]["results"].ToString() != string.Empty)
            {
                this.location = root["query"]["results"]["channel"]["location"].ToObject<Location>();
                this.condition = root["query"]["results"]["channel"]["item"]["condition"].ToObject<Condition>();
                this.forecast = root["query"]["results"]["channel"]["item"]["forecast"].ToObject<Forecast[]>();
                this.lastUpdate = DateTime.Now.ToString();
                this.updateForm();
            }
            else
            {
                MessageBox.Show("Error! Couldn't find the desired location.");
                txtLocation.Text = this.location.city + "," + this.location.country;
            }
        }

        // Gets the weather and forecast for the wanted location
        private void btnGetWeather_Click(object sender, EventArgs e)
        {
            string response = Connect.SendRequest("http://localhost:8888/api/weather/?location=" + txtLocation.Text + "&u=" + lblUnit.Text);

            // The server returned a response
            if (response != null)
            {
                // Parse it
                parse(response);
            }
        }

        // Exits the application
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Changes the displayed temperture units from Fahrenheit and Celsius
        private void lblUnit_Click(object sender, EventArgs e)
        {
            // If the temperture unit was Celsius, changes it to Fahrenheit and reload the data
            if (lblUnit.Text == "C")
            {
                lblUnit.Text = "F";
                btnGetWeather.PerformClick();
            }

            // Otherwise, changes it to Celsius and reload the data
            else
            {
                lblUnit.Text = "C";
                btnGetWeather.PerformClick();
            }
        }

        // Performs a refresh of the data according to the inserted location in the text box
        private void txtLocation_KeyDown(object sender, KeyEventArgs e)
        {
            // checks if the pressed key was Enter
            if (e.KeyCode == Keys.Enter)
            {
                btnGetWeather.PerformClick();
            }
        }

        // Validates the inserted text in the textbox
        private void txtLocation_TextChanged(object sender, EventArgs e)
        {
            // Checks if the text isn't in the right syntax, which is city[,country]
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtLocation.Text, "^[a-zA-Z ]+(?:,+[a-zA-Z ]+)*$"))
            {
                // Display a message box explaining the wanted syntax
                MessageBox.Show("You can only search for city names." +
                                "\n Possibly be followed by a comma and a country name." +
                                "\n No numbers and specail charactres are allowed.");
                txtLocation.Text = this.location.city + "," + this.location.country;
            }
        }

        // Moves the form according to mouse movment
        private void Weather_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
