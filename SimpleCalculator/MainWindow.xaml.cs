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
using System.Text.RegularExpressions;
using Logic;

namespace SimpleCalculator
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

        private void btnPlus_Click(object sender, RoutedEventArgs e)
        {
            txtResultat.Text = (Calculate.Calc(Convert.ToInt32(txtZahl1.Text), Convert.ToInt32(txtZahl2.Text), OperatorEnum.plus)).ToString();
            btnAbspeichern.IsEnabled = true;
        }

        private void btnMinus_Click(object sender, RoutedEventArgs e)
        {
            txtResultat.Text = (Calculate.Calc(Convert.ToInt32(txtZahl1.Text), Convert.ToInt32(txtZahl2.Text), OperatorEnum.minus)).ToString();
            btnAbspeichern.IsEnabled = true;
        }

        private void btnMal_Click(object sender, RoutedEventArgs e)
        {
            txtResultat.Text = (Calculate.Calc(Convert.ToInt32(txtZahl1.Text), Convert.ToInt32(txtZahl2.Text), OperatorEnum.mal)).ToString();
            btnAbspeichern.IsEnabled = true;
        }

        private void btnDurch_Click(object sender, RoutedEventArgs e)
        {
            txtResultat.Text = (Calculate.Calc(Convert.ToInt32(txtZahl1.Text), Convert.ToInt32(txtZahl2.Text), OperatorEnum.durch)).ToString();
            btnAbspeichern.IsEnabled = true;
        }

        private void txtZahl1_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void txtZahl2_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
    }
}
