using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tarea5
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Inicio : TabbedPage
    {
        public Inicio()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            ListaElementos elementos = new ListaElementos();
            ListElements.ItemsSource = elementos._elementos;
            ListElements.ItemSelected += ListElements_ItemSelected;
        }

        private void ListElements_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                var element = e.SelectedItem as Elemento;
                DisplayAlert("Tarea Pendiente", "NOMBRE\n" + element.Nombre + "\n\nDESCRIPCIÓN\n" + element.Descripcion + "\n\nFECHA\n" + element.Fecha + "\n\nDÍAS RESTANTES\n" + element.DiasRestantes + " días restantes.", "Marcar como completada");
            }
        }

        private async void Guardar_Clicked(object sender, EventArgs e)
        {
            if (Nombre.Text == "")
            {
                await DisplayAlert("¡Error!", "No has completado el campo Nombre correctamente. \n\n Vuelva a intentarlo.", "Aceptar");
            }
            else if (Apellido.Text == "")
            {
                await DisplayAlert("¡Error!", "No has completado el campo Apellido correctamente. \n\n Vuelva a intentarlo.", "Aceptar");
            }
            else if (Nacionalidad.Text == "")
            {
                await DisplayAlert("¡Error!", "No has completado el campo Nacionalidad correctamente. \n\n Vuelva a intentarlo.", "Aceptar");
            }
            else
            {
                await DisplayAlert("Datos Guardados", "Nombre\n" + Nombre.Text + "\n\nApellido\n" + Apellido.Text + "\n\nNacionalidad\n" + Nacionalidad.Text + "\n\nFecha de Nacimiento\n" + Fecha.Date + "\n\nEstado Civil\n" + picker1.SelectedItem, "Aceptar");
                Nombre.Text = "";
                Apellido.Text = "";
                Nacionalidad.Text = "";
            }

        }
    }
}