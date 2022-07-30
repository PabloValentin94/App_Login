using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using App_Login;

using System.Collections; // Biblioteca que possui o ArrayList

namespace App_Login
{

    [XamlCompilation(XamlCompilationOptions.Compile)]

    public partial class Login : ContentPage
    {

        string usuario = null;

        string senha = null;

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

            try
            {

                if (usuario.Equals(txt_usuario_login.Text) && senha.Equals(txt_senha_login.Text))
                {

                    App.Current.Properties.Add("PersistenciaUsuarioLogado", txt_usuario_login.Text);

                    App.Current.MainPage = new Area_Restrita.Area_Restrita();

                }

                else if (String.IsNullOrEmpty(txt_usuario_login.Text)
                         || String.IsNullOrEmpty(txt_senha_login.Text))
                {

                    await DisplayAlert("Atenção!", "Preencha todos os campos antes de prosseguir.", "OK");

                }

                else
                {

                    await DisplayAlert("Atenção!", "Usuário ou Senha incorretos! Tente Novamente.\n" +
                                            "\nSe o erro persistir, verifique se você realmente está cadastrado.", "OK");

                }

            }

            catch (Exception ex)
            {

                await DisplayAlert("Erro!", ex.Message, "OK");

            }

        }

    }

}