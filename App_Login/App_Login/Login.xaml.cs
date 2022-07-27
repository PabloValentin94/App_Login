using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using System.Collections; // Biblioteca que possui o ArrayList

namespace App_Login
{

    [XamlCompilation(XamlCompilationOptions.Compile)]

    public partial class Login : ContentPage
    {

        //ArrayList usuarios = new ArrayList();

        //ArrayList senhas = new ArrayList();

        string usuario = "10";

        string senha = "10";

        public Login()
        {

            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, false);

        }

        private async void Button_Clicked(object sender, EventArgs e)
        {

            if(txt_usuario_login.Text == usuario && txt_senha_login.Text == senha)
            {

                await Navigation.PushAsync(new App_Login.Area_Restrita.Area_Restrita());

            }

            else
            {

                await DisplayAlert("Atenção!", "Usuário ou Senha incorretos. Tente Novamente" +
                    " ou verifique se seu cadastro realmente existe.", "OK");

            }

        }

    }

}