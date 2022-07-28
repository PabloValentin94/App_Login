using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using App_Login;

namespace App_Login.Area_Restrita
{

    [XamlCompilation(XamlCompilationOptions.Compile)]

    public partial class Area_Restrita : ContentPage
    {
        public Area_Restrita()
        {

            InitializeComponent();

            img_restricted_area.Source = ImageSource.FromResource("App_Login.Images." +
            "image_restricted_area.png");
            
            NavigationPage.SetHasNavigationBar(this, false);

        }

        private async void Button_Clicked(object sender, EventArgs e)
        {

            try
            {

                if (await DisplayAlert("Aviso!", "Realmente deseja sair da área restrita?",
               "Sim", "Não"))
                {

                    App.Current.Properties.Remove("PersistenciaUsuarioLogado");

                    App.Current.MainPage = new NavigationPage(new Opcoes());

                }

            }

            catch (Exception ex)
            {

                await DisplayAlert("Erro!", ex.Message, "OK");

            }

        }

    }

}
