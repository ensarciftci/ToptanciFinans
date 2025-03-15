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

namespace Toptan_Hesap
{
    public partial class ETahsilatFrm : Form
    {
        public ETahsilatFrm()
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
                comboBox1.DisplayMember = "Ad";
                comboBox1.ValueMember = "MusteriId";
                comboBox1.SelectedIndex = -1;


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
                con.Close();
                dataGridView1.DataSource = dt;
                dataGridView1.Columns["MusteriId"].HeaderText = "M.ID";
                dataGridView1.Columns["MusteriAdi"].HeaderText = "Müşteri Adı";
                dataGridView1.Columns["TahsilatId"].HeaderText = "T.ID";
                foreach (DataGridViewColumn alan in dataGridView1.Columns)
                {
                    alan.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                }
                dataGridView1.Columns["Miktar"].DefaultCellStyle.Format = "\"$\"#,##0.00";
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
        private void ETahsilatFrm_Load(object sender, EventArgs e)
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
            griddoldur("Tahsilatlar");
            cmbdoldur("Musteriler");
            comboBox1.SelectedIndex = -1;
            dataGridView1.ClearSelection();
            comboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox1.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBox1.SelectedIndex = -1;

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
            if (comboBox1.SelectedIndex < 0 || string.IsNullOrEmpty(MiktarTb.Text.Trim()))
            {
                MessageBox.Show("Lütfen tüm bilgileri doldurun !");
                return;
            }
            try
            {
                con.Open();
                cmd = new OleDbCommand("insert into Tahsilatlar (MusteriId,MusteriAdi,Miktar,Tarih) values('" + comboBox1.SelectedValue + "','" + comboBox1.Text + "','" + Convert.ToDecimal(MiktarTb.Text) + "','" + dateTimePicker1.Value.ToLongDateString() + "') ", con);
                cmd.ExecuteNonQuery();
                cmd = new OleDbCommand("update Musteriler set ToplamBorc= ToplamBorc -" + Convert.ToDecimal(MiktarTb.Text) + " where MusteriId= " + comboBox1.SelectedValue, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("İşlem başarılı ", " ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
                griddoldur("Tahsilatlar");
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
                cmd = new OleDbCommand("update Musteriler set ToplamBorc= ToplamBorc + " + dataGridView1.SelectedRows[0].Cells[3].Value + " where MusteriId= " + dataGridView1.SelectedRows[0].Cells[1].Value, con);
                cmd.ExecuteNonQuery();
                cmd = new OleDbCommand("update Tahsilatlar set MusteriId='" + comboBox1.SelectedValue + "',MusteriAdi='" + comboBox1.Text + "',Miktar='" + Convert.ToInt32(MiktarTb.Text) + "',Tarih='" + dateTimePicker1.Value.ToLongDateString() + "' where TahsilatId= " + kimlik, con);
                cmd.ExecuteNonQuery();
                cmd = new OleDbCommand("update Musteriler set ToplamBorc= ToplamBorc -" + Convert.ToDecimal(MiktarTb.Text) + " where MusteriId= " + comboBox1.SelectedValue, con);
                cmd.ExecuteNonQuery();
                con.Close();
                griddoldur("Tahsilatlar");
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
            dataGridView1.ClearSelection();
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
                MiktarTb.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();


            }
            catch (Exception)
            {
                tbreset();
                comboBox1.SelectedIndex = -1;
                kimlik = 0;

            }
        }

        private void sİLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new OleDbCommand("delete from Tahsilatlar where TahsilatId=" + kimlik, con);
            cmd.ExecuteNonQuery();
            if (dataGridView1.SelectedRows[0].Cells[0].Value != null)
            {
                cmd = new OleDbCommand("update Musteriler set ToplamBorc= ToplamBorc +" + dataGridView1.SelectedRows[0].Cells[3].Value + " where MusteriId= " + dataGridView1.SelectedRows[0].Cells[1].Value, con);
                cmd.ExecuteNonQuery();
            }
            con.Close();
            griddoldur("Tahsilatlar");
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
        { try {
                if (dataGridView1.DataSource != null && dataGridView1.DataSource is DataTable)
                {
                    DataTable dt = dataGridView1.DataSource as DataTable;

                    if (comboBox1.SelectedValue != null)
                    {
                        dt.DefaultView.RowFilter = "MusteriId = " + comboBox1.SelectedValue.ToString();
                    }
                    else
                    {
                        dt.DefaultView.RowFilter = "";
                    }
                }
            }
            catch
            {
               
            }
            }
    }
}
