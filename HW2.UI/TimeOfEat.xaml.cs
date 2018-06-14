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

namespace TP.UI
{
    /// <summary>
    /// Логика взаимодействия для TimeOfEat.xaml
    /// </summary>
    public partial class TimeOfEat : Window
    {
        public TimeOfEat()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var breakfast = new Breakfast
            {
                Owner = this
            };
            breakfast.ShowDialog();
            Close();
            

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var breakfast = new Breakfast
            {
                Owner = this
            };
            breakfast.ShowDialog();
            Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var breakfast = new Breakfast
            {
                Owner = this
            };
            breakfast.ShowDialog();
            Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
