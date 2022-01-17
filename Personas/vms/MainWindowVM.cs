using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using Personas.modelo;
using Personas.servicios;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Personas.vms
{
    class MainWindowVM : ObservableObject
    {
        ServicioNavegacion servicioNavegacion = new ServicioNavegacion();
        
        private UserControl pestañaActual;

        // Comandos
        public RelayCommand AbrirListaPersonasCommand { get; }
        public RelayCommand AbrirNuevaPersonaCommand { get; }
        public RelayCommand AbrirAñadirDialogCommand { get; set; }
        // Propiedad donde se guardan los objetos de Persona
        private ObservableCollection<Persona> listaPersonas;

        public ObservableCollection<Persona> ListaPersonas
        {
            get { return listaPersonas; }
            set { SetProperty(ref listaPersonas, value); }
        }

        // Propiedad donde guardamos las nacionalidades
        private ObservableCollection<String> listaNacionalidades;

        public ObservableCollection<String> ListaNacionalidades
        {
            get { return listaNacionalidades; }
            set { SetProperty(ref listaNacionalidades, value); }
        }

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
            AbrirAñadirDialogCommand = new RelayCommand(AbrirAñadirDialog);
            // Instancia vacía para que al iniciar el programa no aparezca ningún UserControl seleccionado
            PestañaActual = new UserControl();
            
            ListaNacionalidades = ServicioDatos.GetNacionalidades();
            ListaPersonas = ServicioDatos.GetPersonas();
        }

        private void AbrirNuevaPersona()
        {
            PestañaActual = servicioNavegacion.AbrirNuevaPersona();
        }

        private void AbrirListaPersonas()
        {
            PestañaActual = servicioNavegacion.AbrirListaPersonas();
        }

        private void AbrirAñadirDialog()
        {
            servicioNavegacion.AbrirAñadirDialog();
        }
    }
}
