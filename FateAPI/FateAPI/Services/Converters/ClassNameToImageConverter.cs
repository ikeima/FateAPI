using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace FateAPI.Services.Converters
{
    class ClassNameToImageConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            string rarity = String.Empty;
            string className = String.Empty;
            try
            {
                className = values[0].ToString();
                rarity = values[1].ToString();
            }
            catch
            {

            }
           
            string path = "class";

            switch (rarity)
            {
                case "2":
                    path += "1_";
                    break;
                case "3":
                    path += "2_";
                    break;
                case "4":
                    path += "3_";
                    break;
                case "5":
                    path += "3_";
                    break;
                default:
                    break;
            }

            switch (className)
            {
                case "saber":
                    path += "1";
                    break;
                case "archer":
                    path += "2";
                    break;
                case "lancer":
                    path += "3";
                    break;
                case "rider":
                    path += "4";
                    break;
                case "caster":
                    path += "5";
                    break;
                case "assassin":
                    path += "6";
                    break;
                case "berserker":
                    path += "7";
                    break;
                case "shielder":
                    path += "8";
                    break;
                case "ruler":
                    path += "9";
                    break;
                case "alterEgo":
                    path += "10";
                    break;
                case "avenger":
                    path += "11";
                    break;
                case "demonGodPillar":
                    path += "12";
                    break;
                case "grandCaster":
                    path += "17";
                    break;
                case "beastII":
                    path += "20";
                    break;
                case "beastI":
                    path += "21";
                    break;
                case "moonCancer":
                    path += "23";
                    break;
                case "beastIIIR":
                    path += "24";
                    break;
                case "beastIIIL":
                    path += "24";
                    break;
                case "foreigner":
                    path += "25";
                    break;
                case "beastUnknown":
                    path += "26";
                    break;
                case "pretender":
                    path += "28";
                    break;
                case "ushiChaosTide":
                    path += "97";
                    break;
                case "cccFinaleEmiyaAlter":
                    path += "124";
                    break;
                //case "saber":
                //    value += "3_1001";
                //    break;
                //case "saber":
                //    value += "3_1002";
                //    break;
                default:
                    break;
            }
            return path;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
