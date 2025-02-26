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

namespace ShoesShop.Pages
{
    /// <summary>
    /// Логика взаимодействия для LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            if (LoginTextBox.Text != "" || PasswordBox.Password != "")
            {
                var UserInfo = SneakerShopIREntities.GetContext().Stuff.FirstOrDefault(x => x.Login == LoginTextBox.Text && x.Password == PasswordBox.Password);
                if(UserInfo != null)
                {
                    MessageBox.Show($"Добро пожаловать, {UserInfo.Roles.RoleName}, {UserInfo.FirstName} {UserInfo.SecondName}");
                    Classes.AppConnect.user = SneakerShopIREntities.GetContext().Stuff.Where(x => x.Login == LoginTextBox.Text).FirstOrDefault();
                    Classes.Manager.ManFrame.Navigate(new AddEDitPage());
                }
                else
                {
                    MessageBox.Show("Неправильный пароль или логин");
                }
            }
            else
            {
                MessageBox.Show("Не введены пароль или логин");
            }
        }
    }
}
