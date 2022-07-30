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

        int i;

        public Login()
        {

            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, false);

        }

        private async void Button_Clicked(object sender, EventArgs e)
        {

            try
            {

                if (String.IsNullOrEmpty(txt_usuario_login.Text) || String.IsNullOrEmpty(txt_senha_login.Text))
                {

                    await DisplayAlert("Atenção!", "Preencha todos os campos antes de prosseguir", "OK");

                }

                else
                {

                    for (i = 0; i > App.usuarios.Count; i++)
                    {

                        if (App.usuarios[i].ToString().Equals(txt_usuario_login.Text)
                            && App.senhas[i].ToString().Equals(txt_senha_login.Text))
                        {

                            i = 0;

                            App.Current.Properties.Add("PersistenciaUsuarioLogado", txt_usuario_login.Text);

                            App.Current.MainPage = new Area_Restrita.Area_Restrita();

                        }

                        else
                        {

                            await DisplayAlert("Atenção!", "Usuário ou Senha incorretos! Tente Novamente.\n" +
                                               "\nSe o erro persistir, verifique se realmente está cadastrado.", "OK");

                        }

                    }

                }

            }

            catch (Exception ex)
            {

                await DisplayAlert("Erro!", ex.Message, "OK");

            }

        }

    }

}