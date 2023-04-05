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
            if (txtUsuario.Text == "cgarciac534@ulacit.ed.cr" && txtContra.Text == "cgarciac")
            {
                Inicio inicio = new Inicio();
                inicio.Show();
            }
            if (txtUsuario.Text == "0" && txtContra.Text == "0")
            {
                Inicio inicio = new Inicio();
                inicio.Show();
            }
            else
            {
                Error_de_credenciales credenciales_error = new Error_de_credenciales();

                credenciales_error.Owner = this;
                credenciales_error.Show();
            }
        }
        private void Error_Pass(object sender, RoutedEventArgs e)
        {
            Password_error password_error = new Password_error();

            password_error.Owner = this;
            password_error.Show();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }
    }
}
