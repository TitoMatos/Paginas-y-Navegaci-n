using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Tarea5
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            if (Email.Text == "admin@uteco.edu.do" & Contraseña.Text == "Password")
            {
                 //await Navigation.PushAsync(new Home());
                 await Navigation.PushModalAsync(new MasterDetailPage1Master());
            }
            else
            {
                await DisplayAlert("¡Error!", "Has introducido los datos incorrectos", "Ok");
            }



        }
    }
}
