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

            PlayerController pc = new PlayerController();
            nyawa.Text = pc.TampilNyawa().ToString();
            score.Text = pc.TampilScore().ToString();
        }

        public void ShowDialog(ref TextBlock LevelSoal, ref TextBlock IdSoal)
        {
            ProvinsiController pc = new ProvinsiController();
            IEnumerable<Provinsi> soal = pc.GetLevel(LevelSoal.Text);

            int idnya = Convert.ToInt32(IdSoal.Text);
            foreach (Provinsi item in soal)
            {
                if (item.SoalId.Equals(idnya))
                    TampilSoal.Text = item.Soal.ToString();
            }
            this.ShowDialog();
        }
    }
}
