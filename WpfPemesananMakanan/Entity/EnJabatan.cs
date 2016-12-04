using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfPemesananMakanan.Entity
{
    class EnJabatan
    {
        private string KdJabatan;
        private string NamaJabatan;

        public void SetKdJabatan(string _KdJabatan)
        {
            KdJabatan = _KdJabatan;
        }
        public string GetKdJabatan()
        {
            return KdJabatan;
        }

        public void SetNmJabatan(string _NamaJabatan)
        {
            NamaJabatan = _NamaJabatan;
        }
        public string GetNmJabatan()
        {
            return NamaJabatan;
        }
    }
}
