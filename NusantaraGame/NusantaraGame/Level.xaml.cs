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
    /// Interaction logic for Level.xaml
    /// </summary>
    public partial class Level : Window
    {
        public Level() //Passing value level to Soal.xaml.cs
        {
            InitializeComponent();
            PlaySound();
        }

        private void PlaySound()
        {
            BgMusic bm = new BgMusic();
            bm.BgMusicPath = AppDomain.CurrentDomain.BaseDirectory + "background music";
            soundPlayer.DataContext = bm;            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            Soal soal1 = new Soal();
            soal1.ShowDialog(ref TextLevelSatu);

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            SoalDua soal1 = new SoalDua();
            soal1.ShowDialog(ref TextLevelDua);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            SoalDua soal1 = new SoalDua();
            soal1.ShowDialog(ref TextLevelTiga);
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            SoalDua soal1 = new SoalDua();
            soal1.ShowDialog(ref TextLevelEmpat);
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            SoalDua soal1 = new SoalDua();
            soal1.ShowDialog(ref TextLevelLima);
        }
    }
}
