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
using static System.Net.Mime.MediaTypeNames;

namespace Toptan_Hesap
{
    public partial class EOdemeFrm : Form
    {
        public EOdemeFrm()
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
                comboBox1.DisplayMember = "TedarikciAdi";
                comboBox1.ValueMember = "TedarikciId";



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
                dataGridView1.Columns["TedarikciId"].HeaderText = "T.ID";
                dataGridView1.Columns["TedarikciAdi"].HeaderText = "Tedarikçi Adı";
                dataGridView1.Columns["OdemeId"].HeaderText = "Ö.ID";

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

        private void EOdemeFrm_Load(object sender, EventArgs e)
        {
            cmbdoldur("Tedarikciler");
            griddoldur("Odemeler");
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
                cmd = new OleDbCommand("insert into Odemeler(TedarikciId,TedarikciAdi,Miktar,Tarih) values('" + comboBox1.SelectedValue + "','" + comboBox1.Text + "','" + Convert.ToDecimal(MiktarTb.Text) + "','" + dateTimePicker1.Value.ToLongDateString() + "') ", con);
                cmd.ExecuteNonQuery();
                cmd = new OleDbCommand("update Tedarikciler set ToplamBorc=ToplamBorc - " + Convert.ToDecimal(MiktarTb.Text) + " where TedarikciId=" + comboBox1.SelectedValue, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("İşlem başarılı ", " ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
                griddoldur("Odemeler");
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            if (dataGridView1.DataSource != null && dataGridView1.DataSource is DataTable)
            {
                DataTable dt = dataGridView1.DataSource as DataTable;

                if (comboBox1.SelectedValue != null|| comboBox1.SelectedIndex!=-1)
                {
                   
                    dt.DefaultView.RowFilter = "TedarikciId = " + comboBox1.SelectedValue.ToString();
                }
                else
                {
                    dt.DefaultView.RowFilter = "";
                }
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
                cmd = new OleDbCommand("update Tedarikciler set ToplamBorc= ToplamBorc + " + dataGridView1.SelectedRows[0].Cells[3].Value + " where TedarikciId=" + dataGridView1.SelectedRows[0].Cells[1].Value, con);
                cmd.ExecuteNonQuery();
                cmd = new OleDbCommand("update Odemeler set TedarikciId='" + comboBox1.SelectedValue + "',TedarikciAdi='" + comboBox1.Text + "',Miktar='" + Convert.ToDecimal(MiktarTb.Text) + "',Tarih='" + dateTimePicker1.Value.ToLongDateString() + "' where OdemeId = " + kimlik, con);
                cmd.ExecuteNonQuery();
                cmd = new OleDbCommand("update Tedarikciler set ToplamBorc=ToplamBorc - " + Convert.ToDecimal(MiktarTb.Text) + " where TedarikciId=" + comboBox1.SelectedValue, con);
                cmd.ExecuteNonQuery();
                con.Close();
                griddoldur("Odemeler");
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
            cmd = new OleDbCommand("delete from Odemeler where OdemeId=" + kimlik, con);
            cmd.ExecuteNonQuery();
            if (dataGridView1.SelectedRows[0].Cells[0].Value != null)
            {
                cmd = new OleDbCommand("update Tedarikciler set ToplamBorc= ToplamBorc+ " + dataGridView1.SelectedRows[0].Cells[3].Value + " where TedarikciId=" + dataGridView1.SelectedRows[0].Cells[1].Value, con);
                cmd.ExecuteNonQuery();
            }
            con.Close();
            griddoldur("Odemeler");
            dataGridView1.ClearSelection();
        }

        private void SifirlaBtn_Click(object sender, EventArgs e)
        {
            tbreset();
           
            comboBox1.SelectedIndex = -1;
            dataGridView1.ClearSelection();
            kimlik = 0;
         

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
    }
}
