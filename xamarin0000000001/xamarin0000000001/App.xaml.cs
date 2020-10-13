using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using xamarin0000000001.Views;

namespace xamarin0000000001
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new SalarieView();
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
