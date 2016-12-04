using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfPemesananMakanan.Entity
{
    class EnPegawai
    {
        private string IdPegawai;
        private string NmPegawai;
        private string kdJabatan;
        private string Sandi;
        private double NoTelp;
        private string Alamat;

        public void SetIdPegawai(string _IdPegawai)
        {
            IdPegawai = _IdPegawai;
        }
        public string GetIdPegawai()
        {
            return IdPegawai;
        }

        public void SetNmPegawai(string _NmPegawai)
        {
            NmPegawai = _NmPegawai;
        }
        public string GetNmPegawai()
        {
            return NmPegawai;
        }

        public void SetKdJabatan(string _kdJabatan)
        {
            kdJabatan = _kdJabatan;
        }
         public string GetKdJabatan()
        {
            return kdJabatan;
        }
        public void SetSandi(string _Sandi)
        {
            Sandi = _Sandi;
        }
        public string GetSandi()
        {
            return Sandi;
        }

        public void SetNoTelp(double _NoTelp)
        {
            NoTelp = _NoTelp;
        }
        public double GetNoTelp()
        {
            return NoTelp;
        }

        public void SetAlamat(string _Alamat)
        {
            Alamat = _Alamat;
        }
        public string GetAlamat()
        {
            return Alamat;
        }
    }
}
