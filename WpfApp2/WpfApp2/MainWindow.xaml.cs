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

namespace WpfApp2
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

        private void Click(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            Win1 w1 = new Win1();
            Win2 w2 = new Win2();
            Win3 w3 = new Win3();
            Win4 w4 = new Win4();
            Win5 w5 = new Win5();
            switch (b.Content.ToString())
            {
                case "Lab 1":
                    w1.Title = "Lab 1";
                    w1.Show();
                    break;
                case "Lab 2":
                    w2.Title = "Lab 2";
                    w2.Show();
                    break;
                case "Lab 3":
                    w3.Title = "Lab 3";
                    w3.Show();
                    break;
                case "Lab 4":
                    w4.Title = "Lab 4";
                    w4.Show();
                    break;
                case "Lab 5":
                    w5.Title = "Lab 5";
                    w5.Show();
                    break;
                default:
                    break;
            }
        }
    }
}
