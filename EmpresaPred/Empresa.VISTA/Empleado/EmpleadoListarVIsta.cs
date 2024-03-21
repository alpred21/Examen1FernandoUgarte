using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Empresa.BSS;
using Empresa.DAL;
using Empresa.MODELO;
namespace Empresa.VISTA.Empleado
{
    public partial class EmpleadoListarVIsta : Form
    {
        public EmpleadoListarVIsta()
        {
            InitializeComponent();
        }
        
        EmpleadoBSS BSS = new EmpleadoBSS();
        private void EmpleadoListarVIsta_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BSS.ListarEmpleadoBSS();

        }
    }
}
