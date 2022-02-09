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
using PaintJob.View.Login;

namespace PaintJob.View.Job
{
    /// <summary>
    /// Interaction logic for JobView.xaml
    /// </summary>
    public partial class JobView : UserControl
    {
        public JobView()
        {
            InitializeComponent();
        }

        // this xaml is same as JobBasicInfoView, use for preview test

        private void Logout_Click(object sender, RoutedEventArgs e)
        {
            LoginView LoginView = new LoginView();
            LoginView.Show();
            // check code - navigate to login close start basic ok
            Window window = Window.GetWindow(this);
            if (window.Title == "StartBasicView")
                window.Close();

        }
        private void test_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
