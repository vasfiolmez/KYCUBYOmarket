namespace KYCUBYOmarket
{
    partial class frmYetkiAta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmYetkiAta));
            this.tctK_ad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.stokgüncelleme = new System.Windows.Forms.CheckBox();
            this.satis_ = new System.Windows.Forms.CheckBox();
            this.stokgörme = new System.Windows.Forms.CheckBox();
            this.stoksil = new System.Windows.Forms.CheckBox();
            this.kullanıcısil = new System.Windows.Forms.CheckBox();
            this.kullanıcıekleme = new System.Windows.Forms.CheckBox();
            this.Stok_ekleme = new System.Windows.Forms.CheckBox();
            this.btnOnayla = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tctK_ad
            // 
            this.tctK_ad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tctK_ad.ForeColor = System.Drawing.Color.Black;
            this.tctK_ad.Location = new System.Drawing.Point(204, 28);
            this.tctK_ad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tctK_ad.Name = "tctK_ad";
            this.tctK_ad.Size = new System.Drawing.Size(216, 30);
            this.tctK_ad.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(39, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.stokgüncelleme);
            this.groupBox1.Controls.Add(this.satis_);
            this.groupBox1.Controls.Add(this.stokgörme);
            this.groupBox1.Controls.Add(this.stoksil);
            this.groupBox1.Controls.Add(this.kullanıcısil);
            this.groupBox1.Controls.Add(this.kullanıcıekleme);
            this.groupBox1.Controls.Add(this.Stok_ekleme);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.Yellow;
            this.groupBox1.Location = new System.Drawing.Point(81, 82);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(296, 273);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "YETKİLER";
            // 
            // stokgüncelleme
            // 
            this.stokgüncelleme.AutoSize = true;
            this.stokgüncelleme.Location = new System.Drawing.Point(53, 239);
            this.stokgüncelleme.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.stokgüncelleme.Name = "stokgüncelleme";
            this.stokgüncelleme.Size = new System.Drawing.Size(158, 24);
            this.stokgüncelleme.TabIndex = 4;
            this.stokgüncelleme.Text = "Stok Güncelleme";
            this.stokgüncelleme.UseVisualStyleBackColor = true;
            // 
            // satis_
            // 
            this.satis_.AutoSize = true;
            this.satis_.Location = new System.Drawing.Point(53, 206);
            this.satis_.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.satis_.Name = "satis_";
            this.satis_.Size = new System.Drawing.Size(74, 24);
            this.satis_.TabIndex = 4;
            this.satis_.Text = "Satış ";
            this.satis_.UseVisualStyleBackColor = true;
            // 
            // stokgörme
            // 
            this.stokgörme.AutoSize = true;
            this.stokgörme.Location = new System.Drawing.Point(53, 172);
            this.stokgörme.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.stokgörme.Name = "stokgörme";
            this.stokgörme.Size = new System.Drawing.Size(120, 24);
            this.stokgörme.TabIndex = 4;
            this.stokgörme.Text = "Stok Görme";
            this.stokgörme.UseVisualStyleBackColor = true;
            // 
            // stoksil
            // 
            this.stoksil.AutoSize = true;
            this.stoksil.Location = new System.Drawing.Point(53, 139);
            this.stoksil.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.stoksil.Name = "stoksil";
            this.stoksil.Size = new System.Drawing.Size(88, 24);
            this.stoksil.TabIndex = 3;
            this.stoksil.Text = "Stok Sil";
            this.stoksil.UseVisualStyleBackColor = true;
            // 
            // kullanıcısil
            // 
            this.kullanıcısil.AutoSize = true;
            this.kullanıcısil.Location = new System.Drawing.Point(53, 106);
            this.kullanıcısil.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kullanıcısil.Name = "kullanıcısil";
            this.kullanıcısil.Size = new System.Drawing.Size(118, 24);
            this.kullanıcısil.TabIndex = 2;
            this.kullanıcısil.Text = "Kullanıcı Sil";
            this.kullanıcısil.UseVisualStyleBackColor = true;
            // 
            // kullanıcıekleme
            // 
            this.kullanıcıekleme.AutoSize = true;
            this.kullanıcıekleme.Location = new System.Drawing.Point(53, 73);
            this.kullanıcıekleme.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kullanıcıekleme.Name = "kullanıcıekleme";
            this.kullanıcıekleme.Size = new System.Drawing.Size(154, 24);
            this.kullanıcıekleme.TabIndex = 1;
            this.kullanıcıekleme.Text = "Kullanıcı Ekleme";
            this.kullanıcıekleme.UseVisualStyleBackColor = true;
            // 
            // Stok_ekleme
            // 
            this.Stok_ekleme.AutoSize = true;
            this.Stok_ekleme.Location = new System.Drawing.Point(53, 39);
            this.Stok_ekleme.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Stok_ekleme.Name = "Stok_ekleme";
            this.Stok_ekleme.Size = new System.Drawing.Size(124, 24);
            this.Stok_ekleme.TabIndex = 0;
            this.Stok_ekleme.Text = "Stok Ekleme";
            this.Stok_ekleme.UseVisualStyleBackColor = true;
            // 
            // btnOnayla
            // 
            this.btnOnayla.BackColor = System.Drawing.Color.Transparent;
            this.btnOnayla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOnayla.Location = new System.Drawing.Point(81, 361);
            this.btnOnayla.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOnayla.Name = "btnOnayla";
            this.btnOnayla.Size = new System.Drawing.Size(296, 43);
            this.btnOnayla.TabIndex = 2;
            this.btnOnayla.Text = "Onayla";
            this.btnOnayla.UseVisualStyleBackColor = false;
            this.btnOnayla.Click += new System.EventHandler(this.btnOnayla_Click);
            // 
            // frmYetkiAta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(456, 418);
            this.Controls.Add(this.btnOnayla);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tctK_ad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmYetkiAta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmYetkiAta";
            this.Load += new System.EventHandler(this.frmYetkiAta_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox stokgörme;
        private System.Windows.Forms.CheckBox stoksil;
        private System.Windows.Forms.CheckBox kullanıcısil;
        private System.Windows.Forms.CheckBox kullanıcıekleme;
        private System.Windows.Forms.CheckBox Stok_ekleme;
        private System.Windows.Forms.Button btnOnayla;
        public System.Windows.Forms.TextBox tctK_ad;
        private System.Windows.Forms.CheckBox satis_;
        private System.Windows.Forms.CheckBox stokgüncelleme;
    }
}