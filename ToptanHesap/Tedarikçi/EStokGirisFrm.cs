using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Toptan_Hesap.Tedarikçi
{
    public partial class EStokGirisFrm : Form
    {
        public EStokGirisFrm()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\TPVT.accdb");
        OleDbCommand cmd;
        OleDbDataAdapter db;
        DataTable dt;
        void cmbdoldur(string tbl)
        {
            try
            {
                if (tbl == "Tedarikciler")
                {
                    con.Open();
                    db = new OleDbDataAdapter("Select *From [" + tbl + "]", con);
                    dt = new DataTable();
                    db.Fill(dt);
                    con.Close();
                    comboBox1.DataSource = dt;
                    comboBox1.DisplayMember = "TedarikciAdi";
                    comboBox1.ValueMember = "TedarikciId";
                }
                if (tbl == "Urunler")
                {
                    con.Open();
                    db = new OleDbDataAdapter("Select *From [" + tbl + "]", con);
                    dt = new DataTable();
                    db.Fill(dt);
                    con.Close();
                    comboBox2.DataSource = dt;
                    comboBox2.DisplayMember = "UrunAdi";
                    comboBox2.ValueMember = "UrunId";
                }



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
                dataGridView1.Columns["StokGirisId"].HeaderText = "S.ID";
                dataGridView1.Columns["TedarikciAdi"].HeaderText = "Tedarikçi Adı";
                dataGridView1.Columns["TedarikciId"].HeaderText = "T.ID";
                dataGridView1.Columns["UrunId"].HeaderText = "Ü.ID";
                dataGridView1.Columns["UrunAdi"].HeaderText = "Ürün";
                foreach (DataGridViewColumn alan in dataGridView1.Columns)
                {
                    alan.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                }
                dataGridView1.Columns["Fiyat"].DefaultCellStyle.Format = "\"$\"#,##0.00";
                dataGridView1.Columns["Tutar"].DefaultCellStyle.Format = "\"$\"#,##0.00";
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
                if (ctrl is TextBox tb)
                {
                    tb.Clear();
                }
        }
        private void EStokGirisFrm_Load(object sender, EventArgs e)
        {
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
            cmbdoldur("Tedarikciler");
            cmbdoldur("Urunler");
            griddoldur("StokGiris");
            comboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox1.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBox1.SelectedIndex = -1;
            comboBox2.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox2.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBox2.SelectedIndex = -1;
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox || ctrl is ComboBox)
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

            if (comboBox1.SelectedIndex < 0 || comboBox2.SelectedIndex < 0 || string.IsNullOrEmpty(AdetTb.Text.Trim()))
            {
                MessageBox.Show("Lütfen tüm bilgileri doldurun !");
                return;
            }
            try
            {
                con.Open();
                cmd = new OleDbCommand("SELECT AlisFiyati FROM Urunler WHERE UrunId = " + comboBox2.SelectedValue, con);
                object fiyatObj = cmd.ExecuteScalar();
                decimal fiyat = Convert.ToDecimal(fiyatObj);

                cmd = new OleDbCommand("insert into StokGiris(TedarikciId,TedarikciAdi,UrunId,UrunAdi,Adet,Fiyat,Tutar,Tarih) values('" + comboBox1.SelectedValue + "','" + comboBox1.Text + "','" + comboBox2.SelectedValue + "','" + comboBox2.Text + "','" + Convert.ToInt32(AdetTb.Text) + "','" + fiyat + "','" + fiyat * Convert.ToInt32(AdetTb.Text) + "','" + dateTimePicker1.Value.ToLongDateString() + "') ", con);
                cmd.ExecuteNonQuery();
                cmd = new OleDbCommand("update Urunler set Stok=Stok+ " + Convert.ToInt32(AdetTb.Text) + " where UrunId=" + comboBox2.SelectedValue, con);
                cmd.ExecuteNonQuery();
                cmd = new OleDbCommand("update Tedarikciler set ToplamBorc=ToplamBorc+" + fiyat * Convert.ToInt32(AdetTb.Text) + " where TedarikciId=" + comboBox1.SelectedValue, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("İşlem başarılı ", " ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
                griddoldur("StokGiris");
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

        int kimlik;

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
                cmd = new OleDbCommand("SELECT AlisFiyati FROM Urunler WHERE UrunId = " + comboBox2.SelectedValue, con);
                object fiyatObj = cmd.ExecuteScalar();
                decimal fiyat = Convert.ToDecimal(fiyatObj);

                cmd = new OleDbCommand("update Urunler set Stok=Stok- " + dataGridView1.SelectedRows[0].Cells[5].Value + " where UrunId=" + dataGridView1.SelectedRows[0].Cells[3].Value, con);
                cmd.ExecuteNonQuery();
                cmd = new OleDbCommand("update Tedarikciler set ToplamBorc=ToplamBorc-" + dataGridView1.SelectedRows[0].Cells[7].Value + " where TedarikciId=" + dataGridView1.SelectedRows[0].Cells[1].Value, con);
                cmd.ExecuteNonQuery();
                cmd = new OleDbCommand("update StokGiris set TedarikciId='" + comboBox1.SelectedValue + "',TedarikciAdi='" + comboBox1.Text + "',UrunId='" + comboBox2.SelectedValue + "',UrunAdi='" + comboBox2.Text + "',Adet='" + Convert.ToInt32(AdetTb.Text) + "',Fiyat='" + fiyat + "',Tutar='" + Convert.ToInt32(AdetTb.Text) * fiyat + "',Tarih='" + dateTimePicker1.Value.ToLongDateString() + "' where StokGirisId = " + kimlik, con);
                cmd.ExecuteNonQuery();
                cmd = new OleDbCommand("update Urunler set Stok=Stok+ " + Convert.ToInt32(AdetTb.Text) + " where UrunId=" + comboBox2.SelectedValue, con);
                cmd.ExecuteNonQuery();
                cmd = new OleDbCommand("update Tedarikciler set ToplamBorc=ToplamBorc+" + fiyat * Convert.ToInt32(AdetTb.Text) + " where TedarikciId=" + comboBox1.SelectedValue, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("İşlem başarılı ", " ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
                griddoldur("StokGiris");
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
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            kimlik = 0;
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentRow != null)
                {
                    kimlik = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

                }
                comboBox1.SelectedValue = dataGridView1.SelectedRows[0].Cells[1].Value;
                comboBox2.SelectedValue = dataGridView1.SelectedRows[0].Cells[3].Value;
                AdetTb.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();


            }
            catch (Exception)
            {
                tbreset();
                comboBox1.SelectedIndex = -1;
                comboBox2.SelectedIndex = -1;
                kimlik = 0;

            }

        }

        private void sİLToolStripMenuItem_Click(object sender, EventArgs e)
        {

            con.Open();
            cmd = new OleDbCommand("delete from StokGiris where StokGirisId=" + kimlik, con);
            cmd.ExecuteNonQuery();
            if (dataGridView1.SelectedRows[0].Cells[0].Value != null)
            {
                cmd = new OleDbCommand("update Urunler set Stok=Stok- " + dataGridView1.SelectedRows[0].Cells[5].Value + " where UrunId=" + dataGridView1.SelectedRows[0].Cells[3].Value, con);
                cmd.ExecuteNonQuery();
                cmd = new OleDbCommand("update Tedarikciler set ToplamBorc=ToplamBorc-" + dataGridView1.SelectedRows[0].Cells[7].Value + " where TedarikciId=" + dataGridView1.SelectedRows[0].Cells[1].Value, con);
                cmd.ExecuteNonQuery();
            }
            con.Close();
            griddoldur("StokGiris");
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

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (dataGridView1.DataSource != null && dataGridView1.DataSource is DataTable)
            {
                DataTable dt = dataGridView1.DataSource as DataTable;

                if (comboBox1.SelectedValue != null || comboBox1.SelectedIndex != -1)
                {

                    dt.DefaultView.RowFilter = "TedarikciId = " + comboBox1.SelectedValue.ToString();
                }
                else
                {
                    dt.DefaultView.RowFilter = "";
                }
            }
        }
    }
}
