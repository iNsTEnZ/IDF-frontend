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
    public partial class WordOfTheDay : Form
    {
        public WordOfTheDay()
        {
            InitializeComponent();

            // Set form and combo box corners to be round
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            // Set the transperaty of the widget
            this.Opacity = 0.9;

            // Fetch a word from server
            getWord();
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

        // Exits the widget
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Get a randomiaze word
        private void getWord()
        {
            string response = Connect.SendRequest("http://localhost:8888/api/wordofday"); 

            if (response != null)
            {
                string[] parsed = response.Split('"');
                this.txtWord.Text = parsed[parsed.Length - 2];
            }
            else
            {
                this.Close();
            }
        }
    }
}
