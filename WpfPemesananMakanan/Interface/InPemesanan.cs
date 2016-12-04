using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace WpfPemesananMakanan.Interface
{
    interface InPemesanan
    {
        String KodeBaru();
        DataSet TampilPesanan();
        Boolean UbahStatusPesanan(Entity.EnPemesanan ep);
        Boolean TambahPesanan(string kodebaru);
        Boolean TambahDetailPesanan(string jml_pesanan, string catatan);
        Boolean UbahDetailPesanan(string jml_pesanan, string catatan);
        DataTable CariPesanan(string nmrPesanan);
    }
}
