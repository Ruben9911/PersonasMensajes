using Personas.mensajeria;
using Personas.modelo;

namespace Personas.vms
{
    internal class ConsultaPersonaVM : ObservableObject
    {
        // Propiedad a la que bindearemos los textbox del XAML
        private Persona personaActual;

        public Persona PersonaActual
        {
            get { return personaActual; }
            set { SetProperty(ref personaActual, value); }
        }

        public ConsultaPersonaVM()
        {
            // Solicita la persona seleccionada a ListaPersonasVM
            PersonaActual = WeakReferenceMessenger.Default.Send<ConsultaPersonaRequestMessage>();
        }
    }
}