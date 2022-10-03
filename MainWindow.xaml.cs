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

namespace Tema2_CuadrosTexto
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            NombreTextBox.Tag = AyudaNombreTextBlock;
            ApellidoTextBox.Tag = AyudaApellidoTextBlock;
        }

        private void AyudaPulsada(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.F1)
            {
                TextBlock text = (TextBlock)(sender as TextBox).Tag;
                if (text.Visibility == Visibility.Hidden) text.Visibility = Visibility.Visible;
                else text.Visibility = Visibility.Hidden;
            }

        }
        private void AyudaEdadPulsada(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.F2)
            {
                if (int.TryParse((sender as TextBox).Text, out _))
                    AyudaEdadTextBlock.Text = "";

                else AyudaEdadTextBlock.Text = "Edad incorrecta";
            }

        }
    }
}
