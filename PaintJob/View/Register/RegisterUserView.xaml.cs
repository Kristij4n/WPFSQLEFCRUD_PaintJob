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
using PaintJob.View.Admin;

namespace PaintJob.View.Register
{
    /// <summary>
    /// Interaction logic for RegisterUserView.xaml
    /// </summary>
    public partial class RegisterUserView : Window
    {
        public RegisterUserView()
        {
            InitializeComponent();
        }

        private void Register_Btt_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Server=WORK-PC\KRISTIJAN;Database=PaintJobDb;User id=sa;Password=test;Integrated Security=True");
                con.Open();
                string add_data = "INSERT INTO [dbo].[Users] VALUES(@Username, @Password)";
                SqlCommand cmd = new SqlCommand(add_data, con);

                cmd.Parameters.AddWithValue("@Username", Username.Text);
                cmd.Parameters.AddWithValue("@Password", Password.Password);
                cmd.ExecuteNonQuery();
                con.Close();
                Username.Text = "";
                Password.Password = "";

                AdminMainView AdminMainView = new AdminMainView();
                this.Close();
                AdminMainView.Show();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
