using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Modelo;
using Capa_Modelo.Modelo_Capacitacion;

namespace Capa_Controlador.Controlador_Capacitación
{
    public class clsControladorCapacitacion
    {
        //Inicializar capa Vista
        clsConsultaCapacitacion cons = new clsConsultaCapacitacion();
        //Retorna datos empleado en string[]
        public string[] funcConsultaEmp(string idEmpleado)
        {
            string[] datos = new string[3];
            //Llamada consulta
            datos = cons.funcNombreEmpleado(idEmpleado);
            return datos;
        }
        //Ingreso de cursos con paso de parámetros
        public void funcIngresoCurso(string idCurso, string nombreCurso, string idCapacitador, string detalle)
        {
            //Llamada consulta
            cons.funcIngresarCurso(idCurso, nombreCurso, idCapacitador, detalle);
        }
        //Retorna datos de capacitador en string[]
        public string[] funcDatosCapacitador(string idEmpleado)
        {
            string[] datos = new string[3];
            //Llamada consulta
            datos = cons.funcDatosCapacitador(idEmpleado);
            return datos;
        }
        //Retorna datos de curso en string[]
        public string[] funcDatosCurso(string idCurso)
        {
            string[] datos = new string[3];
            //Llamada consulta
            datos = cons.funcConsultaCurso(idCurso);
            return datos;
        }
        //Actualizacón de cursos con paso de parámetros
        public void funcActualizarCurso(string idCurso, string nombreCurso, string idEmpleado, string detalle)
        {
            //Llamada consulta
            cons.funcActualizarCurso(idCurso, nombreCurso, idEmpleado, detalle);
        }
        //Eliminación de curso con paso de parámetros
        public void funcEliminarCurso(string idCurso)
        {
            //Llamada consulta
            cons.funcEliminarCurso(idCurso);
        }
        //Ingresar encabezado con paso de parámetros
        public void funcIngresarEncabezado(string idEmpleado, string idEncabezado, string fechaInic, string fechaFin, string idCurso, int horas, string codigoCapa)
        {
            //Llamada consulta
            cons.funcIngresoDetalleCap(idEmpleado, idEncabezado, fechaInic, fechaFin, idCurso, horas, codigoCapa);
        }
        //Llena cursos y retorna DataTable
        public DataTable funcLlenarCurso()
        {
            //Llamada consulta
            DataTable dato = cons.funcLlenarCurso();
            return dato;
        }
        //Llenar dataGridView con retorno de dataTable
        public DataTable funcLlenarDGVRes(string idEmpleado, string idCap)
        {
            //Llamada consulta
            DataTable dato = cons.funcLlenarTablaCap(idEmpleado, idCap);
            return dato;
        }
        //Ingresar nota capacitación con paso de parámetros
        public void funcIngresoNota(string idEmpleado, string idCap, string nota)
        {
            //Llamada consulta
            cons.funcIngresarResultado(idEmpleado, idCap, nota);
        }
        //Llenar codigo de capacitación con retorno DataTable
        public DataTable funcLlenarCodigoCap(string idEmpleado)
        {
            //Llamada consulta
            DataTable dato = cons.funcLlenarCap(idEmpleado);
            return dato;
        }
        //Llenar dataGridView Curso con retorno de DataTable
        public DataTable funcLlenarDGVCurso()
        {
            //Llamada consulta
            DataTable dato = cons.funcDatosDGBCurso();
            return dato;
        }
        //Llenar campos de búsqueda con retorno DataSet
        public DataSet funcLlenarCampos()
        {
            //Llamada consulta
            DataSet Items = cons.funcLlenarCampos();
            return Items;
        }
        //Llenar tabla búsqueda con retorno de DataTable
        public DataTable funcLlenarBusqueda(string nomCampo, string compare)
        {
            //Llamada consulta
            DataTable dato = cons.funcLlenarBusqueda(nomCampo, compare);
            return dato;
        }
        //Consulta capacitación con retorno string[]
        public string[] funcConsultarCapa(string idCapa)
        {
            //Llamada consulta
            string[] datos = new string[6];
            datos = cons.funcConsultarCapa(idCapa);
            return datos;
        }
        //Actualizacón de capacitación con paso de parámetros
        public void funcActualizarCapa(string idCapacitacion, string fechaInicio, string fechaFin, string idEmpleado, string nomCur, string horas, string idEncCapa) {
            //Llamada consulta
            cons.funcActualizarCapa(idCapacitacion, fechaInicio, fechaFin, idEmpleado, nomCur, horas, idEncCapa);
        }
        //Eliminación de capacitación con paso de parámetros
        public void funcEliminarCapa(string idCapa, string idEncCapa) 
        {
            //Llamada consulta
            cons.funcEliminarCapa(idCapa, idEncCapa);
        }
    }
}
