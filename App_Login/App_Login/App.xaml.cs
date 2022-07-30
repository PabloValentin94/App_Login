using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using System.Collections;

namespace App_Login
{
    public partial class App : Application
    {

        public static ArrayList usuarios = new ArrayList();

        public static ArrayList senhas = new ArrayList();

        public App()
        {

            InitializeComponent();

            App.usuarios.Add("Pablo");

            App.senhas.Add("211066");

            if (Properties.ContainsKey("PersistenciaUsuarioLogado"))
            {

                string usuario = Properties.ContainsKey("PersistenciaUsuarioLogado").ToString();

                MainPage = new NavigationPage(new Area_Restrita.Area_Restrita());

            }

            else
            {

                MainPage = new NavigationPage(new Opcoes());

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
