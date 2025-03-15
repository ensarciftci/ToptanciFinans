namespace Toptan_Hesap
{
    partial class EUrunFrm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EUrunFrm));
            GuncelleBtn = new Button();
            SifirlaBtn = new Button();
            EkleBtn = new Button();
            label3 = new Label();
            label2 = new Label();
            UrunFiyatiTb = new TextBox();
            dataGridView1 = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            sİLToolStripMenuItem = new ToolStripMenuItem();
            UrunAdiTb = new TextBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            AnaSayfaBtn = new Button();
            GoruntuleBtn = new Button();
            comboBox1 = new ComboBox();
            label4 = new Label();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // GuncelleBtn
            // 
            GuncelleBtn.BackColor = Color.DarkKhaki;
            GuncelleBtn.FlatStyle = FlatStyle.Flat;
            GuncelleBtn.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            GuncelleBtn.ForeColor = Color.White;
            GuncelleBtn.Location = new Point(148, 349);
            GuncelleBtn.Name = "GuncelleBtn";
            GuncelleBtn.Size = new Size(106, 50);
            GuncelleBtn.TabIndex = 24;
            GuncelleBtn.Text = "GÜNCELLE";
            GuncelleBtn.UseVisualStyleBackColor = false;
            GuncelleBtn.Click += GuncelleBtn_Click;
            // 
            // SifirlaBtn
            // 
            SifirlaBtn.BackColor = Color.DarkKhaki;
            SifirlaBtn.FlatStyle = FlatStyle.Flat;
            SifirlaBtn.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            SifirlaBtn.ForeColor = Color.White;
            SifirlaBtn.Location = new Point(286, 349);
            SifirlaBtn.Name = "SifirlaBtn";
            SifirlaBtn.Size = new Size(83, 50);
            SifirlaBtn.TabIndex = 23;
            SifirlaBtn.Text = "SIFIRLA";
            SifirlaBtn.UseVisualStyleBackColor = false;
            SifirlaBtn.Click += SifirlaBtn_Click;
            // 
            // EkleBtn
            // 
            EkleBtn.BackColor = Color.DarkKhaki;
            EkleBtn.FlatStyle = FlatStyle.Flat;
            EkleBtn.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            EkleBtn.ForeColor = Color.White;
            EkleBtn.Location = new Point(41, 349);
            EkleBtn.Name = "EkleBtn";
            EkleBtn.Size = new Size(83, 50);
            EkleBtn.TabIndex = 22;
            EkleBtn.Text = "EKLE";
            EkleBtn.UseVisualStyleBackColor = false;
            EkleBtn.Click += EkleBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaptionText;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(57, 180);
            label3.Name = "label3";
            label3.Size = new Size(82, 23);
            label3.TabIndex = 20;
            label3.Text = "Alış Fiyatı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaptionText;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(57, 106);
            label2.Name = "label2";
            label2.Size = new Size(78, 23);
            label2.TabIndex = 19;
            label2.Text = "Ürün Adı";
            // 
            // UrunFiyatiTb
            // 
            UrunFiyatiTb.Location = new Point(57, 278);
            UrunFiyatiTb.Name = "UrunFiyatiTb";
            UrunFiyatiTb.Size = new Size(178, 27);
            UrunFiyatiTb.TabIndex = 17;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.ContextMenuStrip = contextMenuStrip1;
            dataGridView1.Location = new Point(423, 106);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(622, 361);
            dataGridView1.TabIndex = 16;
            dataGridView1.MouseClick += dataGridView1_MouseClick;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { sİLToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(98, 28);
            // 
            // sİLToolStripMenuItem
            // 
            sİLToolStripMenuItem.Name = "sİLToolStripMenuItem";
            sİLToolStripMenuItem.Size = new Size(97, 24);
            sİLToolStripMenuItem.Text = "SİL";
            sİLToolStripMenuItem.Click += sİLToolStripMenuItem_Click;
            // 
            // UrunAdiTb
            // 
            UrunAdiTb.Location = new Point(57, 132);
            UrunAdiTb.Name = "UrunAdiTb";
            UrunAdiTb.Size = new Size(178, 27);
            UrunAdiTb.TabIndex = 15;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.DarkKhaki;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1108, 554);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 38;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI Black", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.Maroon;
            label1.Location = new Point(452, 9);
            label1.Name = "label1";
            label1.Size = new Size(173, 38);
            label1.TabIndex = 39;
            label1.Text = "ÜRÜN EKLE";
            // 
            // AnaSayfaBtn
            // 
            AnaSayfaBtn.BackColor = Color.DarkKhaki;
            AnaSayfaBtn.FlatStyle = FlatStyle.Flat;
            AnaSayfaBtn.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            AnaSayfaBtn.ForeColor = Color.White;
            AnaSayfaBtn.Location = new Point(425, 473);
            AnaSayfaBtn.Name = "AnaSayfaBtn";
            AnaSayfaBtn.Size = new Size(126, 50);
            AnaSayfaBtn.TabIndex = 41;
            AnaSayfaBtn.Text = "ANA SAYFA";
            AnaSayfaBtn.UseVisualStyleBackColor = false;
            AnaSayfaBtn.Click += AnaSayfaBtn_Click;
            // 
            // GoruntuleBtn
            // 
            GoruntuleBtn.BackColor = Color.DarkKhaki;
            GoruntuleBtn.FlatStyle = FlatStyle.Flat;
            GoruntuleBtn.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            GoruntuleBtn.ForeColor = Color.White;
            GoruntuleBtn.Location = new Point(628, 473);
            GoruntuleBtn.Name = "GoruntuleBtn";
            GoruntuleBtn.Size = new Size(130, 50);
            GoruntuleBtn.TabIndex = 40;
            GoruntuleBtn.Text = "GÖRÜNTÜLE";
            GoruntuleBtn.UseVisualStyleBackColor = false;
            GoruntuleBtn.Click += GoruntuleBtn_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(853, 72);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(192, 28);
            comboBox1.TabIndex = 46;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ActiveCaptionText;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(58, 252);
            label4.Name = "label4";
            label4.Size = new Size(91, 23);
            label4.TabIndex = 48;
            label4.Text = "Satış Fiyatı";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(58, 206);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(178, 27);
            textBox1.TabIndex = 47;
            // 
            // EUrunFrm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1108, 554);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(comboBox1);
            Controls.Add(AnaSayfaBtn);
            Controls.Add(GoruntuleBtn);
            Controls.Add(label1);
            Controls.Add(GuncelleBtn);
            Controls.Add(SifirlaBtn);
            Controls.Add(EkleBtn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(UrunFiyatiTb);
            Controls.Add(dataGridView1);
            Controls.Add(UrunAdiTb);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "EUrunFrm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HESAP DEFTERİ";
            Load += EUrunFrm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button GuncelleBtn;
        private Button SifirlaBtn;
        private Button EkleBtn;
        private Label label3;
        private Label label2;
        private TextBox UrunFiyatiTb;
        private DataGridView dataGridView1;
        private TextBox UrunAdiTb;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem sİLToolStripMenuItem;
        private PictureBox pictureBox1;
        private Label label1;
        private Button AnaSayfaBtn;
        private Button GoruntuleBtn;
        private ComboBox comboBox1;
        private Label label4;
        private TextBox textBox1;
    }
}