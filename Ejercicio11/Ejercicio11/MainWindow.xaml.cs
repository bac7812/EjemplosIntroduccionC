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

namespace Ejercicio11
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Cita cita = new Cita();
        public MainWindow()
        {
            InitializeComponent(); 
        }

        private void ConsultarBoton_Click(object sender, RoutedEventArgs e)
        {
            DatosDataGrid.ItemsSource = Datos.listaCitas;
            DatosDataGrid.Items.Refresh();
        }

        private void BuscarBoton_Click(object sender, RoutedEventArgs e)
        {
            cita = Datos.listaCitas.Where(c => c.Nombre.Equals(NombreTextBox.Text) || c.Apellidos.Equals(ApellidosTextBox.Text)).FirstOrDefault();
            if (cita != null)
            {
                List<Cita> mostrarCita = new List<Cita>();
                mostrarCita.Add(cita);
                DatosDataGrid.ItemsSource = mostrarCita;
                NombreTextBox.Text = cita.Nombre;
                ApellidosTextBox.Text = cita.Apellidos;
                HoraTextBox.Text = Convert.ToString(cita.Hora);
                MinutosTextBox.Text = Convert.ToString(cita.Minutos);
                FechaDataPicker.Text = Convert.ToString(cita.FechaCita);
            }
            else
            {
                MessageBox.Show("No encontrado datos", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void AnadirBoton_Click(object sender, RoutedEventArgs e)
        {
            cita.Nombre = NombreTextBox.Text;
            cita.Apellidos = ApellidosTextBox.Text;
            cita.Hora = Convert.ToUInt16(HoraTextBox.Text);
            cita.Minutos = Convert.ToUInt16(MinutosTextBox.Text);
            cita.FechaCita = Convert.ToDateTime(FechaDataPicker.Text);
            Datos.listaCitas.Add(cita);
            List<Cita> mostrarCita = new List<Cita>();
            mostrarCita.Add(cita);
            DatosDataGrid.ItemsSource = mostrarCita;
            MessageBox.Show("Guardar datos", "Información", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void ModificarBoton_Click(object sender, RoutedEventArgs e)
        {
            cita.Nombre = NombreTextBox.Text;
            cita.Apellidos = ApellidosTextBox.Text;
            cita.Hora = Convert.ToUInt16(HoraTextBox.Text);
            cita.Minutos = Convert.ToUInt16(MinutosTextBox.Text);
            cita.FechaCita = Convert.ToDateTime(FechaDataPicker.Text);
            DatosDataGrid.Items.Refresh();
            MessageBox.Show("Modificar datos", "Información", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void EliminarBoton_Click(object sender, RoutedEventArgs e)
        {
            Datos.listaCitas.Remove(cita);
            DatosDataGrid.Items.Refresh();
            MessageBox.Show("Eliminar datos", "Información", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void DatosDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                cita = (Cita)DatosDataGrid.SelectedItem;
                NombreTextBox.Text = cita.Nombre;
                ApellidosTextBox.Text = cita.Apellidos;
                HoraTextBox.Text = Convert.ToString(cita.Hora);
                MinutosTextBox.Text = Convert.ToString(cita.Minutos);
                FechaDataPicker.Text = Convert.ToString(cita.FechaCita);
            }
            catch (Exception exp)
            {

            }
        }

        private void VaciarBoton_Click(object sender, RoutedEventArgs e)
        {
            NombreTextBox.Text = "";
            ApellidosTextBox.Text = "";
            HoraTextBox.Text = "";
            MinutosTextBox.Text = "";
            FechaDataPicker.Text = "";
        }
    }
}
