using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using System.Collections.Generic;

using App_Login.View;
using App_Login.View.Area_Restrita;
using App_Login.Model;

namespace App_Login
{

    public partial class App : Application
    {

        public List<Dados_Usuario> lista_usuarios = new List<Dados_Usuario>
        {

            new Dados_Usuario()
            {

                usuario = "Pablo Valentin",

                senha = "211066"

            }

        };

        public App()
        {

            InitializeComponent();

            if(Properties.ContainsKey("PersistenciaUsuarioLogado"))
            {

                string usuario = Properties.ContainsKey("PersistenciaUsuarioLogado").ToString();

                MainPage = new NavigationPage(new Area_Restrita());

            }

            else
            {

                MainPage = new NavigationPage(new Login());

            }

        }

        protected override void OnStart()
        {



        }

        protected override void OnSleep()
        {



        }

        protected override void OnResume()
        {



        }

    }

}
