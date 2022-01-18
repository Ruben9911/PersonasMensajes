using Microsoft.Toolkit.Mvvm.ComponentModel;
using Personas.modelo;
using Personas.servicios;
using System.Collections.ObjectModel;

namespace Personas.vms
{
    internal class ListaPersonasVM : ObservableObject
    {
        // Propiedad donde se guardan los objetos de Persona
        private ObservableCollection<Persona> listaPersonas;

        public ObservableCollection<Persona> ListaPersonas
        {
            get { return listaPersonas; }
            set { SetProperty(ref listaPersonas, value); }
        }

        public ListaPersonasVM()
        {
            ListaPersonas = ServicioDatos.GetPersonas();
        }
    }
}