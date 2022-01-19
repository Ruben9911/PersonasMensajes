using Personas.modelo;

namespace Personas.mensajeria
{
    internal class AgregarPersonaMessage : ValueChangedMessage<Persona>
    {
        public AgregarPersonaMessage(Persona p) : base(p)
        {
        }
    }
}