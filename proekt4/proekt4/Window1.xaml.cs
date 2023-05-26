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
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            int n = int.Parse(vod.Text);
            int m = int.Parse(vod2.Text);

            string rank;
            switch (n)
            {
                case 6:
                    rank = "шестерка";
                    break;
                case 7:
                    rank = "семерка";
                    break;
                case 8:
                    rank = "восьмерка";
                    break;
                case 9:
                    rank = "девятка";
                    break;
                case 10:
                    rank = "десятка";
                    break;
                case 11:
                    rank = "валет";
                    break;
                case 12:
                    rank = "дама";
                    break;
                case 13:
                    rank = "король";
                    break;
                case 14:
                    rank = "туз";
                    break;
                default:
                    rank = "";
                    break;
            }

            string suit;
            switch (m)
            {
                case 1:
                    suit = "пик";
                    break;
                case 2:
                    suit = "треф";
                    break;
                case 3:
                    suit = "бубен";
                    break;
                case 4:
                    suit = "червей";
                    break;
                default:
                    suit = "";
                    break;
            }

           otv.Text=(rank + " " + suit);
        }
    }
}
