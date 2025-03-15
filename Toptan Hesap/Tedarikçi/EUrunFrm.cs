using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Toptan_Hesap
{
    public partial class EUrunFrm : Form
    {
        public EUrunFrm()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + System.Windows.Forms.Application.StartupPath + "\\TPVT.accdb");
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
                comboBox1.DisplayMember = "UrunAdi";
                comboBox1.ValueMember = "UrunId";



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
            //dataGridView1.DataSource = null;
            dataGridView1.ClearSelection();
            try
            {
                con.Open();
                db = new OleDbDataAdapter("Select *from [" + tbl + "]", con);
                dt = new DataTable();
                db.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.Columns["UrunId"].HeaderText = "Ü.ID";
                dataGridView1.Columns["UrunAdi"].HeaderText = "Ürün";
                dataGridView1.Columns["AlisFiyati"].HeaderText = "Alış Fiyatı";
                dataGridView1.Columns["Fiyat"].HeaderText = "Satış Fiyatı";
                foreach (DataGridViewColumn alan in dataGridView1.Columns)
                {
                    alan.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                }
                dataGridView1.Columns["Fiyat"].DefaultCellStyle.Format = "\"$\"#,##0.00";
                dataGridView1.Columns["AlisFiyati"].DefaultCellStyle.Format = "\"$\"#,##0.00";
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
            {
                if (ctrl is TextBox tb)
                {
                    tb.Clear();
                }
            }
        }

        private void EUrunFrm_Load(object sender, EventArgs e)
        {
            cmbdoldur("Urunler");
            comboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox1.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBox1.SelectedIndex = -1;
            this.MaximizeBox = false;
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
            griddoldur("Urunler");
            dataGridView1.ClearSelection();

            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
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
            if (string.IsNullOrEmpty(UrunAdiTb.Text.Trim()) || string.IsNullOrEmpty(UrunFiyatiTb.Text.Trim()) || string.IsNullOrEmpty(textBox1.Text.Trim()))
            {
                MessageBox.Show("Lütfen tüm bilgileri doldurun !");
                return;
            }
            try
            {
                con.Open();
                cmd = new OleDbCommand("insert into Urunler (UrunAdi,AlisFiyati,Fiyat,Tarih) values('" + UrunAdiTb.Text + "','"+Convert.ToDecimal(textBox1.Text)+"','" + Convert.ToDecimal(UrunFiyatiTb.Text) + "','" + DateTime.Now.ToLongDateString() + "')", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("İşlem başarılı ", " ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
                griddoldur("Urunler");
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
            griddoldur("Urunler");
            dataGridView1.ClearSelection();
        }
        int kimlik;
        private void GuncelleBtn_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(UrunAdiTb.Text.Trim()) || string.IsNullOrEmpty(UrunFiyatiTb.Text.Trim()) || string.IsNullOrEmpty(textBox1.Text.Trim()))
            {
                MessageBox.Show("Lütfen tüm bilgileri doldurun !");
                return;
            }
            if (kimlik == 0)
            {
                MessageBox.Show("Lütfen bir veri seçiniz !");
                return;
            }
            try
            {
                con.Open();
                cmd = new OleDbCommand("update Urunler set UrunAdi='" + UrunAdiTb.Text + "',AlisFiyati='"+Convert.ToDecimal(textBox1.Text)+"',Fiyat='" +Convert.ToDecimal(UrunFiyatiTb.Text) + "' where UrunId = " + kimlik, con);
                cmd.ExecuteNonQuery();
                con.Close();
                griddoldur("Urunler");
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

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentRow != null)
                {
                    kimlik = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

                }
                UrunAdiTb.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                UrunFiyatiTb.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();



            }
            catch (Exception)
            {
                tbreset();
                kimlik = 0;
            }
        }

        private void sİLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new OleDbCommand("delete from Urunler where UrunId=" + kimlik, con);
            cmd.ExecuteNonQuery();
            con.Close();
            griddoldur("Urunler");
            dataGridView1.ClearSelection();
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

       

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (dataGridView1.DataSource != null && dataGridView1.DataSource is DataTable)
            {
                DataTable dt = dataGridView1.DataSource as DataTable;

                if (comboBox1.SelectedValue != null || comboBox1.SelectedIndex != -1)
                {

                    dt.DefaultView.RowFilter = "UrunId = " + comboBox1.SelectedValue.ToString();
                }
                else
                {
                    dt.DefaultView.RowFilter = "";
                }
            }
        }
    }
}
