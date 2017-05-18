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

namespace WeatherApp
{
    public partial class Wetaher : Form
    {
        private string temperature;
        private string condition;
        private string humidity;
        private string windspeed;
        private string city;
        private string region;
        private string country;
        private string code = "3200";
        private string local;
        private string lastUpdate;
        private string[] next_day   = new string[10];
        private string[] next_cond  = new string[10];
        private string[] next_condt = new string[10];
        private string[] next_high  = new string[10];
        private string[] next_low   = new string[10];

        public Wetaher()
        {
            InitializeComponent();
            getWeather();
            lblTemperture.Text = temperature;
            lblUnit.Text = string.Format("\u00B0") + "F";
            lblToday.Text = next_day[0];
            lblCity.Text = city + ", " + region;
            lblCountry.Text = country;
            /*lblDay1.Text = next_day[1];
            lblDay2.Text = next_day[2];
            lblDay3.Text = next_day[3];
            lblDay4.Text = next_day[4];
            lblDay5.Text = next_day[5];
            lblHigh1.Text = next_high[1] + string.Format("\u00B0") + "F";
            lblbHigh2.Text = next_high[2] + string.Format("\u00B0") + "F";
            lblHigh3.Text = next_high[3] + string.Format("\u00B0") + "F";
            lblHigh4.Text = next_high[4] + string.Format("\u00B0") + "F";
            lblHigh5.Text = next_high[5] + string.Format("\u00B0") + "F";
            lblLow1.Text = next_low[1] + string.Format("\u00B0") + "F";
            lblLow2.Text = next_low[2] + string.Format("\u00B0") + "F";
            lblLow3.Text = next_low[3] + string.Format("\u00B0") + "F";
            lblLow4.Text = next_low[4] + string.Format("\u00B0") + "F";
            lblLow5.Text = next_low[5] + string.Format("\u00B0") + "F";
            setIcons();
            setIcon();*/
        }

        // Sets the images for the next 5 days weather forecast
        private void setIcons()
        {
            pbForecast1.Image = Image.FromFile(getString(next_cond[1]));
            pbForecast2.Image = Image.FromFile(getString(next_cond[2]));
            pbForecast3.Image = Image.FromFile(getString(next_cond[3]));
            pbForecast4.Image = Image.FromFile(getString(next_cond[4]));
            pbForecast5.Image = Image.FromFile(getString(next_cond[5]));
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
            if (code.Equals("3200"))
            {
                pbCondition.Image = Image.FromFile("../Pics/na.png");
            }
            else
            {
                string st = "../Pics/" + code + ".png";
                pbCondition.Image = Image.FromFile(st);
            }
        }

        // Parses the jason objected recieved and updates the properties
        private void getWeather()
        {
            
        }

        // Gets the weather and forecast for the wanted location
        private void btnGetWeather_Click(object sender, EventArgs e)
        {
            string response = SendRequest("http://localhost:8888/api/weather/?location=" + txtLocation.Text);

            if (response != null)
            {
                MessageBox.Show(response, "Hey there!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                getWeather();
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
    }
}
