using Personas.vms;
using System.Windows;

namespace Personas.vistas
{
    /// <summary>
    /// Lógica de interacción para AñadirDialog.xaml
    /// </summary>
    public partial class AñadirDialog : Window
    {
        private AñadirDialogoVM vm = new AñadirDialogoVM();
        public AñadirDialog()
        {
            InitializeComponent();
            DataContext = vm;
        }

        private void AceptarButton_Click(object sender, RoutedEventArgs e)
        {
            vm.EnviarNuevaNacionalidad();
            DialogResult = true;
        }
    }
}