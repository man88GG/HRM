using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Modelo.Modelo_Capacitacion
{
    public class clsConsultaCapacitacion
    {
        //Llamada a conexión
        clsConexion conexion = new clsConexion();
        
        //Consulta datos empleado
        public string[] funcNombreEmpleado(string idEmpleado)
        {
            //Creación de array
            string[] datos = new string[3];
            try
            {
                //Consulta de empleado
                string BuscarDatoEmpleado = "SELECT CONCAT(emp.nombre1_empleado,' ', emp.nombre2_empleado,' ', " +
                                                "emp.apellido1_empleado,' ',emp.apellido2_empleado)," +
                                                "emp.estado_empleado, dep.nombre_departamento_empresarial " +
                                                "FROM empleado as emp, departamento_empresarial as dep " +
                                                "WHERE emp.fk_id_departamento_empresarial_empleado = dep.pk_id__departamento_empresarial " +
                                                "AND emp.pk_id_empleado = '" + idEmpleado + "';";
                OdbcCommand Query_Busqueda = new OdbcCommand(BuscarDatoEmpleado, conexion.funcconexion());
                OdbcDataReader Lector = Query_Busqueda.ExecuteReader();
                //Ingreso de datos array
                if (Lector.HasRows == true)
                {
                    while (Lector.Read())
                    {
                        datos[0] = Lector.GetString(0);
                        datos[1] = Lector.GetString(1);
                        datos[2] = Lector.GetString(2);
                    }
                }
                //Validación
                else
                {
                    MessageBox.Show("ERROR: El codigo de empleado no es valido o no se encuentra registrado.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return datos;
            }
            //Catch de error de sql
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar SQL: " +
                System.Environment.NewLine + System.Environment.NewLine +
                ex.GetType().ToString() + System.Environment.NewLine +
                ex.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return datos;
            }
        }
        //Consulta de ingreso de cursos
        public void funcIngresarCurso(string idCurso, string nombreCurso, string idCapacitador, string detalle)
        {
            try
            {
                //Obtiene id del curso
                string buscarCurso = "SELECT * FROM curso as cur WHERE cur.pk_id_curso = '" + idCurso + "';";
                OdbcCommand Query_Busqueda = new OdbcCommand(buscarCurso, conexion.funcconexion());
                OdbcDataReader Lector = Query_Busqueda.ExecuteReader();
                //Si el curso existe
                if (Lector.HasRows == true)
                {
                    MessageBox.Show("ERROR: El codigo de curso puede que esté registrado.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //Si no existe
                else
                {
                    try
                    {
                        //Consulta de actualizacón de curso
                        string ingresarCurso = "INSERT INTO `curso` (`pk_id_curso`, `nombre_curso`, `fk_id_empleado_curso`, `detalle_curso`) " +
                                                  "VALUES ('" + idCurso + "', '" + nombreCurso + "', '" + idCapacitador + "', '" + detalle + "')";
                        OdbcCommand Query_Ingreso = new OdbcCommand(ingresarCurso, conexion.funcconexion());
                        Query_Ingreso.ExecuteNonQuery();
                        MessageBox.Show("Ingreso Exitoso", "Curso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    //Catch de error sql
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al ejecutar SQL: " +
                        System.Environment.NewLine + System.Environment.NewLine +
                        ex.GetType().ToString() + System.Environment.NewLine +
                        ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
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
        //COnsulta de datos del capacitador
        public string[] funcDatosCapacitador(string idEmpleado)
        {
            //Creación de array
            string[] datos = new string[3];
            try
            {
                //Consulta datos del capacitador
                string BuscarDatoEmpleado = "SELECT CONCAT(emp.nombre1_empleado,' ', emp.nombre2_empleado,' ', " +
                                            "emp.apellido1_empleado,' ',emp.apellido2_empleado),emp.email_empleado, pst.nombre_puesto " +
                                            "FROM empleado as emp, puesto as pst WHERE emp.fk_id_puesto_empleado = pst.pk_id_puesto " +
                                            "AND emp.pk_id_empleado = '" + idEmpleado + "';";
                OdbcCommand Query_Busqueda = new OdbcCommand(BuscarDatoEmpleado, conexion.funcconexion());
                OdbcDataReader Lector = Query_Busqueda.ExecuteReader();
                //Si el capacitador existe llena array
                if (Lector.HasRows == true)
                {
                    while (Lector.Read())
                    {
                        datos[0] = Lector.GetString(0);
                        datos[1] = Lector.GetString(1);
                        datos[2] = Lector.GetString(2);
                    }
                }
                //Validación
                else
                {
                    MessageBox.Show("ERROR: El codigo de empleado no es valido o no se encuentra registrado.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return datos;
            }
            //Catch error sql
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar SQL: " +
                System.Environment.NewLine + System.Environment.NewLine +
                ex.GetType().ToString() + System.Environment.NewLine +
                ex.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return datos;
            }
        }
        //Consulta datos curso
        public string[] funcConsultaCurso(string idCurso)
        {
            //Creación de array
            string[] datos = new string[3];
            try
            {
                //Consulta datos curso
                string BuscarDatoCurso = "SELECT cu.nombre_curso, cu.fk_id_empleado_curso, cu.detalle_curso " +
                                             "FROM curso as cu WHERE cu.pk_id_curso = '" + idCurso + "';";
                OdbcCommand Query_Busqueda = new OdbcCommand(BuscarDatoCurso, conexion.funcconexion());
                OdbcDataReader Lector = Query_Busqueda.ExecuteReader();
                //Si el curso existe llena array
                if (Lector.HasRows == true)
                {
                    while (Lector.Read())
                    {
                        datos[0] = Lector.GetString(0);
                        datos[1] = Lector.GetString(1);
                        datos[2] = Lector.GetString(2);
                    }
                }
                //Validación
                else
                {
                    MessageBox.Show("ERROR: El codigo de curso no es valido o no se encuentra registrado.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return datos;
            }
            //Catch error sql
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar SQL: " +
                System.Environment.NewLine + System.Environment.NewLine +
                ex.GetType().ToString() + System.Environment.NewLine +
                ex.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return datos;
            }
        }
        //Consulta actualizar cursos
        public void funcActualizarCurso(string idCurso, string nombreCurso, string idEmpleado, string detalle)
        {
            try
            {
                //Consulta de actualizacón de cursos
                string modificarCurso = "UPDATE `curso` SET `nombre_curso` = '" + nombreCurso + "', `fk_id_empleado_curso` = '" + idEmpleado + "', `detalle_curso` = '" + detalle + "' WHERE `curso`.`pk_id_curso` = '" + idCurso + "';";
                OdbcCommand Query_Actualizar = new OdbcCommand(modificarCurso, conexion.funcconexion());
                Query_Actualizar.ExecuteNonQuery();
                MessageBox.Show("Modificación Exitosa", "CURSOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //Catch error sql
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar SQL: " +
                System.Environment.NewLine + System.Environment.NewLine +
                ex.GetType().ToString() + System.Environment.NewLine +
                ex.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Consulta eliminar cursos
        public void funcEliminarCurso(string idCurso)
        {
            try
            {
                //Consulta de eliminación de cursos
                string eliminarCurso = "DELETE FROM `curso` WHERE `curso`.`pk_id_curso` = '" + idCurso + "';";
                OdbcCommand Query_Actualizar = new OdbcCommand(eliminarCurso, conexion.funcconexion());
                Query_Actualizar.ExecuteNonQuery();
                MessageBox.Show("Eliminación Exitosa", "CURSOS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //Validación de elminación de cursos
            catch (Exception)
            {
                MessageBox.Show("No puede eliminar un curso mientras esté asignado a una capacitación. Por favor verifique y vuelva a intentar","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Ingreso de detalle Capacitaciones
        public void funcIngresoDetalleCap(string idEmpleado, string idEncabezado, string fechaInic, string fechaFin, string idCurso, int horas, string codigoCapa)
        {
            try
            {
                //Obtener coincidencia codigo capacitación
                string buscarCurso = "SELECT * FROM `capacitacion` WHERE pk_id_capacitacion   = '" + codigoCapa + "';";
                OdbcCommand Query_Busqueda = new OdbcCommand(buscarCurso, conexion.funcconexion());
                OdbcDataReader Lector = Query_Busqueda.ExecuteReader();
                //Si existe
                if (Lector.HasRows == true)
                {
                    MessageBox.Show("ERROR: El codigo de capacitación puede que esté registrado.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                //Si no existe
                else
                {
                    try
                    {
                        //Obtener codigo de curso
                        string obtenerID = "SELECT cur.pk_id_curso FROM curso as cur WHERE cur.nombre_curso = '" + idCurso + "'; ";
                        OdbcCommand Query_Obtener = new OdbcCommand(obtenerID, conexion.funcconexion());
                        Query_Obtener.ExecuteNonQuery();
                        int codigoCurso = Convert.ToInt32(Query_Obtener.ExecuteScalar());
                        //Busca el curso
                        string buscarCurso2 = "SELECT * FROM `encabezado_capacitacion`  WHERE  	pk_id_encabezado_capacitacion    = '" + idEncabezado + "';";
                        OdbcCommand Query_Busqueda2 = new OdbcCommand(buscarCurso2, conexion.funcconexion());
                        OdbcDataReader Lector2 = Query_Busqueda2.ExecuteReader();
                        //Si el curso existe
                        if (Lector2.HasRows == true)
                        {
                            MessageBox.Show("ERROR: El codigo de detalle puede que esté registrado.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        //Si no existe
                        else
                        {
                            //Consulta para ingresar curso capacitación
                            string insertarEncabezado = "INSERT INTO `encabezado_capacitacion` " +
                                                        "(`pk_id_encabezado_capacitacion`, `fecha_inicio_encabezado_capacitacion`, `fecha_fin_encabezado_capacitacion`, `fk_id_curso_encabezado_capacitacion`, `horas_encabezado_capacitacion`) " +
                                                        "VALUES ('" + idEncabezado + "', '" + fechaInic + "', '" + fechaFin + "', '" + codigoCurso + "', '" + Convert.ToString(horas) + "') ";
                            OdbcCommand Query_Ingreso = new OdbcCommand(insertarEncabezado, conexion.funcconexion());
                            Query_Ingreso.ExecuteNonQuery();
                            //Ingerso capacitación
                            string insertarCapacitacion = "INSERT INTO `capacitacion` (`pk_id_capacitacion`, `fk_id_encabezado_capacitacion`, `fk_id_empleado_capacitacion`) " +
                                                            "VALUES ('" + codigoCapa + "', '" + idEncabezado + "', '" + idEmpleado + "') ";
                            OdbcCommand Query_IngresoC = new OdbcCommand(insertarCapacitacion, conexion.funcconexion());
                            Query_IngresoC.ExecuteNonQuery();
                            MessageBox.Show("Ingreso Exitoso", "Curso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    //Catch de error sql
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al ejecutar SQL: " +
                        System.Environment.NewLine + System.Environment.NewLine +
                        ex.GetType().ToString() + System.Environment.NewLine +
                        ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            //Catch de error sql
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar SQL: " +
                System.Environment.NewLine + System.Environment.NewLine +
                ex.GetType().ToString() + System.Environment.NewLine +
                ex.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Llenar datos curso
        public DataTable funcLlenarCurso()
        {
            //Creación de dataTable
            DataTable Datos = new DataTable();
            try
            {
                //Consulta de cursos
                string llenarCurso = "SELECT * FROM curso";
                OdbcCommand Query_Busqueda1 = new OdbcCommand(llenarCurso, conexion.funcconexion());
                OdbcDataAdapter Lector = new OdbcDataAdapter();
                Lector.SelectCommand = Query_Busqueda1;
                Lector.Fill(Datos);
            }
            //Catch error sql
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar SQL: " +
                System.Environment.NewLine + System.Environment.NewLine +
                ex.GetType().ToString() + System.Environment.NewLine +
                ex.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return Datos;
        }
        //Llenar tabla capacitaciones
        public DataTable funcLlenarTablaCap(string idEmpleado, string idCap)
        {
            //Creación dataTable
            DataTable Datos = new DataTable();
            try
            {
                //Consulta datos capacitacion
                string cargaDatos = "SELECT cap.pk_id_capacitacion AS 'Codigo de Capacitacion', cu.nombre_curso " +
                                    "AS 'Nombre de Curso', enc.fecha_inicio_encabezado_capacitacion AS 'Fecha de Inicio',enc.fecha_fin_encabezado_capacitacion " +
                                    "AS 'Fecha de Termino', cap.resultado_capacitacion AS 'Resultado'" +
                                    "FROM capacitacion as cap, curso as cu, encabezado_capacitacion as enc " +
                                    "WHERE cap.fk_id_encabezado_capacitacion = enc.pk_id_encabezado_capacitacion " +
                                    "AND (cap.fk_id_empleado_capacitacion = '" + idEmpleado + "' AND cap.pk_id_capacitacion = '" + idCap + "') " +
                                    "AND cap.fk_id_encabezado_capacitacion = enc.pk_id_encabezado_capacitacion " +
                                    "AND enc.fk_id_curso_encabezado_capacitacion = cu.pk_id_curso ";
                OdbcCommand Query_Busqueda1 = new OdbcCommand(cargaDatos, conexion.funcconexion());
                OdbcDataAdapter Lector = new OdbcDataAdapter();
                Lector.SelectCommand = Query_Busqueda1;
                Lector.Fill(Datos);
                return Datos;
            }
            //Catch error sql
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar SQL: " +
                System.Environment.NewLine + System.Environment.NewLine +
                ex.GetType().ToString() + System.Environment.NewLine +
                ex.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return Datos;
            }
        }
        //Ingresar resultados capacitación
        public void funcIngresarResultado(string idEmpleado, string idCap, string nota)
        {
            try
            {
                //Obtiene codigo del curso
                string obtenerID = "SELECT cap.pk_id_capacitacion AS 'Codigo de Capacitación'" +
                                    "FROM capacitacion as cap, curso as cu, encabezado_capacitacion as enc " +
                                    "WHERE cap.fk_id_empleado_capacitacion = '" + idEmpleado + "' " +
                                    "AND cap.pk_id_capacitacion = '" + idCap + "' " +
                                    "AND cap.fk_id_encabezado_capacitacion = enc.pk_id_encabezado_capacitacion;";
                OdbcCommand Query_Obtener = new OdbcCommand(obtenerID, conexion.funcconexion());
                Query_Obtener.ExecuteNonQuery();
                int codigoCurso = Convert.ToInt32(Query_Obtener.ExecuteScalar());
                try
                {
                    //Actualiza informacion curso
                    string modificarCurso = "UPDATE `capacitacion` SET `resultado_capacitacion` = '" + Convert.ToString(nota) + "' WHERE `capacitacion`.`pk_id_capacitacion` = " + codigoCurso + ";";
                    OdbcCommand Query_Actualizar = new OdbcCommand(modificarCurso, conexion.funcconexion());
                    Query_Actualizar.ExecuteNonQuery();
                }
                //catch error sql
                catch (Exception ex)
                {
                    MessageBox.Show("Error al ejecutar SQL: " +
                    System.Environment.NewLine + System.Environment.NewLine +
                    ex.GetType().ToString() + System.Environment.NewLine +
                    ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            //catch error sql
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar SQL: " +
                System.Environment.NewLine + System.Environment.NewLine +
                ex.GetType().ToString() + System.Environment.NewLine +
                ex.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Llenar capacitación
        public DataTable funcLlenarCap(string idEmpleado)
        {
            //Creacion dataTable
            DataTable Datos = new DataTable();
            try
            {
                //Consulta datos capacitación
                string llenarCap = "SELECT * FROM capacitacion as ca WHERE ca.fk_id_empleado_capacitacion = '" + idEmpleado + "';";
                OdbcCommand Query_Busqueda1 = new OdbcCommand(llenarCap, conexion.funcconexion());
                OdbcDataAdapter Lector = new OdbcDataAdapter();
                Lector.SelectCommand = Query_Busqueda1;
                Lector.Fill(Datos);
            }
            //Catch error sql
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar SQL: " +
                System.Environment.NewLine + System.Environment.NewLine +
                ex.GetType().ToString() + System.Environment.NewLine +
                ex.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return Datos;
        }
        //Llenar Data grid view cursos
        public DataTable funcDatosDGBCurso()
        {
            //Creación data table
            DataTable Datos = new DataTable();
            try
            {
                //Consulta datos curso
                string cargaDatos = "SELECT cu.pk_id_curso, cu.nombre_curso, CONCAT(emp.nombre1_empleado, " +
                                    "' ', emp.nombre2_empleado, ' ', emp.apellido1_empleado, ' ', emp.apellido2_empleado) " +
                                    "FROM curso as cu, empleado as emp WHERE cu.fk_id_empleado_curso = emp.pk_id_empleado;";
                OdbcCommand Query_Busqueda1 = new OdbcCommand(cargaDatos, conexion.funcconexion());
                OdbcDataAdapter Lector = new OdbcDataAdapter();
                Lector.SelectCommand = Query_Busqueda1;
                Lector.Fill(Datos);
                conexion.funcdesconexion(conexion.funcconexion());
                return Datos;
            }
            //Catch error sql
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar SQL: " +
                System.Environment.NewLine + System.Environment.NewLine +
                ex.GetType().ToString() + System.Environment.NewLine +
                ex.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return Datos;
            }
        }
        //llenar combobox empleado
        public DataSet funcLlenarCampos()
        {
            //Creacion data set
            DataSet Campos = new DataSet();
            try
            {
                //consulta empleados
                string Query_SELECT = "SELECT * FROM " + "empleado";
                OdbcCommand Ejecucion_Query = new OdbcCommand(Query_SELECT, conexion.funcconexion());
                OdbcDataAdapter Lector = new OdbcDataAdapter();
                Lector.SelectCommand = Ejecucion_Query;
                Lector.Fill(Campos);
                return Campos;
            }
            //Catch error sql
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar SQL: " +
                System.Environment.NewLine + System.Environment.NewLine +
                ex.GetType().ToString() + System.Environment.NewLine +
                ex.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return Campos;
            }
        }
        //Llenar campos busqueda
        public DataTable funcLlenarBusqueda(string nomCampo, string compare)
        {
            //Creación data table
            DataTable Datos = new DataTable();
            try
            {
                string cargaDatos = "SELECT emp.pk_id_empleado AS 'Codigo Empleado', " +
                                    "CONCAT(emp.nombre1_empleado, ' ', emp.nombre2_empleado, ' ', emp.apellido1_empleado, ' ', emp.apellido2_empleado)" +
                                    "AS 'Nombre' FROM empleado as emp WHERE emp." + nomCampo + " = '" + compare + "';";
                OdbcCommand Query_Busqueda1 = new OdbcCommand(cargaDatos, conexion.funcconexion());
                OdbcDataAdapter Lector = new OdbcDataAdapter();
                Lector.SelectCommand = Query_Busqueda1;
                Lector.Fill(Datos);
                conexion.funcdesconexion(conexion.funcconexion());
                return Datos;
            }
            //Catch error sql
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar SQL: " +
                System.Environment.NewLine + System.Environment.NewLine +
                ex.GetType().ToString() + System.Environment.NewLine +
                ex.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return Datos;
            }
        }
        //Consulta capacitación
        public string[] funcConsultarCapa(string idCapa)
        {
            //Creación de array
            string[] datos = new string[6];
            try
            {
                //Consulta datos capacitación  
                string BuscarDatoCapacitacion = "SELECT cap.fk_id_empleado_capacitacion, enc.pk_id_encabezado_capacitacion, " +
                                             "enc.fecha_inicio_encabezado_capacitacion, enc.fecha_fin_encabezado_capacitacion, " +
                                             "enc.horas_encabezado_capacitacion, cu.nombre_curso FROM capacitacion as cap, " +
                                             "encabezado_capacitacion as enc, curso as cu " +
                                             "WHERE cap.pk_id_capacitacion = '" + idCapa + "' AND (cap.fk_id_encabezado_capacitacion = enc.pk_id_encabezado_capacitacion " +
                                             "AND enc.fk_id_curso_encabezado_capacitacion = cu.pk_id_curso) ;";
                OdbcCommand Query_Busqueda = new OdbcCommand(BuscarDatoCapacitacion, conexion.funcconexion());
                OdbcDataReader Lector = Query_Busqueda.ExecuteReader();
                //si existe
                if (Lector.HasRows == true)
                {
                    while (Lector.Read())
                    {
                        datos[0] = Lector.GetString(0);
                        datos[1] = Lector.GetString(1);
                        datos[2] = Lector.GetString(2);
                        datos[3] = Lector.GetString(3);
                        datos[4] = Lector.GetString(4);
                        datos[5] = Lector.GetString(5);
                    }
                }
                //Validación
                else
                {
                    MessageBox.Show("ERROR: El codigo de capacitación no es valido o no se encuentra registrado.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return datos;
            }
            //Cathc error sql
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar SQL: " +
                System.Environment.NewLine + System.Environment.NewLine +
                ex.GetType().ToString() + System.Environment.NewLine +
                ex.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return datos;
            }
        }
        //Actualizar Capacitación
        public void funcActualizarCapa(string idCapacitacion, string fechaInicio, string fechaFin, string idEmpleado, string nomCur, string horas, string idEncCapa)
        {
            try
            {
                //Consulta modificar capacitación
                string modificarCap = "UPDATE `capacitacion` SET `fk_id_empleado_capacitacion` = '" + idEmpleado + "' WHERE `capacitacion`.`pk_id_capacitacion` = '" + idCapacitacion + "';";
                OdbcCommand Query_Actualizar = new OdbcCommand(modificarCap, conexion.funcconexion());
                Query_Actualizar.ExecuteNonQuery();
                //Obtener id curso
                string obtenerID = "SELECT cu.pk_id_curso FROM curso as cu WHERE cu.nombre_curso = '" + nomCur + "' ";
                OdbcCommand Query_Obtener = new OdbcCommand(obtenerID, conexion.funcconexion());
                Query_Obtener.ExecuteNonQuery();
                int codigoCurso = Convert.ToInt32(Query_Obtener.ExecuteScalar());
                //Actualizar capacitación
                string modificarCapEnc = "UPDATE `encabezado_capacitacion` SET " +
                                       "`fecha_inicio_encabezado_capacitacion` = '" + fechaInicio + "', `fecha_fin_encabezado_capacitacion` = '" + fechaFin + "', " +
                                       "`fk_id_curso_encabezado_capacitacion` = '" + codigoCurso + "', `horas_encabezado_capacitacion` = '" + horas + "' " +
                                       "WHERE `encabezado_capacitacion`.`pk_id_encabezado_capacitacion` = '" + idEncCapa + "' ;";
                OdbcCommand Query_Actualizar1 = new OdbcCommand(modificarCapEnc, conexion.funcconexion());
                Query_Actualizar1.ExecuteNonQuery();
                MessageBox.Show("Modificación Exitosa", "CAPACITACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //Catch error sql
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar SQL: " +
                System.Environment.NewLine + System.Environment.NewLine +
                ex.GetType().ToString() + System.Environment.NewLine +
                ex.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Eliminar capcitación
        public void funcEliminarCapa(string idCapa, string idEncCapa)
        {
            try
            {
                //Consulta eliminar capcitación
                string eliminarCapa = "DELETE FROM `capacitacion` WHERE `capacitacion`.`pk_id_capacitacion` = '" + idCapa + "'; ";
                OdbcCommand Query_Actualizar = new OdbcCommand(eliminarCapa, conexion.funcconexion());
                Query_Actualizar.ExecuteNonQuery();
                //Consulta eliminar encabezado capacitación
                string eliminarEncCapa = "DELETE FROM `encabezado_capacitacion` " +
                                            "WHERE `encabezado_capacitacion`.`pk_id_encabezado_capacitacion` = '" + idEncCapa + "';";
                OdbcCommand Query_Actualizar1 = new OdbcCommand(eliminarEncCapa, conexion.funcconexion());
                Query_Actualizar1.ExecuteNonQuery();
                MessageBox.Show("Eliminación Exitosa", "CAPACITACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //Catch error sql
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar SQL: " +
                System.Environment.NewLine + System.Environment.NewLine +
                ex.GetType().ToString() + System.Environment.NewLine +
                ex.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
