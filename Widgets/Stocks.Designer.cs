namespace Widgets
{
    partial class Stocks
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
            this.cbSymbol = new System.Windows.Forms.ComboBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDayHigh = new System.Windows.Forms.Label();
            this.lblDayLow = new System.Windows.Forms.Label();
            this.lblYearHigh = new System.Windows.Forms.Label();
            this.lblYearLow = new System.Windows.Forms.Label();
            this.lblMarketCap = new System.Windows.Forms.Label();
            this.lblVolume = new System.Windows.Forms.Label();
            this.lblStockEx = new System.Windows.Forms.Label();
            this.lblDaysRange = new System.Windows.Forms.Label();
            this.lblChange = new System.Windows.Forms.Label();
            this.lblLastTrade = new System.Windows.Forms.Label();
            this.lblAvgDailyVol = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbSymbol
            // 
            this.cbSymbol.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbSymbol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSymbol.Font = new System.Drawing.Font("Eras Medium ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSymbol.ForeColor = System.Drawing.Color.DimGray;
            this.cbSymbol.FormattingEnabled = true;
            this.cbSymbol.Location = new System.Drawing.Point(17, 13);
            this.cbSymbol.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbSymbol.Name = "cbSymbol";
            this.cbSymbol.Size = new System.Drawing.Size(160, 23);
            this.cbSymbol.TabIndex = 0;
            this.cbSymbol.SelectedIndexChanged += new System.EventHandler(this.cbSymbol_SelectedIndexChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Eras Demi ITC", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.DimGray;
            this.lblName.Location = new System.Drawing.Point(13, 53);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(96, 33);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // lblDayHigh
            // 
            this.lblDayHigh.AutoSize = true;
            this.lblDayHigh.BackColor = System.Drawing.Color.Transparent;
            this.lblDayHigh.Font = new System.Drawing.Font("Eras Medium ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDayHigh.ForeColor = System.Drawing.Color.DimGray;
            this.lblDayHigh.Location = new System.Drawing.Point(15, 101);
            this.lblDayHigh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDayHigh.Name = "lblDayHigh";
            this.lblDayHigh.Size = new System.Drawing.Size(45, 19);
            this.lblDayHigh.TabIndex = 2;
            this.lblDayHigh.Text = "High";
            // 
            // lblDayLow
            // 
            this.lblDayLow.AutoSize = true;
            this.lblDayLow.BackColor = System.Drawing.Color.Transparent;
            this.lblDayLow.Font = new System.Drawing.Font("Eras Light ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDayLow.ForeColor = System.Drawing.Color.DimGray;
            this.lblDayLow.Location = new System.Drawing.Point(209, 101);
            this.lblDayLow.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDayLow.Name = "lblDayLow";
            this.lblDayLow.Size = new System.Drawing.Size(38, 20);
            this.lblDayLow.TabIndex = 3;
            this.lblDayLow.Text = "Low";
            // 
            // lblYearHigh
            // 
            this.lblYearHigh.AutoSize = true;
            this.lblYearHigh.BackColor = System.Drawing.Color.Transparent;
            this.lblYearHigh.Font = new System.Drawing.Font("Eras Medium ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYearHigh.ForeColor = System.Drawing.Color.DimGray;
            this.lblYearHigh.Location = new System.Drawing.Point(15, 141);
            this.lblYearHigh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblYearHigh.Name = "lblYearHigh";
            this.lblYearHigh.Size = new System.Drawing.Size(86, 19);
            this.lblYearHigh.TabIndex = 4;
            this.lblYearHigh.Text = "Year High:";
            // 
            // lblYearLow
            // 
            this.lblYearLow.AutoSize = true;
            this.lblYearLow.BackColor = System.Drawing.Color.Transparent;
            this.lblYearLow.Font = new System.Drawing.Font("Eras Light ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYearLow.ForeColor = System.Drawing.Color.DimGray;
            this.lblYearLow.Location = new System.Drawing.Point(209, 141);
            this.lblYearLow.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblYearLow.Name = "lblYearLow";
            this.lblYearLow.Size = new System.Drawing.Size(74, 20);
            this.lblYearLow.TabIndex = 5;
            this.lblYearLow.Text = "Year Low:";
            // 
            // lblMarketCap
            // 
            this.lblMarketCap.AutoSize = true;
            this.lblMarketCap.BackColor = System.Drawing.Color.Transparent;
            this.lblMarketCap.Font = new System.Drawing.Font("Eras Light ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarketCap.ForeColor = System.Drawing.Color.DimGray;
            this.lblMarketCap.Location = new System.Drawing.Point(15, 225);
            this.lblMarketCap.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMarketCap.Name = "lblMarketCap";
            this.lblMarketCap.Size = new System.Drawing.Size(153, 20);
            this.lblMarketCap.TabIndex = 6;
            this.lblMarketCap.Text = "Market Capitalization: ";
            // 
            // lblVolume
            // 
            this.lblVolume.AutoSize = true;
            this.lblVolume.BackColor = System.Drawing.Color.Transparent;
            this.lblVolume.Font = new System.Drawing.Font("Eras Light ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVolume.ForeColor = System.Drawing.Color.DimGray;
            this.lblVolume.Location = new System.Drawing.Point(13, 250);
            this.lblVolume.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(61, 20);
            this.lblVolume.TabIndex = 7;
            this.lblVolume.Text = "Volume";
            // 
            // lblStockEx
            // 
            this.lblStockEx.AutoSize = true;
            this.lblStockEx.BackColor = System.Drawing.Color.Transparent;
            this.lblStockEx.Font = new System.Drawing.Font("Eras Light ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockEx.ForeColor = System.Drawing.Color.DimGray;
            this.lblStockEx.Location = new System.Drawing.Point(15, 200);
            this.lblStockEx.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStockEx.Name = "lblStockEx";
            this.lblStockEx.Size = new System.Drawing.Size(112, 20);
            this.lblStockEx.TabIndex = 8;
            this.lblStockEx.Text = "Stock Exchange";
            // 
            // lblDaysRange
            // 
            this.lblDaysRange.AutoSize = true;
            this.lblDaysRange.BackColor = System.Drawing.Color.Transparent;
            this.lblDaysRange.Font = new System.Drawing.Font("Eras Light ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDaysRange.ForeColor = System.Drawing.Color.DimGray;
            this.lblDaysRange.Location = new System.Drawing.Point(13, 276);
            this.lblDaysRange.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDaysRange.Name = "lblDaysRange";
            this.lblDaysRange.Size = new System.Drawing.Size(88, 20);
            this.lblDaysRange.TabIndex = 9;
            this.lblDaysRange.Text = "Days Range";
            // 
            // lblChange
            // 
            this.lblChange.BackColor = System.Drawing.Color.Transparent;
            this.lblChange.Font = new System.Drawing.Font("Eras Light ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChange.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblChange.Location = new System.Drawing.Point(405, 97);
            this.lblChange.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(78, 25);
            this.lblChange.TabIndex = 10;
            this.lblChange.Text = "change";
            this.lblChange.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLastTrade
            // 
            this.lblLastTrade.AutoSize = true;
            this.lblLastTrade.BackColor = System.Drawing.Color.Transparent;
            this.lblLastTrade.Font = new System.Drawing.Font("Eras Light ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastTrade.ForeColor = System.Drawing.Color.DimGray;
            this.lblLastTrade.Location = new System.Drawing.Point(15, 174);
            this.lblLastTrade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLastTrade.Name = "lblLastTrade";
            this.lblLastTrade.Size = new System.Drawing.Size(76, 20);
            this.lblLastTrade.TabIndex = 11;
            this.lblLastTrade.Text = "Last Trade";
            // 
            // lblAvgDailyVol
            // 
            this.lblAvgDailyVol.AutoSize = true;
            this.lblAvgDailyVol.BackColor = System.Drawing.Color.Transparent;
            this.lblAvgDailyVol.Font = new System.Drawing.Font("Eras Light ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvgDailyVol.ForeColor = System.Drawing.Color.DimGray;
            this.lblAvgDailyVol.Location = new System.Drawing.Point(209, 250);
            this.lblAvgDailyVol.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAvgDailyVol.Name = "lblAvgDailyVol";
            this.lblAvgDailyVol.Size = new System.Drawing.Size(157, 20);
            this.lblAvgDailyVol.TabIndex = 12;
            this.lblAvgDailyVol.Text = "Average Daily Volume";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BackgroundImage = global::Widgets.Properties.Resources.exit;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(483, 13);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(31, 24);
            this.btnExit.TabIndex = 13;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.BackColor = System.Drawing.Color.Transparent;
            this.lblYear.Font = new System.Drawing.Font("Eras Light ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.ForeColor = System.Drawing.Color.DimGray;
            this.lblYear.Location = new System.Drawing.Point(405, 141);
            this.lblYear.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(59, 20);
            this.lblYear.TabIndex = 14;
            this.lblYear.Text = "in YEAR";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Font = new System.Drawing.Font("Eras Light ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.DimGray;
            this.lblDate.Location = new System.Drawing.Point(395, 66);
            this.lblDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(41, 20);
            this.lblDate.TabIndex = 15;
            this.lblDate.Text = "Date";
            // 
            // Stocks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::Widgets.Properties.Resources.finance2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(521, 305);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblAvgDailyVol);
            this.Controls.Add(this.lblLastTrade);
            this.Controls.Add(this.lblChange);
            this.Controls.Add(this.lblDaysRange);
            this.Controls.Add(this.lblStockEx);
            this.Controls.Add(this.lblVolume);
            this.Controls.Add(this.lblMarketCap);
            this.Controls.Add(this.lblYearLow);
            this.Controls.Add(this.lblYearHigh);
            this.Controls.Add(this.lblDayLow);
            this.Controls.Add(this.lblDayHigh);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.cbSymbol);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Miriam Fixed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Stocks";
            this.Text = "Stocks";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Stocks_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbSymbol;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDayHigh;
        private System.Windows.Forms.Label lblDayLow;
        private System.Windows.Forms.Label lblYearHigh;
        private System.Windows.Forms.Label lblYearLow;
        private System.Windows.Forms.Label lblMarketCap;
        private System.Windows.Forms.Label lblVolume;
        private System.Windows.Forms.Label lblStockEx;
        private System.Windows.Forms.Label lblDaysRange;
        private System.Windows.Forms.Label lblChange;
        private System.Windows.Forms.Label lblLastTrade;
        private System.Windows.Forms.Label lblAvgDailyVol;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblDate;
    }
}