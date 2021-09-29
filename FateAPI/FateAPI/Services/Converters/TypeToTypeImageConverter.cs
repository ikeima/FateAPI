using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace FateAPI.Services.Converters
{
    class TypeToTypeImageConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            try
            {
                switch (value.ToString())
                {
                    case "buster":
                        value = "card_txt_buster";
                        break;
                    case "arts":
                        value = "card_txt_arts";
                        break;
                    case "quick":
                        value = "card_txt_quick";
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
