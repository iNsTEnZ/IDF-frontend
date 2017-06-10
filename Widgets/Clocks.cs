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
        Dictionary<string, string> zones = new Dictionary<string, string>();

        public Clocks()
        {
            InitializeComponent();

            addOptions();
            cbLocation.SelectedIndex = 0;

            // Set form and combo box corners to be round
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            // Set the transperaty of the widget
            this.Opacity = 0.9;
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

        private void addOptions()
        {
            string response = Connect.SendRequest("http://localhost:8888/api/time/");

            // Check if there was a response
            if (response != null)
            {
                // Add options to combobox
                // Save time and date for each country
            }
        }

        private void cbLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Display the time and date for the selected item
        }
    }
}
