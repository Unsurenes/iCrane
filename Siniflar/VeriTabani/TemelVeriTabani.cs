using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCrane.Siniflar.VeriTabani
{
    abstract class TemelVeritabani
    {
        //DESKTOP-3ESP0RS
        string yol = @"Data Source=94.73.146.4;Initial Catalog=u7173324_iCrane; User Id=u7173324_team1;Password=HOgs78W3RGwb02M;";
        public SqlDataAdapter adaptor;
        public SqlDataReader okuyucu;
        public DataTable tablo;
        public SqlCommand komut;
        public SqlConnection baglanti;
        public TemelVeritabani()
        {
            yol = @"Data Source=94.73.146.4;Initial Catalog=u7173324_iCrane; User Id=u7173324_team1;Password=HOgs78W3RGwb02M;";
        }

        public void Baglan()
        {
            // Veritabanı bağlanacak
            baglanti = new SqlConnection(yol);
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }

        }


    }
}
