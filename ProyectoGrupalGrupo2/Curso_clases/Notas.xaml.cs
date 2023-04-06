﻿using System;
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
    /// Lógica de interacción para Notas.xaml
    /// </summary>
    public partial class Notas : Window
    {
        public Notas()
        {
            InitializeComponent();
        }


        private void Button_Salir(object sender, RoutedEventArgs e)
        { // salida del sistema

            System.Windows.Application.Current.Shutdown();
        }

        private void TextBox1(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox2(object sender, TextChangedEventArgs e)
        {

        }

        public void Button_Agregar1(object sender, RoutedEventArgs e)
        {// convertirlo en herencias y declarar para que no cambien solo por cerrar esta ventana 

            if (Ingresar1.Text.All(char.IsDigit)) {
                int Grade1;
                Grade1 = int.Parse(Ingresar1.Text);
                if (Grade1 < 0) { MessageBox.Show("La nota debe de estar entre 0 y 100"); }
                if (Grade1 > 100) { MessageBox.Show("La nota debe de estar entre 0 y 100"); }

                Nota1.Text = Ingresar1.Text;
                //variables para el cambio de color o brush
                var bc = new BrushConverter();

                if (Grade1 < 70) { Estado1.Text = "Reprobado"; Estado1.Background = bc.ConvertFrom("#FF7F2020") as Brush; }
                if (Grade1 >= 70) { Estado1.Text = "Aprobado"; Estado1.Background = bc.ConvertFrom("#FF6CB329") as Brush; }
            }

            else { MessageBox.Show("La nota debe de estar entre 0 y 100"); }
            

        }

        private void Button_Agregar2(object sender, RoutedEventArgs e)
        {// convertirlo en herencias y declarar para que no cambien solo por cerrar esta ventana 
           
            if (Ingresar2.Text.All(char.IsDigit)) {
                int Grade2;
                Grade2 = int.Parse(Ingresar2.Text);
                if (Grade2 < 0) { MessageBox.Show("La nota debe de estar entre 0 y 100"); }
                if (Grade2 > 100) { MessageBox.Show("La nota debe de estar entre 0 y 100"); }

                Nota2.Text = Ingresar2.Text;
                //variables para el cambio de color o brush
                var bc = new BrushConverter();

                if (Grade2 < 70) { Estado2.Text = "Reprobado"; Estado2.Background = bc.ConvertFrom("#FF7F2020") as Brush; }
                if (Grade2 >= 70) { Estado2.Text = "Aprobado"; Estado2.Background = bc.ConvertFrom("#FF6CB329") as Brush; }
            }

            else { MessageBox.Show("La nota debe de estar entre 0 y 100"); }


        }
    }
}
