using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using Microsoft.Toolkit.Mvvm.Messaging;
using Personas.mensajeria;
using Personas.servicios;
using System;
using System.Collections.ObjectModel;

namespace Personas.vms
{
    internal class NuevaPersonaVM : ObservableObject
    {
        // Comando para abrir el dialogo para añadir una nacionalidad
        public RelayCommand AbrirAñadirDialogCommand { get; set; }

        // Propiedad donde guardamos las nacionalidades
        private ObservableCollection<String> listaNacionalidades;

        public ObservableCollection<String> ListaNacionalidades
        {
            get { return listaNacionalidades; }
            set { SetProperty(ref listaNacionalidades, value); }
        }

        private String nuevaNacionalidad;

        public String NuevaNacionalidad
        {
            get { return nuevaNacionalidad; }
            set { SetProperty(ref nuevaNacionalidad, value); }
        }

        public NuevaPersonaVM()
        {
            AbrirAñadirDialogCommand = new RelayCommand(AbrirAñadirDialog);

            ListaNacionalidades = ServicioDatos.GetNacionalidades();

            WeakReferenceMessenger.Default.Register<AgregarNacionalidadMessage>
                (this, (r, mensaje) => 
                { 
                    NuevaNacionalidad = mensaje.Value;
                    ListaNacionalidades.Add(mensaje.Value);
                });
        }

        private void AbrirAñadirDialog()
        {
            ServicioNavegacion.AbrirAñadirDialog();
        }
    }
}