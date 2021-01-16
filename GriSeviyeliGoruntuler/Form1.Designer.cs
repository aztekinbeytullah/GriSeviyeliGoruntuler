namespace GriSeviyeliGoruntuler
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnResimYukle = new System.Windows.Forms.Button();
            this.btnGriYap = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnBinaryYap = new System.Windows.Forms.Button();
            this.btnOtsuAlgoritmasiUygula = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnBlop = new System.Windows.Forms.Button();
            this.btnDondur = new System.Windows.Forms.Button();
            this.btnResimKlasoruSec = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(630, 531);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnResimYukle
            // 
            this.btnResimYukle.Location = new System.Drawing.Point(12, 12);
            this.btnResimYukle.Name = "btnResimYukle";
            this.btnResimYukle.Size = new System.Drawing.Size(75, 23);
            this.btnResimYukle.TabIndex = 1;
            this.btnResimYukle.Text = "Resim Yükle";
            this.btnResimYukle.UseVisualStyleBackColor = true;
            this.btnResimYukle.Click += new System.EventHandler(this.btnResimYukle_Click);
            // 
            // btnGriYap
            // 
            this.btnGriYap.Location = new System.Drawing.Point(93, 12);
            this.btnGriYap.Name = "btnGriYap";
            this.btnGriYap.Size = new System.Drawing.Size(75, 23);
            this.btnGriYap.TabIndex = 1;
            this.btnGriYap.Text = "Gri Yap";
            this.btnGriYap.UseVisualStyleBackColor = true;
            this.btnGriYap.Click += new System.EventHandler(this.btnGriYap_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnBinaryYap
            // 
            this.btnBinaryYap.Location = new System.Drawing.Point(174, 12);
            this.btnBinaryYap.Name = "btnBinaryYap";
            this.btnBinaryYap.Size = new System.Drawing.Size(75, 23);
            this.btnBinaryYap.TabIndex = 2;
            this.btnBinaryYap.Text = "Binary Yap";
            this.btnBinaryYap.UseVisualStyleBackColor = true;
            this.btnBinaryYap.Click += new System.EventHandler(this.btnBinaryYap_Click);
            // 
            // btnOtsuAlgoritmasiUygula
            // 
            this.btnOtsuAlgoritmasiUygula.Location = new System.Drawing.Point(255, 12);
            this.btnOtsuAlgoritmasiUygula.Name = "btnOtsuAlgoritmasiUygula";
            this.btnOtsuAlgoritmasiUygula.Size = new System.Drawing.Size(75, 23);
            this.btnOtsuAlgoritmasiUygula.TabIndex = 2;
            this.btnOtsuAlgoritmasiUygula.Text = "Otsu";
            this.btnOtsuAlgoritmasiUygula.UseVisualStyleBackColor = true;
            this.btnOtsuAlgoritmasiUygula.Click += new System.EventHandler(this.btnOtsuAlgoritmasiUygula_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox4.Location = new System.Drawing.Point(0, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(663, 531);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox4);
            this.splitContainer1.Size = new System.Drawing.Size(1301, 533);
            this.splitContainer1.SplitterDistance = 632;
            this.splitContainer1.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Controls.Add(this.btnBlop);
            this.panel1.Controls.Add(this.btnDondur);
            this.panel1.Controls.Add(this.btnOtsuAlgoritmasiUygula);
            this.panel1.Controls.Add(this.btnResimKlasoruSec);
            this.panel1.Controls.Add(this.btnResimYukle);
            this.panel1.Controls.Add(this.btnGriYap);
            this.panel1.Controls.Add(this.btnBinaryYap);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1301, 86);
            this.panel1.TabIndex = 4;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(1169, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 69);
            this.listBox1.TabIndex = 3;
            // 
            // btnBlop
            // 
            this.btnBlop.Location = new System.Drawing.Point(438, 12);
            this.btnBlop.Name = "btnBlop";
            this.btnBlop.Size = new System.Drawing.Size(75, 23);
            this.btnBlop.TabIndex = 2;
            this.btnBlop.Text = "BlopBul";
            this.btnBlop.UseVisualStyleBackColor = true;
            // 
            // btnDondur
            // 
            this.btnDondur.Location = new System.Drawing.Point(336, 12);
            this.btnDondur.Name = "btnDondur";
            this.btnDondur.Size = new System.Drawing.Size(75, 23);
            this.btnDondur.TabIndex = 2;
            this.btnDondur.Text = "Döndür";
            this.btnDondur.UseVisualStyleBackColor = true;
            this.btnDondur.Click += new System.EventHandler(this.btnDondur_Click);
            // 
            // btnResimKlasoruSec
            // 
            this.btnResimKlasoruSec.Location = new System.Drawing.Point(1088, 12);
            this.btnResimKlasoruSec.Name = "btnResimKlasoruSec";
            this.btnResimKlasoruSec.Size = new System.Drawing.Size(75, 23);
            this.btnResimKlasoruSec.TabIndex = 1;
            this.btnResimKlasoruSec.Text = "Resimleri Seç";
            this.btnResimKlasoruSec.UseVisualStyleBackColor = true;
            this.btnResimKlasoruSec.Click += new System.EventHandler(this.btnResimKlasoruSec_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.splitContainer1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 86);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1301, 533);
            this.panel2.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1301, 619);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnResimYukle;
        private System.Windows.Forms.Button btnGriYap;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnBinaryYap;
        private System.Windows.Forms.Button btnOtsuAlgoritmasiUygula;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDondur;
        private System.Windows.Forms.Button btnResimKlasoruSec;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnBlop;
    }
}

