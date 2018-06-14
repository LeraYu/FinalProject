using TP.Core.transport;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
    /// Логика взаимодействия для Summary.xaml
    /// </summary>
    public partial class Summary : Window
    {
        
        public Summary(System.Collections.IList foods,string ans)
        {
            
            InitializeComponent();

            List<Menu> data = new List<Menu>();


            string connString = @"Data Source = (localdb)\MSSQLLocalDB;" +
            "Initial Catalog = Transport; Integrated Security = True;"
            + "Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False;"
            + " ApplicationIntent = ReadWrite; MultiSubnetFailover = False;";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                string query = "Select Restaurants.RestaurantName, Food.FoodName, PathElements.Price From Restaurants " +
                    "JOIN PathElements ON Restaurants.Id = PathElements.RestaurantId " +
                    "JOIN Food ON Food.Id = PathElements.FoodId " +
                    "WHERE PathElements.Time_TimeOfEat = '" + ans + "' " +
                    "AND (Food.FoodName = '" + foods[0].ToString()+"' ";

                for (int i =1;i<foods.Count;i++)
                {
                    query += " OR Food.FoodName = '" + foods[i].ToString() + "' ";

                }
                query += "); ";
                SqlCommand command = new SqlCommand(query, conn);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Menu menu = new Menu()
                    {
                        restaurantName = reader[0].ToString(),
                        foodName = reader[1].ToString(),
                        price = reader[2].ToString()
                    };
                    data.Add(menu);
                }

                reader.Close();

                conn.Close();
                
                Table.ItemsSource = data;
            }
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Table_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
