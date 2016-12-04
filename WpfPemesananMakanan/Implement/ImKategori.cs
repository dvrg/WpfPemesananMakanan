using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace WpfPemesananMakanan.Implement
{
    class ImKategori : Interface.InKategori
    {
        private DataSet ds;
        private MySqlConnection koneksi;
        private MySqlCommand cmd;
        private MySqlDataAdapter adapter;
        private bool status;
        private string queryString;
        public ImKategori()
        {
            koneksi = Koneksi.KoneksiDB.GetKoneksi();
        }
        
        public DataSet TampilKategori()
        {
            ds = new DataSet();
            try
            {
                queryString = @"SELECT * FROM tb_kategori;";

                koneksi.Open();
                Console.WriteLine("Membuka koneksi");
                cmd = new MySqlCommand(queryString, koneksi);
                adapter = new MySqlDataAdapter(cmd);
                cmd.ExecuteNonQuery();
                adapter.Fill(ds,"tb_kategori");
                koneksi.Close();
            }
            catch (MySqlException e)
            {
                Console.WriteLine("Error :" + e);
            }
            return ds;
        }
        public String KodeBaru(string kd)
        {
            string kode = kd.Substring(0, 3);
            return kode;
        }
        public Boolean TambahKategori(Entity.EnKategori ex)
        {
            status = false;
            try
            {
                queryString = @"INSERT INTO tb_kategori(id_kategori,nama_kategori) VALUES('" + ex.GetIdKategori() + "', '" + ex.GetNamaKategori() + "');";
                
                koneksi.Open();
                cmd = new MySqlCommand(queryString, koneksi);
                cmd.ExecuteNonQuery();
                status = true;
                koneksi.Close();
            }
            catch (MySqlException e)
            {
                Console.WriteLine("Error " + e);
            }
            return status;
        }
    }
}
