using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace WpfApp2
{
    class StringToFloatConverter : IValueConverter
    {
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            float result;
            if (!float.TryParse((string)value, out result))
            {
                result = 0f;
                Console.WriteLine("Conversion failed");
            }

            return result;
        }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if(value is string)
            {
                return 0;
            }
            return ((float)value).ToString();
        }
    }
}
