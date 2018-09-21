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

namespace PracticaInteracciones
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            txtcuenta.Text = "Texto Modifiado";
        }

        private void sldporcenprop_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            lblporcenprop.Text =
                ((int)(sldporcenprop.Value)).ToString() +
                "%";

            float cuenta=
            float.Parse(txtcuenta.Text);

            float montoprop = (int)(sldporcenprop.Value) / 100.0f * cuenta;

            float totalApagar = cuenta + montoprop;

            lbltotalprop.Text = totalApagar.ToString();

        }
    }
}
