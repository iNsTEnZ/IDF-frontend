using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Widgets
{
    public partial class Books : Form
    {
        private Items[] results;
        private static PictureBox[] RATES = new PictureBox[5];

        internal class Items
        {
            public VolumeInfo volumeInfo { get; set; }
        }

        internal class VolumeInfo
        {
            public string title { get; set; }
            public string authors { get; set; }
            public string publisher { get; set; }
            public string publishedDate { get; set; }
            public string description { get; set; }
            public object industryIdentifiers { get; set; }
            public string pageCount { get; set; }
            public string categories { get; set; }
            public float  averageRating { get; set; }
            public int    ratingsCount { get; set; }
            public string maturityRating { get; set; }
            public ImageLinks imageLinks { get; set; }
            public string language { get; set; }
            //public string previewLink { get; set; }
            //public string infoLink { get; set; }
            //public string canonicalVolumeLink { get; set; }
            public string subtitle { get; set; }
        }

        public class ImageLinks
        {
            public string smallThumbnail { get; set; }
            public string thumbnail { get; set; }
        }

        public Books()
        {
            InitializeComponent();

            RATES[0] = pbStar1;
            RATES[1] = pbStar2;
            RATES[2] = pbStar3;
            RATES[3] = pbStar4;
            RATES[4] = pbStar5;
 
            show(false);
        }

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
            lblDesc.Visible      = toShow;
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string response = SendRequest("http://localhost:8888/api/books/?bookName=" + txtBookName.Text);

            if (response != null)
            {
                searchBook(response);
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

        // Parses the jason objected recieved and updates the properties
        private void searchBook(string json)
        {
            JObject root = JObject.Parse(json);

            // Checks if the api query retrieved any results
            if (root["query"]["results"].ToString() != string.Empty)
            {
                this.results = root["query"]["results"]["json"]["items"].ToObject<Items[]>();
                searchResults(0);
            }
            else
            {
                MessageBox.Show("Error! Couldn't find the desired location.");
                txtBookName.Text = "";
            }
        }

        private void searchResults(int resNum)
        {
            lblDate.Text      = "Published on: " + this.results[resNum].volumeInfo.publishedDate;
            lblPages.Text     = "Pages: " + this.results[resNum].volumeInfo.pageCount;
            lblTitle.Text     = this.results[resNum].volumeInfo.title;
            lblAuthor.Text    = "Author/s: " + this.results[resNum].volumeInfo.authors;
            lblResNum.Text    = "Result Number: " + (resNum + 1) + " out of" + this.results.Length;
            lblCategory.Text  = "Category: " + this.results[resNum].volumeInfo.categories;
            lblSubtitle.Text  = this.results[resNum].volumeInfo.subtitle;
            lblLanguage.Text  = "Language: " + this.results[resNum].volumeInfo.language;
            lblRateCount.Text = "(" + this.results[resNum].volumeInfo.ratingsCount + ")";
            lblPublisher.Text = "Publisher: " + this.results[resNum].volumeInfo.publisher;

            // Parse description text to fit the lable size
            string temp = this.results[resNum].volumeInfo.description.Replace(". ", "." + System.Environment.NewLine);
            lblDesc.Text      = "Description:\n" + temp;

            // Loads pictures to picture boxes
            pbFront.Load(this.results[resNum].volumeInfo.imageLinks.thumbnail);
            setRating(this.results[resNum].volumeInfo.averageRating);

            // Make data visible
            show(true);
        }

        private void setRating(float rate)
        {
            int whole = (int)rate;
            float fraction = rate - whole;

            if (whole > 0)
            {
                for (int i = 0; i < whole; i++)
                {
                    RATES[i].Image = Image.FromFile("../Stars/4.png");
                }
            }

            if (fraction < 0.5)
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
    }
}
