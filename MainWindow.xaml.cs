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

namespace MusicFest
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private BitmapImage imagOriginal = new BitmapImage(new Uri("/imagenes/avatar1.png", UriKind.Relative));
        private BitmapImage imagRollOver = new BitmapImage(new Uri("/imagenes/avatar2.png", UriKind.Relative));
        public MainWindow()
        {
            InitializeComponent();
        }

        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                lblEstado.Content = "Se pulsó el enter ";
                passContrasena.IsEnabled = true;
                passContrasena.Focus();
            }
        }

        private void imgAvatar_MouseEnter(object sender, MouseEventArgs e)
        {
            lblEstado.Content = "Entrando en el avatar y cambiando imagen";
            imgAvatar.Source = imagRollOver;
        }

        private void imgAvatar_MouseLeave(object sender, MouseEventArgs e)
        {
            lblEstado.Content = "Saliendo del avatar y restaurando la imagen";
            imgAvatar.Source = imagOriginal;
        }

        private void pnlDisenoPrincipal_MouseDown(object sender, MouseButtonEventArgs e)
        {
            lblEstado.Content = "Coordenadas del Click [" + e.GetPosition(this).X + "," + e.GetPosition(this).Y + "]";
        }

        private void passContrasena_KeyUp(object sender, KeyEventArgs e)
        {
            lblEstado.Content = "Has pulsado la tecla <<" + e.Key.ToString() + ">>";
        }
    }
}
