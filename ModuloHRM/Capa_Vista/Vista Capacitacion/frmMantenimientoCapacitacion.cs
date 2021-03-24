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
    public partial class frmMantenimientoCapacitacion : Form
    {
        //Inicializar controlador
        clsControladorCapacitacion con = new clsControladorCapacitacion();
        public frmMantenimientoCapacitacion()
        {
            InitializeComponent();
        }
        //Buscar capacitación empleado
        private void btnBuscarEmp_Click(object sender, EventArgs e)
        {
            //Validación
            if (txtBusqCodEmp.Text == "") { MessageBox.Show("Campo Vacío"); }
            else
            {
                //Creación de variables
                string idEmpleado = txtBusqCodEmp.Text;
                string[] datos = new string[3];
                //Llamada a controlador con paso de parámetros
                datos = con.funcConsultaEmp(idEmpleado);
                //Ingreso de datos
                txtNombEmp.Text = datos[0];
                txtEstEmp.Text = datos[1];
                txtDeptEmp.Text = datos[2];
            }
        }
        //Buscar edición de capacitación
        private void btnBuscarEdit_Click(object sender, EventArgs e)
        {
            //Creación de variables y llamada a controlador con paso de parámetros
            string[] datos = new string[6];
            string[] datosc = new string[3];
            datos = con.funcConsultarCapa(txtCodiCapa.Text);
            txtBusqCodEmp.Text = datos[0];
            //Validación
            if (txtBusqCodEmp.Text != "")
            {
                //Llamada a controlador con paso de parámetros
                datosc = con.funcConsultaEmp(txtBusqCodEmp.Text);
                DataTable dato = con.funcLlenarCurso();
                cmbCurso.DataSource = dato;
                cmbCurso.DisplayMember = "nombre_curso";
                cmbCurso.ResetText();
                dtpFechIni.Value = Convert.ToDateTime(datos[2]);
                dtpFechFin.Value = Convert.ToDateTime(datos[3]);
            }
            //Muestra datos
            txtNombEmp.Text = datosc[0];
            txtEstEmp.Text = datosc[1];
            txtDeptEmp.Text = datosc[2];
            txtCodigoEncabezado.Text = datos[1];
            nudHoras.Value = Convert.ToInt32(datos[4]);
            cmbCurso.Text = datos[5];
        }
        //Actualizar capacitación
        private void btnIngresoCurso_Click(object sender, EventArgs e)
        {
            //Validación
            if (txtCodiCapa.Text == "" ||txtBusqCodEmp.Text == "" ||cmbCurso.Text == "" ||nudHoras.Value == 0 ||txtCodigoEncabezado.Text == "") { MessageBox.Show("Campo Vacío"); }
            else
            {
                //Creación de variables
                string idCapacitacion = txtCodiCapa.Text;
                string fechaInicio = dtpFechIni.Value.Date.ToShortDateString();
                string fechaFin = dtpFechFin.Value.Date.ToShortDateString(); ;
                string idEmpleado = txtBusqCodEmp.Text;
                string nomCur = cmbCurso.Text;
                string horas = Convert.ToString(nudHoras.Value);
                string idEncCapa = txtCodigoEncabezado.Text;
                //Llamada a controlador con paso de parámetros
                con.funcActualizarCapa(idCapacitacion, fechaInicio, fechaFin, idEmpleado, nomCur, horas, idEncCapa);
                //Vacar campos
                txtCodiCapa.Text = "";
                txtBusqCodEmp.Text = "";
                cmbCurso.Text = "";
                nudHoras.Value = 0;
                txtCodigoEncabezado.Text = "";
            }
        }
        //Busqueda eliminación capacitación
        private void btnBuscElimi_Click(object sender, EventArgs e)
        {
            //Creación de variables
            string[] datos = new string[6];
            string[] datosc = new string[3];
            //Llamada a controlador con paso de parámetros
            datos = con.funcConsultarCapa(txtCodigoCapE.Text);
            txtEmpEC.Text = datos[0];
            //Validación
            if (txtEmpEC.Text != "")
            {
                //Llamada a controlador con paso de parámetros
                datosc = con.funcConsultaEmp(txtEmpEC.Text);
                DataTable dato = con.funcLlenarCurso();
                cmbCursoE.DataSource = dato;
                cmbCursoE.DisplayMember = "nombre_curso";
                cmbCursoE.ResetText();
                dtpFechIE.Value = Convert.ToDateTime(datos[2]);
                dtpFechFE.Value = Convert.ToDateTime(datos[3]);
            }
            //Muestra datos
            txtNombEmpE.Text = datosc[0];
            txtEstadoEE.Text = datosc[1];
            txtDepEE.Text = datosc[2];
            txtCodigoEncCapE.Text = datos[1];
            nudHorasE.Value = Convert.ToInt32(datos[4]);
            cmbCursoE.Text = datos[5];
        }
        //Eliminar capacitación
        private void btnEliminarC_Click(object sender, EventArgs e)
        {
            //Validación
            if (txtCodigoCapE.Text == "") { MessageBox.Show("Campo Vacío"); }
            else
            {
                //Creación de variables con llamada a controlador 
                string idCapa = txtCodigoCapE.Text;
                string idEncCapa = txtCodigoEncCapE.Text;
                con.funcEliminarCapa(idCapa, idEncCapa);
                //Vacíar campos
                txtCodigoCapE.Text = "";
                txtEmpEC.Text = "";
                txtNombEmpE.Text = "";
                txtDepEE.Text = "";
                txtEstadoEE.Text = "";
                txtCodigoEncCapE.Text = "";
                cmbCursoE.Text = "";
                nudHorasE.Value = 0;
            }
        }
    }
}