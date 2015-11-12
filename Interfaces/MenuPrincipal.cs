using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Interfaces;

namespace AlquileresDEC.Interfaces
{
    public partial class Menu_Principal : Form
    {
        public Menu_Principal()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var form = new ABM_Propiedad();
            form.Show();
        }

        private void consultarPropiedadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new Consulta_Propiedades();
            form.Show();
        }

        private void selecciónDeAlternativasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new Seleccion_Alternativas();
            form.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dispose();
        }

    }
}
