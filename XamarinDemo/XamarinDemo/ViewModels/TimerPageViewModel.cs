using System;
using System.Collections.Generic;
using System.Text;
using XamarinDemo.Services;
using XamarinDemo.Models;
using Xamarin.Essentials;
using Xamarin.Forms;
using System.Windows.Input;
using System.Collections.ObjectModel;
using System.Linq;

namespace XamarinDemo.ViewModels
{
    public class TimerPageViewModel : BaseViewModel
    {
        private IDataService dataService;
        private ITimerService timerService;
        private ObservableCollection<PresetViewModel> presets;
        private PresetViewModel selectedPreset;
        private IntervalViewModel currentInterval;
        private string timerText;

        public TimerPageViewModel()
        {
            dataService = DependencyService.Get<IDataService>();
            timerService = DependencyService.Get<ITimerService>();

            timerService.SetupCallbacks(OnTick, OnComplete);

            UpdatePresetList();
            dataService.DataUpdateEvent += UpdatePresetList;

            PreviousIntervalCommand = new Command(Previous);
            StopIntervalCommand = new Command(Stop);
            StartIntervalCommand = new Command(Start);
            PauseIntervalCommand = new Command(Pause);
            NextIntervalCommand = new Command(Next);
        }

        public ObservableCollection<PresetViewModel> Presets
        {
            get => presets;
            set
            {
                presets = value;
                OnPropertyChanged(nameof(Presets));

                if (value != null)
                    SelectedPreset = presets.FirstOrDefault();
                else
                    SelectedPreset = null;

            }
        }
        public PresetViewModel SelectedPreset
        {
            get => selectedPreset;
            set
            {

                selectedPreset = value;
                OnPropertyChanged(nameof(SelectedPreset));
                if (value != null)
                    CurrentInterval = selectedPreset.Intervals.FirstOrDefault();
                else
                    CurrentInterval = null;
            }
        }
        public IntervalViewModel CurrentInterval
        {
            get => currentInterval;
            set
            {
                currentInterval = value;
                OnPropertyChanged(nameof(CurrentInterval));
                if (value != null)
                {
                    TimerText = TimeSpanToString(currentInterval.Data.Duration);
                    timerService.SetupDuration(currentInterval.Data.Duration);
                }
                else
                {
                    TimerText = TimeSpanToString(null);
                    timerService.Stop();
                }

                OnPropertyChanged(nameof(HasNextInterval));
                OnPropertyChanged(nameof(HasPreviousInterval));
            }
        }
        public string TimerText
        {
            get => timerText;
            set
            {
                timerText = value;
                OnPropertyChanged(nameof(TimerText));
            }
        }
        public bool IsTimerRunning => timerService.IsRunning;

        public bool HasNextInterval 
        { 
            get
            {
                if (SelectedPreset == null)
                    return false;

                var index = SelectedPreset.Intervals.IndexOf(CurrentInterval);
                if (index+1 >= SelectedPreset.Intervals.Count)
                    return false;

                return true;
            }
        }

        public bool HasPreviousInterval 
        { 
            get
            {
                if (SelectedPreset == null)
                    return false;

                if (SelectedPreset.Intervals.IndexOf(CurrentInterval) <= 0)
                    return false;

                return true;
            }
        }


        public ICommand PreviousIntervalCommand { get; set; }
        public ICommand StopIntervalCommand { get; set; }
        public ICommand StartIntervalCommand { get; set; }
        public ICommand PauseIntervalCommand { get; set; }
        public ICommand NextIntervalCommand { get; set; }

        public void Previous()
        {
            if (HasPreviousInterval)
            {
                CurrentInterval = SelectedPreset.Intervals[SelectedPreset.Intervals.IndexOf(CurrentInterval) - 1];
            }
        }

        public void Stop()
        {
            timerService.Stop();
            timerService.Reset();
            TimerText = TimeSpanToString(CurrentInterval.Data.Duration);
            OnPropertyChanged(nameof(IsTimerRunning));
        }

        public void Start()
        {
            if (timerService.IsRunning && currentInterval == null)
                return;

            timerService.Start();
            OnPropertyChanged(nameof(IsTimerRunning));
        }

        public void Pause()
        {
            timerService.Stop();
            OnPropertyChanged(nameof(IsTimerRunning));
        }

        public void Next()
        {
            if(HasNextInterval)
            {
                CurrentInterval = SelectedPreset.Intervals[SelectedPreset.Intervals.IndexOf(CurrentInterval) + 1];
            }

        }

        public void OnTick(TimeSpan timeSpan)
        {
            TimerText = TimeSpanToString(timeSpan);
        }

        public void OnComplete()
        {
            if(HasNextInterval)
            {
                Next();
                Start();
                
               // Vibration.Vibrate();
            }
            else
            {
                TextToSpeech.SpeakAsync("All intervals completed");
               // Vibration.Vibrate(1500);
            }
        }

        public void UpdatePresetList()
        {
            Presets = new ObservableCollection<PresetViewModel>(PresetViewModel.FromRange(dataService.GetPresets()));
            //SelectedPreset = Presets.FirstOrDefault();
        }

        private string TimeSpanToString(TimeSpan? timeSpan)
        {
            if (!timeSpan.HasValue)
                return "00:00:00";

            return $"{timeSpan.Value.Hours:00}:{timeSpan.Value.Minutes.ToString("00")}:{timeSpan.Value.Seconds.ToString("00")}";
        }
    }
}
