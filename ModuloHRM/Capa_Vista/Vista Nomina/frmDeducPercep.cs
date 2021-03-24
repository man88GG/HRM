using Capa_Controlador.Controlador_Nomina;
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

namespace Capa_Vista.Vista_Nomina
{
    public partial class frmDeducPercep : Form
    {
        public frmDeducPercep()
        {
            //Se asigna cantidad de caracteres maximos para textbox y richtextbox.
            InitializeComponent();
            txtIngresoNomCob.MaxLength = 45;
            txtIngresoMontoCob.MaxLength = 45;
            rtxtIngresoDescCob.MaxLength = 150;

            txtModificarNomCob.MaxLength = 45;
            txtModificarMontoCob.MaxLength = 45;
            rtxtModificarDescCob.MaxLength = 150;
        }

        clsControladorNomina ConsNom = new clsControladorNomina();

        string NombreCob, DescCob, NomOriginalCob; // Varibles que guardan nombre, descripcion y nombre anterior del cobro.
        double MontoCob; // Variable que guarda el monto del cobro
        bool Validado; // Variable de validadcion de datos

        //Inserta deduccion o percepcion a la base de datos
        private void btnIngresoDedPer_Click(object sender, EventArgs e)
        {
            if (funcValidarCamposIngreso() == true)
            {
                NombreCob = txtIngresoNomCob.Text;
                MontoCob = Convert.ToDouble(txtIngresoMontoCob.Text);
                DescCob = rtxtIngresoDescCob.Text;

                if (rbtnDed.Checked == true)
                {
                    ConsNom.funcInsertarDeduccion(NombreCob, MontoCob, DescCob);
                }
                else
                {
                    ConsNom.funcInsertarPercepcion(NombreCob, MontoCob, DescCob);
                }
                funcLimpiarCampos();
            }
        }

        //modifica la deduccion o percepcion ingresada.
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if(funcValidarCamposModificar() == true)
            {
                NombreCob = txtModificarNomCob.Text;
                MontoCob = Convert.ToDouble(txtModificarMontoCob.Text);
                DescCob = rtxtModificarDescCob.Text;

                if (rbtnModificarDed.Checked == true)
                {
                    ConsNom.funcModificarDeduccion(NombreCob, MontoCob, DescCob, NomOriginalCob);
                }
                else if (rbtnModificarPer.Checked == true)
                {
                    ConsNom.funcModificarPercepcion(NombreCob, MontoCob, DescCob, NomOriginalCob);
                }
                else
                {
                    MessageBox.Show("Seleccione el tipo de cobro para realizar la busqueda.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                funcLimpiarCampos();
            }
        }

        //Busca si la modificacion es existente dentro de la pestaña modificar
        private void btnBuscarModificar_Click(object sender, EventArgs e)
        {
            NomOriginalCob = txtModificarNomCob.Text;
            if (rbtnModificarDed.Checked == true)
            {
                OdbcDataReader Lector = ConsNom.funcBuscarDeduccion(txtModificarNomCob.Text);
                if (Lector.HasRows == true)
                {
                    while (Lector.Read())
                    {
                        txtModificarNomCob.Text = Lector.GetString(0);
                        txtModificarMontoCob.Text = Convert.ToString(Lector.GetDouble(1));
                        rtxtModificarDescCob.Text = Lector.GetString(2);
                    }
                }
                else
                {
                    MessageBox.Show("ERROR: El nombre de la deducción no es valido o no se encuentra registrado.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (rbtnModificarPer.Checked == true)
            {
                OdbcDataReader Lector = ConsNom.funcBuscarPercepcion(txtModificarNomCob.Text);
                if (Lector.HasRows == true)
                {
                    while (Lector.Read())
                    {
                        txtModificarNomCob.Text = Lector.GetString(0);
                        txtModificarMontoCob.Text = Convert.ToString(Lector.GetDouble(1));
                        rtxtModificarDescCob.Text = Lector.GetString(2);
                    }
                }
                else
                {
                    MessageBox.Show("ERROR: El nombre de la percepcion no es valido o no se encuentra registrado.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Seleccione el tipo de cobro para realizar la busqueda..", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Elimina una deduccion o percepcion
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (funcValidarCamposEliminar() == true)
            {
                if (rbtnEliminarDed.Checked == true)
                {
                    ConsNom.funcEliminarDeduccion(txtEliminarNomCob.Text);
                }
                else if (rbtnEliminarPer.Checked == true)
                {
                    ConsNom.funcEliminarPercepcion(txtEliminarNomCob.Text);
                }
                else
                {
                    MessageBox.Show("Seleccione el tipo de cobro que desea eliminar.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                funcLimpiarCampos();
            }
        }

        //Busca la deduccion o percepcion dentro de la pestaña eliminar
        private void btnEliminarBuscar_Click(object sender, EventArgs e)
        {
            if (rbtnEliminarDed.Checked == true)
            {
                OdbcDataReader Lector = ConsNom.funcBuscarDeduccion(txtEliminarNomCob.Text);
                if (Lector.HasRows == true)
                {
                    while (Lector.Read())
                    {
                        txtEliminarNomCob.Text = Lector.GetString(0);
                        txtEliminarMontoCob.Text = Convert.ToString(Lector.GetDouble(1));
                        rtxtEliminarDescCob.Text = Lector.GetString(2);
                    }
                }
                else
                {
                    MessageBox.Show("ERROR: El nombre de la deducción no es valido o no se encuentra registrado.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (rbtnEliminarPer.Checked == true)
            {
                OdbcDataReader Lector = ConsNom.funcBuscarPercepcion(txtEliminarNomCob.Text);
                if (Lector.HasRows == true)
                {
                    while (Lector.Read())
                    {
                        txtEliminarNomCob.Text = Lector.GetString(0);
                        txtEliminarMontoCob.Text = Convert.ToString(Lector.GetDouble(1));
                        rtxtEliminarDescCob.Text = Lector.GetString(2);
                    }
                }
                else
                {
                    MessageBox.Show("ERROR: El nombre de la percepcion no es valido o no se encuentra registrado.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Seleccione el tipo de cobro que desea eliminar.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Valida los campos del ingreso.
        private bool funcValidarCamposIngreso()
        {
            if (rbtnDed.Checked == false && rbtnPer.Checked == false)
            {
                MessageBox.Show("No se ha seleccionado el tipo de cobro.", "Tipo de Cobro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Validado = false;
            }
            else if (txtIngresoNomCob.Text == "" || txtIngresoMontoCob.Text == "" || rtxtIngresoDescCob.Text == "")
            {
                MessageBox.Show("Uno o mas campos se encuentran vacios.", "Campos Vacios.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Validado = false;
            }
            else
            {
                Validado = true;
            }

            return Validado;
        }

        //Valida los campos de la pestaña modificar
        private bool funcValidarCamposModificar()
        {
            if (rbtnModificarDed.Checked == false && rbtnModificarPer.Checked == false)
            {
                MessageBox.Show("No se ha seleccionado el tipo de cobro.", "Tipo de Cobro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Validado = false;
            }
            else if (txtModificarNomCob.Text == "" || txtModificarMontoCob.Text == "" || rtxtModificarDescCob.Text == "")
            {
                MessageBox.Show("Uno o mas campos se encuentran vacios.", "Campos Vacios.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Validado = false;
            }
            else
            {
                Validado = true;
            }

            return Validado;
        }

        //Validacion  para ingreso de numeros enteros y decimales unicamente en la pestaña ingreso
        private void txtIngresoMontoCob_TextChanged(object sender, EventArgs e)
        {
            decimal d;
            if (decimal.TryParse(txtIngresoMontoCob.Text, out d) || txtIngresoMontoCob.Text == "")
            {
            }
            else
            {
                txtIngresoMontoCob.Text = "";
                MessageBox.Show("Ingrese unicamente numeros.");
                return;
            }
        }

        //Validacion  para ingreso de numeros enteros y decimales unicamente en la pestaña modificar
        private void txtModificarMontoCob_TextChanged(object sender, EventArgs e)
        {
            decimal d;
            if (decimal.TryParse(txtModificarMontoCob.Text, out d) || txtModificarMontoCob.Text == "")
            {
            }
            else
            {
                txtModificarMontoCob.Text = "";
                MessageBox.Show("Ingrese unicamente numeros.");
                return;
            }
        }

        //Valida los campos de la pestaña eliminar.
        private bool funcValidarCamposEliminar()
        {
            if (rbtnEliminarDed.Checked == false && rbtnEliminarPer.Checked == false)
            {
                MessageBox.Show("No se ha seleccionado el tipo de cobro.", "Tipo de Cobro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Validado = false;
            }
            else if (txtEliminarNomCob.Text == "" || txtEliminarMontoCob.Text == "" || rtxtEliminarDescCob.Text == "")
            {
                MessageBox.Show("Uno o mas campos se encuentran vacios.", "Campos Vacios.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Validado = false;
            }
            else
            {
                Validado = true;
            }

            return Validado;
        }

        //Limpia todos los campos/objetos del formulario.
        private void funcLimpiarCampos()
        {
            rbtnDed.Checked = false;
            rbtnPer.Checked = false;
            txtIngresoNomCob.Text = "";
            txtIngresoMontoCob.Text = "";
            rtxtIngresoDescCob.Text = "";
            rbtnModificarDed.Checked = false;
            rbtnModificarPer.Checked = false;
            txtModificarNomCob.Text = "";
            txtModificarMontoCob.Text = "";
            rtxtModificarDescCob.Text = "";
            rbtnEliminarDed.Checked = false;
            rbtnEliminarPer.Checked = false;
            txtEliminarNomCob.Text = "";
            txtEliminarMontoCob.Text = "";
            rtxtEliminarDescCob.Text = "";

        }
    }
}
