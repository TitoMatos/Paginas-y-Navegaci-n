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
                Nombre = "Elemento 1",
                Descripcion = "Descripción 1",
                Fecha = "?/?/?"
            });

            _elementos.Add(new Elemento
            {
                Nombre = "Elemento 2",
                Descripcion = "Descripción 2",
                Fecha = "??/??/??"
            });

        }
    }

}
