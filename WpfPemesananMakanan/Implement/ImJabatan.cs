using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
namespace WpfPemesananMakanan.Implement
{
    class ImJabatan : Interface.InJabatan
    {
        private MySqlCommand cmd;
        private MySqlConnection koneksi;
        private bool status;
        private string queryString;
        public ImJabatan()
        {
            koneksi = Koneksi.KoneksiDB.GetKoneksi();
        }
        public String KodeBaru(string Id)
        {
            string kode = Id.Substring(0, 3);
            return kode;
        }
        public Boolean TambahJabatan(Entity.EnJabatan ex)
        {
            status = false;   
            try
            {
                queryString = @"INSERT INTO tb_jabatan (kd_jabatan,Nama_jabatan)
	                    VALUES('" + ex.GetKdJabatan() + "','" + ex.GetNmJabatan() + "'); ";
                koneksi.Open();
                cmd = new MySqlCommand(queryString, koneksi);
                cmd.ExecuteNonQuery();
                status = true;
                koneksi.Close();
            }
            catch (MySqlException e)
            {
                Console.WriteLine("Error : +",e);
            }
            return status;
        }
    }
}
