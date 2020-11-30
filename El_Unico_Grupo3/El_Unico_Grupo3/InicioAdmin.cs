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
        public string TipoUSuario;
        public InicioAdmin()
        {
            InitializeComponent();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            if (this.pnContenedor.Controls.Count > 0)
                this.pnContenedor.Controls.RemoveAt(0);
            RegistroCliente cliente = new RegistroCliente();
            cliente.CapturarTipoUsuario = lblTipoUsuarioCapturado.Text;
            AbrirFormulario(cliente);
        }

        private void btnCerrarAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmElUnico login = new frmElUnico();
            login.Show();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmElUnico login = new frmElUnico();
            login.Show();
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
            if (this.pnContenedor.Controls.Count > 0)
                this.pnContenedor.Controls.RemoveAt(0);
            FrmUsuarios usuario = new FrmUsuarios();
            usuario.CapturarTipoUsuario = lblTipoUsuarioCapturado.Text;
            AbrirFormulario(usuario);
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
        public void AbrirFormulario(Form Hijo)
        {
            if (this.pnContenedor.Controls.Count > 0)
                this.pnContenedor.Controls.RemoveAt(0);
            Hijo.TopLevel = false;
            pnContenedor.Controls.Add(Hijo);
            Hijo.Dock = DockStyle.Fill;
            Hijo.Show();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            if (this.pnContenedor.Controls.Count > 0)
                this.pnContenedor.Controls.RemoveAt(0);
            interfazProductos productos = new interfazProductos();
            productos.CapturarTipoUsuario = lblTipoUsuarioCapturado.Text;
            AbrirFormulario(productos);
        }

        private void InicioAdmin_Load(object sender, EventArgs e)
        {
            lblTipoUsuarioCapturado.Text = TipoUSuario;
        }

        private void btnFactura_Click(object sender, EventArgs e)
        {
            RegistroFactura factura = new RegistroFactura();
            AbrirFormulario(factura);
        }

        private void btnProveedor_Click(object sender, EventArgs e)
        {
            RegistroProveedores proveedor = new RegistroProveedores();
            proveedor.CapturarTipoUsuario = lblTipoUsuarioCapturado.Text;
            AbrirFormulario(proveedor);
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            InterfazPedidos pedidos = new InterfazPedidos();
            pedidos.CapturarTipoUsuario = lblTipoUsuarioCapturado.Text;
            AbrirFormulario(pedidos);
        }

        private void pnContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnInventatio_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new frmInventario());
        }

        private void btnPedidos_Click_1(object sender, EventArgs e)
        {
            InterfazPedidos pedidos = new InterfazPedidos();
            pedidos.CapturarTipoUsuario = lblTipoUsuarioCapturado.Text;
            AbrirFormulario(pedidos);
        }

        private void btnProveedor_Click_1(object sender, EventArgs e)
        {
            RegistroProveedores proveedor = new RegistroProveedores();
            proveedor.CapturarTipoUsuario = lblTipoUsuarioCapturado.Text;
            AbrirFormulario(proveedor);
        }
    }
}
