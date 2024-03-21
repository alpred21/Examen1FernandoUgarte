using Actividad1.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa.DAL
{
    public class EmpleadoDAL
    {
        public DataTable ListarEmpleadoDal()
        {
            string consulta = "select * from Empleado";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "table");
            return lista;
        }
    }
}
