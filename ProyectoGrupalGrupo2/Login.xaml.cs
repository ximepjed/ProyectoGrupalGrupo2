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

            //habilitar el boton de ingresar solo si estan ambas credenciales (correctas o incorrectas)
            if (txtUsuario.Text != "" && passwordLogin.Password != "")
            {
                Button_login.IsEnabled = true;
            }
            else
            {
                Button_login.IsEnabled = false;
            }

        }

        //Button_login.IsEnabled = false;

        private void Button_inicio(object sender, RoutedEventArgs e)
        {
            //if para la el acceso a whiteboard, recordemos que es la administracion (nosotros) los que otorgamos correos y passwords
            if (txtUsuario.Text == "cgarciac534@ulacit.ed.cr" && passwordLogin.Password == "cgarciac")
            {
                //ventana inicio
                Inicio inicio = new Inicio();
                inicio.Show();
            }
            if (txtUsuario.Text == "0" && passwordLogin.Password == "0")
            {
                Inicio inicio = new Inicio();
                inicio.Show();
            }
            else
            {
                //window para errores de credenciales
                Error_de_credenciales credenciales_error = new Error_de_credenciales();

                credenciales_error.Owner = this;
                credenciales_error.Show();
            }
        }
        private void Error_Pass(object sender, RoutedEventArgs e)
        {
            //window para contraseña olvidada
            Password_error password_error = new Password_error();

            password_error.Owner = this;
            password_error.Show();
        }

        //validacion de textbox
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            //texto de usuario
            if (txtUsuario.Text != "" && passwordLogin.Password != "" )
            {
                Button_login.IsEnabled = true;
            }
            else
            {
                Button_login.IsEnabled = false;
            }
        }
        private void Password_passwordChanged(object sender, RoutedEventArgs e)
        {
            //texto de usuario
            if (txtUsuario.Text != "" && passwordLogin.Password != "")
            {
                Button_login.IsEnabled = true;
            }
            else
            {
                Button_login.IsEnabled = false;
            }
        }
    }
}
