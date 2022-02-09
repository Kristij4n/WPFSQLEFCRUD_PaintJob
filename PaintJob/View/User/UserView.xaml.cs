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
using PaintJob.View.Admin;

namespace PaintJob.View.User
{
    /// <summary>
    /// Interaction logic for UserView.xaml
    /// </summary>
    public partial class UserView : UserControl
    {
        public UserView()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            AdminMainView AdminMainView = new AdminMainView();
            AdminMainView.Show();
            // check code - navigate to adminMain, close user
            Window window = Window.GetWindow(this);
            if (window.Title == "UserViewWindow")
                window.Close();
        }

        private void ResetError_Click(object sender, RoutedEventArgs e)
        {
            UserViewWindow UserViewWindow = new UserViewWindow();
            UserViewWindow.Show();
            // check code - reopen
            Window window = Window.GetWindow(this);
            if (window.Title == "UserViewWindow")
                window.Close();
        }
    }
}
