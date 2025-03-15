using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toptan_Hesap
{
    internal class BtnRenk
    {
        public static void btnMouseLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            
            
                btn.BackColor = Color.DarkKhaki;
                btn.ForeColor = Color.White;
            

        }
        public static void btnMouseEnter(object sender, EventArgs e)
        {
            Button btn = sender as Button;
           
            
                btn.BackColor = Color.White;
                btn.ForeColor = Color.DarkKhaki;
            
        }

    }
}
