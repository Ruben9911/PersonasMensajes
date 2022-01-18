using Personas.contentcontrols;
using Personas.vistas;
using System.Windows.Controls;

namespace Personas.servicios
{
    internal class ServicioNavegacion
    {
        public static ListaPersonasControl ListaPersonas { get; set; } = new ListaPersonasControl();

        public ServicioNavegacion()
        { }

        // Devuelve un nuevo UserControl de NuevaPersona
        internal static UserControl AbrirNuevaPersona() => new NuevaPersonaControl();

        // Devuelve un nuevo UserControl de ListaPersonas
        internal static UserControl AbrirListaPersonas() => ListaPersonas;

        // Abre un diálogo y devuelve el resultado
        public static bool? AbrirAñadirDialog() => new AñadirDialog().ShowDialog();
    }
}