using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Messaging;
using Personas.mensajeria;
using Personas.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personas.vms
{
    class ConsultaPersonaVM : ObservableObject
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
