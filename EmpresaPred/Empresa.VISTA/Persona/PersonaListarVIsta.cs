using Empresa.BSS;
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
using Empresa.MODELO;

namespace Empresa.VISTA.Persona
{
    public partial class PersonaListarVIsta : Form
    {
        public PersonaListarVIsta()
        {
            InitializeComponent();
        }
        PersonaBSS BSS = new PersonaBSS();

        private void PersonaListarVIsta_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BSS.ListarPersonaBSS();
        }
    }
}
