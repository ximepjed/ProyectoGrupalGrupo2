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
            MessageBox.Show("En este curso, los estudiantes obtendrán las destrezas para programar algoritmos mantenibles, en el sentido de que son" +
                "robustos, flexibles y reutilizables. Se aplica técnicas y patrones para lograr un código fuente fácil de entender, de probar y de cambiar.");
        }


        private void ComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
        }

        private void Button_Tarea(object sender, RoutedEventArgs e)
        {
            Tareas tareas = new Tareas();
            tareas.Owner=this;
            tareas.Show();
        }

        private void Button_Rooster(object sender, RoutedEventArgs e)
        {
            //hacer ventana con herencia
        }

 
        private void Button_Cerrar(object sender, RoutedEventArgs e)
        {// salida de la app
            System.Windows.Application.Current.Shutdown();
        }

        private void Button_sem1(object sender, RoutedEventArgs e)
        {
            Semanas_Frame.NavigationService.Navigate(new Semanas_páginas.Pag_sem1());
        }
        private void Button_sem2(object sender, RoutedEventArgs e)
        {
            Semanas_Frame.NavigationService.Navigate(new Semanas_páginas.Pag_sem2());
        }
        private void Button_sem3(object sender, RoutedEventArgs e)
        {
            Semanas_Frame.NavigationService.Navigate(new Semanas_páginas.Pag_sem3());
        }
        private void Button_sem4(object sender, RoutedEventArgs e)
        {
            Semanas_Frame.NavigationService.Navigate(new Semanas_páginas.Pag_sem4());
        }
        private void Button_sem5(object sender, RoutedEventArgs e)
        {
            Semanas_Frame.NavigationService.Navigate(new Semanas_páginas.Pag_sem5());
        }
        private void Button_sem6(object sender, RoutedEventArgs e)
        {
            Semanas_Frame.NavigationService.Navigate(new Semanas_páginas.Pag_sem6());
        }
        private void Button_sem7(object sender, RoutedEventArgs e)
        {
            Semanas_Frame.NavigationService.Navigate(new Semanas_páginas.Pag_sem7());
        }
        private void Button_sem8(object sender, RoutedEventArgs e)
        {
            Semanas_Frame.NavigationService.Navigate(new Semanas_páginas.Pag_sem8());
        }
        private void Button_sem9(object sender, RoutedEventArgs e)
        {
            Semanas_Frame.NavigationService.Navigate(new Semanas_páginas.Pag_sem9());
        }
        private void Button_sem10(object sender, RoutedEventArgs e)
        {
            Semanas_Frame.NavigationService.Navigate(new Semanas_páginas.Pag_sem10());
        }
        private void Button_sem11(object sender, RoutedEventArgs e)
        {
            Semanas_Frame.NavigationService.Navigate(new Semanas_páginas.Pag_sem11());
        }
        private void Button_sem12(object sender, RoutedEventArgs e)
        {
            Semanas_Frame.NavigationService.Navigate(new Semanas_páginas.Pag_sem12());
        }
        private void Button_sem13(object sender, RoutedEventArgs e)
        {
            Semanas_Frame.NavigationService.Navigate(new Semanas_páginas.Pag_sem13());
        }
        private void Button_sem14(object sender, RoutedEventArgs e)
        {
            Semanas_Frame.NavigationService.Navigate(new Semanas_páginas.Pag_sem14());
        }
        private void Button_sem15(object sender, RoutedEventArgs e)
        {
            Semanas_Frame.NavigationService.Navigate(new Semanas_páginas.Pag_sem15());
        }
    }
}
