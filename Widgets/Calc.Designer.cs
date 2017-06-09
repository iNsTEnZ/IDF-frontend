namespace Widgets
{    
partial class Calc    
{        /// <summary>       
 /// Required designer variable.
         /// </summary>     
    private System.ComponentModel.IContainer components = null;
        /// <summary>        /
// Clean up any resources being used.    
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
        /// <summary>        /// Required method for Designer support - do not modify        /// the contents of this method with the code editor.        /// </summary>  
      private void InitializeComponent()        
{            this.button1 = new System.Windows.Forms.Button();       
     this.button2 = new System.Windows.Forms.Button();  
          this.button3 = new System.Windows.Forms.Button();  
          this.button4 = new System.Windows.Forms.Button();      
      this.button5 = new System.Windows.Forms.Button();         
   this.button6 = new System.Windows.Forms.Button();       
     this.button7 = new System.Windows.Forms.Button();    
        this.button8 = new System.Windows.Forms.Button();  
          this.button9 = new System.Windows.Forms.Button();  
          this.button0 = new System.Windows.Forms.Button();    
        this.btnPlus = new System.Windows.Forms.Button();       
     this.btnDiv = new System.Windows.Forms.Button();   
         this.btnMinus = new System.Windows.Forms.Button();     
       this.btnMul = new System.Windows.Forms.Button();      
      this.lbRes = new System.Windows.Forms.Label();       
     this.btnCE = new System.Windows.Forms.Button();      
      this.btnEqual = new System.Windows.Forms.Button();   
         this.SuspendLayout();         
   //             // button1            //     
        this.button1.Location = new System.Drawing.Point(12, 39);      
      this.button1.Name = "button1";          
  this.button1.Size = new System.Drawing.Size(50, 37);   
         this.button1.TabIndex = 0;         
   this.button1.Text = "1";       
     this.button1.UseVisualStyleBackColor = true;  
          this.button1.Click += new System.EventHandler(this.number_Click);     
       //             // button2            //           
  this.button2.Location = new System.Drawing.Point(93, 39);    
        this.button2.Name = "button2";       
     this.button2.Size = new System.Drawing.Size(50, 37);    
        this.button2.TabIndex = 1;          
  this.button2.Text = "2";          
  this.button2.UseVisualStyleBackColor = true;  
          this.button2.Click += new System.EventHandler(this.number_Click);      
      //             // button3            // 
            this.button3.Location = new System.Drawing.Point(181, 39);  
          this.button3.Name = "button3";        
    this.button3.Size = new System.Drawing.Size(50, 37);       
     this.button3.TabIndex = 2;          
  this.button3.Text = "3";         
   this.button3.UseVisualStyleBackColor = true;   
         this.button3.Click += new System.EventHandler(this.number_Click);  
          //             // button4            //    
         this.button4.Location = new System.Drawing.Point(12, 109);       
     this.button4.Name = "button4";          
  this.button4.Size = new System.Drawing.Size(50, 37);    
        this.button4.TabIndex = 3;          
  this.button4.Text = "4";           
 this.button4.UseVisualStyleBackColor = true;  
           this.button4.Click += new System.EventHandler(this.number_Click);   
          //             // button5            //         
     this.button5.Location = new System.Drawing.Point(93, 109);        
     this.button5.Name = "button5";        
     this.button5.Size = new System.Drawing.Size(50, 37);   
          this.button5.TabIndex = 4;           
 this.button5.Text = "5";          
   this.button5.UseVisualStyleBackColor = true;      
       this.button5.Click += new System.EventHandler(this.number_Click);         
    //             // button6            //    
          this.button6.Location = new System.Drawing.Point(181, 109);       
      this.button6.Name = "button6";        
     this.button6.Size = new System.Drawing.Size(50, 37);   
          this.button6.TabIndex = 5;        
     this.button6.Text = "6";     
        this.button6.UseVisualStyleBackColor = true;           
 this.button6.Click += new System.EventHandler(this.number_Click);       
      //             // button7            //         
     this.button7.Location = new System.Drawing.Point(12, 179);       
      this.button7.Name = "button7";          
   this.button7.Size = new System.Drawing.Size(50, 37);         
    this.button7.TabIndex = 6;        
     this.button7.Text = "7";   
          this.button7.UseVisualStyleBackColor = true;    
         this.button7.Click += new System.EventHandler(this.number_Click);    
         //             // button8            //          
    this.button8.Location = new System.Drawing.Point(93, 179);   
          this.button8.Name = "button8";       
      this.button8.Size = new System.Drawing.Size(50, 37);     
        this.button8.TabIndex = 7;           
 this.button8.Text = "8";          
   this.button8.UseVisualStyleBackColor = true;       
      this.button8.Click += new System.EventHandler(this.number_Click);   
          //             // button9            //      
        this.button9.Location = new System.Drawing.Point(181, 179);    
         this.button9.Name = "button9";            this.button9.Size = new System.Drawing.Size(50, 37);      
       this.button9.TabIndex = 8;        
     this.button9.Text = "9";    
        this.button9.UseVisualStyleBackColor = true;           
 this.button9.Click += new System.EventHandler(this.number_Click);     
        //             // button0            //             
 this.button0.Location = new System.Drawing.Point(93, 245);       
      this.button0.Name = "button0";          
   this.button0.Size = new System.Drawing.Size(50, 37);       
      this.button0.TabIndex = 9;          
   this.button0.Text = "0";          
   this.button0.UseVisualStyleBackColor = true;        
     this.button0.Click += new System.EventHandler(this.number_Click);     
        //             // btnPlus            //          
    this.btnPlus.Location = new System.Drawing.Point(267, 39);      
       this.btnPlus.Name = "btnPlus";         
    this.btnPlus.Size = new System.Drawing.Size(50, 37);     
        this.btnPlus.TabIndex = 10;     
        this.btnPlus.Text = "+";     
        this.btnPlus.UseVisualStyleBackColor = true;       
      this.btnPlus.Click += new System.EventHandler(this.operClick);  
           //             // btnDiv            //       
       this.btnDiv.Location = new System.Drawing.Point(267, 245);     
        this.btnDiv.Name = "btnDiv";       
      this.btnDiv.Size = new System.Drawing.Size(50, 37);      
       this.btnDiv.TabIndex = 11;       
      this.btnDiv.Text = "/";           
 this.btnDiv.UseVisualStyleBackColor = true;       
      this.btnDiv.Click += new System.EventHandler(this.operClick);          
   //             // btnMinus            //           
   this.btnMinus.Location = new System.Drawing.Point(267, 109); 
            this.btnMinus.Name = "btnMinus";          
   this.btnMinus.Size = new System.Drawing.Size(50, 37);     
        this.btnMinus.TabIndex = 12;            
 this.btnMinus.Text = "-";          
   this.btnMinus.UseVisualStyleBackColor = true;   
          this.btnMinus.Click += new System.EventHandler(this.operClick);  
           //             // btnMul            //     
         this.btnMul.Location = new System.Drawing.Point(267, 179); 
            this.btnMul.Name = "btnMul";          
   this.btnMul.Size = new System.Drawing.Size(50, 37);   
          this.btnMul.TabIndex = 13;          
   this.btnMul.Text = "*";          
   this.btnMul.UseVisualStyleBackColor = true;        
     this.btnMul.Click += new System.EventHandler(this.operClick);   
          //             // lbRes            //          
    this.lbRes.AutoSize = true;          
   this.lbRes.Location = new System.Drawing.Point(402, 109);     
        this.lbRes.Name = "lbRes";           
 this.lbRes.Size = new System.Drawing.Size(0, 13);  
           this.lbRes.TabIndex = 14;            
 //             // btnCE            //          
    this.btnCE.Location = new System.Drawing.Point(429, 39); 
            this.btnCE.Name = "btnCE";      
       this.btnCE.Size = new System.Drawing.Size(50, 37);     
        this.btnCE.TabIndex = 15;           
 this.btnCE.Text = "CE";        
     this.btnCE.UseVisualStyleBackColor = true;      
       this.btnCE.Click += new System.EventHandler(this.btnCE_Click);    
         //             // btnEqual            //        
      this.btnEqual.Location = new System.Drawing.Point(181, 245); 
            this.btnEqual.Name = "btnEqual";           
 this.btnEqual.Size = new System.Drawing.Size(50, 37);   
          this.btnEqual.TabIndex = 16;       
      this.btnEqual.Text = "=";        
     this.btnEqual.UseVisualStyleBackColor = true;      
       this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);   
          //             // Calc            //      
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F); 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;  
           this.ClientSize = new System.Drawing.Size(593, 297);          
   this.Controls.Add(this.btnEqual);            
 this.Controls.Add(this.btnCE);           
 this.Controls.Add(this.lbRes);        
     this.Controls.Add(this.btnMul);        
     this.Controls.Add(this.btnMinus);            
 this.Controls.Add(this.btnDiv);           
 this.Controls.Add(this.btnPlus);            
 this.Controls.Add(this.button0);            
 this.Controls.Add(this.button9);           
 this.Controls.Add(this.button8);          
   this.Controls.Add(this.button7);        
     this.Controls.Add(this.button6);      
       this.Controls.Add(this.button5);    
         this.Controls.Add(this.button4);       
      this.Controls.Add(this.button3);        
     this.Controls.Add(this.button2);       
      this.Controls.Add(this.button1);     
        this.Name = "Calc";          
   this.Text = "Calc";         
    this.ResumeLayout(false);  
           this.PerformLayout();
        }
        #endregion
        private System.Windows.Forms.Button button1;     
   private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;   
     private System.Windows.Forms.Button button4;       
 private System.Windows.Forms.Button button5;     
    private System.Windows.Forms.Button button6;  
       private System.Windows.Forms.Button button7;   
      private System.Windows.Forms.Button button8;    
     private System.Windows.Forms.Button button9;     
    private System.Windows.Forms.Button button0;      
   private System.Windows.Forms.Button btnPlus;       
 private System.Windows.Forms.Button btnDiv;      
   private System.Windows.Forms.Button btnMinus;     
    private System.Windows.Forms.Button btnMul;      
   private System.Windows.Forms.Label lbRes;      
 private System.Windows.Forms.Button btnCE;    
     private System.Windows.Forms.Button btnEqual; 
    }
 }
