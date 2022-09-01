using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using AppHotel.View;

namespace AppHotel.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, false);
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            string usuario = txt_usuario.Text;
            string senha = txt_senha.Text;

            string usuario_correto = "aluno";
            string senha_correta = "etec";

            if (usuario == usuario_correto && senha == senha_correta)
            {
                App.Current.Properties.Add("usuario_logado", usuario);
                App.Current.MainPage = new CadastroHospedagem();

                //Navigation.PushAsync(new ContratacaoHospedagem());
            }
            else
                DisplayAlert("Ops!", "Usuário ou senha incorretos.", "OK");
        }
    }
}