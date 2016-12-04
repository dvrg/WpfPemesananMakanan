using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace WpfPemesananMakanan.Koneksi
{
    class KoneksiDB
    {
        public static MySqlConnection GetKoneksi()
        {
            //atur string koneksi
            string strConn = @"SERVER = localhost;" +
                             "PORT = 3306;" +
                             "UID = root;" +
                             "PWD = 052795;" +
                             "DATABASE = db_pemesananmakanan;";
            return new MySqlConnection(strConn);
        }
    }
}
