using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfPemesananMakanan.View
{
    /// <summary>
    /// Interaction logic for VwLoginPegawai.xaml
    /// </summary>
    public partial class VwLoginPegawai : Window
    {
        private Boolean status;
        private Interface.InPegawai pegawaiDao;
            
        public VwLoginPegawai()
        {
            pegawaiDao = Factory.FactoryAll.GetPegawaiDao();
            InitializeComponent();
        }

        private void textNmPengguna_TextChanged(object sender, TextChangedEventArgs e)
        {
            textNmPengguna.Focus();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            if(textNmPengguna.Text == "" || passwordBoxSandi.Password == "")
            {
                MessageBox.Show("ID dan Sandi harus di isi!");
            }
            else
            {
                status = pegawaiDao.LoginPegawai(textNmPengguna.Text, passwordBoxSandi.Password);
                if(status == true)
                {
                    MessageBox.Show("Berhasil!");
                    Admin.VwTampilMenu frm = new Admin.VwTampilMenu();
                    frm.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("ID Atau Sandi salah!");
                    textNmPengguna.Text = "";
                    passwordBoxSandi.Password = "";
                    textNmPengguna.Focus();
                }
            }
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
