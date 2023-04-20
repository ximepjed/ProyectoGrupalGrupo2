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
    /// Lógica de interacción para Tareas.xaml
    /// </summary>
    public partial class Tareas : Window
    {

        public Tareas()
        {
            InitializeComponent();
        }

        private void Button_Salir(object sender, RoutedEventArgs e)
        {//Salida del sistema
            System.Windows.Application.Current.Shutdown();
        }

        private void Button_agregar_tarea(object sender, RoutedEventArgs e)
        {
        }

        private void Button_editar_tarea(object sender, RoutedEventArgs e)
        {
        }

        private void Button_eliminar_tarea(object sender, RoutedEventArgs e)
        {
        }

        private void nombre_tarea_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }

        private void descripción_tarea_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Menu(object sender, RoutedEventArgs e)
        {
            Curso_individual curso_individual = new Curso_individual();
            this.Close();
            curso_individual.Show();
        }
    }
}
