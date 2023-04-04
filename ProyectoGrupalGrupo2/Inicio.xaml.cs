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
    /// Lógica de interacción para Inicio.xaml
    /// </summary>
    public partial class Inicio : Window
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void Clase_cuadro(object sender, RoutedEventArgs e)
        {
            //boton grande, el cuadro con imagen
            Curso_individual curso_individual = new Curso_individual();
            curso_individual.Owner = this;
            curso_individual.Show();
        }
        private void Clase_boton(object sender, RoutedEventArgs e)
        {
            //boton individual del lado izquierdo
            Curso_individual curso_individual = new Curso_individual();
            curso_individual.Owner = this;
            curso_individual.Show();
        }

        private void Button_InfoPer(object sender, RoutedEventArgs e)
        {
            //popup box en donde dice info personal
            MessageBox.Show("Cristhian García Contreras, cgarciac534@ulacit.ed.cr");
        }

 
  
        private void Button_SignOut(object sender, RoutedEventArgs e)
        {//salida de la app
            System.Windows.Application.Current.Shutdown();
        }
    }
}
