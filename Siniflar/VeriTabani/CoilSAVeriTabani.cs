using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iCrane.Siniflar.VeriTabani
{
    class CoilSAVeriTabani : TemelVeritabani
    {
        public DataTable CoilSAGetir()
        {
            Baglan();
            string sorgu = "Select * from CoilSA";
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

        public void SAKodGuncelle(string ruloKodu, PictureBox pctr)
        {
            Baglan();
            string sorgu = "update CoilSA set SAKod='" + pctr.Tag + "' where RuloKodu='" + ruloKodu + "'";
            komut = new SqlCommand(sorgu, baglanti);
            komut.CommandType = CommandType.Text;
            komut.ExecuteNonQuery();
            adaptor = new SqlDataAdapter(komut);
            baglanti.Close();
            baglanti.Dispose();
        }

        public void CoilSAEkle(string bekleyenRuloKodu, string bekleyenGenislik, string bekleyenCap, PictureBox pictureBox)
        {
            Baglan();
            string sorgu = "insert into CoilSA(RuloKodu,[Genişlik(mm)],[Çap(mm)],KoordinatX,KoordinatY,PcrName) values(@RuloKodu,@StokGenislik,@StokCap,@KoordinatX,@KoordinatY,@PcrName)";        
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@RuloKodu", bekleyenRuloKodu);
            komut.Parameters.AddWithValue("@StokGenislik", bekleyenGenislik);
            komut.Parameters.AddWithValue("@StokCap", bekleyenCap);
            komut.Parameters.AddWithValue("@KoordinatX", pictureBox.Location.X);
            komut.Parameters.AddWithValue("@KoordinatY", pictureBox.Location.Y);
            komut.Parameters.AddWithValue("@PcrName", pictureBox.Name);
            komut.CommandType = CommandType.Text;
            komut.ExecuteNonQuery();
            adaptor = new SqlDataAdapter(komut);
            baglanti.Close();
            baglanti.Dispose();
        }

        public void CoilSASil(string stokRuloKodu)
        {
            Baglan();
            string sorgu = "delete from CoilSA where RuloKodu = " + "'" + stokRuloKodu + "'";         
            komut = new SqlCommand(sorgu, baglanti);
            komut.CommandType = CommandType.Text;
            komut.ExecuteNonQuery();
            adaptor = new SqlDataAdapter(komut);
            baglanti.Close();
            baglanti.Dispose();


            
        }
    }
}
