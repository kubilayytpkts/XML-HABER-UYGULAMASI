namespace Haber_uygulaması
{
    partial class HABER
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
            this.GroupBox = new System.Windows.Forms.GroupBox();
            this.textBoxURL = new System.Windows.Forms.TextBox();
            this.buttonGetir = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listboxBaslik = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.webBrowserURL = new System.Windows.Forms.WebBrowser();
            this.GroupBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox
            // 
            this.GroupBox.Controls.Add(this.buttonGetir);
            this.GroupBox.Controls.Add(this.textBoxURL);
            this.GroupBox.Location = new System.Drawing.Point(12, 12);
            this.GroupBox.Name = "GroupBox";
            this.GroupBox.Size = new System.Drawing.Size(765, 52);
            this.GroupBox.TabIndex = 0;
            this.GroupBox.TabStop = false;
            this.GroupBox.Text = "RSS URL";
            // 
            // textBoxURL
            // 
            this.textBoxURL.Location = new System.Drawing.Point(17, 20);
            this.textBoxURL.Name = "textBoxURL";
            this.textBoxURL.Size = new System.Drawing.Size(614, 20);
            this.textBoxURL.TabIndex = 0;
            this.textBoxURL.Text = "https://www.sabah.com.tr/rss/spor.xml";
            // 
            // buttonGetir
            // 
            this.buttonGetir.Location = new System.Drawing.Point(657, 18);
            this.buttonGetir.Name = "buttonGetir";
            this.buttonGetir.Size = new System.Drawing.Size(75, 23);
            this.buttonGetir.TabIndex = 1;
            this.buttonGetir.Text = "getir";
            this.buttonGetir.UseVisualStyleBackColor = true;
            this.buttonGetir.Click += new System.EventHandler(this.buttonGetir_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listboxBaslik);
            this.groupBox2.Location = new System.Drawing.Point(12, 70);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(225, 382);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Haber başlıkları";
            // 
            // listboxBaslik
            // 
            this.listboxBaslik.FormattingEnabled = true;
            this.listboxBaslik.Location = new System.Drawing.Point(14, 19);
            this.listboxBaslik.Name = "listboxBaslik";
            this.listboxBaslik.Size = new System.Drawing.Size(202, 355);
            this.listboxBaslik.TabIndex = 0;
            this.listboxBaslik.SelectedIndexChanged += new System.EventHandler(this.listboxBaslik_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.webBrowserURL);
            this.groupBox1.Location = new System.Drawing.Point(244, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(539, 372);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // webBrowserURL
            // 
            this.webBrowserURL.Location = new System.Drawing.Point(6, 19);
            this.webBrowserURL.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserURL.Name = "webBrowserURL";
            this.webBrowserURL.Size = new System.Drawing.Size(527, 345);
            this.webBrowserURL.TabIndex = 1;
            // 
            // HABER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 470);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.GroupBox);
            this.Name = "HABER";
            this.Text = "HABER";
            this.GroupBox.ResumeLayout(false);
            this.GroupBox.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBox;
        private System.Windows.Forms.Button buttonGetir;
        private System.Windows.Forms.TextBox textBoxURL;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listboxBaslik;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.WebBrowser webBrowserURL;
    }
}

