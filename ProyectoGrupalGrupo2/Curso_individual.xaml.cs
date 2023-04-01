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
    /// Lógica de interacción para Curso_individual.xaml
    /// </summary>
    public partial class Curso_individual : Window
    {
        public Curso_individual()
        {
            InitializeComponent();
        }


        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //hacer
        }

        private void Button_Nota(object sender, RoutedEventArgs e)
        {
            Notas notas = new Notas();
            //notas.Owner();
            notas.Show();
        }

        private void Button_Asistencia(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_About(object sender, RoutedEventArgs e)
        {

        }


        private void ComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Tarea(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Rooster(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Inicio(object sender, RoutedEventArgs e)
        {

        }
    }
}
