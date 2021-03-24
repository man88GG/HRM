using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Controlador.Controlador_Nomina;

namespace Capa_Vista.Vista_Nomina
{
    public partial class frmEmpleadoNomina : Form
    {
        public frmEmpleadoNomina()
        {
            InitializeComponent();
            //Se le asina una cantidad maxima de caracteres a los textbox
            txtIngresoIdEmp.MaxLength = 11;
            txtBuscarIdEmp.MaxLength = 11;
            txtEliminarIdEmp.MaxLength = 11;

        }
        //Se llama a la clase controlador
        clsControladorNomina ConsNom = new clsControladorNomina();
        int Id; // Variable que guarda el ID del empleado

        //Boton de ingreso de cobro a empleado
        private void btnIngresoEmpleadoDedPer_Click(object sender, EventArgs e)
        {
            if(funcValidarCamposIngreso() == true)
            {
                if(rbtnIngresoDed.Checked == true)
                {
                    ConsNom.funcIngresarDeduccionEmpleado(cmbIngresoFecPLan.Text, Id, cmbIngresoDedPer.Text);
                }
                else
                {
                    ConsNom.funcIngresarPercepcionEmpleado(cmbIngresoFecPLan.Text, Id, cmbIngresoDedPer.Text);
                }
            }
            funcLimpiarIngreso();
        }

        //Busca el nombre y puesto de un empleado en la pestaña eliminar
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtEliminarIdEmp.Text == "")
            {
                MessageBox.Show("Ingrese el ID del empleado.", "ERROR BUSQUEDA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Id = Convert.ToInt32(txtEliminarIdEmp.Text);
                OdbcDataReader Lector = ConsNom.funcBuscarNomEmpleado(Id);

                if (Lector.HasRows == true)
                {
                    while (Lector.Read())
                    {
                        txtEliminarNomEmp.Text = (Lector.GetString(0) + " " + Lector.GetString(1) + " " + Lector.GetString(2) + " " + Lector.GetString(3));
                    }
                }
                else
                {
                    MessageBox.Show("ERROR: El ID del empleado no es valido o no se encuentra registrado.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //Elimina la deduccion de un empleado.
        private void btnEliminarEmpleadoDedPer_Click(object sender, EventArgs e)
        {
            if (funcValidarCamposEliminar() == true)
            {
                if (rbtnEliminarDed.Checked == true)
                {
                    ConsNom.funcEliminarDeduccionEmpleado(Id, cmbEliminarDedPer.Text, cmbEliminarFechPlan.Text);
                }
                else
                {
                    ConsNom.funcEliminarPercepcionEmpleado(Id, cmbEliminarDedPer.Text, cmbEliminarFechPlan.Text);
                }
            }
            funcLimpiarEliminar();
        }

        //Busca el nombre y puesto de un empleado en la pestaña ingreso.
        private void btnIngresarBuscar_Click(object sender, EventArgs e)
        {
            if(txtIngresoIdEmp.Text == "")
            {
                MessageBox.Show("Ingrese el ID del empleado.","ERROR BUSQUEDA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Id = Convert.ToInt32(txtIngresoIdEmp.Text);
                OdbcDataReader Lector = ConsNom.funcBuscarNomEmpleado(Id);

                if (Lector.HasRows == true)
                {
                    while (Lector.Read())
                    {
                        txtIngresoNomEmp.Text = (Lector.GetString(0) +" "+ Lector.GetString(1) + " " +Lector.GetString(2) + " " + Lector.GetString(3));
                    }
                }
                else
                {
                    MessageBox.Show("ERROR: El ID del empleado no es valido o no se encuentra registrado.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //Asigna las deducciones al combobox de percepcion o deduccion
        private void rbtnIngresoDed_CheckedChanged(object sender, EventArgs e)
        {
            DataTable Datos = ConsNom.funcLlenarcmbDeducciones();
            cmbIngresoDedPer.DataSource = Datos;
            cmbIngresoDedPer.DisplayMember = "nombre_deduccion";
            cmbIngresoDedPer.ResetText();
        }

        //Carga los periodos de planillas dentro de los combobox correspondientes.
        private void frmEmpleadoNomina_Load(object sender, EventArgs e)
        {
            funcFechaPlanillaIngreso();
            funcFechaPlanillaBuscar();
            funcFechaPlanillaEliminar();
        }

        //Asigna las persepciones al combobox de percepcion o deduccion
        private void rbtnIngresoPerc_CheckedChanged(object sender, EventArgs e)
        {
            DataTable Datos = ConsNom.funcLlenarcmbPercepciones();
            cmbIngresoDedPer.DataSource = Datos;
            cmbIngresoDedPer.DisplayMember = "nombre_percepcion";
            cmbIngresoDedPer.ResetText();
        }

        //Boton usado en la pestaña buscar, buscar los cobros de un empleado
        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            if (funcValidarCamposBuscar() == true)
            {
                Id = Convert.ToInt32(txtBuscarIdEmp.Text);
                OdbcDataReader Lector = ConsNom.funcBuscarNomEmpleado(Id);

                if (Lector.HasRows == true)
                {
                    while (Lector.Read())
                    {
                        txtBuscarNomEmp.Text = (Lector.GetString(0) + " " + Lector.GetString(1) + " " + Lector.GetString(2) + " " + Lector.GetString(3));
                    }
                }
                else
                {
                    MessageBox.Show("ERROR: El ID del empleado no es valido o no se encuentra registrado.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                txtBuscarPuestoEmp.Text = ConsNom.funcBuscarPuestoEmp(Id);
                DataTable DatosDed = ConsNom.funcLlenardgvDedEmp(Id, cmbBuscarPeriodoPlanilla.Text);
                DataTable DatosPer = ConsNom.funcLlenardgvPerEmp(Id, cmbBuscarPeriodoPlanilla.Text);
                dgvDedEmp.DataSource = DatosDed;
                dgvPerEpm.DataSource = DatosPer;
                var Ded = DatosDed.Compute("SUM(Monto)", "");
                var Per = DatosPer.Compute("SUM(Monto)", "");
                txtTotalDed.Text = Ded.ToString();
                txtTotalPer.Text = Per.ToString();
            }
        }

        //Asigna las deducciones al combobox de percepcion o deduccion
        private void rbtnEliminarDed_CheckedChanged(object sender, EventArgs e)
        {
            DataTable Datos = ConsNom.funcLlenarcmbDeducciones();
            cmbEliminarDedPer.DataSource = Datos;
            cmbEliminarDedPer.DisplayMember = "nombre_deduccion";
            cmbEliminarDedPer.ResetText();
        }

        //Asigna las percepciones al combobox de percepcion o deduccion
        private void rbtnEliminarPer_CheckedChanged(object sender, EventArgs e)
        {
            DataTable Datos = ConsNom.funcLlenarcmbPercepciones();
            cmbEliminarDedPer.DataSource = Datos;
            cmbEliminarDedPer.DisplayMember = "nombre_percepcion";
            cmbEliminarDedPer.ResetText();
        }

        //Limpia pestaña de Buscar.
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            funcLimpiarBuscar();
        }

        //Busca la fecha en que finaliza un periodo en la pestaña ingreso.
        private void cmbIngresoFecPLan_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtIngresoFechFin.Text = ConsNom.funcObtenerPeriodoFinal(cmbIngresoFecPLan.Text);
        }

        //Busca la fecha en que finaliza un periodo en la pestaña buscar.
        private void cmbBuscarPeriodoPlanilla_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtBuscarFechaFin.Text = ConsNom.funcObtenerPeriodoFinal(cmbBuscarPeriodoPlanilla.Text);
        }

        //Busca la fecha en que finaliza un periodo en la pestaña eliminar.
        private void cmbEliminarFechPlan_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtEliminarFechFin.Text = ConsNom.funcObtenerPeriodoFinal(cmbEliminarFechPlan.Text);
        }

        //Validaciones de la pestaña ingreso
        private bool funcValidarCamposIngreso()
        {

            DateTime Hoy, Periodo;
            Hoy = DateTime.Now;
            Periodo = Hoy;
            if(txtIngresoFechFin.Text != "")
            {
                Periodo = Convert.ToDateTime(txtIngresoFechFin.Text);
            }

            if (rbtnIngresoDed.Checked == false && rbtnIngresoPerc.Checked == false)
            {
                MessageBox.Show("No se ha seleccionado el tipo de cobro.", "Tipo de Cobro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (txtIngresoIdEmp.Text == "" || txtIngresoNomEmp.Text == "" || cmbIngresoDedPer.Text == "" || cmbIngresoFecPLan.Text == "")
            {
                MessageBox.Show("Uno o mas campos se encuentran vacios.", "Campos Vacios.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Hoy.Date.CompareTo(Periodo.Date) == 1)
            {
                MessageBox.Show("No se puede realizar el ingreso, el periodo de planilla ya finalizo", "PERIODO DE PLANILLA FINALIZADO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }

        //Validaciones de la pestaña buscar
        private bool funcValidarCamposBuscar()
        {
            if (txtBuscarIdEmp.Text == "" || cmbBuscarPeriodoPlanilla.Text == "")
            {
                MessageBox.Show("Uno o mas campos se encuentran vacios.", "Campos Vacios.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }

        //Validaciones de la pestaña eliminar
        private bool funcValidarCamposEliminar()
        {
            DateTime Hoy, Periodo;
            Hoy = DateTime.Now;
            Periodo = Hoy;
            if(txtEliminarFechFin.Text != "")
            {
                Periodo = Convert.ToDateTime(txtEliminarFechFin.Text);
            }
            if (rbtnEliminarDed.Checked == false && rbtnEliminarPer.Checked == false)
            {
                MessageBox.Show("No se ha seleccionado el tipo de cobro.", "Tipo de Cobro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (txtEliminarIdEmp.Text == "" || txtEliminarNomEmp.Text == "" || cmbEliminarDedPer.Text == "" || cmbEliminarFechPlan.Text == "")
            {
                MessageBox.Show("Uno o mas campos se encuentran vacios.", "Campos Vacios.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Hoy.Date.CompareTo(Periodo.Date) == 1)
            {
                MessageBox.Show("No se puede realizar la eliminación, el periodo de planilla ya finalizo", "PERIODO DE PLANILLA FINALIZADO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }

        //Carga la fecha de inicio de un periodo dentro del combobox en la pestaña ingresar.
        private void funcFechaPlanillaIngreso()
        {
            DataTable Datos = ConsNom.funcLLenarcmbFechaPanitlla();
            cmbIngresoFecPLan.DataSource = Datos;
            cmbIngresoFecPLan.DisplayMember = "fecha_inicio_encabezado_nomina";
            cmbIngresoFecPLan.ResetText();
            cmbIngresoFecPLan.SelectedIndex = -1;
        }

        //Carga la fecha de inicio de un periodo dentro del combobox en la pestaña buscar.
        private void funcFechaPlanillaBuscar()
        {
            DataTable Datos = ConsNom.funcLLenarcmbFechaPanitlla();
            cmbBuscarPeriodoPlanilla.DataSource = Datos;
            cmbBuscarPeriodoPlanilla.DisplayMember = "fecha_inicio_encabezado_nomina";
            cmbBuscarPeriodoPlanilla.ResetText();
            cmbBuscarPeriodoPlanilla.SelectedIndex = -1;
        }

        //Carga la fecha de inicio de un periodo dentro del combobox en la pestaña eliminar.
        private void funcFechaPlanillaEliminar()
        {
            DataTable Datos = ConsNom.funcLLenarcmbFechaPanitlla();
            cmbEliminarFechPlan.DataSource = Datos;
            cmbEliminarFechPlan.DisplayMember = "fecha_inicio_encabezado_nomina";
            cmbEliminarFechPlan.ResetText();
            cmbEliminarFechPlan.SelectedIndex = -1;
        }

        //Limpia los campos/ objetos de la pestaña ingreso.
        private void funcLimpiarIngreso()
        {
            txtIngresoIdEmp.Text = "";
            txtIngresoNomEmp.Text = "";
            rbtnIngresoDed.Checked = false;
            rbtnIngresoPerc.Checked = false;
            cmbIngresoDedPer.Text = "";
            cmbIngresoDedPer.DataSource = null;
            cmbIngresoDedPer.SelectedIndex = -1;
            cmbIngresoFecPLan.Text = "";
            cmbIngresoFecPLan.SelectedIndex = -1;
            txtIngresoFechFin.Text = "";

        }

        //Limpia los campos/ objetos de la pestaña buscar.
        private void funcLimpiarBuscar()
        {
            txtBuscarIdEmp.Text = "";
            txtBuscarNomEmp.Text = "";
            txtBuscarPuestoEmp.Text = "";
            cmbBuscarPeriodoPlanilla.Text = "";
            cmbBuscarPeriodoPlanilla.SelectedIndex = -1;
            dgvDedEmp.DataSource = null;
            dgvDedEmp.Refresh();
            dgvPerEpm.DataSource = null;
            dgvPerEpm.Refresh();
            txtTotalDed.Text = "";
            txtTotalPer.Text = "";
            txtBuscarFechaFin.Text = "";
        }

        //Limpia los campos/ objetos de la pestaña eliminar.
        private void funcLimpiarEliminar()
        {
            txtEliminarIdEmp.Text = "";
            txtEliminarNomEmp.Text = "";
            rbtnEliminarDed.Checked = false;
            rbtnEliminarPer.Checked = false;
            cmbEliminarDedPer.Text = "";
            cmbEliminarDedPer.DataSource = null;
            cmbEliminarFechPlan.Text = "";
            cmbEliminarFechPlan.SelectedIndex = -1;
            cmbEliminarDedPer.SelectedIndex = -1;
            txtEliminarFechFin.Text = "";
        }
    }
}
