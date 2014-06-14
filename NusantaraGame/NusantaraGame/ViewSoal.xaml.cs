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
    /// Interaction logic for ViewSoal.xaml
    /// </summary>
    public partial class ViewSoal : Window
    {
        public ViewSoal()
        {
            InitializeComponent();
        }
       
        public void ShowDialog(ref int LevelSoal, ref int IdSoal)
        {
            //Console.WriteLine("1");
            ProvinsiController pc = new ProvinsiController();
            IEnumerable<Provinsi> soal = pc.GetLevel(1);
            foreach (var item in soal)
            { 
                if(item.SoalId.Equals(IdSoal))
                   TampilSoal.Text = item.Soal.ToString(); 
            }
            this.ShowDialog();
        }
    }
}
