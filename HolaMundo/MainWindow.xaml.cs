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

namespace HolaMundo
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public const string DEFAULT_MESSAGE = "Hola, Mundo";
        public MainWindow()
        {
            InitializeComponent();
            SaludoTextBlock.Text = DEFAULT_MESSAGE;
        }

        private void SaludarButton_Click(object sender, RoutedEventArgs e)
        {
            if(NombreTextBox.Text != "")
                SaludoTextBlock.Text = "Holda, " + NombreTextBox.Text;
        }

        private void LimpiarButton_Click(object sender, RoutedEventArgs e)
        {
            SaludoTextBlock.Text = DEFAULT_MESSAGE;
            NombreTextBox.Text = "";
        }
    }
}
