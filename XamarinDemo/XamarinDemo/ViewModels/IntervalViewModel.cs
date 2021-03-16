using System;
using System.Collections.Generic;
using System.Text;
using XamarinDemo.Models;

namespace XamarinDemo.ViewModels
{
    public class IntervalViewModel : BaseViewModel
    {
        public Interval Data { get; private set; }

        public string Name 
        {
            get => Data.Name; 
            set
            {
                Data.Name = value;
                OnPropertyChanged(nameof(Name));
            }
        }
        public string Hours 
        {
            get => Data.Duration.Hours.ToString("00"); 
            set
            {
                Data.Duration = new TimeSpan(int.Parse(value), Data.Duration.Minutes, Data.Duration.Seconds);
                OnPropertyChanged(nameof(Hours));
            }
        }
        public string Minutes 
        { 
            get => Data.Duration.Minutes.ToString("00");
            set
            {
                Data.Duration = new TimeSpan(Data.Duration.Hours, int.Parse(value), Data.Duration.Seconds);
                OnPropertyChanged(nameof(Minutes));
            }
        }
        public string Seconds 
        { 
            get => Data.Duration.Seconds.ToString("00");
            set
            {
                Data.Duration = new TimeSpan(Data.Duration.Hours, Data.Duration.Minutes, int.Parse(value));
                OnPropertyChanged(nameof(Seconds));
            }
        }

        public IntervalViewModel(Interval interval)
        {
            Data = interval;

        }
    }
}
