using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using XamarinDemo.Models;
using XamarinDemo.Services;
using XamarinDemo.Views;

namespace XamarinDemo.ViewModels
{
    public class PresetPageViewModel : BaseViewModel
    {
        private IDataService dataService;

        private bool isPresetSelected = false;
        private PresetViewModel selectedPresetViewModel;

        public ObservableCollection<PresetViewModel> Presets { get; set; }

        public bool IsPresetSelected
        {
            get => isPresetSelected;
            set
            {
                isPresetSelected = value;
                OnPropertyChanged(nameof(IsPresetSelected));
            }
        }

        public PresetViewModel SelectedPresetViewModel
        {
            get => selectedPresetViewModel;
            set
            {
                selectedPresetViewModel = value;
                OnPropertyChanged(nameof(SelectedPresetViewModel));
            }
        }

        public ICommand CreatePresetCommand { get; set; }
        public ICommand DeletePresetCommand { get; set; }
        public ICommand OpenPresetCommand { get; set; }
        public ICommand ClosePresetCommand { get; set; }

        public PresetPageViewModel()
        {
            dataService = DependencyService.Get<IDataService>();
            Presets = new ObservableCollection<PresetViewModel>();

            foreach(var p in dataService.GetPresets())
            {
                Presets.Add(new PresetViewModel(p));
            }

            CreatePresetCommand = new Command(CreatePreset);
            OpenPresetCommand = new Command(OpenPreset);
            ClosePresetCommand = new Command(ClosePreset);
            DeletePresetCommand = new Command(DeletePreset);
        }

        private void DeletePreset()
        {
            Presets.Remove(SelectedPresetViewModel);
            dataService.DeletePreset(SelectedPresetViewModel.Data);
            ClosePreset();
        }

        private void CreatePreset()
        {
            var preset = new Preset() { Name = "New Preset" };
            dataService.AddPreset(preset);
            Presets.Add(new PresetViewModel(preset));

        }
        private void OpenPreset(object obj)
        {
            var target = obj as PresetViewModel;
            IsPresetSelected = true;
            SelectedPresetViewModel = target;
        }

        private void ClosePreset()
        {
            IsPresetSelected = false;
            SelectedPresetViewModel = null;
        }



    }
}
