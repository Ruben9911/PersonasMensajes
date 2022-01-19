using Personas.mensajeria;
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

        // Propiedad enlazada a SelectedItem
        private Persona personaSeleccionada;

        public Persona PersonaSeleccionada
        {
            get { return personaSeleccionada; }
            set { SetProperty(ref personaSeleccionada, value); }
        }

        public ListaPersonasVM()
        {
            ListaPersonas = ServicioDatos.GetPersonas();

            // Suscribimos la vm al mensaje de difusión de una nueva persona y añadimos la nueva persona a nuestra lista
            WeakReferenceMessenger.Default.Register<AgregarPersonaMessage>
                (this, (r, mensaje) =>
                {
                    ListaPersonas.Add(mensaje.Value);
                });

            // Mandamos a ConsultaPersona la persona seleccionada
            WeakReferenceMessenger.Default.Register<ListaPersonasVM, ConsultaPersonaRequestMessage>
                (this, (r, m) =>
                {
                    m.Reply(PersonaSeleccionada);
                });
        }
    }
}