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

namespace PaintJob.View.Job.Manual
{
    /// <summary>
    /// Interaction logic for ManualJobStartView.xaml
    /// </summary>
    public partial class ManualJobStartView : UserControl
    {
        public ManualJobStartView()
        {
            InitializeComponent();
        }

        private void SelectColor_Click(object sender, RoutedEventArgs e)
        {
            SelectColorView SelectColorView = new SelectColorView();
            SelectColorView.Show();
        }
        private void EnterElements_Click(object sender, RoutedEventArgs e)
        {
            EnterElementsView EnterElementsView = new EnterElementsView();
            EnterElementsView.Show();
        }

        private void PrepareMaterial_Click(object sender, RoutedEventArgs e)
        {
            PrepareMaterialView PrepareMaterialView = new PrepareMaterialView();
            PrepareMaterialView.Show();
        }

        private void TechnicalDetails_Click(object sender, RoutedEventArgs e)
        {
            TechnicalDetailsView TechnicalDetailsView = new TechnicalDetailsView();
            TechnicalDetailsView.Show();
        }

        private void WastedMaterial_Click(object sender, RoutedEventArgs e)
        {

        }

    }
}
