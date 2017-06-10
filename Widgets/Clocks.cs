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
    public partial class Clocks : Form
    {
        public Clocks()
        {
            InitializeComponent();

            // Set form and combo box corners to be round
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            // Set the transperaty of the widget
            this.Opacity = 0.9;

            // Get country options
            getCountries();

            // Set defualt
            //cbCountry.SelectedIndex = 0;
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

        // Exist the widget
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Get the current time for the selected country
        private void cbCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            string response = Connect.SendRequest("http://localhost:8888/api/time/?location=" + this.cbCountry.Text);

            // Check if there was a response
            if (response != string.Empty)
            {
                string[] parsed = response.Replace("\"", "").Split(' ');
                this.lblDate.Text = parsed[0];
                this.lblTime.Text = parsed[1];
            }
            else
            {
                MessageBox.Show("Error while receiving data from the server",
                                "Something broke.. :(", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.btnExit.PerformClick();
            }
        }

        // Get possible countries
        private void getCountries()
        {
            string response = Connect.SendRequest("http://localhost:8888/api/time/locations");

            if (response != null)
            {
                response = response.Replace("[", "");
                response = response.Replace("]", "");
                response = response.Replace("\"", "");
                string[] countries = response.Split(',');

                for (int i = 0; i < countries.Length; i++)
                {
                    cbCountry.Items.Add(countries[i]);
                }
            }
        }
    }
}
