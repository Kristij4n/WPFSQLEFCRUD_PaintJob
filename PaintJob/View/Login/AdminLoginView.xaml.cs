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

namespace PaintJob.View.Login
{
    /// <summary>
    /// Interaction logic for AdminLoginView.xaml
    /// </summary>
    public partial class AdminLoginView : Window
    {
        public AdminLoginView()
        {
            InitializeComponent();
        }

        private void Login_Btt_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Server=WORK-PC\KRISTIJAN;Database=PaintJobDb;User id=sa;Password=test;Integrated Security=True");
                con.Open();
                string add_data = "SELECT * FROM [dbo].[Admin] where Administrator = @Administrator and Password = @Password";
                SqlCommand cmd = new SqlCommand(add_data, con);

                cmd.Parameters.AddWithValue("@Administrator", Administrator.Text);
                cmd.Parameters.AddWithValue("@Password", Password.Password);
                cmd.ExecuteNonQuery();
                int Count = Convert.ToInt32(cmd.ExecuteScalar());

                con.Close();

                Administrator.Text = "";
                Password.Password = "";

                if (Count > 0)
                {
                    AdminMainView AdminMainView = new AdminMainView();
                    this.Close();
                    AdminMainView.Show();
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
    }
}
