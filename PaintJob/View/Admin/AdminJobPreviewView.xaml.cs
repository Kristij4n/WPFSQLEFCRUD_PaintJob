﻿using System;
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
using PaintJob.View.Job;

namespace PaintJob.View.Admin
{
    /// <summary>
    /// Interaction logic for AdminJobPreviewView.xaml
    /// </summary>
    public partial class AdminJobPreviewView : UserControl
    {
        public AdminJobPreviewView()
        {
            InitializeComponent();
        }

        private void test_Click(object sender, RoutedEventArgs e)
        {
            MainWindow MainWindow = new MainWindow();
            MainWindow.Show();
        }
    }
}
