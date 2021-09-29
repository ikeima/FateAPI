using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace FateAPI.Services.Converters
{
    class GrowthToLabelConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            int growthCurve = 0;
            try
            {
                growthCurve = System.Convert.ToInt32(value);
            }
            catch { }
            switch (growthCurve)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 9999:
                    value = "Linear";
                    break;
                case 6:
                case 7:
                case 8:
                case 9:
                case 10:
                    value = "Reverse S";
                    break;
                case 11:
                case 12:
                case 13:
                case 14:
                case 15:
                    value = "S";
                    break;
                case 21:
                case 22:
                case 23:
                case 24:
                case 25:
                    value = "Semi Reverse S";
                    break;
                case 26:
                case 27:
                case 28:
                case 29:
                case 30:
                    value = "Semi S";
                    break;
                default:
                    value = "Unknown";
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
