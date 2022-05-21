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
            } else if (sender.Equals(MinusBtn)) {
                Text_Mode.Foreground = Brushes.PaleVioletRed;
                Text_Mode.Text = "Minus";
            }
        }
        private void PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
        private void CalculateBtn_Click(object sender, RoutedEventArgs e)
        {
            string Input = (TextBox)TextBlock.Resources["Enter"];

            MessageBox.Show(Input);

            string Weight = Input.Substring(8);

            string FirstDigits = Input.Substring(0, 2);

            if (Text_Mode.Text == "Plus")
            {
                if (FirstDigits == "25")
                {
                    Weight.Insert(1, ",");
                    Summary.Text += Weight;
                }
                else if (FirstDigits == "24")
                {
                    Weight.Insert(2, ",");
                    Summary.Text += Weight;
                }
                else if (FirstDigits == "23")
                {
                    Weight.Insert(3, ",");
                    Summary.Text += Weight;
                }
                else
                {
                    MessageBox.Show("Barcode should begin from 25, 24 or 23. Try one more time.");
                }
              }
            else if (Text_Mode.Text == "Minus")
            {

            }
            else
            {

            }
        }
    }
}
