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
        public String TipoUSuario;
        public string CapturarUser;
        public InicioAdmin()
        {
            InitializeComponent();

        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCerrarAdmin_Click(object sender, EventArgs e)
        {
            this.Close();
            frmElUnico login = new frmElUnico();
            login.Show();
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

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            FrmUsuarios usuarios = new FrmUsuarios();
            AbrirFormulario(usuarios);
            usuarios.CapturarTipoUsuario = lblTipoUsuarioCapturado.Text;
        }
        private void AbrirFormEnPanel(object formhija)
        {
            if (this.pnContenedor.Controls.Count > 0)
                this.pnContenedor.Controls.RemoveAt(0);
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
           this.pnContenedor.Controls.Add(fh);
            this.pnContenedor.Tag = fh;
            fh.Show();
        }
        private void AbrirFormulario(Form Hijo)
        {
            if (this.pnContenedor.Controls.Count > 0)
                this.pnContenedor.Controls.RemoveAt(0);
            Hijo.TopLevel = false;
            this.pnContenedor.Controls.Add(Hijo);
            Hijo.Dock = DockStyle.Fill;
            Hijo.Show();
        }
        private void btnProductos_Click(object sender, EventArgs e)
        {
            this.AbrirFormEnPanel(new interfazProductos());
        }

        private void InicioAdmin_Load(object sender, EventArgs e)
        {
            lblTipoUsuarioCapturado.Text = TipoUSuario;
        }


    }
}
