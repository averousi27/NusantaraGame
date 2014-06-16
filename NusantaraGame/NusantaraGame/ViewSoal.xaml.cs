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
                {
                    TampilSoal.Text = item.Soal.ToString();

                    //vvvv Ini ga jadi dipake
                    //MessageBox.Show(item.Soal.ToString());
                    //^^^^

                    //Ini untuk menampilkan kota yg benar (jawaban) saat itu (di hide dari view, biar user ga bisa liat)
                    //kota yang benar saat itu disimpan di textblock yang bernama kotaYgBenar
                    //Gunanya nanti pas buat ngecek jawaban
                    kotaYgBenar.Text = item.IbuKota;

                    //Ini untuk menyimpan idSoal saat itu
                    //gunanya untuk pasing parameter untuk menampilkan konten
                    //idSoal saat itu disimpan di textblock yan bernama idKotaYgBenar
                    idKotaYgBenar.Text = Convert.ToString(item.SoalId);
                }
            }



            this.ShowDialog();
        }

        public void ShowKonten(ref TextBlock TextLevel)
        {
            //IdLevelDua.Text = TextLevel.Text;
            //this.ShowDialog();
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            //Mengecek apakah jawaban benar atau salah
            //Jika Benar:
            if (RadioButton.NameProperty.Equals(kotaYgBenar.Text))
            {
                MessageBox.Show("Jawaban Benar");
                Konten isiKonten = new Konten();
                isiKonten.ShowDialog(ref idKotaYgBenar);
            }

            //Jika Salah:
            else
            {
                MessageBox.Show("Jawaban kamu salah! Nyawa kamu berkurang 1");
                this.Close();
            }
        }


        private void RadioButton_Checked_2(object sender, RoutedEventArgs e)
        {
            //Mengecek apakah jawaban benar atau salah
            //Jika Benar:
            //if (RadioButton.NameProperty.Equals(idSoalSkrg.Text))
            if (Jakarta.Name.Equals(kotaYgBenar.Text))
            {
                //Konten isiKonten = new Konten();
                //isiKonten.ShowDialog(ref idSoalSkrg);
                MessageBox.Show("Jawaban Benar");
            }

            //Jika Salah:
            else
            {
                MessageBox.Show("Jawaban kamu salah! Nyawa kamu berkurang 1");
                this.Close();
            }
        }
    }
}
