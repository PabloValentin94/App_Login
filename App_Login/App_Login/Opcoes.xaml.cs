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

    public partial class Opcoes : ContentPage
    {

        public Opcoes()
        {

            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, false);

            img_user.Source = ImageSource.FromResource("App_Login.Images.image_user.png");

        }

        private async void btn_cadastro_Clicked(object sender, EventArgs e)
        {

            try
            {

                await Navigation.PushAsync(new Cadastro());

            }

            catch(Exception ex)
            {

                await DisplayAlert("Erro!", ex.Message, "OK");

            }

        }

        private async void btn_login_Clicked(object sender, EventArgs e)
        {

            // É necessário se cadastrar toda vez que sair da Área Restrita.

            try
            {

                if (await DisplayAlert("Aviso!", "É preciso ter um cadastro antes de fazer" +
                " o login. Você já está cadastrado?", "Sim", "Não"))
                {

                    await DisplayAlert("Atenção!", "Nenhum cadastro foi encontrado! " +
                                        "Cadastre-se antes de prosseguir.", "OK");

                }

            }

            catch (Exception ex)
            {

                await DisplayAlert("Erro!", ex.Message, "OK");

            }

        }

    }

}