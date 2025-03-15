using Toptan_Hesap.Tedarikçi;

namespace Toptan_Hesap
{
    public partial class AnaSayfaFrm : Form
    {
        public AnaSayfaFrm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ESatisFrm frm = new ESatisFrm();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EOdemeFrm frm = new EOdemeFrm();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }

        private void AnaSayfaFrm_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EMusteriFrm frm = new EMusteriFrm();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ETahsilatFrm frm = new ETahsilatFrm();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            EUrunFrm frm = new EUrunFrm();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ETedarikciFrm frm = new ETedarikciFrm();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            EStokGirisFrm frm = new EStokGirisFrm();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            GoruntuleFrm frm = new GoruntuleFrm();  
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }
    }
}
