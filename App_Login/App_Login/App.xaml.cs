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

            },

            new Dados_Usuario()
            {

                usuario = "Tiago Antônio da Silva",

                senha = "tiagotas"

            },

            new Dados_Usuario()
            {

                usuario = "Marcos Rogério Pagagnotti",

                senha = "marcão"

            },

            new Dados_Usuario()
            {

                usuario = "Adauto Facin Filho",

                senha = "211090"

            },

            new Dados_Usuario()
            {

                usuario = "Adib Paulini Neto",

                senha = "211084"

            },

            new Dados_Usuario()
            {

                usuario = "Bianca Camila de Morais",

                senha = "211063"

            },

            new Dados_Usuario()
            {

                usuario = "Bruno Mazzi Pignatari",

                senha = "211077"

            },

            new Dados_Usuario()
            {

                usuario = "Bruno Righi",

                senha = "211080"

            },

            new Dados_Usuario()
            {

                usuario = "Diego Baroni da Silva",

                senha = "211071"

            },

            new Dados_Usuario()
            {

                usuario = "Edilson Chiodi Junior",

                senha = "211377"

            },

            new Dados_Usuario()
            {

                usuario = "Eduardo Frasson Domine",

                senha = "211082"

            },

            new Dados_Usuario()
            {

                usuario = "Gabriel Roberto de Oliveira",

                senha = "211074"

            },

            new Dados_Usuario()
            {

                usuario = "Gabriel Tesser",

                senha = "211081"

            },

            new Dados_Usuario()
            {

                usuario = "Gabriela Martins da Silva",

                senha = "211091"

            },

            new Dados_Usuario()
            {

                usuario = "Giovani D Eleuterio Olaia",

                senha = "211083"

            },

            new Dados_Usuario()
            {

                usuario = "Higor Buttura da Silva",

                senha = "211376"

            },

            new Dados_Usuario()
            {

                usuario = "Hilary Fernanada Rodrigues da Silva",

                senha = "211087"

            },

            new Dados_Usuario()
            {

                usuario = "Hugo Buttura da Silva",

                senha = "211067"

            },

            new Dados_Usuario()
            {

                usuario = "Isabella Moraes Aguiar",

                senha = "211072"

            },

            new Dados_Usuario()
            {

                usuario = "Isabella Rodrigues de Oliveira",

                senha = "211078"

            },

            new Dados_Usuario()
            {

                usuario = "João Paulo Franchini de Freitas",

                senha = "211092"

            },

            new Dados_Usuario()
            {

                usuario = "Julyo Elias Hidalgo da Silva",

                senha = "211362"

            },

            new Dados_Usuario()
            {

                usuario = "Kaliany Andressa Arrabal Palma",

                senha = "211065"

            },

            new Dados_Usuario()
            {

                usuario = "Leonardo Fernando Luzetti",

                senha = "211068"

            },

            new Dados_Usuario()
            {

                usuario = "Lorenzo Fanizzi",

                senha = "211089"

            },

            new Dados_Usuario()
            {

                usuario = "Luar Akynatom Botelho Burghi",

                senha = "211065"

            },

            new Dados_Usuario()
            {

                usuario = "Lucas de Alencar Gomes",

                senha = "211375"

            },

            new Dados_Usuario()
            {

                usuario = "Lucas Gabriel de Paula Pinto",

                senha = "211070"

            },

            new Dados_Usuario()
            {

                usuario = "Mariane Fernanda Pagagnotti",

                senha = "211085"

            },

            new Dados_Usuario()
            {

                usuario = "Mateus Gabriel Moreno",

                senha = "211069"

            },

            new Dados_Usuario()
            {

                usuario = "Renato Serrano Mello da Costa",

                senha = "211073"

            },

            new Dados_Usuario()
            {

                usuario = "Rodrigo Donizete Videira",

                senha = "211076"

            },

            new Dados_Usuario()
            {

                usuario = "Thiago Miranda Luz de Gino Filho",

                senha = "211079"

            },

            new Dados_Usuario()
            {

                usuario = "Victor Roberto Vendrameto",

                senha = "211086"

            }

        };

        public App()
        {

            InitializeComponent();

            if(Properties.ContainsKey("PersistenciaUsuarioLogado"))
            {

                MainPage = new NavigationPage(new Area_Restrita(null));

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
