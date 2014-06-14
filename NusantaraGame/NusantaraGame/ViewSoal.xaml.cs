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
       
        public void ShowDialog(ref TextBlock LevelSoal, ref int IdSoal)
        {
            //Console.WriteLine("1");
            //int Level = Convert.ToInt32(LevelSoal);
            int NoSoal = Convert.ToInt32(IdSoal);
            ProvinsiController pc = new ProvinsiController();
            IEnumerable<Provinsi> soal = pc.GetLevel(LevelSoal.Text);
            foreach (var item in soal)
            { 
                if(item.SoalId.Equals(NoSoal))
                   TampilSoal.Text = item.Soal.ToString(); 
            }
            this.ShowDialog();
        }
    }
}
