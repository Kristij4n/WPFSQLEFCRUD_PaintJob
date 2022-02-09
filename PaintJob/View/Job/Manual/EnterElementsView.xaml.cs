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
    /// Interaction logic for EnterElementsView.xaml
    /// </summary>
    public partial class EnterElementsView : Window
    {
        public EnterElementsView()
        {
            InitializeComponent();
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Server=WORK-PC\KRISTIJAN;Database=PaintJobDb;User id=sa;Password=test;Integrated Security=True");
                con.Open();
                string add_data = "INSERT INTO [dbo].[Elements] VALUES(@ConstructionName, @ConstructionNumber, @ElementsNumber)";
                SqlCommand cmd = new SqlCommand(add_data, con);

                cmd.Parameters.AddWithValue("@ConstructionName", ConstructionName.Text);
                cmd.Parameters.AddWithValue("@ConstructionNumber", ConstructionNumber.Text);
                cmd.Parameters.AddWithValue("@ElementsNumber", ElementsNumber.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                ConstructionName.Text = "";
                ConstructionNumber.Text = "";
                ElementsNumber.Text = "";

                // check code - navigate to adminMain/userMain, close enterElements
                Window window = Window.GetWindow(this);
                if (window.Title == "EnterElementsView")
                    window.Close();


            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
