
using ProyectoGrupalGrupo2.Curso_clases;
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

        List<String> Categorias = new List<String>();
        public static List<Datos_Tareas> Datos = new List<Datos_Tareas>(); //Guarda los datos de nombre, descripción, categoría y fecha
        public Tareas()
        {
            InitializeComponent();
            //Crea la lista de opciones para el combobox de categorias
           

            Categorias.Add("Foro");
            Categorias.Add("Presentación");
            Categorias.Add("Asignación");
            Categorias.Add("Quiz");

            cbox_Categoria.ItemsSource = Categorias;



        }


        private void Button_Salir(object sender, RoutedEventArgs e)
        {//Salida del sistema
            System.Windows.Application.Current.Shutdown();
        }

        private void Button_agregar_tarea(object sender, RoutedEventArgs e)
        {
            
                if (cbox_Categoria.SelectedItem != null && fecha_entrega_tarea.SelectedDate != null && txt_nombre_tarea.Text != null && txt_nombre_tarea.Text != " " && 
                txt_descripcion_tarea.Text != null && txt_descripcion_tarea.Text != " " && txt_nombre_tarea.Text != string.Empty && txt_descripcion_tarea.Text != string.Empty)
                {

                    Llenar_Lista();

                    txt_nombre_tarea.Clear();
                    txt_descripcion_tarea.Clear();

                }
                else
                {
                MessageBox.Show("Debe llenar todos los espacios.", "¡Falta informacion!", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
            

        }

        private void Llenar_Lista()
        {
            try
            {
                string nombre = txt_nombre_tarea.Text;
                string categoria = cbox_Categoria.SelectedItem.ToString();
                string descripcion = txt_descripcion_tarea.Text;
                DateTime? Fecha = fecha_entrega_tarea.SelectedDate;
                string fecha = Fecha.Value.ToString("dd/MM/yyyy"); //guarda la fecha seleccionada

                Datos.Add(new Datos_Tareas($"{nombre}          ", $"|          {categoria}          |", $"           {descripcion}          |", $"          {fecha}"));
                lb_Tareas.ItemsSource = null;
                lb_Tareas.ItemsSource = Datos;


            }
            catch
            {
                MessageBox.Show("Debe llenar todos los espacios.", "¡Falta informacion!",  MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }

        private void Button_eliminar_tarea(object sender, RoutedEventArgs e)
        {
            try
            {
                if (txt_eliminar.Text.All(char.IsDigit))
                {
                    int pos = int.Parse(txt_eliminar.Text);
                    if (pos > Datos.Count) { MessageBox.Show("Digite un número válido."); }
                    Datos.RemoveAt(pos - 1);
                    txt_eliminar.Clear();
                }
                else { MessageBox.Show("Digite un número válido."); }
            }catch { }
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

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
