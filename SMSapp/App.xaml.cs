using AppEssentials.Shared.Pages;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SMSapp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
       
            MainPage = new SmsPage();
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
