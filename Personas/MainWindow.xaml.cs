using Personas.vms;
using System.Windows;

namespace Personas
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MainWindowVM vm = new MainWindowVM();

        public MainWindow()
        {
            InitializeComponent();
            DataContext = vm;
        }

        private void NuevaPersonaButton_Click(object sender, RoutedEventArgs e)
        {
        }

        private void ListaPersonasButton_Click(object sender, RoutedEventArgs e)
        {
        }
    }
}