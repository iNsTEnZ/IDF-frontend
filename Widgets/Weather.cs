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

namespace Widgets
{
    public partial class Weather : Form
    {
        private Location location;
        private Condition condition;
        private Forecast[] forecast = new Forecast[6];
        private string lastUpdate;

        internal class Location
        {
            public string city { get; set; }
            public string country { get; set; }
        }

        internal class Condition
        {
            public string code { get; set; }
            //public string date { get; set; }
            public string temp { get; set; }
            public string text { get; set; }
        }

        internal class Forecast
        {
            public string code { get; set; }
            public string date { get; set; }
            public string day { get; set; }
            public string high { get; set; }
            public string low { get; set; }
            public string text { get; set; }
        }

        public Weather()
        {
            InitializeComponent();
            btnGetWeather_Click(null, null);
        }

        private void updateForm()
        {
            lblUpdate.Text = this.lastUpdate;
            lblTemp.Text = this.condition.temp;
            lblToday.Text = DateTime.Now.DayOfWeek.ToString();
            lblLoc.Text = this.location.city + "," + this.location.country;
            lblText.Text = this.condition.text;
            lblDay1.Text = this.forecast[1].day;
            lblDay2.Text = this.forecast[2].day;
            lblDay3.Text = this.forecast[3].day;
            lblDay4.Text = this.forecast[4].day;
            lblDay5.Text = this.forecast[5].day;
            lblHigh1.Text = this.forecast[1].high;
            lblHigh2.Text = this.forecast[2].high;
            lblHigh3.Text = this.forecast[3].high;
            lblHigh4.Text = this.forecast[4].high;
            lblHigh5.Text = this.forecast[5].high;
            lblLow1.Text = this.forecast[1].low;
            lblLow2.Text = this.forecast[2].low;
            lblLow3.Text = this.forecast[3].low;
            lblLow4.Text = this.forecast[4].low;
            lblLow5.Text = this.forecast[5].low;
            setIcons();
            setIcon();
        }

        // Sets the images for the next 5 days weather forecast
        private void setIcons()
        {
            pbForecast1.Image = Image.FromFile(getString(this.forecast[1].code));
            pbForecast2.Image = Image.FromFile(getString(this.forecast[2].code));
            pbForecast3.Image = Image.FromFile(getString(this.forecast[3].code));
            pbForecast4.Image = Image.FromFile(getString(this.forecast[4].code));
            pbForecast5.Image = Image.FromFile(getString(this.forecast[5].code));
        }

        // Creates and returns a path to the requiered image
        private string getString(string code)
        {
            if (code == "3200")
            {
                return "../Pics/na.png";
            }
            else
            {
                return "../Pics/" + code + ".png";
            }
        }

        // Sets the image of the current weather condition
        private void setIcon()
        {
            if (this.condition.code.Equals("3200"))
            {
                pbCondition.Image = Image.FromFile("../Pics/na.png");
            }
            else
            {
                string st = "../Pics/" + this.condition.code + ".png";
                pbCondition.Image = Image.FromFile(st);
            }
        }

        // Parses the jason objected recieved and updates the properties
        private void getWeather(string json)
        {
            JObject root = JObject.Parse(json);
            this.location = root["query"]["results"]["channel"]["location"].ToObject<Location>();
            this.condition = root["query"]["results"]["channel"]["item"]["condition"].ToObject<Condition>();
            this.forecast = root["query"]["results"]["channel"]["item"]["forecast"].ToObject<Forecast[]>();
            this.lastUpdate = DateTime.Now.ToString();
            this.updateForm();
        }

        // Gets the weather and forecast for the wanted location
        private void btnGetWeather_Click(object sender, EventArgs e)
        {
            string response = SendRequest("http://localhost:8888/api/weather/?location=" + txtLocation.Text + "&u=" + lblUnit.Text);

            if (response != null)
            {
                getWeather(response);
            }
        }

        // Send a request to the server to retrieve weather and forecast for a certain location
        private string SendRequest(string url)
        {
            try
            {
                using (WebClient client = new WebClient())
                {
                    return client.DownloadString(new Uri(url));
                }
            }
            catch (WebException ex)
            {
                MessageBox.Show("Error while receiving data from the server:\n" + ex.Message, "Something broke.. :(", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return null;
            }
        }

        // Exits the application
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblUnit_Click(object sender, EventArgs e)
        {
            if (lblUnit.Text == "C")
            {
                lblUnit.Text = "F";
                btnGetWeather.PerformClick();
            }
            else
            {
                lblUnit.Text = "C";
                btnGetWeather.PerformClick();
            }
        }
    }
}
