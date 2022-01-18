using Microsoft.Toolkit.Mvvm.Messaging.Messages;
using Personas.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personas.mensajeria
{
    class AgregarPersonaMessage : ValueChangedMessage<Persona>
    {
        public AgregarPersonaMessage(Persona p) : base(p) { }
    }
}
