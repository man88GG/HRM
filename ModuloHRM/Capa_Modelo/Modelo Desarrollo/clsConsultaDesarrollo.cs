using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Modelo.Modelo_Desarrollo
{
    public class clsConsultaDesarrollo
    {
        clsConexion Con = new clsConexion();
        public DataTable funcCmbHorario()
        {
            //Declaración de DataTable para Datos
            DataTable Datos = new DataTable();
            try
            {
                //Consulta para Obtener Datos y pasarlos a un DataTable
                string CargaPuestos = "SELECT * FROM HORARIO";
                OdbcCommand Query_Busqueda1 = new OdbcCommand(CargaPuestos, Con.funcconexion());

                OdbcDataAdapter Lector = new OdbcDataAdapter();              
                Lector.SelectCommand = Query_Busqueda1;
                Lector.Fill(Datos);

                Con.funcdesconexion(Con.funcconexion());
                return Datos;              
            }
            catch (Exception ex)
            {
                //Mensaje en dado caso de Error la Consulta
                MessageBox.Show("Error al ejecutar SQL: " +
                    System.Environment.NewLine + System.Environment.NewLine +
                    ex.GetType().ToString() + System.Environment.NewLine +
                    ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return Datos;
            }
        }
        public DataTable funcCmbCompetencia()
        {
            DataTable Datos = new DataTable();
            try
            {
                //Consulta para Obtener Datos y pasarlos a un DataTable
                string CargaPuestos = "SELECT * FROM TIPO_COMPETENCIA";
                OdbcCommand Query_Busqueda1 = new OdbcCommand(CargaPuestos, Con.funcconexion());

                OdbcDataAdapter Lector = new OdbcDataAdapter();
                Lector.SelectCommand = Query_Busqueda1;
                Lector.Fill(Datos);

                Con.funcdesconexion(Con.funcconexion());
                return Datos;
            }
            catch (Exception ex)
            {
                //Mensaje en dado caso de Error la Consulta
                MessageBox.Show("Error al ejecutar SQL: " +
                    System.Environment.NewLine + System.Environment.NewLine +
                    ex.GetType().ToString() + System.Environment.NewLine +
                    ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return Datos;
            }
        }

        public void funcIngresoCompetencias(string IDEmp, string FI, string FF, List<int> IDs_Competencias, List<int> Resultados)
        {
            try
            {
                //Obtener ultimo ID ingresado en la Base de Datos
                string Correlativo = "SELECT IFNULL(MAX(pk_id_encabezado_competencia),0) +1 FROM encabezado_competencia";
                OdbcCommand Query_Validacion = new OdbcCommand(Correlativo, Con.funcconexion());
                int IdEnc = Convert.ToInt32(Query_Validacion.ExecuteScalar());
                OdbcDataReader Ejecucion1 = Query_Validacion.ExecuteReader();

                //Insertar Valores en el Encabezado de Competencia
                string sentencia = "INSERT INTO encabezado_competencia (pk_id_encabezado_competencia, fk_id_empleado_encabezado_competencia, fecha_inicio_encabezado_competencia, fecha_fin_encabezado_competencia) VALUES ('" + IdEnc + "','" + IDEmp + "','" + FI + "','" + FF + "')";
                OdbcCommand Query_Validacion1 = new OdbcCommand(sentencia, Con.funcconexion());
                Query_Validacion1.ExecuteNonQuery();

                //For Para recorrer las listas de Competencia y Resultado
                for(int i =0; i < IDs_Competencias.Count; i++)
                {
                    try
                    {
                        //Obtener ultimo ID ingresado en la Base de Datos
                        string Correlativo2 = "SELECT IFNULL(MAX(pk_id_competencia_desarrollo),0) +1 FROM competencia_desarrollo";
                        OdbcCommand Query_Validacion2 = new OdbcCommand(Correlativo2, Con.funcconexion());
                        int IdEnc2 = Convert.ToInt32(Query_Validacion2.ExecuteScalar());
                        OdbcDataReader Ejecucion2 = Query_Validacion2.ExecuteReader();

                        //Ingresar Competencias Correspondientes a sus resultados
                        string InsertarCompetencias = "INSERT INTO competencia_desarrollo (pk_id_competencia_desarrollo, fk_id_encabezado_competencia, fk_id_tipo_competencia_desarrollo, resultado_competencia_desarrollo) VALUES ('" + IdEnc2 + "','" + IdEnc + "','" + IDs_Competencias[i] + "','" + Resultados[i] + "')";
                        OdbcCommand Query_Validacion3 = new OdbcCommand(InsertarCompetencias, Con.funcconexion());
                        Query_Validacion3.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        //Mensaje en dado caso de Error la Consulta
                        MessageBox.Show("Error al ejecutar SQL: " +
                        System.Environment.NewLine + System.Environment.NewLine +
                        ex.GetType().ToString() + System.Environment.NewLine +
                        ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                //Mensaje Que se Ingreso correctamente los datos
                MessageBox.Show("Ingreso Exitoso de las competencias del Empleado Ingresado", "HRM DESARROLLO LABORAL", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                //Mensaje en dado caso de Error la Consulta
                MessageBox.Show("Error al ejecutar SQL: " +
                    System.Environment.NewLine + System.Environment.NewLine +
                    ex.GetType().ToString() + System.Environment.NewLine +
                    ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
