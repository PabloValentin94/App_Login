﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

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

        private void Button_Clicked(object sender, EventArgs e)
        {



        }

    }

}