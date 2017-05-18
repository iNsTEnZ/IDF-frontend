using System;

namespace WeatherApp
{
    partial class Wetaher
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGetWeather = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pbForecast1 = new System.Windows.Forms.PictureBox();
            this.lblTemperture = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblToday = new System.Windows.Forms.Label();
            this.lblUnit = new System.Windows.Forms.Label();
            this.lblUpdated = new System.Windows.Forms.Label();
            this.pbForecast2 = new System.Windows.Forms.PictureBox();
            this.pbForecast3 = new System.Windows.Forms.PictureBox();
            this.pbForecast4 = new System.Windows.Forms.PictureBox();
            this.lblDay1 = new System.Windows.Forms.Label();
            this.lblDay2 = new System.Windows.Forms.Label();
            this.lblDay3 = new System.Windows.Forms.Label();
            this.lblDay4 = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblHigh1 = new System.Windows.Forms.Label();
            this.lblLow1 = new System.Windows.Forms.Label();
            this.lblLow2 = new System.Windows.Forms.Label();
            this.lblbHigh2 = new System.Windows.Forms.Label();
            this.lblLow3 = new System.Windows.Forms.Label();
            this.lblHigh3 = new System.Windows.Forms.Label();
            this.lblLow4 = new System.Windows.Forms.Label();
            this.lblHigh4 = new System.Windows.Forms.Label();
            this.pbCondition = new System.Windows.Forms.PictureBox();
            this.pbForecast5 = new System.Windows.Forms.PictureBox();
            this.lblDay5 = new System.Windows.Forms.Label();
            this.lblHigh5 = new System.Windows.Forms.Label();
            this.lblLow5 = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbForecast1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbForecast2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbForecast3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbForecast4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCondition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbForecast5)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGetWeather
            // 
            this.btnGetWeather.BackColor = System.Drawing.Color.Transparent;
            this.btnGetWeather.Location = new System.Drawing.Point(118, 14);
            this.btnGetWeather.Name = "btnGetWeather";
            this.btnGetWeather.Size = new System.Drawing.Size(84, 22);
            this.btnGetWeather.TabIndex = 1;
            this.btnGetWeather.Text = "Get Weather";
            this.btnGetWeather.UseVisualStyleBackColor = false;
            this.btnGetWeather.Click += new System.EventHandler(this.btnGetWeather_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.Location = new System.Drawing.Point(624, 15);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(35, 22);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pbForecast1
            // 
            this.pbForecast1.BackColor = System.Drawing.Color.Transparent;
            this.pbForecast1.BackgroundImage = global::WeatherApp.Properties.Resources._32;
            this.pbForecast1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbForecast1.Location = new System.Drawing.Point(47, 271);
            this.pbForecast1.Name = "pbForecast1";
            this.pbForecast1.Size = new System.Drawing.Size(87, 60);
            this.pbForecast1.TabIndex = 4;
            this.pbForecast1.TabStop = false;
            // 
            // lblTemperture
            // 
            this.lblTemperture.AutoSize = true;
            this.lblTemperture.BackColor = System.Drawing.Color.Transparent;
            this.lblTemperture.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemperture.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTemperture.Location = new System.Drawing.Point(295, 86);
            this.lblTemperture.Name = "lblTemperture";
            this.lblTemperture.Size = new System.Drawing.Size(107, 76);
            this.lblTemperture.TabIndex = 6;
            this.lblTemperture.Text = "22";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.BackColor = System.Drawing.Color.Transparent;
            this.lblCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblCity.Location = new System.Drawing.Point(373, 173);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(170, 31);
            this.lblCity.TabIndex = 7;
            this.lblCity.Text = "City, Region ";
            // 
            // lblToday
            // 
            this.lblToday.AutoSize = true;
            this.lblToday.BackColor = System.Drawing.Color.Transparent;
            this.lblToday.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblToday.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblToday.Location = new System.Drawing.Point(304, 180);
            this.lblToday.Name = "lblToday";
            this.lblToday.Size = new System.Drawing.Size(63, 24);
            this.lblToday.TabIndex = 14;
            this.lblToday.Text = "Today";
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.BackColor = System.Drawing.Color.Transparent;
            this.lblUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblUnit.Location = new System.Drawing.Point(394, 122);
            this.lblUnit.Margin = new System.Windows.Forms.Padding(0);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(34, 31);
            this.lblUnit.TabIndex = 15;
            this.lblUnit.Text = "C";
            // 
            // lblUpdated
            // 
            this.lblUpdated.AutoSize = true;
            this.lblUpdated.BackColor = System.Drawing.Color.Transparent;
            this.lblUpdated.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdated.ForeColor = System.Drawing.Color.Silver;
            this.lblUpdated.Location = new System.Drawing.Point(9, 418);
            this.lblUpdated.Name = "lblUpdated";
            this.lblUpdated.Size = new System.Drawing.Size(103, 20);
            this.lblUpdated.TabIndex = 16;
            this.lblUpdated.Text = "Last updated";
            // 
            // pbForecast2
            // 
            this.pbForecast2.BackColor = System.Drawing.Color.Transparent;
            this.pbForecast2.BackgroundImage = global::WeatherApp.Properties.Resources._32;
            this.pbForecast2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbForecast2.Location = new System.Drawing.Point(168, 271);
            this.pbForecast2.Name = "pbForecast2";
            this.pbForecast2.Size = new System.Drawing.Size(87, 60);
            this.pbForecast2.TabIndex = 17;
            this.pbForecast2.TabStop = false;
            // 
            // pbForecast3
            // 
            this.pbForecast3.BackColor = System.Drawing.Color.Transparent;
            this.pbForecast3.BackgroundImage = global::WeatherApp.Properties.Resources._32;
            this.pbForecast3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbForecast3.Location = new System.Drawing.Point(285, 271);
            this.pbForecast3.Name = "pbForecast3";
            this.pbForecast3.Size = new System.Drawing.Size(87, 60);
            this.pbForecast3.TabIndex = 18;
            this.pbForecast3.TabStop = false;
            // 
            // pbForecast4
            // 
            this.pbForecast4.BackColor = System.Drawing.Color.Transparent;
            this.pbForecast4.BackgroundImage = global::WeatherApp.Properties.Resources._32;
            this.pbForecast4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbForecast4.Location = new System.Drawing.Point(409, 271);
            this.pbForecast4.Name = "pbForecast4";
            this.pbForecast4.Size = new System.Drawing.Size(87, 60);
            this.pbForecast4.TabIndex = 19;
            this.pbForecast4.TabStop = false;
            // 
            // lblDay1
            // 
            this.lblDay1.AutoSize = true;
            this.lblDay1.BackColor = System.Drawing.Color.Transparent;
            this.lblDay1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblDay1.ForeColor = System.Drawing.Color.Silver;
            this.lblDay1.Location = new System.Drawing.Point(75, 248);
            this.lblDay1.Name = "lblDay1";
            this.lblDay1.Size = new System.Drawing.Size(37, 20);
            this.lblDay1.TabIndex = 20;
            this.lblDay1.Text = "Day";
            // 
            // lblDay2
            // 
            this.lblDay2.AutoSize = true;
            this.lblDay2.BackColor = System.Drawing.Color.Transparent;
            this.lblDay2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblDay2.ForeColor = System.Drawing.Color.Silver;
            this.lblDay2.Location = new System.Drawing.Point(200, 248);
            this.lblDay2.Name = "lblDay2";
            this.lblDay2.Size = new System.Drawing.Size(37, 20);
            this.lblDay2.TabIndex = 23;
            this.lblDay2.Text = "Day";
            // 
            // lblDay3
            // 
            this.lblDay3.AutoSize = true;
            this.lblDay3.BackColor = System.Drawing.Color.Transparent;
            this.lblDay3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblDay3.ForeColor = System.Drawing.Color.Silver;
            this.lblDay3.Location = new System.Drawing.Point(319, 248);
            this.lblDay3.Name = "lblDay3";
            this.lblDay3.Size = new System.Drawing.Size(37, 20);
            this.lblDay3.TabIndex = 25;
            this.lblDay3.Text = "Day";
            // 
            // lblDay4
            // 
            this.lblDay4.AutoSize = true;
            this.lblDay4.BackColor = System.Drawing.Color.Transparent;
            this.lblDay4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblDay4.ForeColor = System.Drawing.Color.Silver;
            this.lblDay4.Location = new System.Drawing.Point(436, 248);
            this.lblDay4.Name = "lblDay4";
            this.lblDay4.Size = new System.Drawing.Size(37, 20);
            this.lblDay4.TabIndex = 27;
            this.lblDay4.Text = "Day";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.BackColor = System.Drawing.Color.Transparent;
            this.lblCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountry.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblCountry.Location = new System.Drawing.Point(543, 186);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(57, 17);
            this.lblCountry.TabIndex = 28;
            this.lblCountry.Text = "Country";
            // 
            // lblHigh1
            // 
            this.lblHigh1.AutoSize = true;
            this.lblHigh1.BackColor = System.Drawing.Color.Transparent;
            this.lblHigh1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblHigh1.ForeColor = System.Drawing.Color.Silver;
            this.lblHigh1.Location = new System.Drawing.Point(60, 351);
            this.lblHigh1.Name = "lblHigh1";
            this.lblHigh1.Size = new System.Drawing.Size(42, 20);
            this.lblHigh1.TabIndex = 29;
            this.lblHigh1.Text = "High";
            // 
            // lblLow1
            // 
            this.lblLow1.AutoSize = true;
            this.lblLow1.BackColor = System.Drawing.Color.Transparent;
            this.lblLow1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblLow1.ForeColor = System.Drawing.Color.Silver;
            this.lblLow1.Location = new System.Drawing.Point(97, 351);
            this.lblLow1.Name = "lblLow1";
            this.lblLow1.Size = new System.Drawing.Size(38, 20);
            this.lblLow1.TabIndex = 30;
            this.lblLow1.Text = "Low";
            // 
            // lblLow2
            // 
            this.lblLow2.AutoSize = true;
            this.lblLow2.BackColor = System.Drawing.Color.Transparent;
            this.lblLow2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblLow2.ForeColor = System.Drawing.Color.Silver;
            this.lblLow2.Location = new System.Drawing.Point(217, 351);
            this.lblLow2.Name = "lblLow2";
            this.lblLow2.Size = new System.Drawing.Size(38, 20);
            this.lblLow2.TabIndex = 31;
            this.lblLow2.Text = "Low";
            // 
            // lblbHigh2
            // 
            this.lblbHigh2.AutoSize = true;
            this.lblbHigh2.BackColor = System.Drawing.Color.Transparent;
            this.lblbHigh2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblbHigh2.ForeColor = System.Drawing.Color.Silver;
            this.lblbHigh2.Location = new System.Drawing.Point(181, 351);
            this.lblbHigh2.Name = "lblbHigh2";
            this.lblbHigh2.Size = new System.Drawing.Size(42, 20);
            this.lblbHigh2.TabIndex = 32;
            this.lblbHigh2.Text = "High";
            // 
            // lblLow3
            // 
            this.lblLow3.AutoSize = true;
            this.lblLow3.BackColor = System.Drawing.Color.Transparent;
            this.lblLow3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblLow3.ForeColor = System.Drawing.Color.Silver;
            this.lblLow3.Location = new System.Drawing.Point(339, 351);
            this.lblLow3.Name = "lblLow3";
            this.lblLow3.Size = new System.Drawing.Size(38, 20);
            this.lblLow3.TabIndex = 33;
            this.lblLow3.Text = "Low";
            // 
            // lblHigh3
            // 
            this.lblHigh3.AutoSize = true;
            this.lblHigh3.BackColor = System.Drawing.Color.Transparent;
            this.lblHigh3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblHigh3.ForeColor = System.Drawing.Color.Silver;
            this.lblHigh3.Location = new System.Drawing.Point(304, 351);
            this.lblHigh3.Name = "lblHigh3";
            this.lblHigh3.Size = new System.Drawing.Size(42, 20);
            this.lblHigh3.TabIndex = 34;
            this.lblHigh3.Text = "High";
            // 
            // lblLow4
            // 
            this.lblLow4.AutoSize = true;
            this.lblLow4.BackColor = System.Drawing.Color.Transparent;
            this.lblLow4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblLow4.ForeColor = System.Drawing.Color.Silver;
            this.lblLow4.Location = new System.Drawing.Point(458, 351);
            this.lblLow4.Name = "lblLow4";
            this.lblLow4.Size = new System.Drawing.Size(38, 20);
            this.lblLow4.TabIndex = 35;
            this.lblLow4.Text = "Low";
            // 
            // lblHigh4
            // 
            this.lblHigh4.AutoSize = true;
            this.lblHigh4.BackColor = System.Drawing.Color.Transparent;
            this.lblHigh4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblHigh4.ForeColor = System.Drawing.Color.Silver;
            this.lblHigh4.Location = new System.Drawing.Point(421, 351);
            this.lblHigh4.Name = "lblHigh4";
            this.lblHigh4.Size = new System.Drawing.Size(42, 20);
            this.lblHigh4.TabIndex = 36;
            this.lblHigh4.Text = "High";
            // 
            // pbCondition
            // 
            this.pbCondition.BackColor = System.Drawing.Color.Transparent;
            this.pbCondition.BackgroundImage = global::WeatherApp.Properties.Resources._32;
            this.pbCondition.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbCondition.Location = new System.Drawing.Point(101, 64);
            this.pbCondition.Name = "pbCondition";
            this.pbCondition.Size = new System.Drawing.Size(187, 139);
            this.pbCondition.TabIndex = 37;
            this.pbCondition.TabStop = false;
            // 
            // pbForecast5
            // 
            this.pbForecast5.BackColor = System.Drawing.Color.Transparent;
            this.pbForecast5.BackgroundImage = global::WeatherApp.Properties.Resources._32;
            this.pbForecast5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbForecast5.Location = new System.Drawing.Point(531, 271);
            this.pbForecast5.Name = "pbForecast5";
            this.pbForecast5.Size = new System.Drawing.Size(87, 60);
            this.pbForecast5.TabIndex = 38;
            this.pbForecast5.TabStop = false;
            // 
            // lblDay5
            // 
            this.lblDay5.AutoSize = true;
            this.lblDay5.BackColor = System.Drawing.Color.Transparent;
            this.lblDay5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblDay5.ForeColor = System.Drawing.Color.Silver;
            this.lblDay5.Location = new System.Drawing.Point(563, 248);
            this.lblDay5.Name = "lblDay5";
            this.lblDay5.Size = new System.Drawing.Size(37, 20);
            this.lblDay5.TabIndex = 39;
            this.lblDay5.Text = "Day";
            // 
            // lblHigh5
            // 
            this.lblHigh5.AutoSize = true;
            this.lblHigh5.BackColor = System.Drawing.Color.Transparent;
            this.lblHigh5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblHigh5.ForeColor = System.Drawing.Color.Silver;
            this.lblHigh5.Location = new System.Drawing.Point(542, 351);
            this.lblHigh5.Name = "lblHigh5";
            this.lblHigh5.Size = new System.Drawing.Size(42, 20);
            this.lblHigh5.TabIndex = 40;
            this.lblHigh5.Text = "High";
            // 
            // lblLow5
            // 
            this.lblLow5.AutoSize = true;
            this.lblLow5.BackColor = System.Drawing.Color.Transparent;
            this.lblLow5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblLow5.ForeColor = System.Drawing.Color.Silver;
            this.lblLow5.Location = new System.Drawing.Point(580, 351);
            this.lblLow5.Name = "lblLow5";
            this.lblLow5.Size = new System.Drawing.Size(38, 20);
            this.lblLow5.TabIndex = 41;
            this.lblLow5.Text = "Low";
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(12, 15);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(100, 20);
            this.txtLocation.TabIndex = 42;
            this.txtLocation.Text = "Location";
            // 
            // Wetaher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WeatherApp.Properties.Resources.Background1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(671, 447);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.lblLow5);
            this.Controls.Add(this.lblHigh5);
            this.Controls.Add(this.lblDay5);
            this.Controls.Add(this.pbForecast5);
            this.Controls.Add(this.pbCondition);
            this.Controls.Add(this.lblHigh4);
            this.Controls.Add(this.lblLow4);
            this.Controls.Add(this.lblHigh3);
            this.Controls.Add(this.lblLow3);
            this.Controls.Add(this.lblbHigh2);
            this.Controls.Add(this.lblLow2);
            this.Controls.Add(this.lblLow1);
            this.Controls.Add(this.lblHigh1);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.lblDay4);
            this.Controls.Add(this.lblDay3);
            this.Controls.Add(this.lblDay2);
            this.Controls.Add(this.lblDay1);
            this.Controls.Add(this.pbForecast4);
            this.Controls.Add(this.pbForecast3);
            this.Controls.Add(this.pbForecast2);
            this.Controls.Add(this.lblUpdated);
            this.Controls.Add(this.lblUnit);
            this.Controls.Add(this.lblToday);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblTemperture);
            this.Controls.Add(this.pbForecast1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnGetWeather);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Wetaher";
            this.Text = "Weather";
            this.Load += new System.EventHandler(this.Wetaher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbForecast1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbForecast2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbForecast3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbForecast4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCondition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbForecast5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Wetaher_Load(object sender, EventArgs e)
        {
            
        }

        #endregion
        private System.Windows.Forms.Button btnGetWeather;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pbForecast1;
        private System.Windows.Forms.Label lblTemperture;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblToday;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.Label lblUpdated;
        private System.Windows.Forms.PictureBox pbForecast2;
        private System.Windows.Forms.PictureBox pbForecast3;
        private System.Windows.Forms.PictureBox pbForecast4;
        private System.Windows.Forms.Label lblDay1;
        private System.Windows.Forms.Label lblDay2;
        private System.Windows.Forms.Label lblDay3;
        private System.Windows.Forms.Label lblDay4;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblHigh1;
        private System.Windows.Forms.Label lblLow1;
        private System.Windows.Forms.Label lblLow2;
        private System.Windows.Forms.Label lblbHigh2;
        private System.Windows.Forms.Label lblLow3;
        private System.Windows.Forms.Label lblHigh3;
        private System.Windows.Forms.Label lblLow4;
        private System.Windows.Forms.Label lblHigh4;
        private System.Windows.Forms.PictureBox pbCondition;
        private System.Windows.Forms.PictureBox pbForecast5;
        private System.Windows.Forms.Label lblDay5;
        private System.Windows.Forms.Label lblHigh5;
        private System.Windows.Forms.Label lblLow5;
        private System.Windows.Forms.TextBox txtLocation;
    }
}

