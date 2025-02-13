﻿using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using Personas.servicios;
using System.Windows.Controls;

namespace Personas.vms
{
    internal class MainWindowVM : ObservableObject
    {
        private UserControl pestañaActual;

        // Comandos para las pestañas
        public RelayCommand AbrirListaPersonasCommand { get; }

        public RelayCommand AbrirNuevaPersonaCommand { get; }
        public RelayCommand AbrirConsultaPersonaCommand { get; }

        // Propiedad donde guardamos el UserControl que está seleccionado
        public UserControl PestañaActual
        {
            get { return pestañaActual; }
            set { SetProperty(ref pestañaActual, value); }
        }

        public MainWindowVM()
        {
            // Instacia de los comandos pasando por parámetro los métodos que abren las pestañas
            AbrirListaPersonasCommand = new RelayCommand(AbrirListaPersonas);
            AbrirNuevaPersonaCommand = new RelayCommand(AbrirNuevaPersona);
            AbrirConsultaPersonaCommand = new RelayCommand(AbrirConsultaPersona);
            // Instancia vacía para que al iniciar el programa no aparezca ningún UserControl seleccionado
            PestañaActual = new UserControl();
        }

        private void AbrirNuevaPersona()
        {
            PestañaActual = ServicioNavegacion.AbrirNuevaPersona();
        }

        private void AbrirListaPersonas()
        {
            PestañaActual = ServicioNavegacion.AbrirListaPersonas();
        }

        private void AbrirConsultaPersona()
        {
            PestañaActual = ServicioNavegacion.AbrirConsultaPersona();
        }
    }
}