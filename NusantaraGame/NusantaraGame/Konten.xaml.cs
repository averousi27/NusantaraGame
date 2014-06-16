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

        public void ShowDialog(ref TextBlock KotaYgBenar)
        {
            // //int idSoal = Convert.ToInt32(IdSoal);
            ProvinsiController pc = new ProvinsiController();
            Provinsi konten = pc.GetKonten(KotaYgBenar.Text);
            
            
            IbuKota.Text = konten.IbuKota.ToString();
            // MessageBox.Show(konten.IbuKota.ToString());
            LuasWilayah.Text = konten.LuasWilayah.ToString();
            //// MessageBox.Show(konten.LuasWilayah.ToString());
            Suku.Text = konten.Suku.ToString();
            //// MessageBox.Show(konten.Suku.ToString());
            Bahasa.Text = konten.BahasaDaerah.ToString();
            //// MessageBox.Show(konten.BahasaDaerah.ToString());

            //try
            //{
                
            //}
            //catch()

            Flora.Text = konten.Flora.ToString();
            //// //BajuAdat.Text = konten.BajuAdat.ToString();
            ////// MessageBox.Show(konten.BajuAdat.ToString());
            //// //RumahAdat.Text = konten.RumahAdat.ToString();
            //// //MessageBox.Show(konten.RumahAdat.ToString());
           
            //// MessageBox.Show(konten.Flora.ToString());
            Fauna.Text = konten.Fauna.ToString();
            //// MessageBox.Show(konten.Fauna.ToString());
            PotensiAlam.Text = konten.PotensiAlam.ToString();
            //// MessageBox.Show(konten.PotensiAlam.ToString());
            TempatWisata.Text = konten.TempatWisata.ToString();
            //// MessageBox.Show(konten.TempatWisata.ToString());

             
            this.ShowDialog();
        }
    }
}
