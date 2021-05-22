using SIGERRHH.Clases.Base_de_Datos;
using System;
using System.Collections.Generic;
using System.Data;
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

namespace SIGERRHH.Interfaces
{
    /// <summary>
    /// Lógica de interacción para Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        public Window3()
        {
            InitializeComponent();
        }

        private DataTable BuscarDatos(String condicion = "1=1")
        {
            ClsConexion cn = new ClsConexion();
            DataTable dt = new DataTable();
            string query = $"Select * from tb_empleados where {condicion}";
            dt = cn.consultaTablaDirecta(query);
            return dt;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string dpi = Bdpi.Text;
            string nombre = Bnombre.Text;
            string puesto = Bpuesto.Text;
            string fecha = Bfecha.Text;
            string sentencia = $"delete tb_empleados where DPI = {dpi}";
            ClsConexion cn = new ClsConexion();
            cn.EjecutaSQLDirecto(sentencia);
            BuscarDatos();
        }
    }
}
