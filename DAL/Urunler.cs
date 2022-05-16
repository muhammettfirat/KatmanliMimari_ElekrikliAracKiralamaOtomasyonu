using Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Urunler : ICRUD<Urun>
    {
        SqlConnection Conn;
        public Urunler(string strConn)
        {
            Conn = new SqlConnection(strConn);
        }
        public Urun Bul(int id)
        {
            Conn.Open();
            Urun urun = new Urun();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Urunler WHERE UrunID=@ID", Conn);
            cmd.Parameters.AddWithValue("@ID", id);
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            urun.UrunID = -1;
            if (dr.HasRows)
            {
                urun.UrunID = Convert.ToInt32(dr[0]);
                urun.UrunAdi = dr.GetString(1);
                urun.UrunFiyat = dr.GetDecimal(2);
                urun.StokAdedi = dr.GetInt32(3);
            }
            Conn.Close();
            return urun;
        }
        public void Sil(int id)
        {
            Conn.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM Urunler WHERE UrunID=@ID", Conn);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@ID", id);
            cmd.ExecuteNonQuery();
            Conn.Close();
        }
        public void Ekle(Urun model)
        {
            Conn.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Urunler VALUES(@ad,@fiyat,@adet)", Conn); cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@ad", model.UrunAdi);
            cmd.Parameters.AddWithValue("@fiyat", model.UrunFiyat);
            cmd.Parameters.AddWithValue("@adet", model.StokAdedi);
            cmd.ExecuteNonQuery();
            Conn.Close();
        }
     
        public void Guncelle(Urun model)
        {
            Conn.Open();
            SqlCommand cmd = new SqlCommand("UPDATE Urunler SET UrunAdi=@ad,UrunFiyat=@fiyat,StokAdedi=@adet WHERE UrunID = @ID", Conn);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@ID", model.UrunID);
            cmd.Parameters.AddWithValue("@ad", model.UrunAdi);
            cmd.Parameters.AddWithValue("@fiyat", model.UrunFiyat);
            cmd.Parameters.AddWithValue("@adet", model.StokAdedi);
            cmd.ExecuteNonQuery();
            Conn.Close();
        }

        public List<Urun> Liste()
        {
            Conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Urunler", Conn);

            SqlDataReader dr = cmd.ExecuteReader();
            List<Urun> urunler = new List<Urun>();
            while (dr.Read())
            {
                Urun urun = new Urun();
                urun.UrunID = Convert.ToInt32(dr[0]);
                urun.UrunAdi = dr.GetString(1);
                urun.UrunFiyat = dr.GetDecimal(2);
                urun.StokAdedi = dr.GetInt32(3);
                urunler.Add(urun);
            }
            Conn.Close();
            return urunler;
        }

      
        public int AliciSayisi()
        {
            Conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT count(*) FROM Urunler", Conn);
            int sonuc = Convert.ToInt32(cmd.ExecuteScalar());
            Conn.Close();
            return sonuc;
        }
    }
}
