using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace converter_
{
    class rusConverter : IValueConverter
    {
        // Presence -> (русифицированный) string
        public object? Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (!(value is Presence presence))
                return null;
            if (targetType != typeof(string))
               return null;

            return new string[] { "Присутствует", "Опоздал", "Отсутствует"} [(int)presence];
            /*if (presence == Presence.Present)
                return "Присутствует";
            else if (presence == Presence.Late)
                return "Опоздал";
            else if (presence == Presence.Absent)
                return "Отсутствует";
            else
                return null;*/
        }

        public object? ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}
