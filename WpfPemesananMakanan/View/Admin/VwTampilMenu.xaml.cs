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

namespace WpfPemesananMakanan.View.Admin
{
    /// <summary>
    /// Interaction logic for VwTampilMenu.xaml
    /// </summary>
    public partial class VwTampilMenu : Window
    { 
        private DataTable dt = new DataTable();
        private Entity.EnMenu menuTampil;
        private Interface.InMenu menuTampilDao;
        public VwTampilMenu()
        {
            
            menuTampilDao = Factory.FactoryAll.GetMenuDao();
            InitializeComponent();
        }

        private void btnUbahMenu_Click(object sender, RoutedEventArgs e)
        {

        }

        private void comboBoxStatusMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void comboBoxKategoriMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

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

        private void listView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //listView.Items.Add(new);
        }

        private void dataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           dt = menuTampilDao.TampilMenu();
                
            
        }
    }
}
