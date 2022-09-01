using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AppHotel.View;
using System.Collections.Generic;
using AppHotel.Model;
using System.Threading;
using System.Globalization;

namespace AppHotel
{
    public partial class App : Application
    {
        public List<Suite> lista_suites = new List<Suite>
        {
            new Suite()
            {
               Nome = "Super Luxo",
               DiariaAdulta = 110.0,
               DiariaCrianca = 55.0
            },
            new Suite()
            {
               Nome = "Executiva",
               DiariaAdulta = 90.0,
               DiariaCrianca = 45.0
            },
            new Suite()
            {
               Nome = "Crise",
               DiariaAdulta = 45.0,
               DiariaCrianca = 20.0
            }
        };
        public App()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("pt-BR");

            InitializeComponent();

            MainPage = new NavigationPage(new View.Login());
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
