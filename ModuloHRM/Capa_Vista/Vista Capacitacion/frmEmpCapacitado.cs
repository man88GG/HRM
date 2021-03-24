using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Controlador;
using Capa_Controlador.Controlador_Capacitación;

namespace Capa_Vista.Vista_Capacitacion
{
    public partial class frmEmpCapacitado : Form
    {
        //Inicializacón de la capa controlador
        clsControladorCapacitacion con = new clsControladorCapacitacion();
        public frmEmpCapacitado()
        {
            InitializeComponent();
        }
        //Evento de validacion de ingreso
        public void letra(object sender, KeyPressEventArgs e)
        {
            clsValidacion.funcLetras(e);
        }
        public void numero(object sender, KeyPressEventArgs e)
        {
            clsValidacion.funcNumeros(e);
        }
        //Fin de validacion de ingresos
        //Búsqueda de empleado
        private void btnBuscarEmp_Click(object sender, EventArgs e)
        {
            //Validación
            if (txtBusqCodEmp.Text == "") { MessageBox.Show("Campo Vacío"); }
            else
            {
                //Llamada a controlador con llenado de tabla
                DataTable dato = con.funcLlenarCurso();
                cmbCurso.DataSource = dato;
                cmbCurso.DisplayMember = "nombre_curso";
                cmbCurso.ResetText();
                //Creación de variables
                string idEmpleado = txtBusqCodEmp.Text;
                string[] datos = new string[3];
                //Llamada a controlador con paso de parámetros
                datos = con.funcConsultaEmp(idEmpleado);
                //Ingreso de datos a los objetos
                txtNombEmp.Text = datos[0];
                txtEstEmp.Text = datos[1];
                txtDeptEmp.Text = datos[2];
            }
        }
        //Ingreso de curso
        private void btnIngresoCurso_Click(object sender, EventArgs e)
        {
            //Creación de variables
            string idEmpleado = txtBusqCodEmp.Text;
            string idEncabezado = txtCodigoEncabezado.Text;
            string fechaInic = dtpFechIni.Value.Date.ToShortDateString();
            string fechaFin = dtpFechFin.Value.Date.ToShortDateString();
            string idCurso = cmbCurso.Text;
            string codigoCapa = txtCodiCapa.Text;
            int horas = (int)nudHoras.Value;
            //Validación
            if (idEmpleado == "" || idEncabezado == "" || fechaInic == "" || fechaFin == "" || idCurso == "" || codigoCapa == "") { MessageBox.Show("Campo Vacío"); }
            else
            {
                //Llamada a controlador con paso de parámetros
                con.funcIngresarEncabezado(idEmpleado, idEncabezado, fechaInic, fechaFin, idCurso, horas, codigoCapa);
                //Limpieza de campos
                txtBusqCodEmp.Text = "";
                txtCodigoEncabezado.Text = "";
                cmbCurso.Text = "";
                txtCodiCapa.Text = "";
                nudHoras.Value = 0;               
            }
        }
        //Búsqueda Capacitacion
        private void btnBuscarR_Click(object sender, EventArgs e)
        {
            //Validación
            if (txtCodEmpR.Text=="") { MessageBox.Show("Campo Vacío"); }
            else {
                //Creación de variables y llamada a controlador con paso de parámetros
                string idEmpleado = txtCodEmpR.Text;
                DataTable cod = con.funcLlenarCodigoCap(idEmpleado);
                cmbCodigoCap.DataSource = cod;
                cmbCodigoCap.DisplayMember = "pk_id_capacitacion";
                cmbCodigoCap.ResetText();
                string[] datos = new string[3];
                datos = con.funcConsultaEmp(idEmpleado);
                txtNombEmpR.Text = datos[0];
                txtCapR.Text = datos[2];
            }



        }
        //Ingreso de competencia
        private void btnIngresarCompetencia_Click(object sender, EventArgs e)
        {
            //Validación
            if (txtResultado.Text=="") { MessageBox.Show("Campo Vacío"); }
            else {
                //Creación de variables
                dgvCompIng.DataSource = null;
                string idEmpleado = txtCodEmpR.Text;
                string nota = txtResultado.Text;
                string idCap = cmbCodigoCap.Text;
                //Llamada a controlador con paso de parámetros
                con.funcIngresoNota(idEmpleado, idCap, nota);
                DataTable dato = con.funcLlenarDGVRes(idEmpleado, idCap);
                dgvCompIng.DataSource = dato;
                //Limpieza de campos
                txtResultado.Text="";
                cmbCodigoCap.Text="";
            }
        }
        //Búsqueda de empleado capacitado
        private void btnBuscarCap_Click(object sender, EventArgs e)
        {
            //Validacion
            if (cmbCodigoCap.Text == "") { MessageBox.Show("Campo Vacíos"); }
            else
            {
                //Creación de variables
                dgvCompIng.DataSource = null;
                string idEmpleado = txtCodEmpR.Text;
                string idCap = cmbCodigoCap.Text;
                //Llamada a controlador con paso de parámetros
                DataTable dato = con.funcLlenarDGVRes(idEmpleado, idCap);
                string[] datos = new string[3];
                datos = con.funcConsultaEmp(idEmpleado);
                dgvCompIng.DataSource = dato;
            }
        }
    }
}
