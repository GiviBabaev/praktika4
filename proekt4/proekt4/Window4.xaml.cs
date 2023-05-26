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

namespace proekt4
{
    /// <summary>
    /// Логика взаимодействия для Window4.xaml
    /// </summary>
    public partial class Window4 : Window
    {
        public Window4()
        {
            InitializeComponent();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            double p = double.Parse(vod.Text);
            double distance = double.Parse(vod2.Text);
            double totalDistance = double.Parse(vod3.Text);
            int day = 1;
            while (totalDistance <= 200)
            {
                distance *= (1 + p / 100);
                totalDistance += distance;
                day++;
            }

            otv.Text=("После " + day + " дней суммарный пробег лыжника за все дни превысит 200 км");
            otv.Text = ("Суммарный пробег: " + totalDistance);

        }
    }
}
