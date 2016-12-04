using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace WpfPemesananMakanan.Implement
{
    class ImMenu : Interface.InMenu
    {
        private Boolean status;
        private DataSet ds;
        private String queryString;
        private MySqlConnection koneksi;
        private MySqlCommand command;
        private MySqlDataAdapter adapter;
        private MySqlDataReader reader;
        
        public ImMenu()
        {
            koneksi = Koneksi.KoneksiDB.GetKoneksi();
        }

        public String kodeBaru()
        {

        }

        public DataSet TampilMenu()
        {
            ds = new DataSet();
            try
            {
                queryString = @"SELECT * FROM tb_menu";
                koneksi.Open();
                command = new MySqlCommand(queryString, koneksi);
                adapter = new MySqlDataAdapter(command);
                command.ExecuteNonQuery();
                adapter.Fill(ds,"tb_menu");
                koneksi.Close();
            }
            catch (MySqlException e)
            {
                Console.WriteLine("Error ", e);
            }
            return ds;
       }
        public DataSet TampilMenuUser(string kategori)
        {
            ds = new DataSet();
            try
            {
                queryString = @"SELECT * FROM tb_menu WHERE status_menu = 1 AND kategori = '" + kategori + "' ORDER BY ID_menu;";
                koneksi.Open();
                command = new MySqlCommand(queryString, koneksi);
                adapter = new MySqlDataAdapter(command);
                command.ExecuteNonQuery();
                adapter.Fill(ds,"tb_menu");
                koneksi.Close();
            }
            catch (MySqlException e)
            {
                Console.WriteLine("Error ", e);
            }
            return ds;
        }
        public Boolean TambahMenu(Entity.EnMenu ex)
       {
            status = false;
            try
            {
                queryString = @"INSERT INTO tb_menu(ID_menu,nama_menu,gambar,deskripsi,harga,nama_kategori,status_menu)
	                        VALUES ('" + ex.GetIdMenu() + "','" + ex.GetNmMenu() + "','" + ex.GetGambar() + "','" + ex.GetDeskripsi() + "','" + ex.GetHarga() + "','" + ex.Getkategori() + "','" + ex.GetStatus() + "');";
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
       public Boolean UbahMenu(Entity.EnMenu ex)
       {
            status = false;
            try
            {
                queryString = @"UPDATE tb_menu SET nama_menu = '" + ex.GetNmMenu() + "', gambar = '" + ex.GetGambar() + "',deskripsi = '" + ex.GetDeskripsi() + "',harga = '" + ex.GetHarga() + "',nama_kategori = '" + ex.Getkategori() + "',status_menu = '" + ex.GetStatus() + "' WHERE ID_menu = '" + ex.GetIdMenu() + "';";
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
        public DataSet CariMenu(string kategori, string status)
        {
            ds = new DataSet();
            try
            {
                queryString = @"SELECT * FROM tb_menu WHERE status_menu = '" + status + "' OR nama_kategori = '" + kategori + "';";
                koneksi.Open();
                command = new MySqlCommand(queryString, koneksi);
                adapter = new MySqlDataAdapter(command);
                command.ExecuteNonQuery();
                adapter.Fill(ds,"tb_menu");
                koneksi.Close();
            }
            catch (MySqlException e)
            {
                Console.WriteLine("Error ", e);
            }
            return ds;
        }
    }
}
