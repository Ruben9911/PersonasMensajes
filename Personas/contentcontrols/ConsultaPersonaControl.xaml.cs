using Personas.vms;
using System.Windows.Controls;

namespace Personas.contentcontrols
{
    public partial class ConsultaPersonaControl : UserControl
    {
        private ConsultaPersonaVM vm = new ConsultaPersonaVM();

        public ConsultaPersonaControl()
        {
            InitializeComponent();
            DataContext = vm;
        }
    }
}