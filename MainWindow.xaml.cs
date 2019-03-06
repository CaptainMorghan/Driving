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

namespace _185301Driving
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

        private void btnClickToDrive_Click(object sender, RoutedEventArgs e)
        {
            //local variable
            int age;
            int.TryParse(txtAge.Text, out age);

            if (age >= 16)
            {
                lblOutput.Content = "Go drive off a cliff";
            }
            else 
            {
                lblOutput.Content = "Police officer yeets ass out of the car";
            }
        }
    }
}
