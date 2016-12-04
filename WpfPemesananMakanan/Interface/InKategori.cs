using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace WpfPemesananMakanan.Interface
{
    interface InKategori
    {
        DataSet TampilKategori();
        Boolean TambahKategori(Entity.EnKategori e);
        String KodeBaru(string kd);
    }
}
