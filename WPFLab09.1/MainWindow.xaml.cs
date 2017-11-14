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

namespace WPFLab09._1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        int trucks = 0;
        private void btnTruck_Click(object sender, RoutedEventArgs e)
        {
            trucks++;
            string truck = trucks.ToString();
            txbTruck.Text = truck;
        }

        int cars = 0;
        private void btnCar_Click(object sender, RoutedEventArgs e)
        {
            cars++;
            string car = cars.ToString();
            txbCar.Text = car;
        }
    }
}
