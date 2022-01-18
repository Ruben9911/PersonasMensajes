using Personas.vms;
using System.Windows.Controls;

namespace Personas.contentcontrols
{
    /// <summary>
    /// Lógica de interacción para NuevaPersonaControl.xaml
    /// </summary>
    public partial class NuevaPersonaControl : UserControl
    {
        private NuevaPersonaVM vm = new NuevaPersonaVM();
        public NuevaPersonaControl()
        {
            InitializeComponent();
            DataContext = vm;
        }

        private void AceptarButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            vm.AñadirPersona();
        }
    }
}