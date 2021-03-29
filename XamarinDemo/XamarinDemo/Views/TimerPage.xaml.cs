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
    public partial class TimerPage : ContentPage
    {
        public ImageSource PreviousButtonImage { get; set; } = ImageSource.FromResource("XamarinDemo.Resources.skip_previous.png");
        public ImageSource StopButtonImage { get; set; } = ImageSource.FromResource("XamarinDemo.Resources.stop.png"); 
        public ImageSource StartButtonImage{ get; set; } = ImageSource.FromResource("XamarinDemo.Resources.play.png");
        public ImageSource PauseButtonImage { get; set; } = ImageSource.FromResource("XamarinDemo.Resources.pause.png");
        public ImageSource NextButtonImage { get; set; } = ImageSource.FromResource("XamarinDemo.Resources.skip_next.png");

        public TimerPage()
        {
            InitializeComponent();
            BindingContext = new TimerPageViewModel();
        }
    }
}