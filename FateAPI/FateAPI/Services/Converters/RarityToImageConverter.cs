using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace FateAPI.Services.Converters
{
    class RarityToImageConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            int rarity = (int)value;
            switch (rarity)
            {
                case 1:
                    value = "star1";
                    break;
                case 2:
                    value = "star2";
                    break;
                case 3:
                    value = "star3";
                    break;
                case 4:
                    value = "star4";
                    break;
                case 5:
                    value = "star5";
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
