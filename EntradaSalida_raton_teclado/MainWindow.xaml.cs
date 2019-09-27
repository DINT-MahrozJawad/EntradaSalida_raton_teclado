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

namespace EntradaSalida_raton_teclado
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox1_GotFocus(object sender, RoutedEventArgs e)
        {
            Foco.Text = "TextBox 1";
        }
        private void TextBox2_GotFocus(object sender, RoutedEventArgs e)
        {
            Foco.Text = "TextBox 2";
        }
        private void TextBox3_GotFocus(object sender, RoutedEventArgs e)
        {
            Foco.Text = "TextBox 3";
        }

        private void TesxtBox1_MouseEnter(object sender, MouseEventArgs e)
        {
            RatonSobre.Text = "TextBox 1";
        }
        private void TesxtBox2_MouseEnter(object sender, MouseEventArgs e)
        {
            RatonSobre.Text = "TextBox 2";
        }
        private void TesxtBox3_MouseEnter(object sender, MouseEventArgs e)
        {
            RatonSobre.Text = "TextBox 3";
        }

        private void Grid_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            CLickDerecho.Background = Brushes.Green;
            e.Handled = false;
        }

        private void Grid_PreviewMouseRightButtonUp(object sender, MouseButtonEventArgs e)
        {
            CLickDerecho.Background = Brushes.White;
        }

        private void Grid_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            CLickIzquierdo.Background = Brushes.Green;
        }

        private void Grid_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            CLickIzquierdo.Background = Brushes.White;
        }

        private void TextBox_MouseLeave(object sender, MouseEventArgs e)
        {
            RatonSobre.Text = "";
        }

        private void Foco_MouseEnter(object sender, MouseEventArgs e)
        {
            Foco.Text = "";
        }

        private void TesxtBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key.ToString() == ConsoleKey.F1.ToString())
            {
                TextBox2.Text = "Ayuda";
            }
        }
    }
}
