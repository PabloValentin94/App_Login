using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App_Login.View
{

    [XamlCompilation(XamlCompilationOptions.Compile)]

    public partial class Login : ContentPage
    {

        public Login()
        {

            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, false);

            btn_mostrar_ocultar_senha.Source = 
            ImageSource.FromResource("App_Login.View.Imagens.show_password.png");

        }

        private async void Button_Clicked(object sender, EventArgs e)
        {

            try
            {

                if (String.IsNullOrEmpty(txt_usuario_login.Text) || String.IsNullOrEmpty(txt_senha_login.Text))
                {

                    await DisplayAlert("Atenção!", "Preencha todos os campos antes de prosseguir.", "OK");

                }

            }

            catch (Exception ex)
            {

                await DisplayAlert("Erro!", ex.Message, "OK");

            }

        }

        private async void btn_mostrar_ocultar_senha_Clicked(object sender, EventArgs e)
        {

            try
            {

                if (txt_senha_login.IsPassword.Equals(false))
                {

                    btn_mostrar_ocultar_senha.Source = 
                    ImageSource.FromResource("App_Login.View.Imagens.show_password.png");

                    txt_senha_login.IsPassword = true;

                }

                else
                {

                    btn_mostrar_ocultar_senha.Source = 
                    ImageSource.FromResource("App_Login.View.Imagens.hide_password.png");

                    txt_senha_login.IsPassword = false;

                }

            }

            catch (Exception ex)
            {

                await DisplayAlert("Erro!", ex.Message, "OK");

            }

        }

    }

}