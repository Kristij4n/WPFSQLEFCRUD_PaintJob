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
    /// Interaction logic for TechnicalDetailsView.xaml
    /// </summary>
    public partial class TechnicalDetailsView : Window
    {
        public TechnicalDetailsView()
        {
            InitializeComponent();
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Server=WORK-PC\KRISTIJAN;Database=PaintJobDb;User id=sa;Password=test;Integrated Security=True");
                con.Open();
                string add_data = "INSERT INTO [dbo].[TechnicalDetails] VALUES(@WaterInSystem, @AirPressure, @GunAirPressure, @GunPaintFlow, @Temperature)";
                SqlCommand cmd = new SqlCommand(add_data, con);

                cmd.Parameters.AddWithValue("@WaterInSystem", WaterInSystem.Text);
                cmd.Parameters.AddWithValue("@AirPressure", AirPressure.Text);
                cmd.Parameters.AddWithValue("@GunAirPressure", GunAirPressure.Text);
                cmd.Parameters.AddWithValue("@GunPaintFlow", GunPaintFlow.Text);
                cmd.Parameters.AddWithValue("@Temperature", Temperature.Text);

                cmd.ExecuteNonQuery();
                con.Close();
                WaterInSystem.Text = "";
                AirPressure.Text = "";
                GunAirPressure.Text = "";
                GunPaintFlow.Text = "";
                Temperature.Text = "";

                // check code - navigate to adminMain/userMain, close TechDet
                Window window = Window.GetWindow(this);
                if (window.Title == "TechnicalDetailsView")
                    window.Close();


            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
