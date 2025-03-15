namespace Toptan_Hesap.Tedarikçi
{
    partial class EStokGirisFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EStokGirisFrm));
            dateTimePicker1 = new DateTimePicker();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            GuncelleBtn = new Button();
            SifirlaBtn = new Button();
            EkleBtn = new Button();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            sİLToolStripMenuItem = new ToolStripMenuItem();
            AdetTb = new TextBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            AnaSayfaBtn = new Button();
            GoruntuleBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(23, 120);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 46;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(23, 286);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(192, 28);
            comboBox2.TabIndex = 45;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(23, 222);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(192, 28);
            comboBox1.TabIndex = 44;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // GuncelleBtn
            // 
            GuncelleBtn.BackColor = Color.DarkKhaki;
            GuncelleBtn.FlatStyle = FlatStyle.Flat;
            GuncelleBtn.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            GuncelleBtn.ForeColor = Color.White;
            GuncelleBtn.Location = new Point(124, 459);
            GuncelleBtn.Name = "GuncelleBtn";
            GuncelleBtn.Size = new Size(115, 50);
            GuncelleBtn.TabIndex = 43;
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
            SifirlaBtn.Location = new Point(273, 459);
            SifirlaBtn.Name = "SifirlaBtn";
            SifirlaBtn.Size = new Size(83, 50);
            SifirlaBtn.TabIndex = 42;
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
            EkleBtn.Location = new Point(14, 459);
            EkleBtn.Name = "EkleBtn";
            EkleBtn.Size = new Size(83, 50);
            EkleBtn.TabIndex = 41;
            EkleBtn.Text = "EKLE";
            EkleBtn.UseVisualStyleBackColor = false;
            EkleBtn.Click += EkleBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaptionText;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(23, 350);
            label2.Name = "label2";
            label2.Size = new Size(46, 23);
            label2.TabIndex = 40;
            label2.Text = "Adet";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.ContextMenuStrip = contextMenuStrip1;
            dataGridView1.Location = new Point(402, 120);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1054, 491);
            dataGridView1.TabIndex = 39;
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
            // AdetTb
            // 
            AdetTb.Location = new Point(23, 376);
            AdetTb.Name = "AdetTb";
            AdetTb.Size = new Size(178, 27);
            AdetTb.TabIndex = 38;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.DarkKhaki;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1468, 692);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 47;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(23, 196);
            label1.Name = "label1";
            label1.Size = new Size(106, 23);
            label1.TabIndex = 48;
            label1.Text = "Tedarikçi Adı";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaptionText;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(23, 260);
            label3.Name = "label3";
            label3.Size = new Size(78, 23);
            label3.TabIndex = 49;
            label3.Text = "Ürün Adı";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Segoe UI Black", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.ForeColor = Color.Maroon;
            label4.Location = new Point(537, 9);
            label4.Name = "label4";
            label4.Size = new Size(182, 38);
            label4.TabIndex = 50;
            label4.Text = "STOK GİRİŞ ";
            // 
            // AnaSayfaBtn
            // 
            AnaSayfaBtn.BackColor = Color.DarkKhaki;
            AnaSayfaBtn.FlatStyle = FlatStyle.Flat;
            AnaSayfaBtn.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            AnaSayfaBtn.ForeColor = Color.White;
            AnaSayfaBtn.Location = new Point(404, 617);
            AnaSayfaBtn.Name = "AnaSayfaBtn";
            AnaSayfaBtn.Size = new Size(126, 50);
            AnaSayfaBtn.TabIndex = 52;
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
            GoruntuleBtn.Location = new Point(607, 617);
            GoruntuleBtn.Name = "GoruntuleBtn";
            GoruntuleBtn.Size = new Size(130, 50);
            GoruntuleBtn.TabIndex = 51;
            GoruntuleBtn.Text = "GÖRÜNTÜLE";
            GoruntuleBtn.UseVisualStyleBackColor = false;
            GoruntuleBtn.Click += GoruntuleBtn_Click;
            // 
            // EStokGirisFrm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1468, 692);
            Controls.Add(AnaSayfaBtn);
            Controls.Add(GoruntuleBtn);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(dateTimePicker1);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(GuncelleBtn);
            Controls.Add(SifirlaBtn);
            Controls.Add(EkleBtn);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(AdetTb);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "EStokGirisFrm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HESAP DEFTERİ ";
            Load += EStokGirisFrm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Button GuncelleBtn;
        private Button SifirlaBtn;
        private Button EkleBtn;
        private Label label2;
        private DataGridView dataGridView1;
        private TextBox AdetTb;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem sİLToolStripMenuItem;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label3;
        private Label label4;
        private Button AnaSayfaBtn;
        private Button GoruntuleBtn;
    }
}