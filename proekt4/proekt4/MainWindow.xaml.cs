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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace proekt4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window1 window1 = new Window1();
            window1.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Window2 window2 = new Window2();
            window2.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Window3 window3 = new Window3();
            window3.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Window4 window4 = new Window4();
            window4.Show();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Window5 window5 = new Window5();
            window5.Show();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            int unit = int.Parse(vod.Text);
            double weight = int.Parse(vod2.Text);

            double kilograms;
            switch (unit)
            {
                case 1:
                    kilograms = weight;
                    break;
                case 2:
                    kilograms = weight / 1000000;
                    break;
                case 3:
                    kilograms = weight / 1000;
                    break;
                case 4:
                    kilograms = weight * 1000;
                    break;
                case 5:
                    kilograms = weight * 100;
                    break;
                default:
                    kilograms = 0;
                    break;
            }

            otv.Text=("Масса тела в килограммах: " + kilograms);
        }
    }
}
