using System;
using System.Globalization;
using Xamarin.Forms;

namespace FateAPI.Services.Converters
{
    class TypeToImageConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            switch (value.ToString())
            {
                case "buster":
                    value = "card_icon_buster";
                    break;
                case "arts":
                    value = "card_icon_arts";
                    break;
                case "quick":
                    value = "card_icon_quick";
                    break;
            }
            return value;

        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
