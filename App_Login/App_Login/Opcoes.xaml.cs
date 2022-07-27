﻿using System;
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

            await Navigation.PushAsync(new Cadastro());

        }

        private async void btn_login_Clicked(object sender, EventArgs e)
        {

            /* Os argumentos fornecidos à Classe Login são puramente
             * aleatórios. Sua única função é atender a condição da estrutura de decisão
             * do Método Button_Clicked (Login) */

            await Navigation.PushAsync(new Login("0", "0"));

        }
    }

}