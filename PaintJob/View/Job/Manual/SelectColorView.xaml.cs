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

namespace PaintJob.View.Job.Manual
{
    /// <summary>
    /// Interaction logic for SelectColorView.xaml
    /// </summary>
    public partial class SelectColorView : Window
    {
        public SelectColorView()
        {
            InitializeComponent();
            //Test -- cmbColors.ItemsSource = typeof(Colors).GetProperties();
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {            
            try
            {
                SqlConnection con = new SqlConnection(@"Server=WORK-PC\KRISTIJAN;Database=PaintJobDb;User id=sa;Password=test;Integrated Security=True");
                con.Open();
                string add_data = "INSERT INTO [dbo].[Colors] VALUES(@Color)";
                SqlCommand cmd = new SqlCommand(add_data, con);
            
                cmd.Parameters.AddWithValue("@Color", Color.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                Color.Text = "";          
            
                // check code - navigate to adminMain/userMain, close selectColorView
                Window window = Window.GetWindow(this);
                if (window.Title == "SelectColorView")
                    window.Close();
            
            
            }
            catch (Exception ex)
            {
                throw ex;
            }

            // Test
            //try
            //{
            //    SqlConnection con = new SqlConnection(@"Server=WORK-PC\KRISTIJAN;Database=PaintJobDb;User id=sa;Password=test;Integrated Security=True");
            //    con.Open();
            //    string add_data = "INSERT INTO [dbo].[Colors] VALUES(@cmbColors)";
            //    SqlCommand cmd = new SqlCommand(add_data, con);
            //
            //    cmd.Parameters.AddWithValue("@cmbColors", cmbColors.Text);
            //    cmd.ExecuteNonQuery();
            //    con.Close();
            //    cmbColors.Text = "";
            //
            //    //AdminMainView AdminMainView = new AdminMainView();
            //    //this.Close();
            //    //AdminMainView.Show();
            //
            //    // check code - navigate to adminMain, close admin
            //    Window window = Window.GetWindow(this);
            //    if (window.Title == "SelectColorView")
            //        window.Close();
            //
            //
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}

        }
    }
}
