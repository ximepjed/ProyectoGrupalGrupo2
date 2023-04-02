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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ProyectoGrupalGrupo2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Ingresar_login(object sender, RoutedEventArgs e)
        {
            Login login = new Login();

            login.Owner= this;
            login.Show();

        

        }
        private void Button_infoWhite(object sender, RoutedEventArgs e)
        {
            Ulacit_Frame.NavigationService.Navigate(new Información_Whiteboard());
        }
        private void Button_infoULACIT(object sender, RoutedEventArgs e)
        {
            Ulacit_Frame.NavigationService.Navigate(new Información_Ulacit());
        }

        private void Version1_Navigated(object sender, NavigationEventArgs e)
        {

        }
    }
}
