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
    /// Lógica de interacción para Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Ingreso_inicio(object sender, RoutedEventArgs e)
        {
            Inicio inicio = new Inicio();

            inicio.Owner = this;
            inicio.Show();
            this.Close();
        }
        private void Error_Pass(object sender, RoutedEventArgs e)
        {
            Password_error password_error = new Password_error();

            password_error.Owner = this;
            password_error.Show();
        }
    }
}
