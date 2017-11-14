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

namespace WPFLab09._2
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

        double value1 = 0;
        double value2 = 0;
        private void buyBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (comboBox.Text == "Yhdysvallat USD")
                {
                    payBlock.Text = "Suomi EUR";
                    if (double.TryParse(buyBox.Text, out value1))
                    {
                        value2 = value1 * 0.8997;
                        payBox.Text = value2.ToString("0.00");
                    }
                    else
                    {
                        payBox.Text = "0";
                    }
                }
                else if (comboBox.Text == "Suomi EUR")
                {
                    payBlock.Text = "Yhdysvallat USD";
                    if (double.TryParse(buyBox.Text, out value1))
                    {
                        value2 = value1 / 0.8997;
                        payBox.Text = value2.ToString("0.00");
                    }
                    else
                    {
                        payBox.Text = "0";
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
