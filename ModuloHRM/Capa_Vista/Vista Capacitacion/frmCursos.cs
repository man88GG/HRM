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
using Capa_Vista;

namespace Capa_Vista.Vista_Capacitacion
{
    public partial class frmCursos : Form
    {
        //Instancia de capa controlador
        clsControladorCapacitacion con = new clsControladorCapacitacion();
        frmMDI frm = new frmMDI();
        public frmCursos()
        {
            InitializeComponent();
            //Evento KeyDown para ayudas
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(frmCursos_KeyDown);
            funcAMLP();
        }
        //Funcion para llenar daots del combobox
        public void funcAMLP()
        {
            DataSet Datos = con.funcLlenarCampos();
            for (int i = 0; i < Datos.Tables[0].Columns.Count; i++)
            {
                //se agregan los nombres de las columnas al dgvCamposCreacion
                cmbEncabezado.Items.Add(Datos.Tables[0].Columns[i].ColumnName);

            }

        }
        //Acá inician los eventos de validación de teclas
        public void letra(object sender, KeyPressEventArgs e)
        {
            clsValidacion.funcLetras(e);
        }
        public void numero(object sender, KeyPressEventArgs e)
        {
            clsValidacion.funcNumeros(e);
        }
        //Finaliza eventos de validación de teclas
        //Insertar Curso
        private void btnIngresarC_Click(object sender, EventArgs e)
        {
            //Validaciones
            if (rtxtDetalleC.Text == "" || txtCodigoCapacit.Text == "" || txtNombreCurso.Text == "" || txtCodigoCurso.Text == "") { MessageBox.Show("Campo Vacío."); }
            else
            {
                //Llama capa controlador con paso parámetros
                con.funcIngresoCurso(txtCodigoCurso.Text, txtNombreCurso.Text, txtCodigoCapacit.Text, rtxtDetalleC.Text);
                //Limpia campos
                rtxtDetalleC.Text = "";
                txtCodigoCapacit.Text = "";
                txtNombreCurso.Text = "";
                txtCodigoCurso.Text = "";
                txtNombC.Text = "";
                txtEmail.Text = "";
                txtPuestoCurC.Text = "";
            }
        }
        //Busqueda
        private void btnBuscarCapacit_Click(object sender, EventArgs e)
        {
            //Validaciones
            if (txtCodigoCapacit.Text == "") { MessageBox.Show("Campo Vacío."); }
            else
            {
                //Creacion de componentes
                string idEmpleado = txtCodigoCapacit.Text;
                string[] datos = new string[3];
                //Llamado a capa controlador
                datos = con.funcDatosCapacitador(idEmpleado);
                //Ingresando dato a objetos
                txtNombC.Text = datos[0];
                txtEmail.Text = datos[1];
                txtPuestoCurC.Text = datos[2];
            }
        }
        //Busqued
        private void btnBuscarCap_Click(object sender, EventArgs e)
        {
            //Validaciones
            if (txtCodigoCap.Text == "") { MessageBox.Show("Campo Vacío"); }
            else
            {
                //Creacion de variables
                btnEditarCap.Enabled = true;
                string[] datos = new string[3];
                string[] datosc = new string[3];
                //Llamada a controlador
                datos = con.funcDatosCurso(txtCodigoCap.Text);
                txtNombreCE.Text = datos[0];
                txtCodigoCapCE.Text = datos[1];
                rtxtDetalleEdit.Text = datos[2];
                if (txtCodigoCapCE.Text != "") { datosc = con.funcDatosCapacitador(txtCodigoCapCE.Text); }
                txtNombreDCE.Text = datosc[0];
                txtEmailDCE.Text = datosc[1];
                txtPuestoDCE.Text = datosc[2];
            }
        }
        //Actualizacion registros llenar campos
        private void btnActualizarCE_Click(object sender, EventArgs e)
        {
            //Validacion
            if (txtCodigoCapCE.Text == "") { MessageBox.Show("Campo Vacío"); }
            else
            {
                //Creacion Variables
                string idEmpleado = txtCodigoCapCE.Text;
                string[] datosc = new string[3];
                //Llamada a controlador
                datosc = con.funcDatosCapacitador(idEmpleado);
                //Ingreso de datos en objetos
                txtNombreDCE.Text = datosc[0];
                txtEmailDCE.Text = datosc[1];
                txtPuestoDCE.Text = datosc[2];
            }
        }
        //Actualizacion datos
        private void btnEditarCap_Click(object sender, EventArgs e)
        {
            //Creación variables
            string idCurso = txtCodigoCap.Text;
            string nombreCurso = txtNombreCE.Text;
            string idEmpleado = txtCodigoCapCE.Text;
            string detalle = rtxtDetalleEdit.Text;
            //Validación
            if (idCurso == "" || nombreCurso == "" || idEmpleado == "" || detalle == "") { MessageBox.Show("Campo Vacío"); }
            else
            {
                //Llamada controlador con paso parámetros
                con.funcActualizarCurso(idCurso, nombreCurso, idEmpleado, detalle);
                //Limpieza de campos
                txtCodigoCap.Text = "";
                txtNombreCE.Text = "";
                txtCodigoCapCE.Text = "";
                rtxtDetalleEdit.Text = "";
                txtNombreDCE.Text = "";
                txtEmailDCE.Text = "";
                txtPuestoDCE.Text = "";
                btnEditarCap.Enabled = false;
            }
        }
        //Eliminar 
        private void btnEliminarC_Click(object sender, EventArgs e)
        {
            //Llamada a controlador con paso de parámetros
            con.funcEliminarCurso(txtCodigoCE.Text);
            //Limpieza de campos
            txtNombreEli.Text = "";
            txtCodigoCapEli.Text = "";
            txtNombCaEli.Text = "";
            txtEmailCaEli.Text = "";
            txtPuestoEli.Text = "";
            rtxtDetalleCE.Text = "";
            txtCodigoCE.Text = "";
            btnEliminarC.Enabled = false;
        }
        //Busqueda
        private void btnBuscarCE_Click(object sender, EventArgs e)
        {
            //Validación
            if (txtCodigoCE.Text == "") { MessageBox.Show("Campo Vacío"); }
            else
            {
                //Creación de Variables
                btnEliminarC.Enabled = true;
                string[] datos = new string[3];
                string[] datosc = new string[3];
                //Llamada a controlador con paso de parámetros
                datos = con.funcDatosCurso(txtCodigoCE.Text);
                txtNombreEli.Text = datos[0];
                txtCodigoCapEli.Text = datos[1];
                rtxtDetalleCE.Text = datos[2];
                if (txtCodigoCapEli.Text != "") { datosc = con.funcDatosCapacitador(txtCodigoCapEli.Text); }
                //Asignación de datos
                txtNombCaEli.Text = datosc[0];
                txtEmailCaEli.Text = datosc[1];
                txtPuestoEli.Text = datosc[2];
            }
        }
        //Busqueda
        private void btnBuscarEmp_Click(object sender, EventArgs e)
        {
            //Creación de Varibles
            string nomCampo = cmbEncabezado.Text;
            string compare = txtBuscador.Text;
            //Llamada a controlador con paso de parámetros
            DataTable dato = con.funcLlenarBusqueda(nomCampo, compare);
            //Ingreso de datos
            dvgEmpleadosMostrar.DataSource = dato;
            cmbEncabezado.Text = "";
            txtBuscador.Text = "";
        }
       //Actualizar tabla
        private void funcActualizarTabla()
        {
            //Limpieza de listView con llamda a controlador
            lsvInfoCap.Items.Clear();
            DataTable dato = con.funcLlenarDGVCurso();
            //Ingreso datos a listView
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
        //Timer Para actualizar Tablas
        private void tmrDGVCurso_Tick(object sender, EventArgs e)
        {            
            //Llamada de actualizacón de tabla
            funcActualizarTabla();           
        }
        //Evento keyDown Para ayudas
        private void frmCursos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                //Llamada de ayudas
                Help.ShowHelp(this, "Ayudas_HRM/Ayudas_Modulo_HRM.chm", "pg_0004.htm");
            }
        }
    }
}