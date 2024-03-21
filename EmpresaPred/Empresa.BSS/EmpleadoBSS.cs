using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Empresa.DAL;
using Empresa.MODELO;

namespace Empresa.BSS
{
    public class EmpleadoBSS
    {
        EmpleadoDAL dal = new EmpleadoDAL();
        public DataTable ListarEmpleadoBSS()
        {
            return dal.ListarEmpleadoDal();
        }
    }
    public void InsertarEmpleadoBss(Empleado empleado)
    {
        DAL.InsertarEmpleadoDal(empleado);
    }
}
