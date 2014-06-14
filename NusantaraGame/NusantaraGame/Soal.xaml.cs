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
    /// Interaction logic for Soal.xaml
    /// </summary>
    public partial class Soal : Window
    {

        int LevelSoal;

        public Soal()
        {
            InitializeComponent();
        }

        //Code untuk mengubah TextLevel yang berformat string menjadi int
        //agar sesuai dengan database
        public int LevelInt(ref TextBlock TextLevel)
        {
            int i;
            String[] angkaS = { "1", "2", "3", "4", "5" };
            int[] angkaI = { 1, 2, 3, 4, 5 };

            for (i = 0; i < 5; i++)
            {
                if (TextLevel.Equals(angkaS[i]))
                    LevelSoal = angkaI[i];
            }
            return LevelSoal;
        }

        public void ShowDialog(ref TextBlock TextLevel)
        {
            IdSoal.Text = TextLevel.Text;
            this.ShowDialog();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ViewSoal isiSoal = new ViewSoal();
            isiSoal.ShowDialog(ref LevelSoal);
        }


    }
}
