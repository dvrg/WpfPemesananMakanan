using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfPemesananMakanan.Entity
{
    class EnKategori
    {
        private string IdKategori;
        private string namaKategori;

        public void SetIdKategori(string _IdKategori)
        {
            IdKategori = _IdKategori;
        }
        public string GetIdKategori()
        {
            return IdKategori;
        }

        public void SetNamaKategori(string _namaKategori)
        {
            namaKategori = _namaKategori;
        }
        public string GetNamaKategori()
        {
            return namaKategori;
        }
    }
}
