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
        //Variable
        String Mensaje;
        String Hora;

        public Tareas()
        {
            InitializeComponent();
            Mensaje = "Se ha subido el archivo.";
            Hora= DateTime.Now.ToString("h:mm:ss tt");
        }

        private void Button_Click(object sender, RoutedEventArgs e) //Boton Lab1.pdf
        {
           
        }

        private void Button_Click_1(object sender, RoutedEventArgs e) //Boton Lab2.pdf
        {
            
        }
        private void Button_Salir(object sender, RoutedEventArgs e)
        {//Salida del sistema
            System.Windows.Application.Current.Shutdown();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e) //Boton para simular que se subió la tarea
        {
            MessageBox.Show($"{this.Mensaje} \nHora de subida: {Hora}");
        }

        private void Button_Click_3(object sender, RoutedEventArgs e) //Boton para simular que se subió la tarea
        {
            MessageBox.Show($"{this.Mensaje} \nHora de subida: {Hora}");
        }
    }
}
