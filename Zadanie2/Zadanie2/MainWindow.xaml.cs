using System;
using System.Windows;
using System.Windows.Controls;

namespace Zadanie2
{
    public partial class MainWindow : Window
    {
        private double _lastNumber, _result;
        private SelectedOperator _selectedOperator;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void NumberButton_Click(object sender, RoutedEventArgs e)
        {
            int selectedValue = int.Parse((sender as Button).Content.ToString());

            if (CurrentInput.Text == "0")
                CurrentInput.Text = $"{selectedValue}";
            else
                CurrentInput.Text += $"{selectedValue}";
        }

        private void OperatorButton_Click(object sender, RoutedEventArgs e)
        {
            _lastNumber = double.Parse(CurrentInput.Text);
            CurrentInput.Text = "0";

            if (sender == this.DivideButton)
                _selectedOperator = SelectedOperator.Division;
            if (sender == this.MultiplyButton)
                _selectedOperator = SelectedOperator.Multiplication;
            if (sender == this.SubtractButton)
                _selectedOperator = SelectedOperator.Subtraction;
            if (sender == this.AddButton)
                _selectedOperator = SelectedOperator.Addition;
            if (sender == this.ModuloButton)
                _selectedOperator = SelectedOperator.Modulo;
            if (sender == this.PowerButton)
                _selectedOperator = SelectedOperator.Power;

            PreviousOperation.Text = $"{_lastNumber} {((Button)sender).Content}";
        }

        private void EqualButton_Click(object sender, RoutedEventArgs e)
        {
            double newNumber;
            if (!double.TryParse(CurrentInput.Text, out newNumber))
            {
                MessageBox.Show("Niewłaściwe dane", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            switch (_selectedOperator)
            {
                case SelectedOperator.Addition:
                    _result = SimpleMath.Add(_lastNumber, newNumber);
                    break;
                case SelectedOperator.Subtraction:
                    _result = SimpleMath.Subtract(_lastNumber, newNumber);
                    break;
                case SelectedOperator.Multiplication:
                    _result = SimpleMath.Multiply(_lastNumber, newNumber);
                    break;
                case SelectedOperator.Division:
                    _result = SimpleMath.Divide(_lastNumber, newNumber);
                    break;
                case SelectedOperator.Modulo:
                    _result = SimpleMath.Modulo(_lastNumber, newNumber);
                    break;
                case SelectedOperator.Power:
                    _result = SimpleMath.Power(_lastNumber, newNumber);
                    break;
            }

            CurrentInput.Text = _result.ToString();
            PreviousOperation.Text = "";
        }

        private void FunctionButton_Click(object sender, RoutedEventArgs e)
        {
            double result;
            double number = double.Parse(CurrentInput.Text);

            if (sender == this.SquareRootButton)
            {
                result = Math.Sqrt(number);
                CurrentInput.Text = result.ToString();
            }
            else if (sender == this.ReciprocalButton)
            {
                result = 1 / number;
                CurrentInput.Text = result.ToString();
            }
            else if (sender == this.FactorialButton)
            {
                result = Factorial(number);
                CurrentInput.Text = result.ToString();
            }
            else if (sender == this.LogButton)
            {
                result = Math.Log10(number);
                CurrentInput.Text = result.ToString();
            }
            else if (sender == this.LnButton)
            {
                result = Math.Log(number);
                CurrentInput.Text = result.ToString();
            }

            PreviousOperation.Text = $"{((Button)sender).Content}({number})";
        }

        private void ClearEntryButton_Click(object sender, RoutedEventArgs e)
        {
            CurrentInput.Text = "0";
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            CurrentInput.Text = "0";
            PreviousOperation.Text = "";
            _lastNumber = 0;
            _result = 0;
        }

        private void BackspaceButton_Click(object sender, RoutedEventArgs e)
        {
            if (CurrentInput.Text.Length > 1)
                CurrentInput.Text = CurrentInput.Text.Substring(0, CurrentInput.Text.Length - 1);
            else
                CurrentInput.Text = "0";
        }

        private double Factorial(double number)
        {
            if (number < 0)
                throw new ArgumentException("Liczby ujemne nie są dozwolone w przypadku silni");

            if (number == 0)
                return 1;
            // konwersja do int ( zaokraglenie )
            double result = 1;
            for (int i = 1; i <= (int)number; i++)
                result *= i;

            return result;
        }
    }

    public enum SelectedOperator
    {
        Addition,
        Subtraction,
        Multiplication,
        Division,
        Modulo,
        Power
    }

    public class SimpleMath
    {
        public static double Add(double n1, double n2)
        {
            return n1 + n2;
        }

        public static double Subtract(double n1, double n2)
        {
            return n1 - n2;
        }

        public static double Multiply(double n1, double n2)
        {
            return n1 * n2;
        }

        public static double Divide(double n1, double n2)
        {
            if (n2 == 0)
                throw new DivideByZeroException();

            return n1 / n2;
        }

        public static double Modulo(double n1, double n2)
        {
            if (n2 == 0)
                throw new DivideByZeroException();

            return n1 % n2;
        }

        public static double Power(double n1, double n2)
        {
            return Math.Pow(n1, n2);
        }
    }
}
