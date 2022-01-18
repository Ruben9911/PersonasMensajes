using Personas.vms;
using System.Windows.Controls;

namespace Personas.contentcontrols
{
    /// <summary>
    /// Lógica de interacción para ListaPersonasControl.xaml
    /// </summary>
    public partial class ListaPersonasControl : UserControl
    {
        private ListaPersonasVM vm = new ListaPersonasVM();

        public ListaPersonasControl()
        {
            InitializeComponent();
            DataContext = vm;
        }
    }
}