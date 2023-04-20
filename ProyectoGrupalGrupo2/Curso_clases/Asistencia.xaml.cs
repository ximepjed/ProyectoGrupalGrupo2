using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    /// Lógica de interacción para Asistencia.xaml
    /// </summary>
    public partial class Asistencia : Window
    {
        MessageBoxResult res;
        int cont1 = 0;
        int cont2 = 0;


        public Asistencia()
        {
            InitializeComponent();
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Salir(object sender, RoutedEventArgs e)
        { //salida del sistema
            System.Windows.Application.Current.Shutdown();
        }

        private void CheckBox_Checked_1(object sender, RoutedEventArgs e)
        {
            
        }

        private void Asistencia1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Asistencia2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Ausente1_Click(object sender, RoutedEventArgs e)
        {
            //variables para el cambio de color o brush
            var bc = new BrushConverter();
            cont1++;

            if (cont1 == 1)
            {
                Nota_asistencia1.Text = "90";
                { Estado_de_asistencia1.Fill = bc.ConvertFrom("#FFC6DE36") as Brush; }

            }

            if (cont1 == 2)
            {
                Nota_asistencia1.Text = "80";
                { Estado_de_asistencia1.Fill = bc.ConvertFrom("#FFEDC538") as Brush; }

            }

            if (cont1 == 3)
            {
                Nota_asistencia1.Text = "70";
                { Estado_de_asistencia1.Fill = bc.ConvertFrom("#FFEF852C") as Brush; }
                res = MessageBox.Show("¡Advertencia! Este estudiante ha completado el limite de faltas(3) de faltar una vez más reprobará el curso", "Limite de faltas", MessageBoxButton.OK, MessageBoxImage.Exclamation);

            }

            if (cont1 == 4)
            {
                Nota_asistencia1.Text = "60";
                { Estado_de_asistencia1.Fill = bc.ConvertFrom("#FF7F2020") as Brush; }
                res = MessageBox.Show("¡Lo sentimos! Este estudiante sobrepasó el limite de faltas (3), ha reprobado el curso automáticamente", "Limite de faltas", MessageBoxButton.OK, MessageBoxImage.Exclamation);

            }

        }

        private void Ausencia2_Click(object sender, RoutedEventArgs e)
        {
            //variables para el cambio de color o brush
            var bc = new BrushConverter();
            cont2++;

            if (cont2 == 1)
            {
                Nota_asistencia2.Text = "90";
                { Estado_de_asistencia2.Fill = bc.ConvertFrom("#FFC6DE36") as Brush; }
            }

            if (cont2 == 2)
            {
                Nota_asistencia2.Text = "80";
                { Estado_de_asistencia2.Fill = bc.ConvertFrom("#FFEDC538") as Brush; }
            }

            if (cont2 == 3)
            {
                Nota_asistencia2.Text = "70";
                { Estado_de_asistencia2.Fill = bc.ConvertFrom("#FFEF852C") as Brush; }
                res = MessageBox.Show("¡Advertencia! Este estudiante ha completado el limite de faltas(3) de faltar una vez más reprobará el curso", "Limite de faltas", MessageBoxButton.OK, MessageBoxImage.Exclamation);

            }

            if (cont2 == 4)
            {
                Nota_asistencia2.Text = "60";
                { Estado_de_asistencia2.Fill = bc.ConvertFrom("#FF7F2020") as Brush; }
                res = MessageBox.Show("¡Lo sentimos! Este estudiante sobrepasó el limite de faltas (3), ha reprobado el curso automáticamente", "Limite de faltas", MessageBoxButton.OK, MessageBoxImage.Exclamation);

            }

        }

        private void Justificado1_Click(object sender, RoutedEventArgs e)
        {
            //variables para el cambio de color o brush
            var bc = new BrushConverter();
            cont1++;

            if (cont1 == 1)
            {
                Nota_asistencia1.Text = "90";
                { Estado_de_asistencia1.Fill = bc.ConvertFrom("#FFC6DE36") as Brush; }
            }

            if (cont1 == 2)
            {
                Nota_asistencia1.Text = "80";
                { Estado_de_asistencia1.Fill = bc.ConvertFrom("#FFEDC538") as Brush; }

            }

            if (cont1 == 3)
            {
                Nota_asistencia1.Text = "70";
                { Estado_de_asistencia1.Fill = bc.ConvertFrom("#FFEF852C") as Brush; }
                res = MessageBox.Show("¡Advertencia! Este estudiante ha completado el limite de faltas(3) de faltar una vez más reprobará el curso", "Limite de faltas", MessageBoxButton.OK, MessageBoxImage.Exclamation);

            }

            if (cont1 == 4)
            {
                Nota_asistencia1.Text = "60";
                { Estado_de_asistencia1.Fill = bc.ConvertFrom("#FF7F2020") as Brush; }
                res = MessageBox.Show("¡Lo sentimos! Este estudiante sobrepasó el limite de faltas (3), ha reprobado el curso automáticamente", "Limite de faltas", MessageBoxButton.OK, MessageBoxImage.Exclamation);

            }
        }

        private void Justificado2_Click(object sender, RoutedEventArgs e)
        {
            //variables para el cambio de color o brush
            var bc = new BrushConverter();

            cont2++;

            if (cont2 == 1)
            {
                Nota_asistencia2.Text = "90";
                { Estado_de_asistencia2.Fill = bc.ConvertFrom("#FFC6DE36") as Brush; }
            }

            if (cont2 == 2)
            {
                Nota_asistencia2.Text = "80";
                { Estado_de_asistencia2.Fill = bc.ConvertFrom("#FFEDC538") as Brush; }

            }

            if (cont2 == 3)
            {
                Nota_asistencia2.Text = "70";
                { Estado_de_asistencia2.Fill = bc.ConvertFrom("#FFEF852C") as Brush; }
                res = MessageBox.Show("¡Advertencia! Este estudiante ha completado el limite de faltas(3) de faltar una vez más reprobará el curso", "Limite de faltas", MessageBoxButton.OK, MessageBoxImage.Exclamation);

            }

            if (cont2 == 4)
            {
                Nota_asistencia2.Text = "60";
                { Estado_de_asistencia2.Fill = bc.ConvertFrom("#FF7F2020") as Brush; }
                res = MessageBox.Show("¡Lo sentimos! Este estudiante sobrepasó el limite de faltas (3), ha reprobado el curso automáticamente", "Limite de faltas", MessageBoxButton.OK, MessageBoxImage.Exclamation);

            }
        }

        private void Button_Menu(object sender, RoutedEventArgs e)
        {
            Curso_individual curso_individual = new Curso_individual();
            this.Close();
            curso_individual.Show();
        }
    }
}
