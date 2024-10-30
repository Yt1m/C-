using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System;
using System.Threading.Tasks;


namespace PowerCalculator
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(NumberInput.Text, out double number) &&
                int.TryParse(PowerInput.Text, out int power))
            {
                ResultTextBlock.Text = "Вычисляется...";

                double result = await CalculatePowerAsync(number, power);

                ResultTextBlock.Text = $"Результат: {result}";
            }
            else
            {
                ResultTextBlock.Text = "Введите корректные значения.";
            }
        }

        private Task<double> CalculatePowerAsync(double number, int power)
        {
            return Task.Run(() => Math.Pow(number, power));
        }
    }
}
