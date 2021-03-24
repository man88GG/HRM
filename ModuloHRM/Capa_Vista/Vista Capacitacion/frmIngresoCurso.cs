using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Controlador;
using Capa_Controlador.Controlador_Capacitación;

namespace Capa_Vista.Vista_Capacitacion
{
    public partial class frmIngresoCurso : Form
    {
        //Inicializar controlador
        clsControladorCapacitacion con = new clsControladorCapacitacion();       
        public frmIngresoCurso()
        {
            InitializeComponent();
        }
        //Agregar capacitación
        private void btnAgregarCap_Click(object sender, EventArgs e)
        {
            //Muestra mantenimientos de cursos
            frmCursos emp = new frmCursos();
            emp.ShowDialog();
        }
        //Actualizar la tabla
        private void funcActualizarTabla()
        {
            //Llamada a controlador con paso de parámetros
            lsvInfoCap.Items.Clear();
            DataTable dato = con.funcLlenarDGVCurso();
            //Llenar listView
            foreach (DataRow row in dato.Rows)
            {
                ListViewItem item = new ListViewItem(row[0].ToString());
                for (int i = 1; i < dato.Columns.Count; i++)
                {
                    item.SubItems.Add(row[i].ToString());
                }
                lsvInfoCap.Items.Add(item);
            }
        }
        //Timer para actualizar tabla
        private void timer1_Tick(object sender, EventArgs e)
        {
            //Llamada a función
            funcActualizarTabla();
        }
    }
}
