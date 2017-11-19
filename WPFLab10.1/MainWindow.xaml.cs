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

namespace WPFLab10._1
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

        private void btnBuy_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string shoppinglist = null;
                if ((bool)checkBox.IsChecked)
                {
                    shoppinglist += "Milk ";
                }
                if ((bool)checkBox1.IsChecked)
                {
                    shoppinglist += "Butter ";
                }
                if ((bool)checkBox2.IsChecked)
                {
                    shoppinglist += "Beer ";
                }
                if ((bool)checkBox3.IsChecked)
                {
                    shoppinglist += "Chicken ";
                }
                if ((bool)checkBox4.IsChecked)
                {
                    shoppinglist += "Lemonade ";
                }
                textBlock.Text = shoppinglist;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
