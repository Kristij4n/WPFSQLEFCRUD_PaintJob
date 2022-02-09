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
using PaintJob.View.User;

namespace PaintJob.View.Admin
{
    /// <summary>
    /// Interaction logic for AccountsView.xaml
    /// </summary>
    public partial class AccountsView : UserControl
    {


        public AccountsView()
        {
            InitializeComponent();
        }

        private void UserPreview_Click(object sender, RoutedEventArgs e)
        {
            UserViewWindow UserViewWindow = new UserViewWindow();
            UserViewWindow.Show();

            //check code, close adminMain, open user
            Window window = Window.GetWindow(this);
            if (window.Title == "AdminMainView")
                window.Close();

        }

        private void AdminPreview_Click(object sender, RoutedEventArgs e)
        {
            AdminViewWindow AdminViewWindow = new AdminViewWindow();
            AdminViewWindow.Show();

            //check code, close adminMain, open admin
            Window window = Window.GetWindow(this);
            if (window.Title == "AdminMainView")
                window.Close();

        }
    }
}
