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

namespace PaintJob.View.Admin
{
    /// <summary>
    /// Interaction logic for AdminView.xaml
    /// </summary>
    public partial class AdminView : UserControl
    {
        public AdminView()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            AdminMainView AdminMainView = new AdminMainView();
            AdminMainView.Show();
            // check code - navigate to adminMain, close admin
            Window window = Window.GetWindow(this);
            if (window.Title == "AdminViewWindow")
                window.Close();
        }

        private void ResetError_Click(object sender, RoutedEventArgs e)
        {
            AdminViewWindow AdminViewWindow = new AdminViewWindow();
            AdminViewWindow.Show();
            // check code - reopen
            Window window = Window.GetWindow(this);
            if (window.Title == "AdminViewWindow")
                window.Close();
        }
    }
}
