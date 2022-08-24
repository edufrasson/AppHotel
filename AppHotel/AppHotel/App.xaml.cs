using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AppHotel.View;

namespace AppHotel
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new View.Login();
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
