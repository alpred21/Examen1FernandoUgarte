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
    public class PersonaBSS
    {
        PersonaDAL dal = new PersonaDAL();
        public DataTable ListarPersonaBSS()
        {
            return dal.ListarPersonaDal();
        }
    }
}
