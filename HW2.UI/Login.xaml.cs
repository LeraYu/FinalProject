using System.Windows;
using TP.Core.user;
using TP.UI;

namespace TP.Core
{
    public partial class Login
    {
        private readonly UserRegistry _userRegistry;

        public Login()
        {
            InitializeComponent();


            _userRegistry = new UserRegistry();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            var user = _userRegistry.GetUser(Username.Text, PasswordHelper.GetHash(Password.Password));
            if (user == null)
            {
                MessageBox.Show("Incorrect data");
                Clear();
                return;
            }

            var timeOfEat = new TimeOfEat
            {
                Owner = this
            };

            timeOfEat.ShowDialog();

            Clear();
        }

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            var register = new Register(_userRegistry)
            {

                Owner = this
            };

            register.ShowDialog();

            Clear();
        }

        private void Clear()
        {
            Username.Text = "";
            Password.Password = "";
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}