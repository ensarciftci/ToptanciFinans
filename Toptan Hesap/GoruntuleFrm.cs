using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Toptan_Hesap
{
    public partial class GoruntuleFrm : Form
    {
        public GoruntuleFrm()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection($"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Path.Combine(Application.StartupPath, "TPVT.accdb")}; Persist Security Info=False");
        OleDbDataAdapter db;
        DataTable dt;

        void cmbdoldur(string tbl, string Alan1, string Alan2)
        {
            try
            {
                con.Open();
                db = new OleDbDataAdapter("Select DISTINCT [" + Alan1 + "],[" + Alan2 + "] From [" + tbl + "]", con);
                dt = new DataTable();
                db.Fill(dt);
                con.Close();
                comboBox2.DataSource = dt;
                if (tbl == "Musteriler" || tbl == "Satislar" || tbl == "Tahsilatlar")
                {
                    if (tbl == "Musteriler")
                    {
                        comboBox2.DisplayMember = "Ad";
                    }
                    comboBox2.DisplayMember = "MusteriAdi";
                    comboBox2.ValueMember = "MusteriId";
                }
                if (tbl == "Odemeler" || tbl == "Tedarikciler")
                {

                    comboBox2.DisplayMember = "TedarikciAdi";
                    comboBox2.ValueMember = "TedarikciId";
                }
                if (tbl == "Urunler")
                {
                    comboBox2.DisplayMember = "UrunAdi";
                    comboBox2.ValueMember = "UrunId";
                }
                if (tbl == "StokGiris")
                {


                    comboBox2.DisplayMember = "TedarikciAdi";
                    comboBox2.ValueMember = "TedarikciId";

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
                con.Close();
                dataGridView1.DataSource = dt;
                if (comboBox1.Text == "Satışlar" || comboBox1.Text == "Stok Girişleri")
                {

                    dataGridView1.Columns["Fiyat"].DefaultCellStyle.Format = "\"$\"#,##0.00";
                    dataGridView1.Columns["Tutar"].DefaultCellStyle.Format = "\"$\"#,##0.00";
                }
                if (comboBox1.Text == "Müşteriler" || comboBox1.Text == "Tedarikçiler")
                {
                    dataGridView1.Columns["ToplamBorc"].DefaultCellStyle.Format = "\"$\"#,##0.00";
                }
                if (comboBox1.Text == "Tahsilatlar" || comboBox1.Text == "Ödemeler")
                {
                    dataGridView1.Columns["Miktar"].DefaultCellStyle.Format = "\"$\"#,##0.00";
                }
                if (comboBox1.Text == "Ürünler")
                {
                    dataGridView1.Columns["Fiyat"].DefaultCellStyle.Format = "\"$\"#,##0.00";
                    dataGridView1.Columns["AlisFiyati"].DefaultCellStyle.Format = "\"$\"#,##0.00";
                }
                datagirdAraci.baslikDüzenleyici(dataGridView1);
                foreach(DataGridViewColumn alan in dataGridView1.Columns)
                {
                    alan.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

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

        private void GoruntuleFrm_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            comboBox2.Enabled = false;
            comboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox1.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBox1.SelectedIndex = -1;
            comboBox2.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox2.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBox2.SelectedIndex = -1;

            dataGridView1.ClearSelection();
            comboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox1.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBox1.SelectedIndex = -1;
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is ComboBox)
                {
                    ctrl.TabStop = true;
                }
                else
                {
                    ctrl.TabStop = false;
                }
            }
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
            {
                comboBox2.Enabled = true;

            }
            if (comboBox1.SelectedIndex == 0)
            {

                cmbdoldur("Musteriler", "Ad", "MusteriId");
                griddoldur("Musteriler");
            }

            if (comboBox1.SelectedIndex == 1)
            {

                cmbdoldur("Satislar", "MusteriAdi", "MusteriId");
                griddoldur("Satislar");
            }

            if (comboBox1.SelectedIndex == 2)
            {

                cmbdoldur("Tahsilatlar", "MusteriAdi", "MusteriId");
                griddoldur("Tahsilatlar");
            }

            if (comboBox1.SelectedIndex == 3)
            {

                cmbdoldur("Odemeler", "TedarikciAdi", "TedarikciId");
                griddoldur("Odemeler");
            }

            if (comboBox1.SelectedIndex == 4)
            {

                cmbdoldur("StokGiris", "TedarikciAdi", "TedarikciId");
                griddoldur("StokGiris");

            }

            if (comboBox1.SelectedIndex == 5)
            {
                cmbdoldur("Tedarikciler", "TedarikciAdi", "TedarikciId");
                griddoldur("Tedarikciler");

            }

            if (comboBox1.SelectedIndex == 6)
            {
                cmbdoldur("Urunler", "UrunAdi", "UrunId");
                griddoldur("Urunler");

            }

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                if (comboBox1.Text == "Müşteriler" || comboBox1.Text == "Satışlar" || comboBox1.Text == "Tahsilatlar")
                {

                    if (comboBox2.SelectedValue != null)
                    {

                        if (dataGridView1.DataSource != null && dataGridView1.DataSource is DataTable)
                        {
                            DataTable dt = dataGridView1.DataSource as DataTable;

                            if (dt != null)
                            {
                                dt.DefaultView.RowFilter = "MusteriId = " + comboBox2.SelectedValue.ToString();
                            }
                        }

                    }
                    if (comboBox2.SelectedValue != null)
                    {

                        if (dataGridView1.DataSource != null && dataGridView1.DataSource is DataTable)
                        {
                            DataTable dt = dataGridView1.DataSource as DataTable;

                            if (dt != null)
                            {
                                dt.DefaultView.RowFilter = "MusteriId = " + comboBox2.SelectedValue.ToString();
                            }
                        }

                    }
                }
                if (comboBox1.Text == "Tedarikçiler" || comboBox1.Text == "Ödemeler" || comboBox1.Text == "Stok Girişleri")
                {

                    if (comboBox2.SelectedValue != null || comboBox2.SelectedIndex != -1)
                    {

                        if (dataGridView1.DataSource != null && dataGridView1.DataSource is DataTable)
                        {
                            DataTable dt = dataGridView1.DataSource as DataTable;

                            if (dt != null)
                            {
                                dt.DefaultView.RowFilter = "TedarikciId = " + comboBox2.SelectedValue.ToString();
                            }
                        }

                    }
                }
                if (comboBox1.Text == "Ürünler")
                {

                    if (comboBox2.SelectedValue != null || comboBox2.SelectedIndex != -1)
                    {

                        if (dataGridView1.DataSource != null && dataGridView1.DataSource is DataTable)
                        {
                            DataTable dt = dataGridView1.DataSource as DataTable;

                            if (dt != null)
                            {
                                dt.DefaultView.RowFilter = "UrunId = " + comboBox2.SelectedValue.ToString();
                            }
                        }

                    }
                }


            }
            catch
            {
                if (dataGridView1.DataSource != null && dataGridView1.DataSource is DataTable)
                {
                    DataTable dt = dataGridView1.DataSource as DataTable;
                    if (dt != null)
                    {
                        dt.DefaultView.RowFilter = string.Empty;
                    }
                }
            }
            comboBox2.SelectedIndex = -1;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.DataSource != null && dataGridView1.DataSource is DataTable)
                {
                    DataTable dt = dataGridView1.DataSource as DataTable;

                    if (dt != null)
                    {
                        dt.DefaultView.RowFilter = "UrunAdi LIKE '%" + textBox1.Text + "%'";

                    }
                }
            }
            catch
            {
                MessageBox.Show("hata");
            }
        }

        private void SifirlaBtn_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            textBox1.Text = "";
            dataGridView1.DataSource = null;
        }

        private void AnaSayfaBtn_Click(object sender, EventArgs e)
        {
            AnaSayfaFrm frm = new AnaSayfaFrm();
            this.Hide();
            frm.ShowDialog();
            this.Close();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
