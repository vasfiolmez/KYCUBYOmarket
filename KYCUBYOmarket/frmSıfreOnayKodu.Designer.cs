namespace KYCUBYOmarket
{
    partial class frmSıfreOnayKodu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSıfreOnayKodu));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.btnOnaykodu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(90, 113);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(44, 36);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // tb_email
            // 
            this.tb_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_email.ForeColor = System.Drawing.Color.DarkGray;
            this.tb_email.Location = new System.Drawing.Point(132, 113);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(226, 36);
            this.tb_email.TabIndex = 4;
            this.tb_email.Text = "E-mail";
            // 
            // btnOnaykodu
            // 
            this.btnOnaykodu.BackColor = System.Drawing.Color.SteelBlue;
            this.btnOnaykodu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOnaykodu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOnaykodu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOnaykodu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOnaykodu.Location = new System.Drawing.Point(90, 173);
            this.btnOnaykodu.Name = "btnOnaykodu";
            this.btnOnaykodu.Size = new System.Drawing.Size(268, 38);
            this.btnOnaykodu.TabIndex = 6;
            this.btnOnaykodu.Text = "E-Mail\'e Onay Kodu Yolla";
            this.btnOnaykodu.UseVisualStyleBackColor = false;
            this.btnOnaykodu.Click += new System.EventHandler(this.btnOnaykodu_Click);
            // 
            // frmSıfreOnayKodu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(445, 345);
            this.Controls.Add(this.btnOnaykodu);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.tb_email);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmSıfreOnayKodu";
            this.Text = "frmSıfreGuncelleme";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.Button btnOnaykodu;
    }
}