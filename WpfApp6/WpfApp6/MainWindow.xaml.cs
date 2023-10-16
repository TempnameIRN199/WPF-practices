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

namespace WpfApp6
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            Win1 win1 = new Win1();
            Win2 win2 = new Win2();
            Win3 win3 = new Win3();
            Win4 win4 = new Win4();
            switch (btn.Content.ToString())
            {
                case "First":
                    win1.Title = "First";
                    win1.Show();
                    break;
                case "Second":
                    win2.Title = "Second";
                    win2.Show();
                    break;
                case "Third":
                    win3.Title = "Third";
                    win3.Show();
                    break;
                case "Fourth":
                    win4.Title = "Fourth";
                    win4.Show();
                    break;
            }
        }
    }
}
