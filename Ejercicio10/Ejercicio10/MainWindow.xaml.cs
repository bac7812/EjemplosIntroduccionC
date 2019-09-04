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

namespace Ejercicio10
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MaquinaCambio maquina = new MaquinaCambio();

        public MainWindow()
        {
            InitializeComponent();
            SaldoDataGrid.ItemsSource = Datos.monedas;
        }

        private void BotonSuma_Click(object sender, RoutedEventArgs e)
        {
            SaldoDataGrid.ItemsSource = Datos.monedas;
            Datos.monedas.ElementAt(MonedasCantidadComboBox.SelectedIndex).AnadirNumMonedas(1);
            SaldoDataGrid.Items.Refresh();
        }

        private void BotonResta_Click(object sender, RoutedEventArgs e)
        {
            if (Datos.monedas.ElementAt(MonedasCantidadComboBox.SelectedIndex).valor > 0)
            {
                SaldoDataGrid.ItemsSource = Datos.monedas;
                Datos.monedas.ElementAt(MonedasCantidadComboBox.SelectedIndex).DisminuirMonedas(1);
                SaldoDataGrid.Items.Refresh();
            }
        }

        private void BotonCambiar_Click(object sender, RoutedEventArgs e)
        {
            CambioDataGrid.ItemsSource = maquina.ObtenerCambio(Datos.monedas.ElementAt(MonedasCambioComboBox.SelectedIndex));
            SaldoDataGrid.Items.Refresh();
        }

        private void BotonSaldo_Click(object sender, RoutedEventArgs e)
        {
            //TextBlockSaldo.Text = "Total: " + maquina.ObtenerSaldoMaquina();
            TextBlockSaldo.Text = "Total: " + Datos.monedas.Sum(s => s.valor * s.cantidad).ToString();
            SaldoDataGrid.ItemsSource = Datos.monedas.Select(s => new { Valor = s.valor, Cantidad = s.cantidad, Total = s.valor * s.cantidad}).ToList();
        }
    }
}
