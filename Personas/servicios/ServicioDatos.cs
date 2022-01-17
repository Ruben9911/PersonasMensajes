using Personas.modelo;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personas.servicios
{
    class ServicioDatos
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
