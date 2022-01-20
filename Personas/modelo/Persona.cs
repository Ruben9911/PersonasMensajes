using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;

namespace Personas.modelo
{
    internal class Persona : ObservableObject
    {
        private String nombre;

        public String Nombre
        {
            get { return nombre; }
            set { SetProperty(ref nombre, value); }
        }

        private int edad;

        public int Edad
        {
            get { return edad; }
            set { SetProperty(ref edad, value); }
        }

        private String nacionalidad;

        public String Nacionalidad
        {
            get { return nacionalidad; }
            set { SetProperty(ref nacionalidad, value); }
        }

        private String datos;
        private Persona personaActual;

        public String Datos
        {
            get { return datos; }
            set { SetProperty(ref datos, value); }
        }

        public Persona(string nombre, int edad, string nacionalidad)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.nacionalidad = nacionalidad;
            Datos = ToString();
        }

        public Persona()
        {
        }

        public Persona(Persona personaActual)
        {
            this.personaActual = personaActual;
        }

        public override string ToString() => $"{nombre} - {edad} - {nacionalidad}";
    }
}