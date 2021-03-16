using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinDemo.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class IntervalCell : ViewCell
    {
        #region Picker item list definitions
        private static List<string> hourValues;
        private static List<string> minuteValues;
        private static List<string> secondValues;

        public static List<string> HourValues 
        { 
            get
            {
                if(hourValues == null)
                {
                    hourValues = new List<string>();
                    for(int i = 0; i < 24; i++)
                    {
                        hourValues.Add(i.ToString("00"));
                    }
                }

                return hourValues;
            }
        }
        public static List<string> MinuteValues
        {
            get
            {
                if (minuteValues == null)
                {
                    minuteValues = new List<string>();
                    for (int i = 0; i < 60; i++)
                    {
                        minuteValues.Add(i.ToString("00"));
                    }
                }

                return minuteValues;
            }
        }
        public static List<string> SecondValues
        {
            get
            {
                if (secondValues == null)
                {
                    secondValues = new List<string>();
                    for (int i = 0; i < 60; i++)
                    {
                        secondValues.Add(i.ToString("00"));
                    }
                }
                return secondValues;
            }
        }

        public List<string> HourList => HourValues;
        public List<string> MinuteList => MinuteValues;
        public List<string> SecondList => SecondValues;

        #endregion
        
        public static readonly BindableProperty DeleteCommandProperty =
            BindableProperty.Create(
                nameof(DeleteCommand),
                typeof(ICommand),
                typeof(IntervalCell));

        public static readonly BindableProperty DeleteCommandParameterProperty =
            BindableProperty.Create(
                nameof(DeleteCommandParameter),
                typeof(object),
                typeof(IntervalCell));


        public ICommand DeleteCommand 
        {
            get => (ICommand)GetValue(DeleteCommandProperty);
            set => SetValue(DeleteCommandProperty, value); 
        }

        public object DeleteCommandParameter 
        {
            get => GetValue(DeleteCommandParameterProperty);
            set => SetValue(DeleteCommandParameterProperty, value);
        }


        public IntervalCell()
        {
            InitializeComponent();
        }
    }
}