using EspacoA.Telas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EspacoA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Principal Principal1 = new Principal();
            Principal1.Show();

        }
    }
}
