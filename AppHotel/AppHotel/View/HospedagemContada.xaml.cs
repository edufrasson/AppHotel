using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppHotel.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HospedagemContada : ContentPage
    {
        public HospedagemContada()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new CadastroHospedagem();
        }
    }
}