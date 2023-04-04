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
using System.Windows.Shapes;

namespace ProyectoGrupalGrupo2
{
    /// <summary>
    /// Lógica de interacción para Notas.xaml
    /// </summary>
    public partial class Notas : Window
    {
        public Notas()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Salir(object sender, RoutedEventArgs e)
        { // salida del sistema

            System.Windows.Application.Current.Shutdown();
        }

        private void Button_Agregar(object sender, RoutedEventArgs e)
        {
            TextBlock.Text

        }

        private void TextBox(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox1(object sender, TextChangedEventArgs e)
        {

        }
    }
}
