using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using Microsoft.Toolkit.Mvvm.Messaging;
using Personas.mensajeria;
using Personas.servicios;

namespace Personas.vms
{
    internal class AñadirDialogoVM : ObservableRecipient
    {
        private string nacionalidad;

        public string Nacionalidad
        {
            get { return nacionalidad; }
            set { SetProperty(ref nacionalidad, value); }
        }

        
        public AñadirDialogoVM()
        {
        }

        // Cuando se pulsa el botón Aceptar, enviamos lo que hay en el textblock bindeado en Nacionalidad
        public void EnviarNuevaNacionalidad()
        {
            WeakReferenceMessenger.Default.Send(new AgregarNacionalidadMessage(Nacionalidad));
        }

    }
}