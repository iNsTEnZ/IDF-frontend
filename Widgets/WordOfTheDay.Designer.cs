namespace Widgets
{
    partial class WordOfTheDay
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
            this.lblWord = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblWord
            // 
            this.lblWord.AutoSize = true;
            this.lblWord.Location = new System.Drawing.Point(12, 56);
            this.lblWord.Name = "lblWord";
            this.lblWord.Size = new System.Drawing.Size(35, 13);
            this.lblWord.TabIndex = 0;
            this.lblWord.Text = "label1";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BackgroundImage = global::Widgets.Properties.Resources.exit;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(246, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(26, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(13, 87);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(259, 20);
            this.txtDesc.TabIndex = 3;
            // 
            // WordOfTheDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Widgets.Properties.Resources.clac;
            this.ClientSize = new System.Drawing.Size(284, 265);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblWord);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WordOfTheDay";
            this.Text = "WordOfTheDay";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWord;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtDesc;
    }
}