using System;
using System.Collections.Generic;
using System.Text;

namespace Tarea5
{
    public class Elemento
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Fecha { get; set; }
        public string DiasRestantes { get; set; }
    }

    public class ListaElementos
    {
        public List<Elemento> _elementos { get; set; }
        
        public ListaElementos()
        {
            _elementos = new List<Elemento>();
            LoadElements();
        }

        public void LoadElements()
        {
            _elementos.Add(new Elemento
            {
                Nombre = "Crear una App en Xamarin Forms",
                Descripcion = "Muestre un mensaje de saludo con su nombre y apellido.",
                Fecha = "22/9/2020",
                DiasRestantes = "8"
            });

            _elementos.Add(new Elemento
            {
                Nombre = "Controles practica 1",
                Descripcion = "Crear un proyecto Xamarin Forms y realizar una pantalla que permita al usuario ingresar los siguientes datos establecidos.",
                Fecha = "24/9/2020",
                DiasRestantes = "10"
            });

            _elementos.Add(new Elemento
            {
                Nombre = "Controles practica 2",
                Descripcion = "Crear un proyecto Xamarin Forms que le permita a un usuario calcular cual seria su cuota de pago para un préstamo, favor tomar en consideración lo establecidos.",
                Fecha = "26/9/2020",
                DiasRestantes = "12"
            });

            _elementos.Add(new Elemento
            {
                Nombre = "Uso de Listas",
                Descripcion = "Luego de haber realizado la calculadora solicitada en la tarea numero 3, realizar lo establecido.",
                Fecha = "28/9/2020",
                DiasRestantes = "14"
            });

            _elementos.Add(new Elemento
            {
                Nombre = "Paginas y Navegación",
                Descripcion = "Realizar una nueva aplicación que permita al usuario realizar y visualizar lo establecido.",
                Fecha = "30/9/2020",
                DiasRestantes = "16"
            });


        }
    }

}
