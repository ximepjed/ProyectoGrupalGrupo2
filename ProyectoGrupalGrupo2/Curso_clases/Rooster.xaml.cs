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

namespace ProyectoGrupalGrupo2.Curso_clases
{
    /// <summary>
    /// Interaction logic for Rooster.xaml
    /// </summary>
    public partial class Rooster : Window
    {
        public Rooster()
        {
            InitializeComponent();
        }

        private void Button_Salir(object sender, RoutedEventArgs e)
        {//salida del sistema
            System.Windows.Application.Current.Shutdown();

        }

        private void Button_Menu(object sender, RoutedEventArgs e)
        {
            Curso_individual curso_individual = new Curso_individual();
            this.Close();
            curso_individual.Show();
        }
    }
}
