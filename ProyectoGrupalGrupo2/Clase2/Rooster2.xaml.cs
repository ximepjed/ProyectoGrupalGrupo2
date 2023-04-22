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

namespace ProyectoGrupalGrupo2.Clase2
{
    /// <summary>
    /// Interaction logic for Rooster2.xaml
    /// </summary>
    public partial class Rooster2 : Window
    {
        public Rooster2()
        {
            InitializeComponent();
        }

        private void Button_Menu(object sender, RoutedEventArgs e)
        {
            Curso_individual2 curso_individual2 = new Curso_individual2();
            this.Close();
            curso_individual2.Show();

        }

        private void Button_Salir(object sender, RoutedEventArgs e)
        {//salida del sistema
            System.Windows.Application.Current.Shutdown();

        }
    }
}
