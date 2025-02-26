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
    /// Логика взаимодействия для AddEDitPage.xaml
    /// </summary>
    public partial class AddEDitPage : Page
    {
        public AddEDitPage()
        {
            InitializeComponent();
            RoleNameText.Text = $"{Classes.AppConnect.user.Roles.RoleName}";
            NameText.Text = $"{Classes.AppConnect.user.FirstName} {Classes.AppConnect.user.SecondName}";
        }

        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            Classes.Manager.ManFrame.Navigate(new LoginPage());
        }

        private void OrdersBtn_Click(object sender, RoutedEventArgs e)
        {
            MenuFrame.Navigate(new OrdersPage());
        }
    }
}
