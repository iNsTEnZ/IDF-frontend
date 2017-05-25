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

        // Initialiazes the form with the defualt data 
        public Weather()
        {
            InitializeComponent();
            btnGetWeather_Click(null, null);
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
            pbCondition.Image = Image.FromFile(getString(this.condition.code));
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

        // Parses the jason objected recieved and updates the properties
        private void getWeather(string json)
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
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtLocation.Text, "^[a-zA-Z ]+(?:,[a-zA-Z ]+)*$"))
            {
                // Display a message box explaining the wanted syntax
                MessageBox.Show("You can only search for city names." +
                                "\n Possibly be followed by a comma and a country name." +
                                "\n No numbers and specail charactres are allowed.");
                txtLocation.Text = this.location.city + "," + this.location.country;
            }
        }
    }
}
