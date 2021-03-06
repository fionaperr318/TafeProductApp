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

namespace ProductApps
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Product cProduct;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                decimal myPayment;
                cProduct = new Product(Convert.ToDecimal(priceTextBox.Text), Convert.ToInt16(quantityTextBox.Text));
                cProduct.calTotalPayment();

                double totalPayment;


                myPayment = cProduct.calTotalPayment();

                decimal.ToDouble(myPayment);

                totalPayment = (decimal.ToDouble(myPayment) + 25.00 + 5.00) * 1.1;

                totalPaymentTextBlock.Text = (myPayment + 25.00m).ToString();
                totalPaymentTextBlock.Text = Convert.ToString(cProduct.TotalPayment);
                totalChargeAfterWrap.Text = (myPayment + 25.00m+5.00m).ToString();
                totalChargeAfterWrap.Text = Convert.ToString(cProduct.TotalPayment);
                totalChargeAfterGST.Text = (totalPayment*1.1).ToString();
                totalChargeAfterGST.Text = Convert.ToString(cProduct.TotalPayment);

            }
            catch (FormatException)
            {
                MessageBox.Show("Enter data again", "Data Entry Error");
            }
        }

        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            productTextBox.Text = "";
            priceTextBox.Text = "";
            quantityTextBox.Text = "";
            totalPaymentTextBlock.Text = "";
        }

        private void closeButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
