using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using WpfApp2.Models;

namespace WpfApp2.Converters
{
    [ValueConversion(typeof(bool), typeof(IssueType), ParameterType = typeof(IssueType))]
    class IssueTypeConverter : IValueConverter
    {
        private static IssueTypeConverter instance;

        public static IssueTypeConverter Instance
        {
            get
            {
                if (instance == null)
                    instance = new IssueTypeConverter();

                return instance;
            }
        }

        private IssueTypeConverter() {}

        public /*bool*/ object Convert(/*IssueType*/object value, Type targetType, /*IssueType*/object parameter, CultureInfo culture)
        {
            return value.Equals(parameter);
        }

        public /*IssueType*/object ConvertBack(object /*bool*/value, Type targetType, /*IssueType*/object parameter, CultureInfo culture)
        {
            return (bool)value ? parameter : Binding.DoNothing;
        }
    }
}
