using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
namespace WpfPemesananMakanan.Implement
{
    class ImPegawai : Interface.InPegawai
    {
        private Boolean status;
        private String queryString;
        private MySqlConnection koneksi;
        private MySqlCommand command;
        private MySqlDataReader reader;
        private MySqlDataAdapter adapter;
        public ImPegawai()
        {
            koneksi = Koneksi.KoneksiDB.GetKoneksi();
        }
        public DataSet TampilPegawai()
        {
            DataSet ds = new DataSet();
            try
            {
                queryString = @"SELECT * FROM tb_pegawai";
                koneksi.Open();
                command = new MySqlCommand(queryString, koneksi);
                adapter = new MySqlDataAdapter(command);
                command.ExecuteNonQuery();
                adapter.Fill(ds,"tb_pegawai");
                koneksi.Close();
            }
            catch (MySqlException e)
            {
                Console.WriteLine("Error : +", e);
            }
            return ds;
        }
        public Boolean TambahPegawai(Entity.EnPegawai ex)
        {
            status = false;
            try
            {
                queryString = @"INSERT INTO tb_pegawai(ID_pegawai,nama_pegawai,kd_jabatan,no_telepo,sandi,alamat)
	                VALUES ('" + ex.GetIdPegawai() + "','" + ex.GetNmPegawai() + "','" + ex.GetKdJabatan() + "','" + ex.GetNoTelp() + "','" + ex.GetSandi() + "','" + ex.GetAlamat() + "');";
                koneksi.Open();
                command = new MySqlCommand(queryString, koneksi);
                command.ExecuteNonQuery();
                status = true;
                koneksi.Close();
            }
            catch (MySqlException e)
            {
                Console.WriteLine("Error : +",e);
            }
            return status;
        }

        public Boolean UbahPegawai(Entity.EnPegawai ex)
        {
            status = false;
            try
            {
                queryString = @"UPDATE tb_pegawai SET nama_pegawai = '" + ex.GetNmPegawai() + "', kd_jabatan = '" + ex.GetKdJabatan() + "',no_telepo = '" + ex.GetNoTelp() + "',sandi = '" + ex.GetSandi() + "',alamat = '" + ex.GetAlamat() + "' WHERE ID_pegawai = '" + ex.GetIdPegawai() + "';";
                command = new MySqlCommand(queryString, koneksi);
                command.ExecuteNonQuery();
                status = true;
            }
            catch (MySqlException e)
            {
                Console.WriteLine("Error ", e);
            }
            return status;
        }

        public Boolean LoginPegawai(string IdPegawai, string Sandi)
        {
            status = false;
            try
            {
                queryString = @"SELECT ID_pegawai,sandi FROM tb_pegawai WHERE ID_pegawai = '" + IdPegawai + "' AND sandi = '" + Sandi + "'";
                koneksi.Open();
                command = new MySqlCommand(queryString, koneksi);
                command.ExecuteNonQuery();
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    if (reader.GetString(0).ToString() == IdPegawai && reader.GetString(1).ToString() == Sandi)
                    {
                        status = true;
                    }
                    else
                    {
                        status = false;
                    }
                }
                koneksi.Close();
            }
            catch (MySqlException e)
            {
                Console.WriteLine("Error" + e);
            }
            return status;
        }
    }
}
