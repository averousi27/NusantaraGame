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
        public Soal()
        {
            InitializeComponent();
        }

        public void ShowDialog(ref TextBlock TextLevel)
        {
            TextSoal.Text = TextLevel.Text;
            this.ShowDialog();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }


    }
}
