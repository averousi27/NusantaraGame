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
    /// Interaction logic for SoalSatu.xaml
    /// </summary>
    public partial class SoalSatu : Window
    {
        public SoalSatu()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            SoalController sc = new SoalController();
            IEnumerable<Provinsi> provinsis = sc.GetLevel();
            foreach (var item in provinsis)
            {
                if (item.SoalId == 1)
                    MessageBox.Show(item.ToString());
            }
        }
    }
}
