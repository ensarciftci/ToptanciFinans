namespace Toptan_Hesap
{
    partial class EOdemeFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EOdemeFrm));
            dateTimePicker1 = new DateTimePicker();
            GuncelleBtn = new Button();
            SifirlaBtn = new Button();
            EkleBtn = new Button();
            label4 = new Label();
            MiktarTb = new TextBox();
            dataGridView1 = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            sİLToolStripMenuItem = new ToolStripMenuItem();
            comboBox1 = new ComboBox();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            AnaSayfaBtn = new Button();
            GoruntuleBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarForeColor = SystemColors.ActiveCaption;
            dateTimePicker1.CalendarMonthBackground = Color.MistyRose;
            dateTimePicker1.CalendarTitleBackColor = SystemColors.InactiveCaption;
            dateTimePicker1.Location = new Point(56, 80);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 0;
            // 
            // GuncelleBtn
            // 
            GuncelleBtn.BackColor = Color.DarkKhaki;
            GuncelleBtn.FlatStyle = FlatStyle.Flat;
            GuncelleBtn.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            GuncelleBtn.ForeColor = Color.White;
            GuncelleBtn.Location = new Point(147, 354);
            GuncelleBtn.Name = "GuncelleBtn";
            GuncelleBtn.Size = new Size(103, 50);
            GuncelleBtn.TabIndex = 34;
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
            SifirlaBtn.Location = new Point(271, 354);
            SifirlaBtn.Name = "SifirlaBtn";
            SifirlaBtn.Size = new Size(83, 50);
            SifirlaBtn.TabIndex = 33;
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
            EkleBtn.Location = new Point(42, 354);
            EkleBtn.Name = "EkleBtn";
            EkleBtn.Size = new Size(83, 50);
            EkleBtn.TabIndex = 32;
            EkleBtn.Text = "EKLE";
            EkleBtn.UseVisualStyleBackColor = false;
            EkleBtn.Click += EkleBtn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Black;
            label4.Font = new Font("Segoe UI", 10.2F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(56, 234);
            label4.Name = "label4";
            label4.Size = new Size(123, 23);
            label4.TabIndex = 31;
            label4.Text = "Ödeme Miktarı";
            // 
            // MiktarTb
            // 
            MiktarTb.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            MiktarTb.Location = new Point(56, 262);
            MiktarTb.Name = "MiktarTb";
            MiktarTb.Size = new Size(219, 32);
            MiktarTb.TabIndex = 28;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.Gray;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.ContextMenuStrip = contextMenuStrip1;
            dataGridView1.Location = new Point(427, 80);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(678, 361);
            dataGridView1.TabIndex = 26;
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
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(56, 163);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(219, 36);
            comboBox1.TabIndex = 35;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.DarkKhaki;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1242, 533);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 37;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Black;
            label2.Font = new Font("Segoe UI", 10.2F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(57, 135);
            label2.Name = "label2";
            label2.Size = new Size(50, 23);
            label2.TabIndex = 38;
            label2.Text = "ALICI";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Segoe UI Black", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.Maroon;
            label3.Location = new Point(507, 9);
            label3.Name = "label3";
            label3.Size = new Size(197, 38);
            label3.TabIndex = 39;
            label3.Text = "ÖDEME EKLE ";
            // 
            // AnaSayfaBtn
            // 
            AnaSayfaBtn.BackColor = Color.DarkKhaki;
            AnaSayfaBtn.FlatStyle = FlatStyle.Flat;
            AnaSayfaBtn.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            AnaSayfaBtn.ForeColor = Color.White;
            AnaSayfaBtn.Location = new Point(429, 447);
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
            GoruntuleBtn.Location = new Point(632, 447);
            GoruntuleBtn.Name = "GoruntuleBtn";
            GoruntuleBtn.Size = new Size(130, 50);
            GoruntuleBtn.TabIndex = 40;
            GoruntuleBtn.Text = "GÖRÜNTÜLE";
            GoruntuleBtn.UseVisualStyleBackColor = false;
            GoruntuleBtn.Click += GoruntuleBtn_Click;
            // 
            // EOdemeFrm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1242, 533);
            Controls.Add(AnaSayfaBtn);
            Controls.Add(GoruntuleBtn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(GuncelleBtn);
            Controls.Add(SifirlaBtn);
            Controls.Add(EkleBtn);
            Controls.Add(label4);
            Controls.Add(MiktarTb);
            Controls.Add(dataGridView1);
            Controls.Add(dateTimePicker1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "EOdemeFrm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HESAP DEFTERİ";
            Load += EOdemeFrm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private Button GuncelleBtn;
        private Button SifirlaBtn;
        private Button EkleBtn;
        private Label label4;
        private TextBox MiktarTb;
        private DataGridView dataGridView1;
        private ComboBox comboBox1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem sİLToolStripMenuItem;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private Button AnaSayfaBtn;
        private Button GoruntuleBtn;
    }
}