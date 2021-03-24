using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Odbc;
using System.Windows.Forms;

namespace Capa_Modelo.Modelo_Nomina
{
    public class clsConsultasNomina
    {
        clsConexion Conexion = new clsConexion();

        // Metodos para formulario frmDeducPercep

         //Ingresa deducciones a la base de datos
        public void funIngresarDededuccion(string Nom, double Monto, string Desc)
        {
            try
            {
                string Correlativo = "SELECT IFNULL(MAX(pk_id_deduccion),0) +1 FROM deduccion";
                OdbcCommand Query_Validacion = new OdbcCommand(Correlativo, Conexion.funcconexion());
                int IdDed = Convert.ToInt32(Query_Validacion.ExecuteScalar());
                OdbcDataReader Ejecucion1 = Query_Validacion.ExecuteReader();

                string sentencia = "INSERT INTO deduccion (pk_id_deduccion, nombre_deduccion, monto_deduccion, descripcion_deduccion) VALUES ('" + IdDed + "','" + Nom + "','" + Monto + "','" + Desc + "')";
                OdbcCommand Query_Validacion1 = new OdbcCommand(sentencia, Conexion.funcconexion());
                Query_Validacion1.ExecuteNonQuery();
                MessageBox.Show("Ingreso Exitoso", "INGRESO DE DEDUCCIONES", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error al ejecutar SQL: " +
                    System.Environment.NewLine + System.Environment.NewLine +
                    ex.GetType().ToString() + System.Environment.NewLine +
                    ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Ingresa percepciones a la base de datos
        public void funIngresarPercepcion(string Nom, double Monto, string Desc)
        {
            try
            {
                string Correlativo = "SELECT IFNULL(MAX(pk_id_percepcion ),0) +1 FROM percepcion";
                OdbcCommand Query_Validacion = new OdbcCommand(Correlativo, Conexion.funcconexion());
                int IdPer = Convert.ToInt32(Query_Validacion.ExecuteScalar());
                OdbcDataReader Ejecucion1 = Query_Validacion.ExecuteReader();

                string sentencia = "INSERT INTO percepcion (pk_id_percepcion, nombre_percepcion, monto_percepcion, descripcion_percepcion) VALUES ('" + IdPer + "','" + Nom + "','" + Monto + "','" + Desc + "')";
                OdbcCommand Query_Validacion1 = new OdbcCommand(sentencia, Conexion.funcconexion());
                Query_Validacion1.ExecuteNonQuery();
                MessageBox.Show("Ingreso Exitoso", "INGRESO DE PERCEPCIONES", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar SQL: " +
                    System.Environment.NewLine + System.Environment.NewLine +
                    ex.GetType().ToString() + System.Environment.NewLine +
                    ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //busca las deducciones en la base de datos
        public OdbcDataReader funcBuscarDeduccion(string Nom)
        {
            try
            {
                string sentencia = "SELECT nombre_deduccion, monto_deduccion, descripcion_deduccion FROM deduccion WHERE nombre_deduccion = '" + Nom + "'";
                OdbcCommand Query_Validacion1 = new OdbcCommand(sentencia, Conexion.funcconexion());
                OdbcDataReader Lector = Query_Validacion1.ExecuteReader();
                return Lector;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar SQL: " +
                    System.Environment.NewLine + System.Environment.NewLine +
                    ex.GetType().ToString() + System.Environment.NewLine +
                    ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        //busca las percepciones en la base de datos
        public OdbcDataReader funcBuscarPercepcion(string Nom)
        {
            try
            {
                string sentencia = "SELECT 	nombre_percepcion, monto_percepcion, descripcion_percepcion FROM percepcion WHERE nombre_percepcion = '" + Nom + "'";
                OdbcCommand Query_Validacion1 = new OdbcCommand(sentencia, Conexion.funcconexion());
                OdbcDataReader Lector = Query_Validacion1.ExecuteReader();
                return Lector;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar SQL: " +
                    System.Environment.NewLine + System.Environment.NewLine +
                    ex.GetType().ToString() + System.Environment.NewLine +
                    ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        //modifica deducciones
        public void funcModificarDeduccion(string Nom, double Monto, string Desc, string NomAnt)
        {
            try
            {
                string sentencia = "UPDATE deduccion SET nombre_deduccion='" + Nom + "', monto_deduccion='" + Monto + "', 	descripcion_deduccion='" + Desc + "' WHERE nombre_deduccion= '" + NomAnt + "'";
                OdbcCommand Query_Validacion1 = new OdbcCommand(sentencia, Conexion.funcconexion());
                Query_Validacion1.ExecuteNonQuery();
                MessageBox.Show("Modificación Exitosa", "MODIFICACIÓN DE DEDUCCIONES", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar SQL: " +
                    System.Environment.NewLine + System.Environment.NewLine +
                    ex.GetType().ToString() + System.Environment.NewLine +
                    ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //modifica percepiones
        public void funcModificarPercepcion(string Nom, double Monto, string Desc, string NomAnt)
        {
            try
            {
                string sentencia = "UPDATE percepcion SET 	nombre_percepcion='" + Nom + "', monto_percepcion='" + Monto + "', 		descripcion_percepcion='" + Desc + "' WHERE nombre_percepcion= '" + NomAnt + "'";
                OdbcCommand Query_Validacion1 = new OdbcCommand(sentencia, Conexion.funcconexion());
                Query_Validacion1.ExecuteNonQuery();
                MessageBox.Show("Modificación Exitosa", "MODIFICACIÓN DE PERCEPCIONES", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar SQL: " +
                    System.Environment.NewLine + System.Environment.NewLine +
                    ex.GetType().ToString() + System.Environment.NewLine +
                    ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //elimina deducciones
        public void funcEliminarDeduccion(string Nom)
        {
            try
            {
                string sentencia = "DELETE FROM deduccion WHERE nombre_deduccion = '" + Nom + "'";
                OdbcCommand Query_Validacion1 = new OdbcCommand(sentencia, Conexion.funcconexion());
                OdbcDataReader Lector = Query_Validacion1.ExecuteReader();
                MessageBox.Show("Elimincación Exitosa", "ELIMINCACIÓN DE DEDUCCIONES", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar SQL: " +
                    System.Environment.NewLine + System.Environment.NewLine +
                    ex.GetType().ToString() + System.Environment.NewLine +
                    ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //elimina percepciones
        public void funcEliminarPercepcion(string Nom)
        {
            try
            {
                string sentencia = "DELETE FROM percepcion WHERE nombre_percepcion = '" + Nom + "'";
                OdbcCommand Query_Validacion1 = new OdbcCommand(sentencia, Conexion.funcconexion());
                OdbcDataReader Lector = Query_Validacion1.ExecuteReader();
                MessageBox.Show("Elimincación Exitosa", "ELIMINCACIÓN DE PERCEPCIONES", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar SQL: " +
                    System.Environment.NewLine + System.Environment.NewLine +
                    ex.GetType().ToString() + System.Environment.NewLine +
                    ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //obitne el periodo final de la planilla
        public string funcObtenerPeriodoFinal (string FI)
        {
            string PeriodoFinal;
            try
            {
                string sentencia = "SELECT fecha_fin_encabezado_nomina FROM encabezado_nomina " +
                    "WHERE fecha_inicio_encabezado_nomina = '" + FI + "'";
                OdbcCommand Query_Validacion1 = new OdbcCommand(sentencia, Conexion.funcconexion());
                PeriodoFinal = Convert.ToString(Query_Validacion1.ExecuteScalar());
                return PeriodoFinal;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar SQL: " +
                    System.Environment.NewLine + System.Environment.NewLine +
                    ex.GetType().ToString() + System.Environment.NewLine +
                    ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        // Metodos para formulario frmEmpleadoNomina

        //busca nombre del empleado
        public OdbcDataReader funcBuscarNomEmpleado(int Id)
        {
            try
            {
                string sentencia = "SELECT nombre1_empleado, nombre2_empleado, apellido1_empleado, apellido2_empleado" +
                    " FROM empleado WHERE pk_id_empleado = '" + Id + "'";
                OdbcCommand Query_Validacion1 = new OdbcCommand(sentencia, Conexion.funcconexion());
                OdbcDataReader Lector = Query_Validacion1.ExecuteReader();
                return Lector;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar SQL: " +
                    System.Environment.NewLine + System.Environment.NewLine +
                    ex.GetType().ToString() + System.Environment.NewLine +
                    ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        //busca las deducciones para insertarlas en combobox
        public DataTable funcDeduccionescmb()
        {
            try
            {
                DataTable Datos = new DataTable();
                string sentencia = "SELECT nombre_deduccion FROM deduccion";
                OdbcCommand Query_Validacion1 = new OdbcCommand(sentencia, Conexion.funcconexion());
                OdbcDataAdapter Lector = new OdbcDataAdapter();
                Lector.SelectCommand = Query_Validacion1;
                Lector.Fill(Datos);
                return Datos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar SQL: " +
                    System.Environment.NewLine + System.Environment.NewLine +
                    ex.GetType().ToString() + System.Environment.NewLine +
                    ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        //busca las percepciones para insertarlas en combobox
        public DataTable funcPercepcionescmb()
        {
            try
            {
                DataTable Datos = new DataTable();
                string sentencia = "SELECT nombre_percepcion FROM percepcion";
                OdbcCommand Query_Validacion1 = new OdbcCommand(sentencia, Conexion.funcconexion());
                OdbcDataAdapter Lector = new OdbcDataAdapter();
                Lector.SelectCommand = Query_Validacion1;
                Lector.Fill(Datos);
                return Datos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar SQL: " +
                    System.Environment.NewLine + System.Environment.NewLine +
                    ex.GetType().ToString() + System.Environment.NewLine +
                    ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        //busca las fechas de inicio de planilla para insertarlas en combobox
        public DataTable funcFechaPlanillacmb()
        {
            try
            {
                DataTable Datos = new DataTable();
                string sentencia = "SELECT fecha_inicio_encabezado_nomina FROM encabezado_nomina";
                OdbcCommand Query_Validacion1 = new OdbcCommand(sentencia, Conexion.funcconexion());
                OdbcDataAdapter Lector = new OdbcDataAdapter();
                Lector.SelectCommand = Query_Validacion1;
                Lector.Fill(Datos);
                return Datos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar SQL: " +
                    System.Environment.NewLine + System.Environment.NewLine +
                    ex.GetType().ToString() + System.Environment.NewLine +
                    ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        //ingresa una deduccion a un empleado
        public void funcIngresarDeduccionEmpleado(string EncNom, int IdEmp, string Ded)
        {
            try
            {
                string Correlativo = "SELECT IFNULL(MAX(pk_id_detalle_nomina),0) +1 FROM detalle_nomina";
                OdbcCommand Query = new OdbcCommand(Correlativo, Conexion.funcconexion());
                int Id_detalle_nomina = Convert.ToInt32(Query.ExecuteScalar());

                string sentenciaDed = "SELECT pk_id_deduccion FROM deduccion WHERE nombre_deduccion ='" + Ded + "'";
                OdbcCommand Query_Validacion1 = new OdbcCommand(sentenciaDed, Conexion.funcconexion());
                int IdDed = Convert.ToInt32(Query_Validacion1.ExecuteScalar());

                string sentenciaEncNom = "SELECT pk_id_encabezado_nomina  FROM encabezado_nomina WHERE fecha_inicio_encabezado_nomina ='" + EncNom + "'";
                OdbcCommand Query_Validacion3 = new OdbcCommand(sentenciaEncNom, Conexion.funcconexion());
                int IdEncNom = Convert.ToInt32(Query_Validacion3.ExecuteScalar());

                string sentencia = "INSERT INTO detalle_nomina (pk_id_detalle_nomina, fk_id_encabezado_detalle_nomina , fk_id_empleado_detalle_nomina, fk_id_deducciones_detalle_nomina) VALUES ('" + Id_detalle_nomina + "','" + IdEncNom + "','" + IdEmp + "','" + IdDed + "')";
                OdbcCommand Query_Validacion2 = new OdbcCommand(sentencia, Conexion.funcconexion());
                Query_Validacion2.ExecuteNonQuery();
                MessageBox.Show("Ingreso Exitoso", "INGRESO DE DEDUCCIONES", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar SQL: " +
                    System.Environment.NewLine + System.Environment.NewLine +
                    ex.GetType().ToString() + System.Environment.NewLine +
                    ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //ingresa una percepcion a un empleado
        public void funcIngresarPercepcionEmpleado(string EncNom, int IdEmp, string Per)
        {
            try
            {
                string Correlativo = "SELECT IFNULL(MAX(pk_id_detalle_nomina),0) +1 FROM detalle_nomina";
                OdbcCommand Query = new OdbcCommand(Correlativo, Conexion.funcconexion());
                int Id_detalle_nomina = Convert.ToInt32(Query.ExecuteScalar());

                string sentenciaDed = "SELECT pk_id_percepcion FROM percepcion WHERE nombre_percepcion ='" + Per + "'";
                OdbcCommand Query_Validacion1 = new OdbcCommand(sentenciaDed, Conexion.funcconexion());
                int IdPer = Convert.ToInt32(Query_Validacion1.ExecuteScalar());

                string sentenciaEncNom = "SELECT pk_id_encabezado_nomina  FROM encabezado_nomina WHERE fecha_inicio_encabezado_nomina ='" + EncNom + "'";
                OdbcCommand Query_Validacion3 = new OdbcCommand(sentenciaEncNom, Conexion.funcconexion());
                int IdEncNom = Convert.ToInt32(Query_Validacion3.ExecuteScalar());

                string sentencia = "INSERT INTO detalle_nomina (pk_id_detalle_nomina, fk_id_encabezado_detalle_nomina , fk_id_empleado_detalle_nomina, fk_id_percepciones_detalle_nomina) VALUES ('" + Id_detalle_nomina + "','" + IdEncNom + "','" + IdEmp + "','" + IdPer + "')";
                OdbcCommand Query_Validacion2 = new OdbcCommand(sentencia, Conexion.funcconexion());
                Query_Validacion2.ExecuteNonQuery();
                MessageBox.Show("Ingreso Exitoso", "INGRESO DE DEDUCCIONES", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar SQL: " +
                    System.Environment.NewLine + System.Environment.NewLine +
                    ex.GetType().ToString() + System.Environment.NewLine +
                    ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //busca deducciones de un empleado
        public DataTable funcDedEmpleado(int IdEmp,string Fecha)
        {
            try
            {
                DataTable Datos = new DataTable();
                string sentencia = "SELECT ded.nombre_deduccion AS 'Deduccion', ded.monto_deduccion AS 'Monto' FROM detalle_nomina AS det, empleado AS emp, deduccion AS ded, encabezado_nomina AS enc " +
                    "WHERE det.fk_id_empleado_detalle_nomina ='" + IdEmp + "' AND emp.pk_id_empleado ='" + IdEmp + "' AND " +
                    "det.fk_id_deducciones_detalle_nomina = ded.pk_id_deduccion AND enc.fecha_inicio_encabezado_nomina ='" + Fecha + "'";

                OdbcCommand Query_Validacion1 = new OdbcCommand(sentencia, Conexion.funcconexion());
                OdbcDataAdapter Lector = new OdbcDataAdapter();
                Lector.SelectCommand = Query_Validacion1;
                Lector.Fill(Datos);
                return Datos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar SQL: " +
                    System.Environment.NewLine + System.Environment.NewLine +
                    ex.GetType().ToString() + System.Environment.NewLine +
                    ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        //busca percepciones de un empleado
        public DataTable funcPerEmpleado(int IdEmp, string Fecha)
        {
            try
            {
                DataTable Datos = new DataTable();
                string sentencia = "SELECT per.nombre_percepcion AS 'Percepcion', per.monto_percepcion AS 'Monto' FROM detalle_nomina AS det, empleado AS emp, percepcion AS per, encabezado_nomina AS enc " +
                    "WHERE det.fk_id_empleado_detalle_nomina ='" + IdEmp + "' AND emp.pk_id_empleado ='" + IdEmp + "' AND " +
                    "det.fk_id_percepciones_detalle_nomina = per.pk_id_percepcion AND enc.fecha_inicio_encabezado_nomina ='" + Fecha + "'";

                OdbcCommand Query_Validacion1 = new OdbcCommand(sentencia, Conexion.funcconexion());
                OdbcDataAdapter Lector = new OdbcDataAdapter();
                Lector.SelectCommand = Query_Validacion1;
                Lector.Fill(Datos);
                return Datos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar SQL: " +
                    System.Environment.NewLine + System.Environment.NewLine +
                    ex.GetType().ToString() + System.Environment.NewLine +
                    ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        //elimina deducciones de un empleado
        public void funcEliminarDeduccionEmpleado(int IdEmp, string Ded, string Fecha)
        {
            try
            {
                string sentenciaDed = "SELECT pk_id_deduccion FROM deduccion WHERE nombre_deduccion ='" + Ded + "'";
                OdbcCommand Query1 = new OdbcCommand(sentenciaDed, Conexion.funcconexion());
                int IdDed = Convert.ToInt32(Query1.ExecuteScalar());

                string sentenciaEncNom = "SELECT pk_id_encabezado_nomina  FROM encabezado_nomina WHERE fecha_inicio_encabezado_nomina ='" + Fecha + "'";
                OdbcCommand Query2 = new OdbcCommand(sentenciaEncNom, Conexion.funcconexion());
                int IdEncNom = Convert.ToInt32(Query2.ExecuteScalar());

                MessageBox.Show(IdDed.ToString() + " " + IdEmp.ToString() + " " + IdEncNom.ToString());

                string sentencia = "DELETE FROM detalle_nomina WHERE fk_id_empleado_detalle_nomina = '" + IdEmp + "' AND fk_id_deducciones_detalle_nomina = '" + IdDed + "'" +
                    " AND fk_id_encabezado_detalle_nomina = '" + IdEncNom + "'";
                OdbcCommand Query_Validacion1 = new OdbcCommand(sentencia, Conexion.funcconexion());
                OdbcDataReader Ejecucion3 = Query_Validacion1.ExecuteReader();
                MessageBox.Show("Elimincación Exitosa", "ELIMINCACIÓN DE DEDUCCIONES", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar SQL: " +
                    System.Environment.NewLine + System.Environment.NewLine +
                    ex.GetType().ToString() + System.Environment.NewLine +
                    ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //elimina percepciones de un empleado
        public void funcEliminarPercepcionEmpleado(int IdEmp, string Per, string Fecha)
        {
            try
            {
                string sentenciaDed = "SELECT pk_id_percepcion FROM percepcion WHERE nombre_percepcion ='" + Per + "'";
                OdbcCommand Query1 = new OdbcCommand(sentenciaDed, Conexion.funcconexion());
                int IdPer = Convert.ToInt32(Query1.ExecuteScalar());

                string sentenciaEncNom = "SELECT pk_id_encabezado_nomina  FROM encabezado_nomina WHERE fecha_inicio_encabezado_nomina ='" + Fecha + "'";
                OdbcCommand Query2 = new OdbcCommand(sentenciaEncNom, Conexion.funcconexion());
                int IdEncNom = Convert.ToInt32(Query2.ExecuteScalar());

                string sentencia = "DELETE FROM detalle_nomina WHERE fk_id_empleado_detalle_nomina = '" + IdEmp + "' AND fk_id_percepciones_detalle_nomina = '" + IdPer + "'" +
                    " AND fk_id_encabezado_detalle_nomina = '" + IdEncNom + "'";
                OdbcCommand Query_Validacion1 = new OdbcCommand(sentencia, Conexion.funcconexion());
                Query_Validacion1.ExecuteNonQuery();
                MessageBox.Show("Elimincación Exitosa", "ELIMINCACIÓN DE PERCEPCIONES", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar SQL: " +
                    System.Environment.NewLine + System.Environment.NewLine +
                    ex.GetType().ToString() + System.Environment.NewLine +
                    ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //busca el puesto de un empleado.
        public string funcBuscarPuestoEmp(int Id)
        {
            string puesto = "";
            try
            {
                string sentencia = "SELECT p.nombre_puesto FROM empleado AS emp, puesto AS p " +
                    "WHERE emp.fk_id_puesto_empleado = p.pk_id_puesto AND pk_id_empleado = '" + Id + "'";
                OdbcCommand Query_Validacion1 = new OdbcCommand(sentencia, Conexion.funcconexion());
                puesto = Convert.ToString(Query_Validacion1.ExecuteScalar());
                return puesto;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar SQL: " +
                    System.Environment.NewLine + System.Environment.NewLine +
                    ex.GetType().ToString() + System.Environment.NewLine +
                    ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        //Metodos para formulario frmNomina

        //busca todas las deducciones realizadas a empleados de un periodo de planilla
        public DataTable funcVisDeducciones()
        {
            try
            {
                DataTable Datos = new DataTable();
                string sentencia = "SELECT * FROM deduccion";
                OdbcCommand Query_Validacion1 = new OdbcCommand(sentencia, Conexion.funcconexion());
                OdbcDataAdapter Lector = new OdbcDataAdapter();
                Lector.SelectCommand = Query_Validacion1;
                Lector.Fill(Datos);
                return Datos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar SQL: " +
                    System.Environment.NewLine + System.Environment.NewLine +
                    ex.GetType().ToString() + System.Environment.NewLine +
                    ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        //busca todas las percepciones realizadas a empleados de un periodo de planilla
        public DataTable funcVisPercepciones()
        {
            try
            {
                DataTable Datos = new DataTable();
                string sentencia = "SELECT * FROM percepcion";
                OdbcCommand Query_Validacion1 = new OdbcCommand(sentencia, Conexion.funcconexion());
                OdbcDataAdapter Lector = new OdbcDataAdapter();
                Lector.SelectCommand = Query_Validacion1;
                Lector.Fill(Datos);
                return Datos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar SQL: " +
                    System.Environment.NewLine + System.Environment.NewLine +
                    ex.GetType().ToString() + System.Environment.NewLine +
                    ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        //busca todas las deducciones de un periodode planilla
        public DataTable funcVisDedPlanilla(string Fecha)
        {
            try
            {
                DataTable Datos = new DataTable();
                string sentencia = "SELECT emp.pk_id_empleado AS 'ID Empleado' , emp.nombre1_empleado AS 'Primer Nombre', emp.nombre2_empleado AS 'Segundo Nombre', emp.apellido1_empleado AS 'Primer Apellido', emp.apellido2_empleado AS 'Segundo Apellido'," +
                    " ded.nombre_deduccion AS 'Deduccion', ded.monto_deduccion AS 'Monto' FROM detalle_nomina AS det, empleado AS emp, encabezado_nomina AS enc, deduccion AS ded " +
                    "WHERE enc.fecha_inicio_encabezado_nomina ='" + Fecha + "' AND det.fk_id_empleado_detalle_nomina = emp.pk_id_empleado AND det.fk_id_deducciones_detalle_nomina = ded.pk_id_deduccion";
                OdbcCommand Query_Validacion1 = new OdbcCommand(sentencia, Conexion.funcconexion());
                OdbcDataAdapter Lector = new OdbcDataAdapter();
                Lector.SelectCommand = Query_Validacion1;
                Lector.Fill(Datos);
                return Datos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar SQL: " +
                    System.Environment.NewLine + System.Environment.NewLine +
                    ex.GetType().ToString() + System.Environment.NewLine +
                    ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        //busca todas las percepciones de un periodode planilla
        public DataTable funcVisPerPlanilla(string Fecha)
        {
            try
            {
                DataTable Datos = new DataTable();
                string sentencia = "SELECT emp.pk_id_empleado AS 'ID Empleado' , emp.nombre1_empleado AS 'Primer Nombre', emp.nombre2_empleado AS 'Segundo Nombre', emp.apellido1_empleado AS 'Primer Apellido', emp.apellido2_empleado AS 'Segundo Apellido'," +
                    " per.nombre_percepcion AS 'Percepcion', per.monto_percepcion AS 'Monto' FROM detalle_nomina AS det, empleado AS emp, encabezado_nomina AS enc, percepcion AS per " +
                    "WHERE enc.fecha_inicio_encabezado_nomina ='" + Fecha + "' AND det.fk_id_empleado_detalle_nomina = emp.pk_id_empleado AND det.fk_id_percepciones_detalle_nomina  = per.pk_id_percepcion";
                OdbcCommand Query_Validacion1 = new OdbcCommand(sentencia, Conexion.funcconexion());
                OdbcDataAdapter Lector = new OdbcDataAdapter();
                Lector.SelectCommand = Query_Validacion1;
                Lector.Fill(Datos);
                return Datos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar SQL: " +
                    System.Environment.NewLine + System.Environment.NewLine +
                    ex.GetType().ToString() + System.Environment.NewLine +
                    ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        //busca todas las horas de todos los empleados durante un periodo de planilla
        public DataTable funcVisHoras(string Fecha)
        {
            try
            {
                DataTable Datos = new DataTable();
                string sentencia = "SELECT emp.pk_id_empleado AS 'ID Empleado' , emp.nombre1_empleado AS 'Primer Nombre', emp.nombre2_empleado AS 'Segundo Nombre', emp.apellido1_empleado AS 'Primer Apellido', emp.apellido2_empleado AS 'Segundo Apellido'," +
                    " ch.horas_hordinarias AS 'Horas Ordinarias', ch.horas_extra AS 'Horas Extraordinarias' FROM control_horas AS ch, empleado AS emp, encabezado_nomina AS enc " +
                    "WHERE ch.fk_id_control_horas_empleado = emp.pk_id_empleado AND enc.fecha_inicio_encabezado_nomina ='" + Fecha + "'";
                OdbcCommand Query_Validacion1 = new OdbcCommand(sentencia, Conexion.funcconexion());
                OdbcDataAdapter Lector = new OdbcDataAdapter();
                Lector.SelectCommand = Query_Validacion1;
                Lector.Fill(Datos);
                return Datos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar SQL: " +
                    System.Environment.NewLine + System.Environment.NewLine +
                    ex.GetType().ToString() + System.Environment.NewLine +
                    ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        //busca todos los dias de todos los empleados durante un periodo de planilla
        public DataTable funcVisDias(string Fecha)
        {
            try
            {
                DataTable Datos = new DataTable();
                string sentencia = "SELECT emp.pk_id_empleado AS 'ID Empleado' , emp.nombre1_empleado AS 'Primer Nombre', emp.nombre2_empleado AS 'Segundo Nombre', emp.apellido1_empleado AS 'Primer Apellido', emp.apellido2_empleado AS 'Segundo Apellido'," +
                    " ca.dias_laborados AS 'Dias Laborados', ca.dias_ausente_justificados AS 'Dias Ausentado(Justificados)', ca.dias_ausente_injustificados AS 'Dias Ausentado(Injustificados)' " +
                    "FROM control_asistencia AS ca, empleado AS emp, encabezado_nomina AS enc " +
                    "WHERE ca.fk_id_control_asistencia_empleado = emp.pk_id_empleado AND enc.fecha_inicio_encabezado_nomina ='" + Fecha + "'";
                OdbcCommand Query_Validacion1 = new OdbcCommand(sentencia, Conexion.funcconexion());
                OdbcDataAdapter Lector = new OdbcDataAdapter();
                Lector.SelectCommand = Query_Validacion1;
                Lector.Fill(Datos);
                return Datos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar SQL: " +
                    System.Environment.NewLine + System.Environment.NewLine +
                    ex.GetType().ToString() + System.Environment.NewLine +
                    ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        //Ingresa un nuevo periodo de planilla
        public void funcCrearPeriodo(string Nom, string FI, string FF)
        {
            try
            {
                string Correlativo = "SELECT IFNULL(MAX(pk_id_encabezado_nomina),0) +1 FROM encabezado_nomina";
                OdbcCommand Query_Validacion = new OdbcCommand(Correlativo, Conexion.funcconexion());
                int IdEnc = Convert.ToInt32(Query_Validacion.ExecuteScalar());
                OdbcDataReader Ejecucion1 = Query_Validacion.ExecuteReader();

                string sentencia = "INSERT INTO encabezado_nomina (pk_id_encabezado_nomina, nombre_encabezado_nomina, fecha_inicio_encabezado_nomina, fecha_fin_encabezado_nomina) VALUES ('" + IdEnc + "','" + Nom + "','" + FI + "','" + FF + "')";
                OdbcCommand Query_Validacion1 = new OdbcCommand(sentencia, Conexion.funcconexion());
                Query_Validacion1.ExecuteNonQuery();
                MessageBox.Show("Ingreso Exitoso", "INGRESO DE PERIODO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar SQL: " +
                    System.Environment.NewLine + System.Environment.NewLine +
                    ex.GetType().ToString() + System.Environment.NewLine +
                    ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Metodos para formulario frmControlHorasDias

        //ingresa horas laboradas de un empleado
        public void funcIgresarHoras(string Fecha, int IdEmp, int HorasOrd, int HorasExt)
        {
            try
            {
                string Correlativo = "SELECT IFNULL(MAX(pk_id_control_horas),0) +1 FROM control_horas";
                OdbcCommand Query = new OdbcCommand(Correlativo, Conexion.funcconexion());
                int Id_Control_Horas = Convert.ToInt32(Query.ExecuteScalar());

                string sentenciaEncNom = "SELECT pk_id_encabezado_nomina  FROM encabezado_nomina WHERE fecha_inicio_encabezado_nomina ='" + Fecha + "'";
                OdbcCommand Query_Validacion3 = new OdbcCommand(sentenciaEncNom, Conexion.funcconexion());
                int IdEncNom = Convert.ToInt32(Query_Validacion3.ExecuteScalar());

                string sentencia = "INSERT INTO control_horas (pk_id_control_horas , fk_id_control_horas_empleado  , fk_id_control_horas_encabezado_nomina, horas_hordinarias, horas_extra) VALUES ('" + Id_Control_Horas    + "','" + IdEmp + "','" + IdEncNom + "','" + HorasOrd + "','" + HorasExt + "')";
                OdbcCommand Query_Validacion2 = new OdbcCommand(sentencia, Conexion.funcconexion());
                Query_Validacion2.ExecuteNonQuery();
                MessageBox.Show("Ingreso Exitoso", "INGRESO DE HORAS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar SQL: " +
                    System.Environment.NewLine + System.Environment.NewLine +
                    ex.GetType().ToString() + System.Environment.NewLine +
                    ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //ingresa dias laboradas de un empleado
        public void funcIgresarDias(string Fecha, int IdEmp, int DiasLab, int DiasJus, int DiasInjust)
        {
            try
            {
                string Correlativo = "SELECT IFNULL(MAX(pk_id_control_asistencia ),0) +1 FROM control_asistencia";
                OdbcCommand Query = new OdbcCommand(Correlativo, Conexion.funcconexion());
                int Id_Control_asistencia = Convert.ToInt32(Query.ExecuteScalar());

                string sentenciaEncNom = "SELECT pk_id_encabezado_nomina  FROM encabezado_nomina WHERE fecha_inicio_encabezado_nomina ='" + Fecha + "'";
                OdbcCommand Query_Validacion3 = new OdbcCommand(sentenciaEncNom, Conexion.funcconexion());
                int IdEncNom = Convert.ToInt32(Query_Validacion3.ExecuteScalar());

                string sentencia = "INSERT INTO control_asistencia (pk_id_control_asistencia , fk_id_control_asistencia_empleado ,fk_id_control_asistencia_encabezado_nomina, dias_laborados, dias_ausente_justificados, dias_ausente_injustificados) VALUES ('" + Id_Control_asistencia + "','" + IdEmp + "','" + IdEncNom + "','" + DiasLab + "','" + DiasJus + "','" + DiasInjust + "')";
                OdbcCommand Query_Validacion2 = new OdbcCommand(sentencia, Conexion.funcconexion());
                Query_Validacion2.ExecuteNonQuery();
                MessageBox.Show("Ingreso Exitoso", "INGRESO DE DIAS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar SQL: " +
                    System.Environment.NewLine + System.Environment.NewLine +
                    ex.GetType().ToString() + System.Environment.NewLine +
                    ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //modifica horas laboradas de un empleado
        public void funcModificarHoras(string Fecha, int IdEmp, int HorasOrd, int HorasExt)
        {
            try
            {
                string sentenciaEncNom = "SELECT pk_id_encabezado_nomina  FROM encabezado_nomina WHERE fecha_inicio_encabezado_nomina ='" + Fecha + "'";
                OdbcCommand Query_Validacion3 = new OdbcCommand(sentenciaEncNom, Conexion.funcconexion());
                int IdEncNom = Convert.ToInt32(Query_Validacion3.ExecuteScalar());

                string sentencia = "UPDATE control_horas SET horas_hordinarias='" + HorasOrd + "', horas_extra='" + HorasExt + "' WHERE fk_id_control_horas_empleado= '" + IdEmp + "' AND fk_id_control_horas_encabezado_nomina= '" + IdEncNom + "'";
                OdbcCommand Query_Validacion1 = new OdbcCommand(sentencia, Conexion.funcconexion());
                Query_Validacion1.ExecuteNonQuery();
                MessageBox.Show("Modificación Exitosa", "MODIFICACIÓN DE HORAS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar SQL: " +
                    System.Environment.NewLine + System.Environment.NewLine +
                    ex.GetType().ToString() + System.Environment.NewLine +
                    ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //modifica dias laboradas de un empleado
        public void funcModificarDias(string Fecha, int IdEmp, int DiasLab, int DiasJus, int DiasInjust)
        {
            try
            {
                string sentenciaEncNom = "SELECT pk_id_encabezado_nomina  FROM encabezado_nomina WHERE fecha_inicio_encabezado_nomina ='" + Fecha + "'";
                OdbcCommand Query_Validacion3 = new OdbcCommand(sentenciaEncNom, Conexion.funcconexion());
                int IdEncNom = Convert.ToInt32(Query_Validacion3.ExecuteScalar());

                string sentencia = "UPDATE control_asistencia SET dias_laborados='" + DiasLab + "', dias_ausente_justificados='" + DiasJus + "', dias_ausente_injustificados='" + DiasInjust + "' WHERE fk_id_control_asistencia_empleado= '" + IdEmp + "' AND fk_id_control_asistencia_encabezado_nomina= '" + IdEncNom + "'";
                OdbcCommand Query_Validacion1 = new OdbcCommand(sentencia, Conexion.funcconexion());
                Query_Validacion1.ExecuteNonQuery();
                MessageBox.Show("Modificación Exitosa", "MODIFICACIÓN DE HORAS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar SQL: " +
                    System.Environment.NewLine + System.Environment.NewLine +
                    ex.GetType().ToString() + System.Environment.NewLine +
                    ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //busca horas laboradas de un empleado
        public OdbcDataReader funcBuscarHoras(int IdEmp, string Fecha)
        {
            try
            {
                string sentenciaEncNom = "SELECT pk_id_encabezado_nomina  FROM encabezado_nomina WHERE fecha_inicio_encabezado_nomina ='" + Fecha + "'";
                OdbcCommand Query_Validacion3 = new OdbcCommand(sentenciaEncNom, Conexion.funcconexion());
                int IdEncNom = Convert.ToInt32(Query_Validacion3.ExecuteScalar());

                string sentencia = "SELECT 	horas_hordinarias, 	horas_extra FROM control_horas WHERE fk_id_control_horas_empleado = '" + IdEmp + "'AND fk_id_control_horas_encabezado_nomina = '" + IdEncNom + "'";
                OdbcCommand Query_Validacion1 = new OdbcCommand(sentencia, Conexion.funcconexion());
                OdbcDataReader Lector = Query_Validacion1.ExecuteReader();
                return Lector;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar SQL: " +
                    System.Environment.NewLine + System.Environment.NewLine +
                    ex.GetType().ToString() + System.Environment.NewLine +
                    ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        //busca dias laboradas de un empleado
        public OdbcDataReader funcBuscarDias(int IdEmp, string Fecha)
        {
            try
            {
                string sentenciaEncNom = "SELECT pk_id_encabezado_nomina  FROM encabezado_nomina WHERE fecha_inicio_encabezado_nomina ='" + Fecha + "'";
                OdbcCommand Query_Validacion3 = new OdbcCommand(sentenciaEncNom, Conexion.funcconexion());
                int IdEncNom = Convert.ToInt32(Query_Validacion3.ExecuteScalar());

                string sentencia = "SELECT dias_laborados, dias_ausente_justificados, dias_ausente_injustificados FROM control_asistencia WHERE fk_id_control_asistencia_empleado = '" + IdEmp + "'AND fk_id_control_asistencia_encabezado_nomina = '" + IdEncNom + "'";
                OdbcCommand Query_Validacion1 = new OdbcCommand(sentencia, Conexion.funcconexion());
                OdbcDataReader Lector = Query_Validacion1.ExecuteReader();
                return Lector;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar SQL: " +
                    System.Environment.NewLine + System.Environment.NewLine +
                    ex.GetType().ToString() + System.Environment.NewLine +
                    ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
