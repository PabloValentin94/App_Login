using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using App_Login;

namespace App_Login
{

    [XamlCompilation(XamlCompilationOptions.Compile)]

    public partial class Login : ContentPage
    {

        public Login()
        {

            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, false);

            btn_mostrar_ocultar_senha.Source = ImageSource.FromResource("App_Login.Images.show_password.png");

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

                    if(App.usuarios.Contains(txt_usuario_login.Text))
                    {

                        if (App.senhas.Contains(txt_senha_login.Text))
                        {

                            App.Current.Properties.Add("PersistenciaUsuarioLogado", txt_usuario_login.Text);

                            App.Current.MainPage = new Area_Restrita.Area_Restrita();

                        }

                        else
                        {

                            await DisplayAlert("Atenção!", "Nenhum cadastro encontrado no sistema." +
                                                    " Verifique se seu Usuário e sua Senha estão corretos e tente novamente.\n" +
                                                    "\nSe o erro persistir, verifique se você realmente está cadastrado.", "OK");

                        }

                    }

                    else
                    {

                        await DisplayAlert("Atenção!", "Nenhum cadastro encontrado no sistema." +
                                                " Verifique se seu Usuário e sua Senha estão corretos e tente novamente.\n" +
                                                "\nSe o erro persistir, verifique se você realmente está cadastrado.", "OK");

                    }

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

                    btn_mostrar_ocultar_senha.Source = ImageSource.FromResource("App_Login.Images.show_password.png");

                    txt_senha_login.IsPassword = true;

                }

                else
                {

                    btn_mostrar_ocultar_senha.Source = ImageSource.FromResource("App_Login.Images.hide_password.png");

                    txt_senha_login.IsPassword = false;

                }

            }

            catch(Exception ex)
            {

                await DisplayAlert("Erro!", ex.Message, "OK");

            }

        }

    }

}