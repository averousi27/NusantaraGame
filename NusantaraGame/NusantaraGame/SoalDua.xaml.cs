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

namespace NusantaraGame
{
    /// <summary>
    /// Interaction logic for SoalDua.xaml
    /// </summary>
    public partial class SoalDua : Window
    {
        public SoalDua()
        {
            InitializeComponent();
        }

        public void ShowDialog(ref TextBlock TextLevel)
        {
            IdLevelDua.Text = TextLevel.Text;
            this.ShowDialog();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ViewSoal isiSoal = new ViewSoal();
            isiSoal.ShowDialog(ref IdLevelDua, ref SoalDua_1);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            ViewSoal isiSoal = new ViewSoal();
            isiSoal.ShowDialog(ref IdLevelDua, ref SoalDua_2);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            ViewSoal isiSoal = new ViewSoal();
            isiSoal.ShowDialog(ref IdLevelDua, ref SoalDua_3);
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            ViewSoal isiSoal = new ViewSoal();
            isiSoal.ShowDialog(ref IdLevelDua, ref SoalDua_4);
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            ViewSoal isiSoal = new ViewSoal();
            isiSoal.ShowDialog(ref IdLevelDua, ref SoalDua_5);
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            ViewSoal isiSoal = new ViewSoal();
            isiSoal.ShowDialog(ref IdLevelDua, ref SoalDua_6);
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            ViewSoal isiSoal = new ViewSoal();
            isiSoal.ShowDialog(ref IdLevelDua, ref SoalDua_7);
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
