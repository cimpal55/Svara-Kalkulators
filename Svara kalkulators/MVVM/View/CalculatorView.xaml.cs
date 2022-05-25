using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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



namespace Svara_kalkulators.MVVM.View
{
    /// <summary>
    /// Логика взаимодействия для HomeView.xaml
    /// </summary>
    public partial class CalculatorView : UserControl
    {
        public CalculatorView()
        {
            InitializeComponent();
        }
        private void ModesBtn_Click(object sender, RoutedEventArgs e)
        {
            if (sender.Equals(PlusBtn))
            {
                Text_Mode.Foreground = Brushes.PaleGreen; ;
                Text_Mode.Text = "Plus";
            }
            else if (sender.Equals(MinusBtn))
            {
                Text_Mode.Foreground = Brushes.PaleVioletRed;
                Text_Mode.Text = "Minus";
            }
        }
        private new void PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        float Summ = 0;
        private void CalculateBtn_Click(object sender, RoutedEventArgs e)
        {
            if (Enter.Text.Length < 12)
            {
                MessageBox.Show("Barcode is incorrect. It should consist of 12 numbers.", "Barcode error", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
                string Weight = Enter.Text.Substring(8);

                string FirstDigits = Enter.Text.Substring(0, 2);

                if (Text_Mode.Text == "Plus")
                {
                    if (FirstDigits == "25")
                    {
                        Summ += float.Parse(Weight) / 10;

                    }
                    else if (FirstDigits == "24")
                    {
                        Summ += float.Parse(Weight) / 100;
                    }
                    else if (FirstDigits == "23")
                    {
                        Summ += float.Parse(Weight) / 1000;
                    }
                    else
                    {
                        MessageBox.Show("Barcode should begin from 25, 24 or 23. Try one more time.", "Barcode error", MessageBoxButton.OK, MessageBoxImage.Warning);
                    }
                }

                else if (Text_Mode.Text == "Minus")
                {
                    if (FirstDigits == "25")
                    {
                        Summ -= float.Parse(Weight) / 10;
                    }
                    else if (FirstDigits == "24")
                    {
                        Summ -= float.Parse(Weight) / 100;
                    }
                    else if (FirstDigits == "23")
                    {
                        Summ -= float.Parse(Weight) / 1000;
                    }
                    else
                    {
                        MessageBox.Show("Barcode should begin from 25, 24 or 23. Try one more time.", "Barcode error", MessageBoxButton.OK, MessageBoxImage.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Select a mode.", "Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }

            if (Summ < 0)
            {
                Summ = 0;
            }
            Summary.Text = Convert.ToString(Summ);
        }

        private void ResetBtn_Click(object sender, RoutedEventArgs e)
        {
            Summ = 0;
            Summary.Text = Convert.ToString(Summ);
        }
    }
}
