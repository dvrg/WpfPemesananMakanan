using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfPemesananMakanan.Factory
{
    //tahap 5
    class FactoryAll
    {
        //pembuatan object dari class interface
        private static Interface.InKategori kategoriDao;
        private static Interface.InJabatan jabatanDao;
        private static Interface.InPegawai pegawaiDao;
        private static Interface.InMenu menuDao;
        private static Interface.InPemesanan pemesananDao;

        public static Interface.InKategori GetKategoriDao()
        {
            kategoriDao = new Implement.ImKategori();
            return kategoriDao;
        }

        public static Interface.InJabatan GetJabatanDao()
        {
            jabatanDao = new Implement.ImJabatan();
            return jabatanDao;
        }

        public static Interface.InPegawai GetPegawaiDao()
        {
            pegawaiDao = new Implement.ImPegawai();
            return pegawaiDao;
        }
        
        public static Interface.InMenu GetMenuDao()
        {
            menuDao = new Implement.ImMenu();
            return menuDao;
        }
        public static Interface.InPemesanan GetPemesananDao()
        {
            pemesananDao = new Implement.ImPemesanan();
            return pemesananDao;
        }
    }
}
