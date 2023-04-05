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

        private void Nota1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Nota2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Ausente1(object sender, RoutedEventArgs e)
        {
            cont1++;

            if (cont1 == 1)
            {
                AusenciaNota2.Text = "90";

            }

            if (cont1 == 2)
            {
                AusenciaNota2.Text = "80";

            }

            if (cont1 == 3)
            {
                AusenciaNota2.Text = "70";
                res = MessageBox.Show("¡Advertencia! Este estudiante ha completado el limite de faltas(3) de faltar una vez más reprobará el curso", "Limite de faltas", MessageBoxButton.OK, MessageBoxImage.Exclamation);

            }

            if (cont1 == 4)
            {
                AusenciaNota2.Text = "60";
                res = MessageBox.Show("¡Lo sentimos! Este estudiante sobrepasó el limite de faltas (3), ha reprobado el curso automáticamente", "Limite de faltas", MessageBoxButton.OK, MessageBoxImage.Exclamation);

            }

        }

        private void AusenciaNota_2_Click(object sender, RoutedEventArgs e)
        {
            cont2++;

            if (cont2 == 1)
            {
                AusenciaNota2.Text = "90";

            }

            if (cont2 == 2)
            {
                AusenciaNota2.Text = "80";
                
            }

            if (cont2 == 3)
            {
                AusenciaNota2.Text = "70";
                res = MessageBox.Show("¡Advertencia! Este estudiante ha completado el limite de faltas(3) de faltar una vez más reprobará el curso", "Limite de faltas", MessageBoxButton.OK, MessageBoxImage.Exclamation);

            }

            if (cont2 == 4)
            {
                AusenciaNota2.Text = "60";
                res = MessageBox.Show("¡Lo sentimos! Este estudiante sobrepasó el limite de faltas (3), ha reprobado el curso automáticamente", "Limite de faltas", MessageBoxButton.OK, MessageBoxImage.Exclamation);

            }

        }

        private void Justificado1_Click(object sender, RoutedEventArgs e)
        {
            cont1++;

            if (cont1 == 1)
            {
                AusenciaNota2.Text = "90";

            }

            if (cont1 == 2)
            {
                AusenciaNota2.Text = "80";

            }

            if (cont1 == 3)
            {
                AusenciaNota2.Text = "70";
                res = MessageBox.Show("¡Advertencia! Este estudiante ha completado el limite de faltas(3) de faltar una vez más reprobará el curso", "Limite de faltas", MessageBoxButton.OK, MessageBoxImage.Exclamation);

            }

            if (cont1 == 4)
            {
                AusenciaNota2.Text = "60";
                res = MessageBox.Show("¡Lo sentimos! Este estudiante sobrepasó el limite de faltas (3), ha reprobado el curso automáticamente", "Limite de faltas", MessageBoxButton.OK, MessageBoxImage.Exclamation);

            }
        }

        private void Justificado2_Click(object sender, RoutedEventArgs e)
        {
            cont2++;

            if (cont2 == 1)
            {
                AusenciaNota2.Text = "90";

            }

            if (cont2 == 2)
            {
                AusenciaNota2.Text = "80";

            }

            if (cont2 == 3)
            {
                AusenciaNota2.Text = "70";
                res = MessageBox.Show("¡Advertencia! Este estudiante ha completado el limite de faltas(3) de faltar una vez más reprobará el curso", "Limite de faltas", MessageBoxButton.OK, MessageBoxImage.Exclamation);

            }

            if (cont2 == 4)
            {
                AusenciaNota2.Text = "60";
                res = MessageBox.Show("¡Lo sentimos! Este estudiante sobrepasó el limite de faltas (3), ha reprobado el curso automáticamente", "Limite de faltas", MessageBoxButton.OK, MessageBoxImage.Exclamation);

            }
        }
    }
}
