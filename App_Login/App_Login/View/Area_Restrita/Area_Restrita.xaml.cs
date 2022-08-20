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
        public Area_Restrita()
        {
            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, false);

            restricted_area.Source = ImageSource.FromResource("App_Login.View.Imagens." +
            "restricted_area.png");

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