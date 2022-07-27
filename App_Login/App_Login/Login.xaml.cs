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

        string usuario = "0";

        string senha = "0";

        /* Os valores atribuídos, as duas variáveis acima, servem somente para
         * atender a condição da estrutura de decisão do Método Button_Clicked */

        public Login(string texto_usuario, string texto_senha)
        {

            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, false);

            usuario = texto_usuario;

            senha = texto_senha;

        }

        private async void Button_Clicked(object sender, EventArgs e)
        {

            if (txt_usuario_login.Text == usuario && txt_senha_login.Text == senha)
            {

                await Navigation.PushAsync(new App_Login.Area_Restrita.Area_Restrita());

            }

            else
            {

                if (usuario == "0" && senha == "0")
                {

                    await DisplayAlert("Erro", "Apararentemente este cadastro não existe. Tente" +
                        " se cadastrar antes de prosseguir.", "OK");

                }

                else
                {

                    await DisplayAlert("Atenção!", "Usuário ou Senha incorretos. Tente Novamente.", "OK");

                }

            }

        }

    }

}