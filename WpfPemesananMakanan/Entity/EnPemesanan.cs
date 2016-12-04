using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfPemesananMakanan.Entity
{
    class EnPemesanan
    {
        private string KdPemesanan;
        private DateTime TglPemesanan;
        private bool Status;

        public void SetKdPemesanan(string _KdPemesanan)
        {
            KdPemesanan = _KdPemesanan;
        }
        public string GetKdPemesanan()
        {
            return KdPemesanan;
        }

        public void SetTglPemesanan(DateTime _TglPemesanan)
        {
            TglPemesanan = _TglPemesanan;
        }
        public DateTime GetTglPemesanan()
        {
            return TglPemesanan;
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
