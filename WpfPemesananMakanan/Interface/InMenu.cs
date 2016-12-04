using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace WpfPemesananMakanan.Interface
{
    interface InMenu
    {
        String kodeBaru();
        DataSet TampilMenu();
        DataSet TampilMenuUser(string kategori); 
        Boolean TambahMenu(Entity.EnMenu e);
        Boolean UbahMenu(Entity.EnMenu e);
        DataSet CariMenu(string kategori, string status);
    }
}
