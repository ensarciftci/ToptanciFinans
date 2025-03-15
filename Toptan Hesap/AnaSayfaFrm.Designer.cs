namespace Toptan_Hesap
{
    partial class AnaSayfaFrm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaSayfaFrm));
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Crimson;
            button1.Font = new Font("Segoe UI", 13.8F);
            button1.ForeColor = Color.White;
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(193, 96);
            button1.TabIndex = 0;
            button1.Text = "Müşteri Ekle";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Crimson;
            button2.Font = new Font("Segoe UI", 13.8F);
            button2.ForeColor = Color.White;
            button2.Location = new Point(12, 126);
            button2.Name = "button2";
            button2.Size = new Size(193, 96);
            button2.TabIndex = 1;
            button2.Text = "Satış Ekle";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Crimson;
            button3.Font = new Font("Segoe UI", 13.8F);
            button3.ForeColor = Color.White;
            button3.Location = new Point(785, 126);
            button3.Name = "button3";
            button3.Size = new Size(193, 96);
            button3.TabIndex = 2;
            button3.Text = "Ödeme Ekle";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Crimson;
            button4.Font = new Font("Segoe UI", 13.8F);
            button4.ForeColor = Color.White;
            button4.Location = new Point(416, 126);
            button4.Name = "button4";
            button4.Size = new Size(193, 96);
            button4.TabIndex = 3;
            button4.Text = "Görüntüle";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Crimson;
            button5.Font = new Font("Segoe UI", 13.8F);
            button5.ForeColor = Color.White;
            button5.Location = new Point(416, 255);
            button5.Name = "button5";
            button5.Size = new Size(193, 96);
            button5.TabIndex = 4;
            button5.Text = "Ürün Ekle";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.Crimson;
            button6.Font = new Font("Segoe UI", 13.8F);
            button6.ForeColor = Color.White;
            button6.Location = new Point(12, 255);
            button6.Name = "button6";
            button6.Size = new Size(193, 96);
            button6.TabIndex = 5;
            button6.Text = "Tahsilat  Ekle";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.Crimson;
            button7.Font = new Font("Segoe UI", 13.8F);
            button7.ForeColor = Color.White;
            button7.Location = new Point(785, 12);
            button7.Name = "button7";
            button7.Size = new Size(193, 96);
            button7.TabIndex = 6;
            button7.Text = "Tedarikçi  Ekle";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.Crimson;
            button8.Font = new Font("Segoe UI", 13.8F);
            button8.ForeColor = Color.White;
            button8.Location = new Point(785, 255);
            button8.Name = "button8";
            button8.Size = new Size(193, 96);
            button8.TabIndex = 7;
            button8.Text = "Stok Giriş Ekle";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.anasayfaarka;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(990, 384);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // AnaSayfaFrm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(990, 384);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AnaSayfaFrm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HESAP DEFTERİ";
            Load += AnaSayfaFrm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private PictureBox pictureBox1;
    }
}
