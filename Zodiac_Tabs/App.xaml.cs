using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Zodiac_Tabs
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new TabbedZodiac();
        }

        protected override async void OnStart()
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
