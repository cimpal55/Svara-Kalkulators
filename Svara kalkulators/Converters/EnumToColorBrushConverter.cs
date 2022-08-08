using Svara_kalkulators.MVVM.ViewModel;
using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace Svara_kalkulators.Converters
{
    public class EnumToColorBrushConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Color colorDefault = (Color)ColorConverter.ConvertFromString("#FF48644C");

            switch ((int)value)
            {
                case (int)Mode.Plus:
                    return new SolidColorBrush(Colors.PaleGreen);

                case (int)Mode.Minus:
                    return new SolidColorBrush(Colors.PaleVioletRed);

                default:
                    return new SolidColorBrush(colorDefault);
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
