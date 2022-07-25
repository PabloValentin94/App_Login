using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App_Login
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Opcoes : ContentPage
    {

        public Opcoes()
        {

            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, false);

            img_user.Source = ImageSource.FromResource("App_Login.Imagem.Image.png");

        }

        private async void btn_cadastro_Clicked(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new App_Login.Cadastro());

        }

        private async void btn_login_Clicked(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new App_Login.Login());

        }
    }

}