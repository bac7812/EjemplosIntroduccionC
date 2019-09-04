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

namespace Ejercicio12
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool arriba = true;
        int numeroJornada = 1;
        public MainWindow()
        {
            InitializeComponent();
            for(int e = 0; e < Datos.equipos.Count; e++)
            {
                if ((e % 2) == 0)
                {
                    equipoLocalListBox.Items.Add(Datos.equipos[e].equipo);
                    Jornada.equipoLocal.AddFirst(Datos.equipos[e].equipo);
                }
                else
                {
                    equipoVisitanteListBox.Items.Add(Datos.equipos[e].equipo);
                    Jornada.equipoVisitante.AddFirst(Datos.equipos[e].equipo);
                }
            }
        }

        private void siguienteBoton_Click(object sender, RoutedEventArgs e)
        {
            if (numeroJornada != 8)
            {
                if (arriba == true)
                {
                    Jornada.InsertarAlPrincipio();
                    equipoLocalListBox.Items.Clear();
                    for (int l = 0; l < Jornada.equipoLocal.Count; l++)
                    {
                        equipoLocalListBox.Items.Add(Jornada.equipoLocal.ElementAt(l));
                    }
                    arriba = false;
                    NumeroJornadaTextBlock.Text = Convert.ToString(numeroJornada++);
                }
                else
                {
                    Jornada.InsertarAlFinal();
                    equipoLocalListBox.Items.Clear();
                    equipoVisitanteListBox.Items.Clear();
                    for (int l = 0; l < Jornada.equipoLocal.Count; l++)
                    {
                        equipoLocalListBox.Items.Add(Jornada.equipoLocal.ElementAt(l));
                    }
                    for (int v = 0; v < Jornada.equipoVisitante.Count; v++)
                    {
                        equipoVisitanteListBox.Items.Add(Jornada.equipoVisitante.ElementAt(v));
                    }
                    arriba = true;
                    NumeroJornadaTextBlock.Text = Convert.ToString(numeroJornada++);
                }
            }
            else
            {
                MessageBox.Show("Fin de Jornada", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
