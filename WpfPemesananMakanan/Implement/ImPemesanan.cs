using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace WpfPemesananMakanan.Implement
{
    class ImPemesanan : Interface.InPemesanan
    {
        private Boolean status;
        private DataTable dt;
        private DataSet ds;
        private string queryString;
        private MySqlConnection koneksi;
        private MySqlCommand command;
        private MySqlDataAdapter adapter;
        private MySqlDataReader reader;

        public ImPemesanan()
        {
            koneksi = Koneksi.KoneksiDB.GetKoneksi();
        }
        public String KodeBaru()
        {
            int kode = 0;
            string kodeBaru = "";
            queryString = @"SELECT MAX(RIGHT(kd_pemesanan,3)) FROM tb_pemesanan;";

            try
            {
                koneksi.Open();
                command = new MySqlCommand(queryString, koneksi);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    kode = Int16.Parse(reader.GetString(0).ToString());
                    if (kode < 10)
                    {
                        kodeBaru = "00" + (kode + 1);
                    }
                    else if (kode < 100)
                    {
                        kodeBaru = "0" + (kode + 1);
                    }
                    else if (kode < 1000)
                    {
                        kodeBaru = "" + (kode + 1);
                    }
                }
                koneksi.Close();
            }
            catch (MySqlException e)
            {
                Console.WriteLine("Erro ", e);
            }
            return kodeBaru;
        }
        public DataSet TampilPesanan()
        {
            ds = new DataSet();
            queryString = @"SELECT * FROM tb_pemesanan";
            try
            {
                koneksi.Open();
                command = new MySqlCommand(queryString, koneksi);
                adapter = new MySqlDataAdapter(command);
                command.ExecuteNonQuery();
                adapter.Fill(ds);
                koneksi.Close();
            }
            catch (MySqlException e)
            {
                Console.WriteLine("Error ", e);
            }
            return ds;
        }
        public Boolean UbahStatusPesanan(Entity.EnPemesanan ep)
        {
            status = false;
            queryString = @"UPDATE tb_pemesanan set status_pemesanan = '"+ep.GetStatus()+"' WHERE kd_pemesanan = '"+ep.GetKdPemesanan()+"';";
            try
            {
                koneksi.Open();
                command = new MySqlCommand(queryString, koneksi);
                command.ExecuteNonQuery();
                status = true;
                koneksi.Close();
            }
            catch (MySqlException e)
            {
                Console.WriteLine("Error ", e);
            }
            return status;
        }
        public Boolean TambahPesanan(string kodeBaru)
        {
            status = false;
            queryString = @"INSERT INTO tb_pemesanan(kd_pemesanan,tgl_pemesanan,status_pemesanan) VALUES ('" + kodeBaru + "',NOW(),0);";
            try
            {
                koneksi.Open();
                command = new MySqlCommand(queryString, koneksi);
                command.ExecuteNonQuery();
                koneksi.Close();
            }
            catch (MySqlException e)
            {
                Console.WriteLine("Error +", e);
            }
            return status;
        }
        public Boolean TambahDetailPesanan(string jml_pesanan, string catatan)
        {
            status = false;
            //queryString = @"INSERT INTO tb_detailpemesanan(id_menu,kd_pemesanan,jumlah_pemesanan,harga) VALUES('"++"','"++"','"++"','"++"');";
            try
            {
                koneksi.Open();
                command = new MySqlCommand(queryString, koneksi);
                command.ExecuteNonQuery();
                koneksi.Close();
            }
            catch (MySqlException e)
            {
                Console.WriteLine("Error +", e);
            }
            return status;
        }
        public Boolean UbahDetailPesanan(string jml_pesanan, string catatan)
        {
            status = false;
            //queryString = @"UPDATE tb_detailpemesanan SET jumlah_pemesanan = '" + + "', catatan = '" + + "' WHERE kd_pemesanan = '" +  + "';";
            try
            {
                koneksi.Open();
                command = new MySqlCommand(queryString, koneksi);
                command.ExecuteNonQuery();
                status = true;
                koneksi.Close();
            }
            catch (MySqlException e)
            {
                Console.WriteLine("Error ", e);
            }
            return status;
        }
        public DataTable CariPesanan(string nmrPesanan)
        {
            dt = new DataTable();
            queryString = @"SELECT * FROM tb_pemesanan WHERE kd_pemesanan = '" + nmrPesanan + "';";
            try
            {
                koneksi.Open();
                command = new MySqlCommand(queryString, koneksi);
                adapter = new MySqlDataAdapter(command);
                command.ExecuteNonQuery();
                adapter.Fill(dt);
                koneksi.Close();
            }
            catch (MySqlException e)
            {
                Console.WriteLine("Error ", e);
            }
            return dt;
        }
    }
}
