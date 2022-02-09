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
    /// Interaction logic for PrepareMaterialView.xaml
    /// </summary>
    public partial class PrepareMaterialView : Window
    {
        public PrepareMaterialView()
        {
            InitializeComponent();
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Server=WORK-PC\KRISTIJAN;Database=PaintJobDb;User id=sa;Password=test;Integrated Security=True");
                con.Open();
                string add_data = "INSERT INTO [dbo].[PrepareMaterial] VALUES(@ColorMl, @ThinnerMl, @HardenerMl)";
                SqlCommand cmd = new SqlCommand(add_data, con);

                cmd.Parameters.AddWithValue("@ColorMl", ColorMl.Text);
                cmd.Parameters.AddWithValue("@ThinnerMl", ThinnerMl.Text);
                cmd.Parameters.AddWithValue("@HardenerMl", HardenerMl.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                ColorMl.Text = "";
                ThinnerMl.Text = "";
                HardenerMl.Text = "";

                // check code - navigate to adminMain/userMain, close PrepareMaterial
                Window window = Window.GetWindow(this);
                if (window.Title == "PrepareMaterialView")
                    window.Close();


            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
