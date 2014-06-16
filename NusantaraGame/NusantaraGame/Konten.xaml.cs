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
    /// Interaction logic for Konten.xaml
    /// </summary>
    public partial class Konten : Window
    {
        public Konten()
        {
            InitializeComponent();
        }

        public void ShowDialog(ref TextBlock LevelSoal, ref TextBlock IdSoal)
        {
            ProvinsiController pc = new ProvinsiController();
            IEnumerable<Provinsi> konten = pc.GetLevel(LevelSoal.Text);

            int idnya = Convert.ToInt32(IdSoal.Text);
            foreach (Provinsi item in konten)
            {

                if (item.SoalId.Equals(idnya))
                {
                    IbuKota.Text = item.IbuKota.ToString();
                    MessageBox.Show(item.IbuKota.ToString());
                    LuasWilayah.Text = item.LuasWilayah.ToString();
                    MessageBox.Show(item.LuasWilayah.ToString());
                    Suku.Text = item.Suku.ToString();
                    MessageBox.Show(item.Suku.ToString());
                    Bahasa.Text = item.BahasaDaerah.ToString();
                    MessageBox.Show(item.BahasaDaerah.ToString());
                    //BajuAdat.Text = item.BajuAdat.ToString();
                    //MessageBox.Show(item.BajuAdat.ToString());
                    //RumahAdat.Text = item.RumahAdat.ToString();
                    //MessageBox.Show(item.RumahAdat.ToString());
                    Flora.Text = item.Flora.ToString();
                    MessageBox.Show(item.Flora.ToString());
                    Fauna.Text = item.Fauna.ToString();
                    MessageBox.Show(item.Fauna.ToString());
                    PotensiAlam.Text = item.PotensiAlam.ToString();
                    MessageBox.Show(item.PotensiAlam.ToString());
                    TempatWisata.Text = item.TempatWisata.ToString();
                    MessageBox.Show(item.TempatWisata.ToString());
                }
            }
            this.ShowDialog();
        }
    }
}
