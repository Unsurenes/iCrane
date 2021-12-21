using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iCrane.Siniflar.VeriTabani
{
    class CoilVeriTabani : TemelVeritabani
    {
        public DataTable CoilGetir()
        {
            Baglan();
            string sorgu = "select * from Coil order by SUBSTRING(RuloKodu,3,50) desc";
            komut = new SqlCommand(sorgu, baglanti);
            komut.CommandType = CommandType.Text;
            komut.ExecuteNonQuery();
            tablo = new DataTable();
            adaptor = new SqlDataAdapter(komut);
            adaptor.Fill(tablo);
            baglanti.Close();
            baglanti.Dispose();
            return tablo;
        }

        public void CoilSil(string bekleyenRuloKodu)
        {
            Baglan();
            string sorgu = "delete from Coil where RuloKodu=" + "'" + bekleyenRuloKodu + "'";
            komut = new SqlCommand(sorgu, baglanti);
            komut.CommandType = CommandType.Text;
            komut.ExecuteNonQuery();
            adaptor = new SqlDataAdapter(komut);
            baglanti.Close();
            baglanti.Dispose();
        }

        public void CoilEkle(string stokRuloKodu, string stokGenislik, string stokCap)
        {
            Baglan();
            string sorgu = "insert into Coil(RuloKodu, [Genişlik(mm)],[Çap(mm)]) values(@StokRuloKodu,@StokGenislik,@StokCap)";          
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@StokRuloKodu", stokRuloKodu);
            komut.Parameters.AddWithValue("@StokGenislik", stokGenislik);
            komut.Parameters.AddWithValue("@StokCap", stokCap);
            komut.CommandType = CommandType.Text;
            komut.ExecuteNonQuery();
            adaptor = new SqlDataAdapter(komut);
            baglanti.Close();
            baglanti.Dispose();
        }
    }
}
