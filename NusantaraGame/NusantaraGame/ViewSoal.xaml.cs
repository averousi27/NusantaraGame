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
            if (NAD.Name.Equals(kotaYgBenar.Text))
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

        private void SumUt_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void RadioButton_Checked_3(object sender, RoutedEventArgs e)
        {
            //Mengecek apakah jawaban benar atau salah
            //Jika Benar:
            if (SumUt.Name.Equals(kotaYgBenar.Text))
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

        private void RadioButton_Checked_4(object sender, RoutedEventArgs e)
        {
            //Mengecek apakah jawaban benar atau salah
            //Jika Benar:
            if (Riau.Name.Equals(kotaYgBenar.Text))
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

        private void RadioButton_Checked_5(object sender, RoutedEventArgs e)
        {
            //Mengecek apakah jawaban benar atau salah
            //Jika Benar:
            if (SumBar.Name.Equals(kotaYgBenar.Text))
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

        private void RadioButton_Checked_6(object sender, RoutedEventArgs e)
        {
            //Mengecek apakah jawaban benar atau salah
            //Jika Benar:
            if (Jambi.Name.Equals(kotaYgBenar.Text))
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

        private void RadioButton_Checked_7(object sender, RoutedEventArgs e)
        {
            //Mengecek apakah jawaban benar atau salah
            //Jika Benar:
            if (SumSel.Name.Equals(kotaYgBenar.Text))
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

        private void RadioButton_Checked_8(object sender, RoutedEventArgs e)
        {
            //Mengecek apakah jawaban benar atau salah
            //Jika Benar:
            if (Lampung.Name.Equals(kotaYgBenar.Text))
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

        private void RadioButton_Checked_9(object sender, RoutedEventArgs e)
        {
            //Mengecek apakah jawaban benar atau salah
            //Jika Benar:
            if (Bengkulu.Name.Equals(kotaYgBenar.Text))
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

        private void RadioButton_Checked_10(object sender, RoutedEventArgs e)
        {
            //Mengecek apakah jawaban benar atau salah
            //Jika Benar:
            if (Bangka.Name.Equals(kotaYgBenar.Text))
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

        private void RadioButton_Checked_11(object sender, RoutedEventArgs e)
        {
            //Mengecek apakah jawaban benar atau salah
            //Jika Benar:
            if (KalTim.Name.Equals(kotaYgBenar.Text))
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

        private void RadioButton_Checked_12(object sender, RoutedEventArgs e)
        {
            //Mengecek apakah jawaban benar atau salah
            //Jika Benar:
            if (KalBar.Name.Equals(kotaYgBenar.Text))
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

        private void RadioButton_Checked_13(object sender, RoutedEventArgs e)
        {
            //Mengecek apakah jawaban benar atau salah
            //Jika Benar:
            if (KalTeng.Name.Equals(kotaYgBenar.Text))
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

        private void RadioButton_Checked_14(object sender, RoutedEventArgs e)
        {
            //Mengecek apakah jawaban benar atau salah
            //Jika Benar:
            if (KalSel.Name.Equals(kotaYgBenar.Text))
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

        private void RadioButton_Checked_15(object sender, RoutedEventArgs e)
        {
            //Mengecek apakah jawaban benar atau salah
            //Jika Benar:
            if (SulUt.Name.Equals(kotaYgBenar.Text))
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

        private void RadioButton_Checked_16(object sender, RoutedEventArgs e)
        {
            //Mengecek apakah jawaban benar atau salah
            //Jika Benar:
            if (Gorontalo.Name.Equals(kotaYgBenar.Text))
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

        private void RadioButton_Checked_17(object sender, RoutedEventArgs e)
        {
            //Mengecek apakah jawaban benar atau salah
            //Jika Benar:
            if (SulBar.Name.Equals(kotaYgBenar.Text))
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

        private void RadioButton_Checked_18(object sender, RoutedEventArgs e)
        {
            //Mengecek apakah jawaban benar atau salah
            //Jika Benar:
            if (SulSel.Name.Equals(kotaYgBenar.Text))
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

        private void RadioButton_Checked_19(object sender, RoutedEventArgs e)
        {
            //Mengecek apakah jawaban benar atau salah
            //Jika Benar:
            if (SulTengah.Name.Equals(kotaYgBenar.Text))
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

        private void RadioButton_Checked_20(object sender, RoutedEventArgs e)
        {
            //Mengecek apakah jawaban benar atau salah
            //Jika Benar:
            if (SulTeng.Name.Equals(kotaYgBenar.Text))
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

        private void RadioButton_Checked_21(object sender, RoutedEventArgs e)
        {
            //Mengecek apakah jawaban benar atau salah
            //Jika Benar:
            if (Banten.Name.Equals(kotaYgBenar.Text))
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

        private void RadioButton_Checked_22(object sender, RoutedEventArgs e)
        {
            //Mengecek apakah jawaban benar atau salah
            //Jika Benar:
            if (JaTeng.Name.Equals(kotaYgBenar.Text))
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

        private void RadioButton_Checked_23(object sender, RoutedEventArgs e)
        {
            //Mengecek apakah jawaban benar atau salah
            //Jika Benar:
            if (Yogya.Name.Equals(kotaYgBenar.Text))
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

        private void RadioButton_Checked_24(object sender, RoutedEventArgs e)
        {
            //Mengecek apakah jawaban benar atau salah
            //Jika Benar:
            if (JaTim.Name.Equals(kotaYgBenar.Text))
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

        private void RadioButton_Checked_25(object sender, RoutedEventArgs e)
        {
            //Mengecek apakah jawaban benar atau salah
            //Jika Benar:
            if (Bali.Name.Equals(kotaYgBenar.Text))
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

        private void RadioButton_Checked_26(object sender, RoutedEventArgs e)
        {
            //Mengecek apakah jawaban benar atau salah
            //Jika Benar:
            if (NTB.Name.Equals(kotaYgBenar.Text))
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

        private void RadioButton_Checked_27(object sender, RoutedEventArgs e)
        {
            //Mengecek apakah jawaban benar atau salah
            //Jika Benar:
            if (NTT.Name.Equals(kotaYgBenar.Text))
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

        private void RadioButton_Checked_28(object sender, RoutedEventArgs e)
        {
            //Mengecek apakah jawaban benar atau salah
            //Jika Benar:
            if (Maluku.Name.Equals(kotaYgBenar.Text))
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

        private void RadioButton_Checked_29(object sender, RoutedEventArgs e)
        {
            //Mengecek apakah jawaban benar atau salah
            //Jika Benar:
            if (MalUt.Name.Equals(kotaYgBenar.Text))
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

        private void RadioButton_Checked_30(object sender, RoutedEventArgs e)
        {
            //Mengecek apakah jawaban benar atau salah
            //Jika Benar:
            if (PapBar.Name.Equals(kotaYgBenar.Text))
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

        private void RadioButton_Checked_31(object sender, RoutedEventArgs e)
        {
            //Mengecek apakah jawaban benar atau salah
            //Jika Benar:
            if (Papua.Name.Equals(kotaYgBenar.Text))
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

        private void RadioButton_Checked_32(object sender, RoutedEventArgs e)
        {
            //Mengecek apakah jawaban benar atau salah
            //Jika Benar:
            if (KepRiau.Name.Equals(kotaYgBenar.Text))
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

        private void RadioButton_Checked_33(object sender, RoutedEventArgs e)
        {
            //Mengecek apakah jawaban benar atau salah
            //Jika Benar:
            if (JaBar.Name.Equals(kotaYgBenar.Text))
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

        private void RadioButton_Checked_34(object sender, RoutedEventArgs e)
        {
            //Mengecek apakah jawaban benar atau salah
            //Jika Benar:
            if (KalUt.Name.Equals(kotaYgBenar.Text))
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
    }
}
