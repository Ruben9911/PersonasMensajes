using Personas.vms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Personas.contentcontrols
{
    /// <summary>
    /// Lógica de interacción para ListaPersonasControl.xaml
    /// </summary>
    public partial class ListaPersonasControl : UserControl
    {
        private MainWindowVM vm = new MainWindowVM();
        public ListaPersonasControl()
        {
            InitializeComponent();
            DataContext = vm;
        }
    }
}
