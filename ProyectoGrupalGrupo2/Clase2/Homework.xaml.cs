using ProyectoGrupalGrupo2.Clase2;
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
    /// Interaction logic for Homework.xaml
    /// </summary>
    public partial class Homework : Window
    {
        List<String> Categorias = new List<String>(); //Lista para guardar los elementos del combobox de categoria
        public static List<Datos_Tareas2> Datos2 = new List<Datos_Tareas2>(); //Guarda los datos de nombre, descripción, categoría y fecha

        public Homework()
        {
            InitializeComponent();
            //Crea la lista de opciones para el combobox de categorias
            Categorias.Add("Foro");
            Categorias.Add("Presentación");
            Categorias.Add("Asignación");
            Categorias.Add("Quiz");

            cbox_Categoria.ItemsSource = Categorias; //Hca que combobox use los elementos creados anteriormente
        }

        private void Button_Menu(object sender, RoutedEventArgs e)
        {
            Curso_individual2 curso_individual2 = new Curso_individual2();
            this.Close();
            curso_individual2.Show();
        }

        private void Button_Salir(object sender, RoutedEventArgs e)
        {//Salida del sistema
            System.Windows.Application.Current.Shutdown();

        }

        private void lb_Tareas_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void nombre_tarea_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }

        private void descripción_tarea_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void Llenar_Lista()
        {
            try
            {
                //Asigna los valores de los textbox, combobox y select date a variables, para guardarlas en "Datos"
                string nombre = txt_nombre_tarea.Text;
                string categoria = cbox_Categoria.SelectedItem.ToString();
                string descripcion = txt_descripcion_tarea.Text;
                DateTime? Fecha = fecha_entrega_tarea.SelectedDate;
                string fecha = Fecha.Value.ToString("dd/MM/yyyy"); //guarda la fecha seleccionada tras volverla string

                //Guardas las variables en la lista
                Datos2.Add(new Datos_Tareas2($"{nombre}          ", $"|          {categoria}          |", $"           {descripcion}          |", $"          {fecha}"));

                //Refresca el listbox de tareas
                lb_Tareas.ItemsSource = null;
                lb_Tareas.ItemsSource = Datos2;


            }
            catch
            {
                MessageBox.Show("Debe llenar todos los espacios.", "¡Falta informacion!", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }


        private void Button_agregar_tarea(object sender, RoutedEventArgs e)
        {//Si se cumplen las condiciones permite que se agreguen los elementos a la lista y que se muestre en el listbox
            if (cbox_Categoria.SelectedItem != null && fecha_entrega_tarea.SelectedDate != null && txt_nombre_tarea.Text != null && txt_nombre_tarea.Text != " " &&
            txt_descripcion_tarea.Text != null && txt_descripcion_tarea.Text != " " && txt_nombre_tarea.Text != string.Empty && txt_descripcion_tarea.Text != string.Empty)
            {

                Llenar_Lista(); //Llama al método que llena la lista "Datos"

                txt_nombre_tarea.Clear();//Vacia el textbox del nombre
                txt_descripcion_tarea.Clear();//Vacia el textbox de la descripción

            }
            else
            {
                MessageBox.Show("Debe llenar todos los espacios.", "¡Falta informacion!", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }

        }

        private void Button_eliminar_tarea(object sender, RoutedEventArgs e)
        {
            try
            {
                if (txt_eliminar.Text.All(char.IsDigit)) //Permite que solo se ingresen numeros
                {
                    int pos = int.Parse(txt_eliminar.Text);
                    if (pos > Datos2.Count) { MessageBox.Show("Digite un número válido."); }
                    Datos2.RemoveAt(pos - 1); //Elimina la posicion elegida por el usuario
                    txt_eliminar.Clear(); //Vacia el textbox de eliminar
                }
                else { MessageBox.Show("Digite un número válido."); }
            }
            catch { }

        }
    }
}
