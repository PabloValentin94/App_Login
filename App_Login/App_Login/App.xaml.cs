using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App_Login
{

    public partial class App : Application
    {

        public App()
        {

            InitializeComponent();

            if(Properties.ContainsKey("PersistenciaUsuarioLogado"))
            {

                string usuario = Properties.ContainsKey("PersistenciaUsuarioLogado").ToString();

                MainPage = new NavigationPage(new View.Area_Restrita.Area_Restrita());

            }

            else
            {

                MainPage = new NavigationPage(new View.Login());

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
