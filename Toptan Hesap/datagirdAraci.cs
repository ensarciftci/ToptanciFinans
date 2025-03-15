using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toptan_Hesap
{
    public static class datagirdAraci
    {
        public static void baslikDüzenleyici(DataGridView dgv)
        {
            Dictionary<string, string> alanBaslik = new Dictionary<string, string>()
                {
                    {"MusteriId","M.ID" },
                    {"Ad","Müşteri Adı" },
                    {"ToplamBorc","Toplam Borç" },
                    {"OdemeId","Ö.ID" },
                    {"TedarikciId","T.ID" },
                    {"SatisId","S.ID" },
                    {"MusteriAdi","Müşteri Adı"},
                    {"UrunId","Ü.ID" },
                    {"UrunAdi","Ürün" },
                    {"StokGirisId","S.ID" },
                    {"TahsilatId","T.ID" },
                    {"AlisFiyati","Alış Fiyatı" },
                    {"Fiyat","Satış Fiyatı" }

                };
            foreach(var alan in alanBaslik)
            {
                if(dgv.Columns.Contains(alan.Key))
                {
                    dgv.Columns[alan.Key].HeaderText = alan.Value;
                }


            }


        }
     

    }
}
