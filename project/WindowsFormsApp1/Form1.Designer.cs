namespace WindowsFormsApp1
{
    partial class Form1
    {
        
        public System.ComponentModel.IContainer components = null;

       
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

  

        
        public void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.clickCounter = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.priceLabel = new System.Windows.Forms.Label();
            this.perClickLabel = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.buyBuff = new System.Windows.Forms.Button();
            this.buyBack = new System.Windows.Forms.Button();
            this.SuspendLayout();

            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Name = "label1";
            this.label1.UseMnemonic = false;
            this.label1.Click += new System.EventHandler(this.label1_Click);
 
            resources.ApplyResources(this.clickCounter, "clickCounter");
            this.clickCounter.BackColor = System.Drawing.Color.Transparent;
            this.clickCounter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clickCounter.Name = "clickCounter";
            this.clickCounter.UseMnemonic = false;

            this.button1.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.button1, "button1");
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
  
            resources.ApplyResources(this.priceLabel, "priceLabel");
            this.priceLabel.BackColor = System.Drawing.Color.Transparent;
            this.priceLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.UseMnemonic = false;
            this.perClickLabel.Click += new System.EventHandler(this.perClickLabel_Click);

            resources.ApplyResources(this.perClickLabel, "perClickLabel");
            this.perClickLabel.BackColor = System.Drawing.Color.Transparent;
            this.perClickLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.perClickLabel.Name = "perClickLabel";
            this.perClickLabel.UseMnemonic = false;
            this.perClickLabel.Click += new System.EventHandler(this.perClickLabel_Click);

            this.button2.BackColor = System.Drawing.Color.MediumAquamarine;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.button2.FlatAppearance.BorderSize = 2;
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
  
            resources.ApplyResources(this.buyBuff, "buyBuff");
            this.buyBuff.Name = "buyBuff";
            this.buyBuff.UseVisualStyleBackColor = true;
            this.buyBuff.Click += new System.EventHandler(this.buyBuff_Click);
  
            resources.ApplyResources(this.buyBack, "buyBack");
            this.buyBack.Name = "buyBack";
            this.buyBack.UseVisualStyleBackColor = true;
            this.buyBack.Click += new System.EventHandler(this.button3_Click);
 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.Controls.Add(this.buyBack);
            this.Controls.Add(this.buyBuff);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.perClickLabel);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.clickCounter);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.TransparencyKey = System.Drawing.Color.MediumSeaGreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label clickCounter;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Label priceLabel;
        public System.Windows.Forms.Label perClickLabel;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button buyBuff;
        public System.Windows.Forms.Button buyBack;
    }
}

