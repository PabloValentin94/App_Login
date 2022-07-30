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

        private async void btn_confirmar(object sender, EventArgs e)
        {

            try
            {

                if (String.IsNullOrEmpty(txt_usuario_cadastro.Text) || String.IsNullOrEmpty(txt_senha_cadastro.Text))
                {

                    await DisplayAlert("Atenção!", "Preencha todos os campos antes de prosseguir.", "OK");

                }

                else
                {

                    App.usuarios.Add(txt_usuario_cadastro.Text);

                    App.senhas.Add(txt_senha_cadastro.Text);

                    await DisplayAlert("Concluído!", "Usuário cadastrado com sucesso.", "OK");

                    await Navigation.PopAsync();

                }

            }

            catch (Exception ex)
            {

                await DisplayAlert("Erro!", ex.Message, "OK");

            }

        }

        private async void btn_apagar_cadastros(object sender, EventArgs e)
        {

            int qnt_cadastros = App.usuarios.Count;

            if(App.usuarios.Count > 0)
            {

                if (await DisplayAlert("Aviso!", "Existem " + qnt_cadastros.ToString() +
                                   " cadastros no sistema. Realmente deseja apagá-los?", "Sim", "Não"))
                {

                    App.usuarios.Clear();

                    App.senhas.Clear();

                    await DisplayAlert("Atenção!", qnt_cadastros.ToString() +
                                       " cadastros apagados.", "OK");

                }

            }

            else
            {

                await DisplayAlert("Aviso!", "O sistema ainda não possui nenhum cadastro.",
                                   "OK");

            }

        }

    }

}