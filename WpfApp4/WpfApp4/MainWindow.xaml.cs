using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
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

namespace WpfApp4
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

        private void MenuItemColor_Click(object sender, RoutedEventArgs e) {

            MenuItem mi = (MenuItem)sender;
            string color = mi.Header.ToString();

            switch (color) {
                case "Червоний":
                    txtb1.Foreground = Brushes.Red;
                    break;
                case "Зелений":
                    txtb1.Foreground = Brushes.Green;
                    break;
                case "Синій":
                    txtb1.Foreground = Brushes.Blue;
                    break;
                case "Чорний":
                    txtb1.Foreground = Brushes.Black;
                    break;
                case "Рожевий":
                    txtb1.Foreground = Brushes.Pink;
                    break;
                case "Фіолетовий":
                    txtb1.Foreground = Brushes.Purple;
                    break;
                default:
                    break;
            }
        }

        private void MenuItemProperties_Click(object sender, RoutedEventArgs e) {

            MenuItem menuItem = (MenuItem)sender;

            if (menuItem != null) {

                string propertyName = menuItem.Header.ToString();
                FontWeight fontWeight = txtb1.FontWeight;
                FontStyle fontStyle = txtb1.FontStyle;
                TextDecorationCollection textDecorations = txtb1.TextDecorations;

                if (propertyName == "Жирний") {
                    if (fontWeight == FontWeights.Bold) {
                        fontWeight = FontWeights.Normal;
                    }
                    else {
                        fontWeight = FontWeights.Bold;
                    }
                }
                else if (propertyName == "Курсив") {
                    if (fontStyle == FontStyles.Italic) {
                        fontStyle = FontStyles.Normal;
                    }
                    else {
                        fontStyle = FontStyles.Italic;
                    }
                }
                else if (propertyName == "Підкреслений") {
                    if (textDecorations.Count > 0) {
                        textDecorations.Clear();
                    }
                    else {
                        textDecorations.Add(TextDecorations.Underline);
                    }
                }

                txtb1.FontWeight = fontWeight;
                txtb1.FontStyle = fontStyle;
                txtb1.TextDecorations = textDecorations;
            }

        }

        private void MenuItemPenSize_Click(object sender, RoutedEventArgs e) {

            MenuItem menuItem = (MenuItem)sender;

            if (menuItem != null) {

                string header = menuItem.Header.ToString();
                double size = Convert.ToDouble(header);
                
                if (double.TryParse(header, out size))
                {
                    txtb1.FontSize = size;
                }
            }
        }
        private void MenuItemTransparency_Click(object sender, RoutedEventArgs e)
        {
            MenuItem menuItem = sender as MenuItem;
            if (menuItem != null)
            {
                string header = menuItem.Header.ToString();
                double opacity;

                // Спробуйте конвертувати вибраний рівень прозорості в число
                if (double.TryParse(header.Replace("%", ""), out opacity))
                {
                    // Перетворіть відсоток у дійсне значення від 0 до 1
                    opacity = opacity / 100;

                    // Встановіть новий рівень прозорості для вашого TextBox
                    txtb1.Opacity = opacity;
                }
            }
        }


    }
}
