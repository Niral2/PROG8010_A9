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

namespace CarInfo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ViewModel vm = new ViewModel();
        public MainWindow()
        {
            InitializeComponent();
            DataContext = vm;
        }
        private void Label_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!char.IsDigit(e.Text, e.Text.Length - 1))
            {
                e.Handled = true;
            }
        }

        private void btnCreateCar(object sender, RoutedEventArgs e)
        {
            if (vm.Make != "")
            {
                vm.CreateCar();
            } else
            {
                MessageBox.Show("Please enter a Make for your vehicle!");
            }
        }

        private void btnAccelerate(object sender, RoutedEventArgs e)
        {
            bool success = vm.AccelerateCar();
            warnNoCar(success);
        }

        private void btnDecelerate(object sender, RoutedEventArgs e)
        {
            bool success = vm.DecelerateCar();
            warnNoCar(success);
        }
        private void warnNoCar(bool success)
        {
            if (!success)
            {
                MessageBox.Show("Please create a car before you can drive!");
            }
        }
    }
}
