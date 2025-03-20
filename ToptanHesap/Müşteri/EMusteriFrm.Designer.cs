namespace Toptan_Hesap
{
    partial class EMusteriFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EMusteriFrm));
            AdTb = new TextBox();
            dataGridView1 = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            sİLToolStripMenuItem = new ToolStripMenuItem();
            TelTb = new TextBox();
            AdresTb = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            EkleBtn = new Button();
            SifirlaBtn = new Button();
            GoruntuleBtn = new Button();
            GuncelleBtn = new Button();
            pictureBox1 = new PictureBox();
            AnaSayfaBtn = new Button();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // AdTb
            // 
            AdTb.Location = new Point(45, 142);
            AdTb.Name = "AdTb";
            AdTb.Size = new Size(178, 27);
            AdTb.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.ContextMenuStrip = contextMenuStrip1;
            dataGridView1.Location = new Point(393, 73);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(615, 379);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.MouseClick += dataGridView1_MouseClick;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { sİLToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(211, 56);
            // 
            // sİLToolStripMenuItem
            // 
            sİLToolStripMenuItem.Name = "sİLToolStripMenuItem";
            sİLToolStripMenuItem.Size = new Size(210, 24);
            sİLToolStripMenuItem.Text = "SİL";
            sİLToolStripMenuItem.Click += sİLToolStripMenuItem_Click;
            // 
            // TelTb
            // 
            TelTb.Location = new Point(45, 216);
            TelTb.Name = "TelTb";
            TelTb.Size = new Size(178, 27);
            TelTb.TabIndex = 2;
            // 
            // AdresTb
            // 
            AdresTb.Location = new Point(45, 289);
            AdresTb.Name = "AdresTb";
            AdresTb.Size = new Size(178, 27);
            AdresTb.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI Black", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.Maroon;
            label1.Location = new Point(426, 9);
            label1.Name = "label1";
            label1.Size = new Size(216, 38);
            label1.TabIndex = 5;
            label1.Text = "MÜŞTERİ EKLE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Black;
            label2.ForeColor = Color.White;
            label2.Location = new Point(45, 119);
            label2.Name = "label2";
            label2.Size = new Size(81, 20);
            label2.TabIndex = 6;
            label2.Text = "AD SOYAD";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Black;
            label3.ForeColor = Color.White;
            label3.Location = new Point(45, 193);
            label3.Name = "label3";
            label3.Size = new Size(95, 20);
            label3.TabIndex = 7;
            label3.Text = "TELEFON NO";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Black;
            label4.ForeColor = Color.White;
            label4.Location = new Point(45, 266);
            label4.Name = "label4";
            label4.Size = new Size(55, 20);
            label4.TabIndex = 8;
            label4.Text = "ADRES";
            // 
            // EkleBtn
            // 
            EkleBtn.BackColor = Color.DarkKhaki;
            EkleBtn.FlatStyle = FlatStyle.Flat;
            EkleBtn.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            EkleBtn.ForeColor = Color.White;
            EkleBtn.Location = new Point(26, 357);
            EkleBtn.Name = "EkleBtn";
            EkleBtn.Size = new Size(88, 50);
            EkleBtn.TabIndex = 10;
            EkleBtn.Text = "EKLE";
            EkleBtn.UseVisualStyleBackColor = false;
            EkleBtn.Click += EkleBtn_Click;
            // 
            // SifirlaBtn
            // 
            SifirlaBtn.BackColor = Color.DarkKhaki;
            SifirlaBtn.FlatStyle = FlatStyle.Flat;
            SifirlaBtn.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            SifirlaBtn.ForeColor = Color.White;
            SifirlaBtn.Location = new Point(284, 357);
            SifirlaBtn.Name = "SifirlaBtn";
            SifirlaBtn.Size = new Size(92, 50);
            SifirlaBtn.TabIndex = 11;
            SifirlaBtn.Text = "SIFIRLA";
            SifirlaBtn.UseVisualStyleBackColor = false;
            SifirlaBtn.Click += SifirlaBtn_Click;
            // 
            // GoruntuleBtn
            // 
            GoruntuleBtn.BackColor = Color.DarkKhaki;
            GoruntuleBtn.FlatStyle = FlatStyle.Flat;
            GoruntuleBtn.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            GoruntuleBtn.ForeColor = Color.White;
            GoruntuleBtn.Location = new Point(596, 458);
            GoruntuleBtn.Name = "GoruntuleBtn";
            GoruntuleBtn.Size = new Size(130, 50);
            GoruntuleBtn.TabIndex = 13;
            GoruntuleBtn.Text = "GÖRÜNTÜLE";
            GoruntuleBtn.UseVisualStyleBackColor = false;
            GoruntuleBtn.Click += GoruntuleBtn_Click;
            // 
            // GuncelleBtn
            // 
            GuncelleBtn.BackColor = Color.DarkKhaki;
            GuncelleBtn.FlatStyle = FlatStyle.Flat;
            GuncelleBtn.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            GuncelleBtn.ForeColor = Color.White;
            GuncelleBtn.Location = new Point(145, 357);
            GuncelleBtn.Name = "GuncelleBtn";
            GuncelleBtn.Size = new Size(110, 50);
            GuncelleBtn.TabIndex = 14;
            GuncelleBtn.Text = "GÜNCELLE";
            GuncelleBtn.UseVisualStyleBackColor = false;
            GuncelleBtn.Click += GuncelleBtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Khaki;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1020, 521);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // AnaSayfaBtn
            // 
            AnaSayfaBtn.BackColor = Color.DarkKhaki;
            AnaSayfaBtn.FlatStyle = FlatStyle.Flat;
            AnaSayfaBtn.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            AnaSayfaBtn.ForeColor = Color.White;
            AnaSayfaBtn.Location = new Point(393, 458);
            AnaSayfaBtn.Name = "AnaSayfaBtn";
            AnaSayfaBtn.Size = new Size(126, 50);
            AnaSayfaBtn.TabIndex = 16;
            AnaSayfaBtn.Text = "ANA SAYFA";
            AnaSayfaBtn.UseVisualStyleBackColor = false;
            AnaSayfaBtn.Click += AnaSayfaBtn_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(802, 39);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(180, 28);
            comboBox1.TabIndex = 42;
            comboBox1.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // EMusteriFrm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1020, 521);
            Controls.Add(comboBox1);
            Controls.Add(AnaSayfaBtn);
            Controls.Add(GuncelleBtn);
            Controls.Add(GoruntuleBtn);
            Controls.Add(SifirlaBtn);
            Controls.Add(EkleBtn);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(AdresTb);
            Controls.Add(TelTb);
            Controls.Add(dataGridView1);
            Controls.Add(AdTb);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "EMusteriFrm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HESAP DEFTERİ";
            Load += EMusteri_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox AdTb;
        private DataGridView dataGridView1;
        private TextBox TelTb;
        private TextBox AdresTb;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button EkleBtn;
        private Button SifirlaBtn;
        private Button GoruntuleBtn;
        private Button GuncelleBtn;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem sİLToolStripMenuItem;
        private PictureBox pictureBox1;
        private Button AnaSayfaBtn;
        private ComboBox comboBox1;
    }
}