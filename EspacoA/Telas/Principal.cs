using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EspacoA.Telas
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void PacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadUsu Usuarios = new CadUsu();
            Usuarios.TopLevel = false;
            Usuarios.Parent = telas;
            Usuarios.Show();
        }

        private void PacienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CadPac Pacientes = new CadPac();
            Pacientes.TopLevel = false;
            Pacientes.Parent = telas;
            Pacientes.Show();
        }

        private void EstéticaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadEst Estetica = new CadEst();
            Estetica.TopLevel = false;
            Estetica.Parent = telas;
            Estetica.Show();
        }
    }
}
