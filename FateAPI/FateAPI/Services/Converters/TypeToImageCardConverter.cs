using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace FateAPI.Services.Converters
{
    class TypeToImageCardConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            try
            {
                switch (value.ToString())
                {
                    case "buster":
                        value = "card_bg_buster";
                        break;
                    case "arts":
                        value = "card_bg_arts";
                        break;
                    case "quick":
                        value = "card_bg_quick";
                        break;
                }
            }
            catch { }
            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
