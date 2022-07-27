using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App_Login.Area_Restrita
{

    [XamlCompilation(XamlCompilationOptions.Compile)]

    public partial class Area_Restrita : ContentPage
    {
        public Area_Restrita()
        {

            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, false);

        }

    }

}