namespace KYCUBYOmarket
{
    partial class frmKasa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKasa));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBarkodNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAlınan_para = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPara_ustu = new System.Windows.Forms.TextBox();
            this.pb5tl = new System.Windows.Forms.PictureBox();
            this.pb10tl = new System.Windows.Forms.PictureBox();
            this.pb20tl = new System.Windows.Forms.PictureBox();
            this.pb50tl = new System.Windows.Forms.PictureBox();
            this.pb100tl = new System.Windows.Forms.PictureBox();
            this.pb200tl = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSatışYAP = new System.Windows.Forms.Button();
            this.btnSatısİptal = new System.Windows.Forms.Button();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.btnUruncıkart = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtÜrünadett = new System.Windows.Forms.TextBox();
            this.btnekle = new System.Windows.Forms.Button();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb5tl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb10tl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb20tl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb50tl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb100tl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb200tl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(14, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(242, 100);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(52, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 57);
            this.label2.TabIndex = 4;
            this.label2.Text = "0,00 ₺";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(59, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "BARKOD NO:";
            // 
            // txtBarkodNo
            // 
            this.txtBarkodNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBarkodNo.Location = new System.Drawing.Point(63, 154);
            this.txtBarkodNo.Name = "txtBarkodNo";
            this.txtBarkodNo.Size = new System.Drawing.Size(206, 26);
            this.txtBarkodNo.TabIndex = 0;
            this.txtBarkodNo.TextChanged += new System.EventHandler(this.txtBarkodNo_TextChanged);
            this.txtBarkodNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBarkodNo_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(27, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "ALINAN PARA";
            // 
            // txtAlınan_para
            // 
            this.txtAlınan_para.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAlınan_para.Location = new System.Drawing.Point(31, 281);
            this.txtAlınan_para.Name = "txtAlınan_para";
            this.txtAlınan_para.Size = new System.Drawing.Size(113, 26);
            this.txtAlınan_para.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.SteelBlue;
            this.label4.Location = new System.Drawing.Point(155, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "PARA ÜSTÜ";
            // 
            // txtPara_ustu
            // 
            this.txtPara_ustu.Enabled = false;
            this.txtPara_ustu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPara_ustu.Location = new System.Drawing.Point(159, 281);
            this.txtPara_ustu.Name = "txtPara_ustu";
            this.txtPara_ustu.Size = new System.Drawing.Size(123, 26);
            this.txtPara_ustu.TabIndex = 3;
            // 
            // pb5tl
            // 
            this.pb5tl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb5tl.Image = ((System.Drawing.Image)(resources.GetObject("pb5tl.Image")));
            this.pb5tl.Location = new System.Drawing.Point(20, 373);
            this.pb5tl.Name = "pb5tl";
            this.pb5tl.Size = new System.Drawing.Size(124, 62);
            this.pb5tl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pb5tl.TabIndex = 4;
            this.pb5tl.TabStop = false;
            this.pb5tl.Click += new System.EventHandler(this.pb5tl_Click);
            // 
            // pb10tl
            // 
            this.pb10tl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb10tl.Image = ((System.Drawing.Image)(resources.GetObject("pb10tl.Image")));
            this.pb10tl.Location = new System.Drawing.Point(159, 373);
            this.pb10tl.Name = "pb10tl";
            this.pb10tl.Size = new System.Drawing.Size(123, 62);
            this.pb10tl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pb10tl.TabIndex = 4;
            this.pb10tl.TabStop = false;
            this.pb10tl.Click += new System.EventHandler(this.pb10tl_Click);
            // 
            // pb20tl
            // 
            this.pb20tl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb20tl.Image = ((System.Drawing.Image)(resources.GetObject("pb20tl.Image")));
            this.pb20tl.Location = new System.Drawing.Point(20, 441);
            this.pb20tl.Name = "pb20tl";
            this.pb20tl.Size = new System.Drawing.Size(124, 62);
            this.pb20tl.TabIndex = 4;
            this.pb20tl.TabStop = false;
            this.pb20tl.Click += new System.EventHandler(this.pb20tl_Click);
            // 
            // pb50tl
            // 
            this.pb50tl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb50tl.Image = ((System.Drawing.Image)(resources.GetObject("pb50tl.Image")));
            this.pb50tl.Location = new System.Drawing.Point(159, 441);
            this.pb50tl.Name = "pb50tl";
            this.pb50tl.Size = new System.Drawing.Size(123, 62);
            this.pb50tl.TabIndex = 4;
            this.pb50tl.TabStop = false;
            this.pb50tl.Click += new System.EventHandler(this.pb50tl_Click);
            // 
            // pb100tl
            // 
            this.pb100tl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb100tl.Image = ((System.Drawing.Image)(resources.GetObject("pb100tl.Image")));
            this.pb100tl.Location = new System.Drawing.Point(20, 509);
            this.pb100tl.Name = "pb100tl";
            this.pb100tl.Size = new System.Drawing.Size(124, 62);
            this.pb100tl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pb100tl.TabIndex = 4;
            this.pb100tl.TabStop = false;
            this.pb100tl.Click += new System.EventHandler(this.pb100tl_Click);
            // 
            // pb200tl
            // 
            this.pb200tl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb200tl.Image = ((System.Drawing.Image)(resources.GetObject("pb200tl.Image")));
            this.pb200tl.Location = new System.Drawing.Point(159, 509);
            this.pb200tl.Name = "pb200tl";
            this.pb200tl.Size = new System.Drawing.Size(123, 62);
            this.pb200tl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pb200tl.TabIndex = 4;
            this.pb200tl.TabStop = false;
            this.pb200tl.Click += new System.EventHandler(this.pb200tl_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(9, 132);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(48, 48);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox7.TabIndex = 5;
            this.pictureBox7.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(298, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1044, 537);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // btnSatışYAP
            // 
            this.btnSatışYAP.BackColor = System.Drawing.Color.White;
            this.btnSatışYAP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSatışYAP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSatışYAP.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSatışYAP.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnSatışYAP.Location = new System.Drawing.Point(297, 15);
            this.btnSatışYAP.Name = "btnSatışYAP";
            this.btnSatışYAP.Size = new System.Drawing.Size(122, 39);
            this.btnSatışYAP.TabIndex = 3;
            this.btnSatışYAP.Text = "Satış Yap";
            this.btnSatışYAP.UseVisualStyleBackColor = false;
            this.btnSatışYAP.Click += new System.EventHandler(this.btnSatışYAP_Click);
            // 
            // btnSatısİptal
            // 
            this.btnSatısİptal.BackColor = System.Drawing.Color.White;
            this.btnSatısİptal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSatısİptal.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSatısİptal.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnSatısİptal.Location = new System.Drawing.Point(425, 15);
            this.btnSatısİptal.Name = "btnSatısİptal";
            this.btnSatısİptal.Size = new System.Drawing.Size(122, 39);
            this.btnSatısİptal.TabIndex = 4;
            this.btnSatısİptal.Text = "Satış İptal";
            this.btnSatısİptal.UseVisualStyleBackColor = false;
            this.btnSatısİptal.Click += new System.EventHandler(this.btnSatısİptal_Click);
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(0, 581);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(47, 37);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 15;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Click += new System.EventHandler(this.pictureBox8_Click);
            // 
            // btnUruncıkart
            // 
            this.btnUruncıkart.BackColor = System.Drawing.Color.White;
            this.btnUruncıkart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUruncıkart.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnUruncıkart.Location = new System.Drawing.Point(553, 13);
            this.btnUruncıkart.Name = "btnUruncıkart";
            this.btnUruncıkart.Size = new System.Drawing.Size(191, 41);
            this.btnUruncıkart.TabIndex = 5;
            this.btnUruncıkart.Text = "Listeden Ürün Çıkart";
            this.btnUruncıkart.UseVisualStyleBackColor = false;
            this.btnUruncıkart.Click += new System.EventHandler(this.btnUruncıkart_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.SteelBlue;
            this.label5.Location = new System.Drawing.Point(52, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 19);
            this.label5.TabIndex = 2;
            this.label5.Text = "Ürün Adet";
            // 
            // txtÜrünadett
            // 
            this.txtÜrünadett.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtÜrünadett.Location = new System.Drawing.Point(56, 213);
            this.txtÜrünadett.Name = "txtÜrünadett";
            this.txtÜrünadett.Size = new System.Drawing.Size(88, 26);
            this.txtÜrünadett.TabIndex = 1;
            // 
            // btnekle
            // 
            this.btnekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnekle.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnekle.Location = new System.Drawing.Point(159, 212);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(110, 27);
            this.btnekle.TabIndex = 2;
            this.btnekle.Text = "ekle";
            this.btnekle.UseVisualStyleBackColor = true;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // btnHesapla
            // 
            this.btnHesapla.BackColor = System.Drawing.Color.White;
            this.btnHesapla.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHesapla.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnHesapla.Location = new System.Drawing.Point(31, 318);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(251, 37);
            this.btnHesapla.TabIndex = 19;
            this.btnHesapla.Text = "HESAPLA";
            this.btnHesapla.UseVisualStyleBackColor = false;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // frmKasa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1356, 622);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.txtÜrünadett);
            this.Controls.Add(this.btnUruncıkart);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.btnSatısİptal);
            this.Controls.Add(this.btnSatışYAP);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pb200tl);
            this.Controls.Add(this.pb50tl);
            this.Controls.Add(this.pb100tl);
            this.Controls.Add(this.pb20tl);
            this.Controls.Add(this.pb10tl);
            this.Controls.Add(this.pb5tl);
            this.Controls.Add(this.txtPara_ustu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAlınan_para);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBarkodNo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmKasa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAna";
            this.Load += new System.EventHandler(this.frmKasa_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmKasa_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb5tl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb10tl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb20tl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb50tl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb100tl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb200tl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBarkodNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAlınan_para;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPara_ustu;
        private System.Windows.Forms.PictureBox pb5tl;
        private System.Windows.Forms.PictureBox pb10tl;
        private System.Windows.Forms.PictureBox pb20tl;
        private System.Windows.Forms.PictureBox pb50tl;
        private System.Windows.Forms.PictureBox pb100tl;
        private System.Windows.Forms.PictureBox pb200tl;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSatışYAP;
        private System.Windows.Forms.Button btnSatısİptal;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Button btnUruncıkart;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtÜrünadett;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.Button btnHesapla;
    }
}