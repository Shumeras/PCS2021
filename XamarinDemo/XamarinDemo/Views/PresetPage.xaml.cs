using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinDemo.ViewModels;

namespace XamarinDemo.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PresetPage : ContentPage
    {
        public PresetPage()
        {
            BindingContext = new PresetPageViewModel();
            InitializeComponent();    
        }

        protected override bool OnBackButtonPressed()
        {
            if(BindingContext is PresetPageViewModel ctx && ctx.IsPresetSelected)
            {
                ctx.ClosePresetCommand.Execute(null);
                return true;
            }

            return base.OnBackButtonPressed();
        }

    }

}