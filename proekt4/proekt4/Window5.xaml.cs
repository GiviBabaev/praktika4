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
    /// Логика взаимодействия для Window5.xaml
    /// </summary>
    public partial class Window5 : Window
    {
        public Window5()
        {
            InitializeComponent();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            int n = int.Parse(vod.Text);

            bool nu = false;
            while (n > 0)
            {
                int digit = n % 10;
                if (digit % 2 == 0)
                {
                    nu = true;
                    break;
                }
                n /= 10;
            }

            otv.Text = Convert.ToString(nu);

        }
    }
}
