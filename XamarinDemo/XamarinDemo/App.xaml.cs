using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinDemo.Services;
using XamarinDemo.Views;

namespace XamarinDemo
{
    public partial class App : Application
    {
        public App()
        {
            DependencyService.Register<MockDataService>();
            DependencyService.Register<SimpleTimerService>();

            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
