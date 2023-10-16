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

namespace WpfApp10
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private double? firstNum = null;
        public string operation = null;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void funeral(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            txtbox1.Text += button.Content;
        }
        

        private void Operation_Click(object sender, RoutedEventArgs e)
        {
            if (firstNum == null)
            {
                firstNum = Convert.ToDouble(txtbox1.Text);
                Button button = (Button)sender;
                operation = button.Content.ToString();
                txtbox1.Text += operation;
            }
        }

        private void clear(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            if (button.Content.ToString() == "CE")
            {
                txtbox1.Text = "";
            }
            else
            {
                txtbox1.Text = "";
                txtbox2.Text = "";
                firstNum = null;
                operation = null;
            }
        }

        private void Equals_Click(object sender, RoutedEventArgs e)
        {
            if (firstNum != null)
            {
                double secondNum;
                if (operation != null)
                {
                    secondNum = Convert.ToDouble(txtbox1.Text.Substring(firstNum.ToString().Length + 1));
                }
                else
                {
                    secondNum = Convert.ToDouble(txtbox1.Text);
                }

                switch (operation)
                {
                    case "+":
                        txtbox2.Text = (firstNum + secondNum).ToString();
                        break;
                    case "-":
                        txtbox2.Text = (firstNum - secondNum).ToString();
                        break;
                    case "*":
                        txtbox2.Text = (firstNum * secondNum).ToString();
                        break;
                    case "/":
                        if (secondNum != 0)
                            txtbox2.Text = (firstNum / secondNum).ToString();
                        else
                            txtbox2.Text = "Error";
                        break;
                }
                firstNum = null;
                operation = null;
            }
        }

        private void Backspace_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtbox1.Text))
            {
                txtbox1.Text = txtbox1.Text.Remove(txtbox1.Text.Length - 1);
            }
        }

        private void btn_Convert(object sender, RoutedEventArgs e)
        {
            if (!txtbox1.Text.Contains(","))
            {
                if (string.IsNullOrEmpty(txtbox1.Text))
                {
                    txtbox1.Text = "0,";
                }
                else
                {
                    txtbox1.Text += ",";
                }
            }
        }

    }
}
