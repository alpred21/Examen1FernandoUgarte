using Actividad1.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa.DAL
{
    public class PersonaDAL
    {
        public DataTable ListarPersonaDal()
        {
            string consulta = "select * from Persona";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "table");
            return lista;
        }
    }
}
