﻿using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NusantaraGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //SoalController pc = new SoalController();
            //IEnumerable<Provinsi> provinsis = pc.GetAllData();
            //foreach (var item in provinsis)
            //{
            //    MessageBox.Show(item.ToString());
            //}
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Level level = new Level();
            level.Show();
            this.Hide();
        }


    }
}
