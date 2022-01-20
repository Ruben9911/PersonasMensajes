using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using Microsoft.Toolkit.Mvvm.Messaging;
using Personas.mensajeria;
using Personas.modelo;
using Personas.servicios;
using System;
using System.Collections.ObjectModel;

namespace Personas.vms
{
    internal class NuevaPersonaVM : ObservableObject
    {
        // Propiedades del formulario que creará una nueva Persona
        private Persona personaActual;

        public Persona PersonaActual
        {
            get { return personaActual; }
            set { SetProperty(ref personaActual, value); }
        }


        // Comando para abrir el dialogo para añadir una nacionalidad
        public RelayCommand AbrirAñadirDialogCommand { get; set; }

        // Propiedad donde guardamos las nacionalidades
        private ObservableCollection<String> listaNacionalidades;

        public ObservableCollection<String> ListaNacionalidades
        {
            get { return listaNacionalidades; }
            set { SetProperty(ref listaNacionalidades, value); }
        }

        public NuevaPersonaVM()
        {
            AbrirAñadirDialogCommand = new RelayCommand(AbrirAñadirDialog);

            // Carga de datos de las nacionalidades
            ListaNacionalidades = ServicioDatos.GetNacionalidades();

            PersonaActual = new Persona();
            // NuevaPersonaVM se suscribe al mensaje de difusión mandado por AñadirDialogoVM
            WeakReferenceMessenger.Default.Register<AgregarNacionalidadMessage>
                (this, (r, mensaje) =>
                {
                    ListaNacionalidades.Add(mensaje.Value);
                });
        }

        // Al pulsar el botón aceptar se llama a este método
        // Crea un objeto Persona con todos los datos del formulario y envía un mensaje de difusión al que está suscrito ListaPersonasVM
        public void AñadirPersona()
        {
            WeakReferenceMessenger.Default.Send(new AgregarPersonaMessage(new Persona(PersonaActual.Nombre, PersonaActual.Edad, PersonaActual.Nacionalidad)));
        }

        private void AbrirAñadirDialog()
        {
            ServicioNavegacion.AbrirAñadirDialog();
        }
    }
}