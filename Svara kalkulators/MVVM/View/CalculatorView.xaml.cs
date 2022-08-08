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
        private new void PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        float Summ = 0;

        private void ResetBtn_Click(object sender, RoutedEventArgs e)
        {
            Summ = 0;
            Summary.Text = Convert.ToString(Summ);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
