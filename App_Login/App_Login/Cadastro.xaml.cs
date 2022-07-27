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
    public partial class Cadastro : ContentPage
    {

        public Cadastro()
        {

            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, false);

        }

        private async void Button_Clicked(object sender, EventArgs e)
        {

            if (txt_usuario_cadastro.Text == null || txt_senha_cadastro.Text == null
                || txt_usuario_cadastro.Text == "" || txt_senha_cadastro.Text == "")
            {

                await DisplayAlert("Atenção!", "Preencha todos os campos antes de prosseguir.", "OK");

            }

            else
            {

                await DisplayAlert("Concluído!", "Usuário cadastrado.", "OK");

                await Navigation.PopAsync();

            }

        }

    }

}