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
using System.Data;
using MySql.Data.MySqlClient;

namespace WpfPemesananMakanan.View.Admin
{
    /// <summary>
    /// Interaction logic for AddMenuPaket.xaml
    /// </summary>
    public partial class AddMenuPaket : Window
    {
        private bool status;
        private string kodeBaru;
        private Entity.EnMenu TambahMenu;
        private Entity.EnKategori kategori;
        private Interface.InMenu menuDao;
        private Interface.InKategori kategoriDao;
        private DataSet ds;
        public AddMenuPaket()
        {
            //cbKategori();
            menuDao = Factory.FactoryAll.GetMenuDao();
            kategoriDao = Factory.FactoryAll.GetKategoriDao();
            InitializeComponent();
        }

        private void cbKategori()
        {   
            //review
            //comboBoxKategoriMenu.Items.Clear();
            ds = new DataSet();
            ds = kategoriDao.TampilKategori();
            int row = ds.Tables[0].Rows.Count - 1;
            for (int i = 0; i <= row; i++)
            {
                
                comboBoxKategoriMenu.ItemsSource = ds.Tables[0].DefaultView;
                comboBoxKategoriMenu.DisplayMemberPath = ds.Tables[0].Rows[i][1].ToString();
                comboBoxKategoriMenu.SelectedValuePath = ds.Tables[0].Rows[i][0].ToString();
                
                //Console.WriteLine(ds.Tables[0].Rows[i][0]);
            }
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

        private void btnGambarMenu_Click(object sender, RoutedEventArgs e)
        {
              
        }

        private void textNmMenu_TextChanged(object sender, TextChangedEventArgs e)
        {
            TambahMenu.SetNmMenu(textNmMenu.Text);
        }

        private void textHargaMenu_TextChanged(object sender, TextChangedEventArgs e)
        {
            TambahMenu.setHarga(double.Parse(textHargaMenu.Text));
        }

        private void textDeskripsimenu_TextChanged(object sender, TextChangedEventArgs e)
        {
            TambahMenu.SetDeskripsi(textDeskripsiMenu.Text);
        }

        private void comboBox_SelectionChangedMenu(object sender, SelectionChangedEventArgs e)
        {
            TambahMenu.SetKategori(comboBoxKategoriMenu.SelectedValue.ToString());
        }

        private void btnSimpanMenu_Click(object sender, RoutedEventArgs e)
        {
            if(textNmKategori.Text == "" || textNmMenu.Text == "" || textDeskripsiMenu.Text == "")
            {
                MessageBox.Show("Lengkapi seluruh data!");
            }
            else
            {
                status = menuDao.TambahMenu(TambahMenu);
                if (status == true)
                {
                    MessageBox.Show("Data Kategori Berhasil Ditambahkan");
                    VwTampilMenu formVwMenu = new VwTampilMenu();
                    formVwMenu.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Data gagal ditambahkan!");
                }
            }
        }

        private void textNmKategori_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void btnSimpanKategori_Click(object sender, RoutedEventArgs e)
        {
            kategori = new Entity.EnKategori();
            
            kategori.SetNamaKategori(textNmKategori.Text);
            kategori.SetIdKategori(kategoriDao.KodeBaru(textNmKategori.Text));

            if (textNmKategori.Text == "")
            {
                MessageBox.Show("Masukan nama kategori!");
            }
            else
            {
                status = kategoriDao.TambahKategori(kategori);
                if (status == true)
                {
                    MessageBox.Show("Data Kategori Berhasil Ditambahkan");
                    VwTampilMenu formVwMenu = new VwTampilMenu();
                    formVwMenu.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Data gagal ditambahkan!");
                }
            }
        }
    }
}
