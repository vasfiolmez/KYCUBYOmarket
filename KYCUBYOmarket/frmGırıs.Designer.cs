namespace KYCUBYOmarket
{
    partial class frmGırıs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGırıs));
            this.tbKsıfre = new System.Windows.Forms.TextBox();
            this.tbKullanıcıAd = new System.Windows.Forms.TextBox();
            this.btnGırıs = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbKsıfre
            // 
            this.tbKsıfre.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tbKsıfre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbKsıfre.Font = new System.Drawing.Font("Microsoft Sans Serif", 23.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbKsıfre.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbKsıfre.Location = new System.Drawing.Point(135, 408);
            this.tbKsıfre.Multiline = true;
            this.tbKsıfre.Name = "tbKsıfre";
            this.tbKsıfre.PasswordChar = '*';
            this.tbKsıfre.Size = new System.Drawing.Size(272, 42);
            this.tbKsıfre.TabIndex = 2;
            // 
            // tbKullanıcıAd
            // 
            this.tbKullanıcıAd.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tbKullanıcıAd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbKullanıcıAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 23.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbKullanıcıAd.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbKullanıcıAd.Location = new System.Drawing.Point(135, 308);
            this.tbKullanıcıAd.Multiline = true;
            this.tbKullanıcıAd.Name = "tbKullanıcıAd";
            this.tbKullanıcıAd.Size = new System.Drawing.Size(272, 46);
            this.tbKullanıcıAd.TabIndex = 1;
            // 
            // btnGırıs
            // 
            this.btnGırıs.BackColor = System.Drawing.Color.Navy;
            this.btnGırıs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGırıs.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGırıs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGırıs.ForeColor = System.Drawing.SystemColors.Control;
            this.btnGırıs.Location = new System.Drawing.Point(90, 505);
            this.btnGırıs.Name = "btnGırıs";
            this.btnGırıs.Size = new System.Drawing.Size(305, 38);
            this.btnGırıs.TabIndex = 5;
            this.btnGırıs.Text = "GİRİŞ";
            this.btnGırıs.UseVisualStyleBackColor = false;
            this.btnGırıs.Click += new System.EventHandler(this.btnGırıs_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(165, 567);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Şifremi Unuttum?";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(409, 597);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 39);
            this.label2.TabIndex = 9;
            this.label2.Text = "  ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // frmGırıs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(64)))), ((int)(((byte)(65)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(482, 666);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbKullanıcıAd);
            this.Controls.Add(this.btnGırıs);
            this.Controls.Add(this.tbKsıfre);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.Chocolate;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGırıs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmGırıs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnGırıs;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox tbKsıfre;
        public System.Windows.Forms.TextBox tbKullanıcıAd;
        private System.Windows.Forms.Label label2;
    }
}

