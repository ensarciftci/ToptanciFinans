using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Diagnostics;
using System.Runtime.InteropServices.Marshalling;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace Toptan_Hesap
{
    public partial class EMusteriFrm : Form
    {
        public EMusteriFrm()
        {
            InitializeComponent();
        }

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\TPVT.accdb");
        OleDbDataAdapter db;
        OleDbCommand cmd;
        DataTable dt;
        void cmbdoldur(string tbl)
        {
            try
            {
                con.Open();
                db = new OleDbDataAdapter("Select *From [" + tbl + "]", con);
                dt = new DataTable();
                db.Fill(dt);
                con.Close();
                comboBox1.DataSource = dt;
                comboBox1.DisplayMember = "Ad";
                comboBox1.ValueMember = "MusteriId";



            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata : " + ex.Message);

            }
            finally
            {

                if (con.State == ConnectionState.Open)
                { con.Close(); }
            }
        }
        void griddoldur(string tbl)
        {
            dataGridView1.DataSource = null;
            dataGridView1.ClearSelection();

            try
            {
                con.Open();
                db = new OleDbDataAdapter("Select* From [" + tbl + "]", con);
                dt = new DataTable();
                db.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.Columns["MusteriId"].HeaderText = "M.ID";
                dataGridView1.Columns["AD"].HeaderText = "Müşteri Adı";
                dataGridView1.Columns["Telefon"].HeaderText = "Telefon";
                dataGridView1.Columns["ToplamBorc"].HeaderText = "Toplam Borç";
                foreach (DataGridViewColumn alan in dataGridView1.Columns)
                { 
                alan.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                }
                dataGridView1.Columns["ToplamBorc"].DefaultCellStyle.Format = "\"$\"#,##0.00";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata : " + ex.Message);

            }
            finally
            {


                if (con.State == ConnectionState.Open)
                { con.Close(); }
            }
        }
        void tbreset()
        {
            foreach (Control ctrl in this.Controls)
                if (ctrl is System.Windows.Forms.TextBox tb)
                {
                    tb.Clear();
                }
        }
        private void EMusteri_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            comboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox1.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBox1.SelectedIndex = -1;
            EkleBtn.MouseEnter += BtnRenk.btnMouseEnter;
            GuncelleBtn.MouseEnter += BtnRenk.btnMouseEnter;
            SifirlaBtn.MouseEnter += BtnRenk.btnMouseEnter;
            AnaSayfaBtn.MouseEnter += BtnRenk.btnMouseEnter;
            GoruntuleBtn.MouseEnter += BtnRenk.btnMouseEnter;
            EkleBtn.MouseLeave += BtnRenk.btnMouseLeave;
            GuncelleBtn.MouseLeave += BtnRenk.btnMouseLeave;
            SifirlaBtn.MouseLeave += (BtnRenk.btnMouseLeave);
            AnaSayfaBtn.MouseLeave += BtnRenk.btnMouseLeave;
            GoruntuleBtn.MouseLeave += BtnRenk.btnMouseLeave;
            cmbdoldur("Musteriler");
            griddoldur("Musteriler");
            dataGridView1.ClearSelection();
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is System.Windows.Forms.TextBox)
                {
                    ctrl.TabStop = true;
                }
                else
                {
                    ctrl.TabStop = false;
                }
            }

        }

        private void EkleBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(AdTb.Text.Trim()) || string.IsNullOrEmpty(TelTb.Text.Trim()) || string.IsNullOrEmpty(AdresTb.Text.Trim()))
            {
                MessageBox.Show("Lütfen tüm bilgileri doldurun !");
                return;
            }
            try
            {
                con.Open();
                cmd = new OleDbCommand("insert into Musteriler (Ad,Telefon,Adres) values('" + AdTb.Text + "','" + TelTb.Text + "','" + AdresTb.Text + "')", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("İşlem başarılı ", " ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
                griddoldur("Musteriler");
                dataGridView1.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata : " + ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                { con.Close(); }
            }
        }

        private void SifirlaBtn_Click(object sender, EventArgs e)
        {
            tbreset();
            griddoldur("Musteriler");
            dataGridView1.ClearSelection();
            comboBox1.SelectedIndex = -1;

        }
        int kimlik;
        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentRow != null)
                {
                    kimlik = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

                }
                AdTb.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                TelTb.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                AdresTb.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();


            }
            catch (Exception)
            {
                tbreset();
                kimlik = 0;
            }

        }



        private void GuncelleBtn_Click(object sender, EventArgs e)
        {
            if (kimlik == 0)
            {
                MessageBox.Show("Lütfen bir veri seçiniz !");
                return;
            }
            try
            {
                con.Open();
                cmd = new OleDbCommand("update Musteriler set Ad='" + AdTb.Text + "',Telefon='" + TelTb.Text + "',Adres='" + AdresTb.Text + "' where MusteriId = " + kimlik, con);
                cmd.ExecuteNonQuery();
                con.Close();
                griddoldur("Musteriler");
                dataGridView1.ClearSelection();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Hata : " + ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                { con.Close(); }
            }
        }

        private void sİLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new OleDbCommand("delete from Musteriler where MusteriId=" + kimlik, con);
            cmd.ExecuteNonQuery();
            con.Close();
            griddoldur("Musteriler");
            dataGridView1.ClearSelection();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AnaSayfaBtn_Click(object sender, EventArgs e)
        {
            AnaSayfaFrm frm = new AnaSayfaFrm();
            this.Hide();
            frm.ShowDialog();
            this.Close();


        }

        private void GoruntuleBtn_Click(object sender, EventArgs e)
        {
            GoruntuleFrm frm = new GoruntuleFrm();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dataGridView1.DataSource != null && dataGridView1.DataSource is DataTable)
            {
                DataTable dt = dataGridView1.DataSource as DataTable;

                if (comboBox1.SelectedValue != null)
                {
                    dt.DefaultView.RowFilter = "MusteriId = " + comboBox1.SelectedValue.ToString();
                }
                else
                {
                    dt.DefaultView.RowFilter = ""; // Filtreyi kaldır
                }
            }
        }
    }
}
