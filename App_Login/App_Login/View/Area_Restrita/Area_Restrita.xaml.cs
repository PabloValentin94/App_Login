using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App_Login.View.Area_Restrita
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Area_Restrita : ContentPage
    {

        string nome;

        public Area_Restrita(string nome_usuario)
        {
            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, false);

            restricted_area.Source = ImageSource.FromResource("App_Login.View.Imagens." +
            "restricted_area.png");

            this.nome = nome_usuario;

            mensagem_boas_vindas();

        }

        private async void mensagem_boas_vindas()
        {

            await DisplayAlert("Mensagem", "Seja bem-vindo " + this.nome, "OK");

        }

        private async void Button_Clicked(object sender, EventArgs e)
        {

            try
            {

                if (await DisplayAlert("Aviso!", "Realmente deseja sair da Área Restrita?",
                                       "Sim", "Não"))
                {

                    App.Current.Properties.Remove("PersistenciaUsuarioLogado");

                    App.Current.MainPage = new NavigationPage(new Login());

                }

            }

            catch (Exception ex)
            {

                await DisplayAlert("Erro!", ex.Message, "OK");

            }

        }
    }
}