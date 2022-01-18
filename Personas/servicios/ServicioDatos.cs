using Personas.modelo;
using System;
using System.Collections.ObjectModel;

namespace Personas.servicios
{
    internal class ServicioDatos
    {
        public static ObservableCollection<Persona> GetPersonas() =>
            new ObservableCollection<Persona>()
            {
                new Persona("Joakin",25,"Italiana"),
                new Persona("Pepe", 69, "Española"),
                new Persona("Juan", 13, "Francesa")
            };

        public static ObservableCollection<String> GetNacionalidades() =>
            new ObservableCollection<String>() { "Italiana", "Española", "Francesa" };
    }
}