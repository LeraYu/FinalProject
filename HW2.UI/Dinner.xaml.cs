using TP.Core;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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
    /// Логика взаимодействия для Dinner.xaml
    /// </summary>
    public partial class Dinner : Window
    {
        public Dinner()
        {
            InitializeComponent();
            Context context = new Context();
            context.Food.Load();
            var smth = context.Food.Local;
            var list = smth.ToBindingList();
            foreach (var temp in list)
            {
                Menu.Items.Add(temp.FoodName);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var summary = new Summary(Menu.SelectedItems, "Dinner")
            {
                Owner = this
            };

            summary.ShowDialog();

            Close();
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
