using System;
using System.Windows;

namespace PrakticheskayaRabota1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double x = double.Parse(inputTextBox.Text);
                double result = 0;

                if (shRadioButton.IsChecked == true)
                {
                    result = Math.Sinh(x);
                }
                else if (x2RadioButton.IsChecked == true)
                {
                    result = Math.Pow(x, 2);
                }
                else if (exRadioButton.IsChecked == true)
                {
                    result = Math.Exp(x);
                }

                outputTextBox.Text = result.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите корректное число.");
            }
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            inputTextBox.Clear();
            outputTextBox.Clear();
        }
    }
}

