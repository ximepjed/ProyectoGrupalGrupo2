using ProyectoGrupalGrupo2.Clase2;
using ProyectoGrupalGrupo2.Windows_extras;
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
    /// Interaction logic for Curso_individual2.xaml
    /// </summary>
    public partial class Curso_individual2 : Window
    {
        public Curso_individual2()
        {
            InitializeComponent();
        }

        private void Button_Click_About(object sender, RoutedEventArgs e)
        {//boton de informacion del curso y su pantalla
            Información_de_curso información_curso = new Información_de_curso();
            información_curso.Owner = this;
            información_curso.Show();

        }

        private void Button_Click_Cursos(object sender, RoutedEventArgs e)
        {
            Inicio inicio = new Inicio();
            this.Close();
            inicio.Show();
        }

        private void Button_Cerrar(object sender, RoutedEventArgs e)
        {// salida de la app
            System.Windows.Application.Current.Shutdown();

        }

        private void Button_Nota(object sender, RoutedEventArgs e)
        {
            Grades notas = new Grades();
            this.Close();
            notas.Show();

        }

        private void Button_Tarea(object sender, RoutedEventArgs e)
        {
            Homework tareas = new Homework();
            this.Close();
            tareas.Show();

        }

        private void Button_Asistencia(object sender, RoutedEventArgs e)
        {
            Attendance asistencia = new Attendance();
            this.Close();
            asistencia.Show();

        }

        private void Button_Rooster(object sender, RoutedEventArgs e)
        {
            Rooster2 rooster = new Rooster2();
            this.Close();
            rooster.Show();

        }

        private void ComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }

        //las 15 semanas correspondientes y su navegacion entre páginas...
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
