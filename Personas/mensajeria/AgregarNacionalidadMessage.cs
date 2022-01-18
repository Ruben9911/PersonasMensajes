using Microsoft.Toolkit.Mvvm.Messaging.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personas.mensajeria
{
    class AgregarNacionalidadMessage : ValueChangedMessage<String>
    {
        public AgregarNacionalidadMessage(String texto) : base(texto) { }
    }
}
