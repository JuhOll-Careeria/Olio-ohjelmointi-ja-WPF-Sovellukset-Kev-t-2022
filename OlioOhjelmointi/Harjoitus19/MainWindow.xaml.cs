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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Harjoitus19
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // staattinen lista sivuista. Tätä voidaan kutsua mistä vain käyttämällä:
        // MainWindow.Kerrokset[index], jossa index on listan numero, esim 0 => 1 listalla, 1 => toinen listalla
        public static List<Page> Kerrokset = new List<Page>();

        Hissi hissi = new Hissi();

        public MainWindow()
        {
            InitializeComponent();

            Kerrokset.Add(new Kerros1());
            Kerrokset.Add(new Kerros2());
            Kerrokset.Add(new Kerros3());
            Kerrokset.Add(new Kerros4());

            VaihdaKerrosta(1);
        }

        void VaihdaKerrosta(int kerros)
        {
            Frame_Main.NavigationService.Navigate(Kerrokset[kerros - 1]); // kerros - 1, koska listat alkaa indexistä 0
            hissi.NykyinenKerros = kerros;
            tb_Kerros.Text = "Kerros " + hissi.NykyinenKerros;
        }

        private void btn_Kerros1_Click(object sender, RoutedEventArgs e)
        {
            VaihdaKerrosta(1); // Vaihdetaan kerrokselle 1
        }

        private void btn_Kerros2_Click(object sender, RoutedEventArgs e)
        {
            VaihdaKerrosta(2); // Vaihdetaan kerrokselle 2
        }

        private void btn_Kerros3_Click(object sender, RoutedEventArgs e)
        {
            VaihdaKerrosta(3); // Vaihdetaan kerrokselle 3
        }

        private void btn_Kerros4_Click(object sender, RoutedEventArgs e)
        {
            VaihdaKerrosta(4); // Vaihdetaan kerrokselle 4
        }
    }
}
