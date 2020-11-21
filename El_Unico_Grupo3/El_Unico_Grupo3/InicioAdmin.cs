using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace El_Unico_Grupo3
{
    public partial class InicioAdmin : Form
    {
        public InicioAdmin()
        {
            InitializeComponent();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCerrarAdmin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnExpandir_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnExpandir.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnExpandir.Visible = true;
        }
    }
}
