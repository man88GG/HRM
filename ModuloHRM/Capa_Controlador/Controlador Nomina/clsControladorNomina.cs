using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Odbc;
using Capa_Modelo;
using Capa_Modelo.Modelo_Nomina;

namespace Capa_Controlador.Controlador_Nomina
{
    public class clsControladorNomina
    {
        clsConsultasNomina Consulta = new clsConsultasNomina();

        // Metodos para formulario frmDeducPercep

        //Paso de parametros para ingresar una deducciones
        public void funcInsertarDeduccion(string Nom, double Monto, string Desc)
        {
            Consulta.funIngresarDededuccion(Nom, Monto, Desc);
        }

        //Paso de parametros para ingresar una percepcion
        public void funcInsertarPercepcion(string Nom, double Monto, string Desc)
        {
            Consulta.funIngresarPercepcion(Nom, Monto, Desc);
        }

        //Paso de parametros para buscar una deduccion
        public OdbcDataReader funcBuscarDeduccion(string Nom)
        {
            OdbcDataReader Lector = Consulta.funcBuscarDeduccion(Nom);
            return Lector;
        }

        //Paso de parametros para buscar una percepcion
        public OdbcDataReader funcBuscarPercepcion(string Nom)
        {
            OdbcDataReader Lector = Consulta.funcBuscarPercepcion(Nom);
            return Lector;
        }

        //Paso de parametros para modificar una deduccion
        public void funcModificarDeduccion(string Nom, double Monto, string Desc, string NomAnt)
        {
            Consulta.funcModificarDeduccion(Nom, Monto, Desc, NomAnt);
        }

        //Paso de parametros para modificar una percepcion
        public void funcModificarPercepcion(string Nom, double Monto, string Desc, string NomAnt)
        {
            Consulta.funcModificarPercepcion(Nom, Monto, Desc, NomAnt);
        }

        //Paso de parametros para eliminar una deduccion
        public void funcEliminarDeduccion(string Nom)
        {
            Consulta.funcEliminarDeduccion(Nom);
        }

        //Paso de parametros para eliminar una percepcion
        public void funcEliminarPercepcion(string Nom)
        {
            Consulta.funcEliminarPercepcion(Nom);
        }

        //Paso de parametros para obtener la fecha final de un periodo de planilla
        public string funcObtenerPeriodoFinal(string FI)
        {
            string FF = Consulta.funcObtenerPeriodoFinal(FI);
            return FF;
        }

        //Metodos para formulario frmEmpleadoNomina

        public OdbcDataReader funcBuscarNomEmpleado(int Id)
        {
            OdbcDataReader Lector = Consulta.funcBuscarNomEmpleado(Id);
            return Lector;
        }

        //Paso de parametros para llenar combobox de deducciones
        public DataTable funcLlenarcmbDeducciones()
        {
            DataTable Items = Consulta.funcDeduccionescmb();
            return Items;
        }

        //Paso de parametros para llenar combobox de percepciones
        public DataTable funcLlenarcmbPercepciones()
        {
            DataTable Items = Consulta.funcPercepcionescmb();
            return Items;
        }

        //Paso de parametros para llenar combobox con fecha de inicio de planilla
        public DataTable funcLLenarcmbFechaPanitlla()
        {
            DataTable Items = Consulta.funcFechaPlanillacmb();
            return Items;
        }

        //Paso de parametros para ingresar una deducciona a un empleado
        public void funcIngresarDeduccionEmpleado(string EncNom, int IdEmp, string Ded)
        {
            Consulta.funcIngresarDeduccionEmpleado(EncNom, IdEmp, Ded);
        }

        //Paso de parametros para ingresar una percepcion a un empleado
        public void funcIngresarPercepcionEmpleado(string EncNom, int IdEmp, string Per)
        {
            Consulta.funcIngresarPercepcionEmpleado(EncNom, IdEmp, Per);
        }

        //Paso de parametros para buscar deduciones de un empleado
        public DataTable funcLlenardgvDedEmp(int IdEmp, string Fecha)
        {
            DataTable Items = Consulta.funcDedEmpleado(IdEmp, Fecha);
            return Items;
        }

        //Paso de parametros para buscar percepciones de un empleado
        public DataTable funcLlenardgvPerEmp(int IdEmp, string Fecha)
        {
            DataTable Items = Consulta.funcPerEmpleado(IdEmp, Fecha);
            return Items;
        }

        //Paso de parametros para elminar una deduccion a un empleado
        public void funcEliminarDeduccionEmpleado(int IdEmp, string Ded, string fecha)
        {
            Consulta.funcEliminarDeduccionEmpleado(IdEmp, Ded, fecha);
        }

        //Paso de parametros para elminar una percepcion a un empleado
        public void funcEliminarPercepcionEmpleado(int IdEmp, string Per, string fecha)
        {
            Consulta.funcEliminarPercepcionEmpleado(IdEmp, Per, fecha);
        }

        //Paso de parametros para buscar el puesto de un empleado
        public string funcBuscarPuestoEmp (int Id)
        {
            string puesto = Consulta.funcBuscarPuestoEmp(Id);
            return puesto;
        }

        //Metodos para formulario frmNomina

        //Paso de parametros para visualizar en un datagridview las deducciones
        public DataTable funcVisDeducciones()
        {
            DataTable Datos = Consulta.funcVisDeducciones();
            return Datos;
        }

        //Paso de parametros para visualizar en un datagridview las percepciones
        public DataTable funcVisPercepciones()
        {
            DataTable Datos = Consulta.funcVisPercepciones();
            return Datos;
        }

        //Paso de parametros para visualizar en un datagridview las deducciones de un periodo
        public DataTable funcVisDedPlanilla(string Fecha)
        {
            DataTable Datos = Consulta.funcVisDedPlanilla(Fecha);
            return Datos;
        }

        //Paso de parametros para visualizar en un datagridview las percepciones de un periodo
        public DataTable funcVisPerPlanilla(string Fecha)
        {
            DataTable Datos = Consulta.funcVisPerPlanilla(Fecha);
            return Datos;
        }

        //Paso de parametros para visualizar en un datagridview las horas laboradas de un periodo
        public DataTable funcVisHoras(string Fecha)
        {
            DataTable Datos = Consulta.funcVisHoras(Fecha);
            return Datos;
        }

        //Paso de parametros para visualizar en un datagridview los dias laboradas de un periodo
        public DataTable funcVisDias(string Fecha)
        {
            DataTable Datos = Consulta.funcVisDias(Fecha);
            return Datos;
        }

        //Paso de parametros para crear un nuevo periodo de planilla
        public void funcCrearPeriodo(string Nom, string FI, string FF)
        {
            Consulta.funcCrearPeriodo(Nom, FI, FF);
        }

        //Metodos para formulario frmControlHorasDias

        //Paso de parametros para ingresar horas a un empleado
        public void funcIgresarHoras(string Fecha, int IdEmp, int HorasOrd, int HorasExt)
        {
            Consulta.funcIgresarHoras(Fecha, IdEmp, HorasOrd, HorasExt);
        }

        //Paso de parametros para ingresar los dias laborados de un empleado
        public void funcIgresarDias(string Fecha, int IdEmp, int DiasLab, int DiasJus, int DiasInjust)
        {
            Consulta.funcIgresarDias(Fecha, IdEmp, DiasLab, DiasJus, DiasInjust);
        }

        //Paso de parametros para modificar las horas de un empleado
        public void funcModificarHoras(string Fecha, int IdEmp, int HorasOrd, int HorasExt)
        {
            Consulta.funcModificarHoras(Fecha, IdEmp, HorasOrd, HorasExt);
        }

        //Paso de parametros para modificar los dias de un empleado
        public void funcModificarDias(string Fecha, int IdEmp, int DiasLab, int DiasJus, int DiasInjust)
        {
            Consulta.funcModificarDias(Fecha, IdEmp, DiasLab, DiasJus, DiasInjust);
        }

        //Paso de parametros para buscar horas de un empleado
        public OdbcDataReader funcBuscarHoras(int Id, string Fecha)
        {
            OdbcDataReader Lector = Consulta.funcBuscarHoras(Id, Fecha);
            return Lector;
        }

        //Paso de parametros para buscar dias de un empleado
        public OdbcDataReader funcBuscarDias(int Id, string Fecha)
        {
            OdbcDataReader Lector = Consulta.funcBuscarDias(Id, Fecha);
            return Lector;
        }
    }
}
