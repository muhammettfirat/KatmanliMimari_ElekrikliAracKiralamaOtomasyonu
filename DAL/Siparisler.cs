using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
namespace DAL
{
    public class Siparisler : ICRUD<Siparis>
    {
        SqlConnection Conn;
        public Siparisler(string strConn)
        {
            Conn = new SqlConnection(strConn);
        }

        public Siparis Bul(int id)
        {
            Conn.Open();
            Siparis siparis = new Siparis();
            SqlCommand cmd = new SqlCommand("SELECT s.SiparisID,a.AliciID,a.AliciAdi,a.AliciSoyadi,u.UrunID,u.UrunAdi,u.UrunFiyat,s.SiparisAdet FROM Alicilar a  Inner Join Siparisler s on a.AliciID = s.AliciID Inner Join Urunler u on s.UrunID = u.UrunID WHERE SiparisID=@ID", Conn);
            cmd.Parameters.AddWithValue("@ID", id);
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            siparis.SiparisID = -1;
            if (dr.HasRows)
            {
                
                siparis.SiparisID = Convert.ToInt32(dr[0]);
                siparis.AliciID = (int)dr[1];
                siparis.AliciAdi = (string)dr[2];
                siparis.AliciSoyadi = (string)dr[3];
                siparis.UrunID = (int)dr[4];
                siparis.UrunAdi = (string)dr[5];
                siparis.UrunFiyat = (decimal)dr[6];
                siparis.SiparisAdet = dr.GetInt32(7);

            }
            Conn.Close();
            return siparis;
        }
        public int AliciAdiBul(string ad)
        {
            Conn.Open();
            Alici alici = new Alici();
            SqlCommand cmd = new SqlCommand("SELECT a.AliciID FROM Alicilar a WHERE AliciAdi=@ad", Conn);
            cmd.Parameters.AddWithValue("@ad", ad);
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
          
            if (dr.HasRows)
            {
                alici.AliciID = Convert.ToInt32(dr[0]);
              
            }
            Conn.Close();
            return alici.AliciID;
        }
        public int UrunAdiBul(string ad)
        {
            Conn.Open();
            Urun urun = new Urun();
            SqlCommand cmd = new SqlCommand("SELECT u.UrunID FROM Urunler u WHERE UrunAdi=@ad", Conn);
            cmd.Parameters.AddWithValue("@ad", ad);
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();

            if (dr.HasRows)
            {
                urun.UrunID = Convert.ToInt32(dr[0]);

            }
            Conn.Close();
            return urun.UrunID;
        }
        public void Ekle(Siparis model)
        {
            Conn.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Siparisler VALUES(@aliciID,@urunID,@adet)", Conn);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@aliciID", model.AliciID);
            cmd.Parameters.AddWithValue("@urunID", model.UrunID);
            cmd.Parameters.AddWithValue("@adet", model.SiparisAdet);
       
           

            cmd.ExecuteNonQuery();
            Conn.Close();
        }

        public void Guncelle(Siparis model)
        {
            Conn.Open();
            SqlCommand cmd = new SqlCommand("UPDATE Siparisler SET AliciID=@aliciID,UrunID=@urunID,SiparisAdet=@adet WHERE SiparisID = @ID", Conn);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@ID", model.SiparisID);
            cmd.Parameters.AddWithValue("@aliciID", model.AliciID);
            cmd.Parameters.AddWithValue("@urunID", model.UrunID);
            cmd.Parameters.AddWithValue("@adet", model.SiparisAdet);
          
            cmd.ExecuteNonQuery();
            Conn.Close();
        }

        public List<Siparis> Liste()
        {
            Conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT s.SiparisID,a.AliciID,a.AliciAdi,a.AliciSoyadi,u.UrunID,u.UrunAdi,u.UrunFiyat,s.SiparisAdet FROM Alicilar a  Inner Join Siparisler s on a.AliciID = s.AliciID Inner Join Urunler u on s.UrunID = u.UrunID", Conn);

            SqlDataReader dr = cmd.ExecuteReader();
            List<Siparis> siparisler = new List<Siparis>();
            while (dr.Read())
            {
                Siparis siparis = new Siparis();
                siparis.SiparisID = Convert.ToInt32(dr[0]);
                siparis.AliciID = (int)dr[1];
                siparis.AliciAdi = (string)dr[2];
                siparis.AliciSoyadi = (string)dr[3];
                siparis.UrunID = (int)dr[4];
                siparis.UrunAdi = (string)dr[5];
                siparis.UrunFiyat = (decimal)dr[6];
                siparis.SiparisAdet = dr.GetInt32(7);
               

                siparisler.Add(siparis);
            }
            Conn.Close();
            return siparisler;
        }

        public void Sil(int id)
        {

            Conn.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM Siparisler WHERE SiparisID=@ID", Conn);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@ID", id);
            cmd.ExecuteNonQuery();
            Conn.Close();
        }
        public int SiparisSayisi()
        {
            Conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT count(*) FROM Siparisler", Conn);
            int sonuc = Convert.ToInt32(cmd.ExecuteScalar());
            Conn.Close();
            return sonuc;
        }
    }
}
