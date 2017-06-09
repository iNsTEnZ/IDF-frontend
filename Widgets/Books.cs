using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Widgets
{
    public partial class Books : Form, IJson
    {
        private Items[] results;
        private static PictureBox[] RATES = new PictureBox[5];

        // Represnts a search results
        internal class Items
        {
            public VolumeInfo volumeInfo { get; set; }
        }

        // Represnts a book. Holds it's deatils.
        internal class VolumeInfo
        {
            public string title { get; set; }
            public object authors { get; set; }
            public string publisher { get; set; }
            public string publishedDate { get; set; }
            public string description { get; set; }
            public string pageCount { get; set; }
            public string categories { get; set; }
            public float  averageRating { get; set; }
            public int    ratingsCount { get; set; }
            public string maturityRating { get; set; }
            public ImageLinks imageLinks { get; set; }
            public string language { get; set; }
            public string subtitle { get; set; }
        }

        // Holds the book reslt's image link
        public class ImageLinks
        {
            public string smallThumbnail { get; set; }
            public string thumbnail { get; set; }
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

        public Books()
        {
            InitializeComponent();

            RATES[0] = pbStar1;
            RATES[1] = pbStar2;
            RATES[2] = pbStar3;
            RATES[3] = pbStar4;
            RATES[4] = pbStar5;

            // Set form and text box corners to be round
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            this.txtBookName.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, this.txtBookName.Width, this.txtBookName.Height, 5, 5));

            // Set the transperaty of the widget
            this.Opacity = 0.9;

            show(false);
        }

        // Hides or displays the details on the form
        private void show(bool toShow)
        {
            for (int i = 0; i < 5; i++)
            {
                RATES[i].Visible = toShow;
            }

            pbFront.Visible      = toShow;
            lblAuthor.Visible    = toShow;
            lblTitle.Visible     = toShow;
            lblSubtitle.Visible  = toShow;
            txtDesc.Visible      = toShow;
            lblPublisher.Visible = toShow;
            lblPages.Visible     = toShow;
            lblCategory.Visible  = toShow;
            lblDate.Visible      = toShow;
            lblLanguage.Visible  = toShow;
            lblRateCount.Visible = toShow;
            lblResNum.Visible    = toShow;
            lblRating.Visible    = toShow;
            btnNext.Visible      = toShow;
            btnBack.Visible      = toShow;
        }

        // Sends a request to the server and returns its response
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtBookName.Text != string.Empty)
            {
                string response = Connect.SendRequest("http://localhost:8888/api/books/?bookName=" + txtBookName.Text);

                // Check if the server returned a respond
                if (response != null)
                {
                    // Parse it
                    parse(response);
                }
            }
            else
            {
                MessageBox.Show("Error! You need to enter a book name to search for.");
            }
        }

        // Parses the jason objected recieved and updates the properties
        public void parse(string json)
        {
            JObject root = JObject.Parse(json);

            // Checks if the api query retrieved any results
            if (root["query"]["results"]["json"]["totalItems"].ToString() != "0")
            {
                this.results = root["query"]["results"]["json"]["items"].ToObject<Items[]>();
                searchResults(0);
            }
            else
            {
                MessageBox.Show("No results were found");
                txtBookName.Text = "";
            }
        }

        // Displays the search result number resNum
        private void searchResults(int resNum)
        {
            txtDesc.Text      = "Description:"+ Environment.NewLine + this.results[resNum].volumeInfo.description;
            lblDate.Text      = "Published on: " + this.results[resNum].volumeInfo.publishedDate;
            lblPages.Text     = "Pages: " + this.results[resNum].volumeInfo.pageCount;
            lblTitle.Text     = this.results[resNum].volumeInfo.title;
            lblResNum.Text    = "Result Number: " + (resNum + 1) + " out of" + this.results.Length;
            lblCategory.Text  = "Category: " + this.results[resNum].volumeInfo.categories;
            lblSubtitle.Text  = this.results[resNum].volumeInfo.subtitle;
            lblLanguage.Text  = "Language: " + this.results[resNum].volumeInfo.language;
            lblRateCount.Text = "(" + this.results[resNum].volumeInfo.ratingsCount + ")";
            lblPublisher.Text = "Publisher: " + this.results[resNum].volumeInfo.publisher;

            // Loads pictures to picture boxes
            pbFront.Load(this.results[resNum].volumeInfo.imageLinks.thumbnail);
            setRating(this.results[resNum].volumeInfo.averageRating);

            // Set the buttons 
            setBrowsing(resNum);

            // Set authors
            getAuthors(resNum);

            // Make data visible
            show(true);
        }

        // Disables and enables the browsing buttons according to the current search result number
        private void setBrowsing(int resNum)
        {
            // If its the first result, disables the back button
            if (resNum == 0)
            {
                btnBack.Enabled = false;
                btnNext.Enabled = true;
            }

            // If its last result, disables the next button
            else if (resNum == this.results.Length - 1)
            {
                btnNext.Enabled = false;
                btnBack.Enabled = true;
            }
            else
            {
                btnBack.Enabled = true;
                btnNext.Enabled = true;
            }
        }

        // Sets the stars' pictures according to the rate of the book
        private void setRating(float rate)
        {
            int whole = (int)rate;
            float fraction = rate - whole;

            // Checks if it has any whole stars
            if (whole > 0)
            {
                // Sets whole star image
                for (int i = 0; i < whole; i++)
                {
                    RATES[i].Image = Image.FromFile("../Stars/4.png");
                }
            }

            if (fraction < 0.5 && fraction > 0)
            {
                RATES[whole].Image = Image.FromFile("../Stars/1.png");
            }
            else if (fraction == 0.5)
            {
                RATES[whole].Image = Image.FromFile("../Stars/2.png");
            }
            else if (fraction > 0.5)
            {
                RATES[whole].Image = Image.FromFile("../Stars/3.png");
            }

            for (int i = (fraction == 0 ? whole : whole + 1); i < 5; i++)
            {
                RATES[i].Image = Image.FromFile("../Stars/0.png");
            }
        }
        // Displays the authors
        private void getAuthors(int resNum)
        {
            // Checks if there is a known author
            if (this.results[resNum].volumeInfo.authors != null)
            {
                Type valueType = this.results[resNum].volumeInfo.authors.GetType();

                // Checks if there are a number of authors
                if (valueType.Name == "JArray")
                {
                    var authors = ((IEnumerable)this.results[resNum].volumeInfo.authors).Cast<object>()
                               .Select(x => x == null ? x : x.ToString()).ToArray();
                    string concatenated = string.Join(",", authors.Cast<string>().ToArray<string>());
                    lblAuthor.Text = "Author/s: " + concatenated;
                }
            }
            else
            {
                lblAuthor.Text = "Author/s: " + this.results[resNum].volumeInfo.authors;
            }
        }

        // Gets the next search result 
        private void btnNext_Click(object sender, EventArgs e)
        {
            int currRes = Int32.Parse(Regex.Match(lblResNum.Text, @"\d+").Value);
            searchResults(currRes);
        }

        // Gets the previous search result
        private void btnBack_Click(object sender, EventArgs e)
        {
            int currRes = Int32.Parse(Regex.Match(lblResNum.Text, @"\d+").Value);
            searchResults(currRes - 2);
        }

        private void txtBookName_KeyDown(object sender, KeyEventArgs e)
        {
            // checks if the pressed key was Enter
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch.PerformClick();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
