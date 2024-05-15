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

using System.Windows;

namespace Calculator
{
    public partial class MainWindow : Window
    {
        private string currentInput = string.Empty;
        private char? currentOperator = null;
        private double result = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Number_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            currentInput += button.Content.ToString();
            InputTextBox.Text = currentInput;
        }

        private void Operator_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            currentOperator = button.Content.ToString()[0];
            result = double.Parse(currentInput);
            currentInput = string.Empty;
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            currentInput = string.Empty;
            currentOperator = null;
            result = 0;
            InputTextBox.Text = string.Empty;
        }

        private void Equal_Click(object sender, RoutedEventArgs e)
        {
            if (currentOperator != null)
            {
                switch (currentOperator)
                {
                    case '+':
                        result += double.Parse(currentInput);
                        break;
                    case '-':
                        result -= double.Parse(currentInput);
                        break;
                    case '*':
                        result *= double.Parse(currentInput);
                        break;
                    case '/':
                        result /= double.Parse(currentInput);
                        break;
                }
                InputTextBox.Text = result.ToString();
                currentInput = string.Empty;
                currentOperator = null;
            }
        }
    }
}

