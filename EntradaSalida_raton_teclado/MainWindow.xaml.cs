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

        private void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            Foco.Text = ((TextBox)sender).Name;
        }

        private void TextBox_MouseEnter(object sender, MouseEventArgs e)
        {
            RatonSobre.Text = ((TextBox)sender).Name;
        }

        private void TextBox_MouseLeave(object sender, MouseEventArgs e)
        {
            RatonSobre.Text = "";
        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (((TextBox)sender).Name == "TextBox2" && e.Key.ToString() == ConsoleKey.F1.ToString())
                TextBox2.Text = "Ayuda";

            if (((TextBox)sender).Name == "TextBox3")
            {
                string sinVocales = QuitaVocales(TextBox3.Text);
                TextBox3.Text = sinVocales;
                TextBox3.CaretIndex = TextBox3.Text.Length;
            }
        }
        

        private static string QuitaVocales(string txt)
        {
            string vocales = "aeiouAEIOU";
            string txtVocalesQuitado = "";

            for (int i = 0; i < txt.Length; i++)
            {
                if (!vocales.Contains(txt[i]))
                    txtVocalesQuitado += txt[i];
            }
            return txtVocalesQuitado;
        }

        private void Foco_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Foco.Text = "";
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                CLickIzquierdo.Background = Brushes.Green;
            if (e.RightButton == MouseButtonState.Pressed)
                CLickDerecho.Background = Brushes.Green;
        }

        private void Window_MouseUp(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Released)
                CLickIzquierdo.Background = Brushes.White;
            if (e.RightButton == MouseButtonState.Released)
                CLickDerecho.Background = Brushes.White;
        }
    }
}
