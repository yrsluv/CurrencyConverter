using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
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

namespace CurrencyConverter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            BindCurrency();
        }

        private void BindCurrency()
        {
            DataTable dtCurrency = new DataTable();
            dtCurrency.Columns.Add("Text");
            dtCurrency.Columns.Add("Value");

            dtCurrency.Rows.Add("--SELECT--", 0);
            dtCurrency.Rows.Add("RUB", 1);
            dtCurrency.Rows.Add("USD", 56);
            dtCurrency.Rows.Add("EUR", 57);
            dtCurrency.Rows.Add("AZN", 33);
            dtCurrency.Rows.Add("GBP", 70);

            cmbFromCurrency.ItemsSource = dtCurrency.DefaultView;
            cmbFromCurrency.DisplayMemberPath = "Text";
            cmbFromCurrency.SelectedValuePath = "Value";
            cmbFromCurrency.SelectedIndex = 0;

            cmbToCurrency.ItemsSource = dtCurrency.DefaultView;
            cmbToCurrency.DisplayMemberPath = "Text";
            cmbToCurrency.SelectedValuePath = "Value";
            cmbToCurrency.SelectedIndex = 0;

        }

        private void txtCurrency_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtСonvertedCurrency_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void cmbFromCurrency_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void cmbToCurrency_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Convert_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {

        }

        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {

        }

        private void СonvertedNumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {

        }
    }
}
