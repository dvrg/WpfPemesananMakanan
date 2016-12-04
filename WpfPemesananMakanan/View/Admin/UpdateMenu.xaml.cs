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
    /// Interaction logic for UpdateMenuPaket.xaml
    /// </summary>
    public partial class UpdateMenuPaket : Window
    {
        private bool status;
        private Entity.EnMenu UpdateMenu;
        private Entity.EnKategori kategori;
        private Interface.InMenu menuDao;
        private Interface.InKategori kategoriDao;
        public UpdateMenuPaket()
        {
            menuDao = Factory.FactoryAll.GetMenuDao();
            kategoriDao = Factory.FactoryAll.GetKategoriDao();
            InitializeComponent();
        }
        public void isiComboKategori()
        {
            DataSet tampilCombo = kategoriDao.TampilKategori();
            //comboBoxKategoriMenu
            //for () ;

        }

        private void btnUbahMenu_Click(object sender, RoutedEventArgs e)
        {

        }

        private void textNmMenu_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void textHargaMenu_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void textDeskripsimenu_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void comboBox_SelectionChangedMenu(object sender, SelectionChangedEventArgs e)
        {

        }

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void btnGambarMenu_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
