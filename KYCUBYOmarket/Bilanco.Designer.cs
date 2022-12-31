namespace KYCUBYOmarket
{
    partial class Bilanco
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bilanco));
            this.lblEnCokSatan = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblToplamKznc = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTümü = new System.Windows.Forms.Button();
            this.btnAylik = new System.Windows.Forms.Button();
            this.btnGünlük = new System.Windows.Forms.Button();
            this.lblEnAz = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEnCokSatan
            // 
            this.lblEnCokSatan.AutoSize = true;
            this.lblEnCokSatan.BackColor = System.Drawing.Color.Transparent;
            this.lblEnCokSatan.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEnCokSatan.ForeColor = System.Drawing.Color.Green;
            this.lblEnCokSatan.Location = new System.Drawing.Point(313, 338);
            this.lblEnCokSatan.Name = "lblEnCokSatan";
            this.lblEnCokSatan.Size = new System.Drawing.Size(27, 29);
            this.lblEnCokSatan.TabIndex = 15;
            this.lblEnCokSatan.Text = "_";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(428, 342);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "En Az Satan Ürün :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(91, 342);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(227, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "En Çok Satan Ürün :";
            // 
            // lblToplamKznc
            // 
            this.lblToplamKznc.AutoSize = true;
            this.lblToplamKznc.BackColor = System.Drawing.Color.Transparent;
            this.lblToplamKznc.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamKznc.ForeColor = System.Drawing.Color.Green;
            this.lblToplamKznc.Location = new System.Drawing.Point(479, 398);
            this.lblToplamKznc.Name = "lblToplamKznc";
            this.lblToplamKznc.Size = new System.Drawing.Size(27, 29);
            this.lblToplamKznc.TabIndex = 12;
            this.lblToplamKznc.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(294, 398);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Toplam Kazanç :";
            // 
            // btnTümü
            // 
            this.btnTümü.BackColor = System.Drawing.Color.Transparent;
            this.btnTümü.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTümü.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnTümü.Location = new System.Drawing.Point(226, 443);
            this.btnTümü.Name = "btnTümü";
            this.btnTümü.Size = new System.Drawing.Size(348, 39);
            this.btnTümü.TabIndex = 8;
            this.btnTümü.Text = "Tüm Satış İşlemlerini Göster";
            this.btnTümü.UseVisualStyleBackColor = false;
            this.btnTümü.Click += new System.EventHandler(this.btnTümü_Click);
            // 
            // btnAylik
            // 
            this.btnAylik.BackColor = System.Drawing.Color.Transparent;
            this.btnAylik.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAylik.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnAylik.Location = new System.Drawing.Point(418, 283);
            this.btnAylik.Name = "btnAylik";
            this.btnAylik.Size = new System.Drawing.Size(396, 39);
            this.btnAylik.TabIndex = 9;
            this.btnAylik.Text = "En Az Satan Ürünleri Göster";
            this.btnAylik.UseVisualStyleBackColor = false;
            this.btnAylik.Click += new System.EventHandler(this.btnAylik_Click);
            // 
            // btnGünlük
            // 
            this.btnGünlük.BackColor = System.Drawing.Color.Transparent;
            this.btnGünlük.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGünlük.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnGünlük.Location = new System.Drawing.Point(12, 283);
            this.btnGünlük.Name = "btnGünlük";
            this.btnGünlük.Size = new System.Drawing.Size(373, 39);
            this.btnGünlük.TabIndex = 10;
            this.btnGünlük.Text = "En Çok Satan Ürünleri Göster";
            this.btnGünlük.UseVisualStyleBackColor = false;
            this.btnGünlük.Click += new System.EventHandler(this.btnGünlük_Click);
            // 
            // lblEnAz
            // 
            this.lblEnAz.AutoSize = true;
            this.lblEnAz.BackColor = System.Drawing.Color.Transparent;
            this.lblEnAz.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEnAz.ForeColor = System.Drawing.Color.Green;
            this.lblEnAz.Location = new System.Drawing.Point(633, 339);
            this.lblEnAz.Name = "lblEnAz";
            this.lblEnAz.Size = new System.Drawing.Size(27, 29);
            this.lblEnAz.TabIndex = 16;
            this.lblEnAz.Text = "_";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(802, 249);
            this.dataGridView1.TabIndex = 17;
            // 
            // Bilanco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(825, 500);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblEnAz);
            this.Controls.Add(this.lblEnCokSatan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblToplamKznc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTümü);
            this.Controls.Add(this.btnAylik);
            this.Controls.Add(this.btnGünlük);
            this.ForeColor = System.Drawing.Color.SteelBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Bilanco";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bilanço Formu";
            this.Load += new System.EventHandler(this.Bilanco_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnCokSatan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblToplamKznc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTümü;
        private System.Windows.Forms.Button btnAylik;
        private System.Windows.Forms.Button btnGünlük;
        private System.Windows.Forms.Label lblEnAz;
        private System.Windows.Forms.DataGridView dataGridView1;

    }
}