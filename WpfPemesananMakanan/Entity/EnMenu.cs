using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfPemesananMakanan.Entity
{
    class EnMenu
    {
        private string IdMenu;
        private string NmMenu;
        private string Gambar;
        private string Deskripsi;
        private double Harga;
        private string Kategori;
        private bool Status;

        public void SetIdMenu(string _IdMenu)
        {
            IdMenu = _IdMenu;
        }
        public string GetIdMenu()
        {
            return IdMenu;
        }

        public void SetNmMenu(string _NmMenu)
        {
            NmMenu = _NmMenu;
        }
        public string GetNmMenu()
        {
            return NmMenu;
        }

        public void SetGambar(string _Gambar)
        {
            Gambar = _Gambar;
        }
        public string GetGambar()
        {
            return Gambar;
        }

        public void SetDeskripsi(string _Deskripsi)
        {
            Deskripsi = _Deskripsi;
        }
        public string GetDeskripsi()
        {
            return Deskripsi;
        }

        public void setHarga(double _Harga)
        {
            Harga = _Harga;
        }
        public double GetHarga()
        {
            return Harga;
        }

        public void SetKategori(string _Kategori)
        {
            Kategori = _Kategori;
        }
        public string Getkategori()
        {
            return Kategori;
        }

        public void SetStatus(bool _Status)
        {
            Status = _Status;
        }
        public bool GetStatus()
        {
            return Status;
        }
    }
}
