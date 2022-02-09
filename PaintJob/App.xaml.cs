using PaintJob.View;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using PaintJob.View.Login;

namespace PaintJob
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            // show login on startup

            LoginView LoginView = new LoginView();
            LoginView.Show();
        }
    }
}
