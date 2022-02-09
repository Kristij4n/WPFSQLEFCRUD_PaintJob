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

namespace PaintJob.View.Register
{
    /// <summary>
    /// Interaction logic for RegisterOptionsView.xaml
    /// </summary>
    public partial class RegisterOptionsView : UserControl
    {
        public RegisterOptionsView()
        {
            InitializeComponent();
        }
        private void RegisterUser_Click(object sender, RoutedEventArgs e)
        {
            RegisterUserView RegisterUserView = new RegisterUserView();
            RegisterUserView.Show();

            //check code, close adminMain, open reg user
            Window window = Window.GetWindow(this);
            if (window.Title == "AdminMainView")
                window.Close();

        }

        private void RegisterAdmin_Click(object sender, RoutedEventArgs e)
        {
            RegisterAdminView RegisterAdminView = new RegisterAdminView();
            RegisterAdminView.Show();

            //check code, close adminMain, open reg admin
            Window window = Window.GetWindow(this);
            if (window.Title == "AdminMainView")
                window.Close();

        }
    }
}
