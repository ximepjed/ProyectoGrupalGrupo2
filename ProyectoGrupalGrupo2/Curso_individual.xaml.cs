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
            notas.Owner=this;
            notas.Show();
        }

        private void Button_Asistencia(object sender, RoutedEventArgs e)
        {
            Asistencia asistencia = new Asistencia();
            asistencia.Owner= this;
            asistencia.Show();
        }

        private void Button_Click_About(object sender, RoutedEventArgs e)
        {
            //pop up box
        }


        private void ComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            //configurar
        }

        private void Button_Tarea(object sender, RoutedEventArgs e)
        {
            Tareas tareas = new Tareas();
            tareas.Owner=this;
            tareas.Show();
        }

        private void Button_Rooster(object sender, RoutedEventArgs e)
        {
            //hacer ventana
        }

        private void Button_Inicio(object sender, RoutedEventArgs e)
        {
            Inicio inicio = new Inicio();
            inicio.Owner=this;
            inicio.Show();
        }
    }
}
