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
                DisplayAlert("Tarea Pendiente", "NOMBRE\n" + element.Nombre + "\n\nDESCRIPCIÓN\n" + element.Descripcion + "\n\nFECHA\n" + "Todavía no funciona" + "\n\nDÍAS RESTANTES\n" + "6" + " días restantes.", "Marcar como completada");
            }
        }
    }
}