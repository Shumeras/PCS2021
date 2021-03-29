using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using XamarinDemo.Models;

namespace XamarinDemo.ViewModels
{
    public class PresetViewModel : BaseViewModel
    {
        public static List<PresetViewModel> FromRange(IEnumerable<Preset> presets)
        {
            var result = new List<PresetViewModel>();
            foreach(var preset in presets)
            {
                result.Add(new PresetViewModel(preset));
            }

            return result;
        }

        public Preset Data { get; private set; }
        public string Name 
        {
            get => Data.Name; 
            set
            {
                Data.Name = value;
                OnPropertyChanged(nameof(Name));
            }
        }
        public ObservableCollection<IntervalViewModel> Intervals { get; set; }
        public ICommand CreateIntervalCommand { get; set; }
        public ICommand DeleteIntervalCommand { get; set; }

        public PresetViewModel(Preset target)
        {
            Data = target;
            Intervals = new ObservableCollection<IntervalViewModel>();
            foreach(var i in Data.Intervals)
            {
                Intervals.Add(new IntervalViewModel(i));
            }

            CreateIntervalCommand = new Command(CreateInterval);
            DeleteIntervalCommand = new Command(DeleteInterval);
        }

        public void CreateInterval()
        {
            var interval = new Interval() {Name = "New Interval"};
            Intervals.Add(new IntervalViewModel(interval));
            Data.Intervals.Add(interval);

        }

        public void DeleteInterval(object obj)
        {
            var target = obj as IntervalViewModel;
            Intervals.Remove(target);
            Data.Intervals.Remove(target.Data);
        }

    }
}
