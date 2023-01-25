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

namespace LidiaMadeTours.UserControls
{
    /// <summary>
    /// Interaction logic for ControlTemplatesDemo.xaml
    /// </summary>
    public partial class ControlTemplatesDemo : UserControl
    {
        public ControlTemplatesDemo()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            MessageTextBlock.Text = "Cancel";
        }

        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            MessageTextBlock.Text = "OK";
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            MessageTextBlock.Text = "Save";
        }
    }
}
