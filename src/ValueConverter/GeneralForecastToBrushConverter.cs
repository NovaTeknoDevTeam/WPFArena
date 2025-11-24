using System;
using System.Windows.Data;
using System.Windows.Media;

namespace ValueConverter;

public class GeneralForecastToBrushConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
    {
        var gf = (Forecast.GeneralForecast)value;
        switch (gf)
        {
            case Forecast.GeneralForecast.Cloudy:
                return Brushes.LightGray;
            case Forecast.GeneralForecast.Dry:
                return Brushes.LightYellow;
            case Forecast.GeneralForecast.Rainy:
                return Brushes.LightGreen;
            case Forecast.GeneralForecast.Snowy:
                return Brushes.LightBlue;
            case Forecast.GeneralForecast.Sunny:
                return Brushes.Yellow;
        }

        return Binding.DoNothing;
    }

    public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}