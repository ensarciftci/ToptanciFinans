namespace Toptan_Hesap
{
    partial class GoruntuleFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GoruntuleFrm));
            dataGridView1 = new DataGridView();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            AnaSayfaBtn = new Button();
            SifirlaBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(242, 121);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1220, 615);
            dataGridView1.TabIndex = 39;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Müşteriler", "Satışlar", "Tahsilatlar", "Ödemeler", "Stok Girişleri", "Tedarikçiler", "Ürünler" });
            comboBox1.Location = new Point(26, 67);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(180, 28);
            comboBox1.TabIndex = 40;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(985, 67);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(180, 28);
            comboBox2.TabIndex = 41;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Khaki;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1474, 813);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 43;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Black;
            label2.ForeColor = Color.White;
            label2.Location = new Point(35, 44);
            label2.Name = "label2";
            label2.Size = new Size(81, 20);
            label2.TabIndex = 44;
            label2.Text = "TABLO ADI";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.ForeColor = Color.White;
            label1.Location = new Point(985, 44);
            label1.Name = "label1";
            label1.Size = new Size(30, 20);
            label1.TabIndex = 45;
            label1.Text = "AD";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            textBox1.Location = new Point(1238, 67);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(165, 30);
            textBox1.TabIndex = 46;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Black;
            label3.ForeColor = Color.White;
            label3.Location = new Point(1238, 44);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 47;
            label3.Text = "ÜRÜN";
            // 
            // AnaSayfaBtn
            // 
            AnaSayfaBtn.BackColor = Color.DarkKhaki;
            AnaSayfaBtn.FlatStyle = FlatStyle.Flat;
            AnaSayfaBtn.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            AnaSayfaBtn.ForeColor = Color.White;
            AnaSayfaBtn.Location = new Point(216, 742);
            AnaSayfaBtn.Name = "AnaSayfaBtn";
            AnaSayfaBtn.Size = new Size(126, 50);
            AnaSayfaBtn.TabIndex = 49;
            AnaSayfaBtn.Text = "ANA SAYFA";
            AnaSayfaBtn.UseVisualStyleBackColor = false;
            AnaSayfaBtn.Click += AnaSayfaBtn_Click;
            // 
            // SifirlaBtn
            // 
            SifirlaBtn.BackColor = Color.DarkKhaki;
            SifirlaBtn.FlatStyle = FlatStyle.Flat;
            SifirlaBtn.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            SifirlaBtn.ForeColor = Color.White;
            SifirlaBtn.Location = new Point(35, 742);
            SifirlaBtn.Name = "SifirlaBtn";
            SifirlaBtn.Size = new Size(92, 50);
            SifirlaBtn.TabIndex = 48;
            SifirlaBtn.Text = "SIFIRLA";
            SifirlaBtn.UseVisualStyleBackColor = false;
            SifirlaBtn.Click += SifirlaBtn_Click;
            // 
            // GoruntuleFrm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1474, 813);
            Controls.Add(AnaSayfaBtn);
            Controls.Add(SifirlaBtn);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(dataGridView1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "GoruntuleFrm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HESAP DEFTERİ";
            Load += GoruntuleFrm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
        private TextBox textBox1;
        private Label label3;
        private Button AnaSayfaBtn;
        private Button SifirlaBtn;
    }
}