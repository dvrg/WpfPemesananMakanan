using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace WpfPemesananMakanan.Interface
{
    interface InPegawai
    {
        DataSet TampilPegawai();
        Boolean TambahPegawai(Entity.EnPegawai e);
        Boolean UbahPegawai(Entity.EnPegawai e);
        Boolean LoginPegawai(string IdPegawai, string Sandi);
    }
}
