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
                Text_Mode.Foreground = Brushes.Green; ;
                Text_Mode.Text = "Plus";
            } else if (sender.Equals(MinusBtn)) {
                Text_Mode.Foreground = Brushes.Red;
                Text_Mode.Text = "Minus";
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
