using SIGERRHH.Clases.Archivos;
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
    /// Lógica de interacción para Window4.xaml
    /// </summary>
    public partial class Window4 : Window
    {
        public Window4()
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
            string nombre = Mnombre.Text;
            string edad = Medad.Text;
            string puesto = Mpuesto.Text;
            string salario = Msalario.Text;
            string depto = Mdepto.Text;
            string condicion = $"DPI = {Mdpi}";
            DataTable dt = BuscarDatos(condicion);
           
            if (dt.Rows.Count > 0)
            {
                int dpi = dt.Rows[0].Field<Int32>("DPI");
                Mdpi.Text = dpi + "";
            }
            else
            {
                Mnombre.Text = "No hay informacion";
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string dpi = Mdpi.Text;
            string salario = Msalario.Text;
            string puesto = Mpuesto.Text;
            string depto = Mdepto.Text;
            string sentencia = $"update tb_empleados set = {salario},'{puesto}','{depto}' where DPI = {dpi}";
            ClsConexion cn = new ClsConexion();
            cn.EjecutaSQLDirecto(sentencia);
            BuscarDatos();
        }
    }
}
