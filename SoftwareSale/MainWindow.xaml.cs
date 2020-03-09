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

namespace SoftwareSale
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        decimal price = 99.0m; // package price
        decimal d1 = 0.2m; // 20% discount
        decimal d2 = 0.3m; // 30% discount
        decimal d3 = 0.4m; // 40% discount
        decimal d4 = 0.5m; // 50% discount
        public MainWindow()
        {
            InitializeComponent();
            quantity.Text = "0";
        }
        private void Order_Click(object sender, RoutedEventArgs e)
        {
            uint numberPackage = uint.Parse(quantity.Text);
            if (numberPackage == 0)
            {
                MessageBox.Show("Input package quantities");
            }
            else
            {
                decimal total = numberPackage * price;
                totalPrice.Content = "Total price $" + total;
                if (numberPackage >= 100)
                {
                    decimal totalDiscount = total * d4; //Calculating discount
                    discount.Content = "Discount $" + totalDiscount;
                    grandTotal.Content = "Total after Discount $" + (total - totalDiscount); //Subtracting discount
                }
                else if (numberPackage >= 50)
                {
                    decimal totalDiscount = total * d3; //Calculating discount
                    discount.Content = "Discount $" + totalDiscount;
                    grandTotal.Content = "Total after Discount $" + (total - totalDiscount); //Subtracting discount
                }
                else if (numberPackage >= 20)
                {
                    decimal totalDiscount = total * d2; //Calculating discount
                    discount.Content = "Discount $" + totalDiscount;
                    grandTotal.Content = "Total after Discount $" + (total - totalDiscount); //Subtracting discount
                }
                else if (numberPackage >= 10)
                {
                    decimal totalDiscount = total * d1; //Calculating discount
                    discount.Content = "Discount $" + totalDiscount;
                    grandTotal.Content = "Total after Discount $" + (total - totalDiscount); //Subtracting discount
                }
                else
                {
                    decimal totalDiscount = total * 0;
                    discount.Content = "Discount $" + totalDiscount;
                    grandTotal.Content = "Total after Discount $" + (total - totalDiscount);
                }
            }
        }
        private void Btn1_Click(object sender, RoutedEventArgs e)
        {
            quantity.Text = "10"; // It will Add 10 to text box
        }

        private void Btn2_Click(object sender, RoutedEventArgs e)
        {
            quantity.Text = "20"; // It will Add 20 to text box
        }

        private void Btn3_Click(object sender, RoutedEventArgs e)
        {
            quantity.Text = "40"; // It will Add 40 to text box
        }

        private void Btn4_Click(object sender, RoutedEventArgs e)
        {
            quantity.Text = "100"; // It will Add 100 to text box
        }
        private void Package_KeyDown(object sender, KeyEventArgs e)  // start check when press the key
        {
            if (e.Key >= Key.D0 && e.Key <= Key.D9 || e.Key == Key.Back) //when a key from 0-9 or back is pressed
            {
                e.Handled = false; //recieve the value of key 
            }
            else
            {
                e.Handled = true; // dont recieve the value of key
            }
        }
    }
}
