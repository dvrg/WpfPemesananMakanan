using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace WpfPemesananMakanan.Interface
{
    interface InJabatan
    {
        Boolean TambahJabatan(Entity.EnJabatan e);
        String KodeBaru(string Id);
    }
}
