using System;
using System.Collections.Generic;
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
using PaintJob.View.User;

namespace PaintJob.View.Login
{
    /// <summary>
    /// Interaction logic for LoginView.xaml
    /// </summary>
    public partial class LoginView : Window
    {
        public LoginView()
        {
            InitializeComponent();
        }

        private void UserLogin_Btt_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Server=WORK-PC\KRISTIJAN;Database=PaintJobDb;User id=sa;Password=test;Integrated Security=True");
                con.Open();
                string add_data = "SELECT * FROM [dbo].[Users] where Username = @Username and Password = @Password";
                SqlCommand cmd = new SqlCommand(add_data, con);

                cmd.Parameters.AddWithValue("@Username", Username.Text);
                cmd.Parameters.AddWithValue("@Password", Password.Password);
                cmd.ExecuteNonQuery();
                int Count = Convert.ToInt32(cmd.ExecuteScalar());
                
                con.Close();
                
                Username.Text = "";
                Password.Password = "";

                if (Count > 0)
                {

                    UserMainView UserMainView = new UserMainView();
                    this.Close();
                    UserMainView.Show();

                    //edit to start basic view
                    //StartBasicView StartBasicView = new StartBasicView();
                    //this.Close();
                    //StartBasicView.Show();
                }
                else
                {
                    MessageBox.Show("Password or Username is invalid");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }  

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            AdminLoginView AdminLoginView = new AdminLoginView();
            this.Close();
            AdminLoginView.Show();
        }

        private void Exit_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Application.Current.Shutdown(0);
        }
    }
}
