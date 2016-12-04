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

namespace WpfPemesananMakanan.View.Admin
{
    /// <summary>
    /// Interaction logic for AddPegawai.xaml
    /// </summary>
    public partial class AddPegawai : Window
    {
        private bool status;
        private string kodebaru;
        private Entity.EnPegawai pegawai;
        private Interface.InPegawai pegawaiDao;
        private Entity.EnJabatan jabatan;
        private Interface.InJabatan jabatanDao;
        public AddPegawai()
        {
            pegawaiDao = Factory.FactoryAll.GetPegawaiDao();
            jabatanDao = Factory.FactoryAll.GetJabatanDao();
            InitializeComponent();
        }

        private void MenuItemKeluarUser_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void MenuItemEditUser_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MenuItemLihatMenu_Click(object sender, RoutedEventArgs e)
        {
            VwTampilMenu frm = new VwTampilMenu();
            frm.Show();
            this.Close();
        }

        private void MenuItemTambahMenu_Click(object sender, RoutedEventArgs e)
        {
            AddMenuPaket frm = new AddMenuPaket();
            frm.Show();
            this.Close();
        }

        private void MenuItemTambahUser_Click(object sender, RoutedEventArgs e)
        {
            AddPegawai frm = new AddPegawai();
            frm.Show();
            this.Close();
        }

        private void textNmPegawai_TextChanged(object sender, TextChangedEventArgs e)
        {
            pegawai.SetNmPegawai(textNmPegawai.Text);
        }

        private void textNmrTelepon_TextChanged(object sender, TextChangedEventArgs e)
        {
            pegawai.SetNoTelp(int.Parse(textNmrTelepon.Text));
        }

        private void textAlamat_TextChanged(object sender, TextChangedEventArgs e)
        {
            pegawai.SetAlamat(textAlamat.Text);
        }

        private void btnSimpanPegawai_Click(object sender, RoutedEventArgs e)
        {
            if(textNmPegawai.Text == "" || passwordBox.Password == "")
            {
                MessageBox.Show("Lengkapi data Nama dan Sandi!.");
            }
            else
            {
                status = pegawaiDao.TambahPegawai(pegawai);
                if (status == true)
                {
                    MessageBox.Show("Data Berhasil Ditambahkan");
                    VwTampilMenu frm = new VwTampilMenu();
                    frm.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Gagal Menambahkan data.");
                }
            }
        }

        private void btnSimpanJabatan_Click(object sender, RoutedEventArgs e)
        {
            jabatan = new Entity.EnJabatan();

            jabatan.SetNmJabatan(textNmJabatan.Text);
            jabatan.SetKdJabatan(jabatanDao.KodeBaru(textNmJabatan.Text));

            if (textNmJabatan.Text == "")
            {
                MessageBox.Show("Nama Jabatan Harus Di isi!.");
            }
            else
            {
                status = jabatanDao.TambahJabatan(jabatan);
                if (status == true)
                {
                    MessageBox.Show("Data Berhasil Ditambahkan");
                    VwTampilMenu frm = new VwTampilMenu();
                    frm.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Gagal Menambahkan data.");
                }
            }
        }

        private void textNmJabatan_TextChanged(object sender, TextChangedEventArgs e)
        {
           
        }

        private void comboBox_SelectionChangedJabatan(object sender, SelectionChangedEventArgs e)
        {
            pegawai.SetKdJabatan(ComboBox.SelectedItemProperty.ToString());
        }
    }
}
