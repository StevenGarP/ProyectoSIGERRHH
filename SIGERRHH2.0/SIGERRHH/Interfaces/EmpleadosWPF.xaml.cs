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
    /// Lógica de interacción para Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
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
    }
}
