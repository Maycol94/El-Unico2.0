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
    public partial class RegistroProveedores : Form
    {
        private string Consulta;
        private string NombreProveedor;
        private string TelefonoProveedor;
        private string DireccionProveedor;
        
        public string CapturarTipoUsuario;
        ConexionDataBase conexionDB = new ConexionDataBase();
        public RegistroProveedores()
        {
            InitializeComponent();
        }

        private void RegistroProveedores_Load(object sender, EventArgs e)
        {
            dgvProveedor.DataSource = conexionDB.LlenarGrid("Select * from tab_proveedor");
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            NombreProveedor = txtNombreProveedor.Text;
            TelefonoProveedor = txtTelefonoProveedor.Text;
            DireccionProveedor = txtDireccionProveedor.Text;
            Consulta = "INSERT INTO tab_proveedor (Nombre_Proveedor, Telefono_Proveedor, Direccion_Proveedor) VALUES ('" + NombreProveedor + "', '" + TelefonoProveedor + "', '" + DireccionProveedor + "');";
            if (EstaValidado())
            {
                errorIcone.Clear();
                if (conexionDB.Insertar(Consulta))
                {
                    MessageBox.Show("Registro guardato con exito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvProveedor.DataSource = conexionDB.LlenarGrid("Select * from tab_proveedor");
                    txtIdProveedor.Clear();
                    txtNombreProveedor.Clear();
                    txtTelefonoProveedor.Clear();
                    txtDireccionProveedor.Clear();
                    txtIdProveedorBusqueda.Clear();
                    txtNombreProveedor.Focus();
                }
                else
                {
                    MessageBox.Show("No se pudo realizar registro", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNombreProveedor.Clear();
                    txtTelefonoProveedor.Clear();
                    txtDireccionProveedor.Clear();
                    txtNombreProveedor.Focus();
                }
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (validarBusqueda())
            {
                Consulta = "Update tab_proveedor SET Nombre_Proveedor='" + txtNombreProveedor.Text + "', Telefono_Proveedor='" + txtTelefonoProveedor.Text + "', Direccion_Proveedor='" + txtDireccionProveedor.Text + "' where Id_Proveedor=" + txtIdProveedor.Text;
                if (conexionDB.Actualizar(Consulta))
                {
                    MessageBox.Show("Registro actualizado con exito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvProveedor.DataSource = conexionDB.LlenarGrid("Select * from tab_proveedor");
                    txtIdProveedor.Clear();
                    txtNombreProveedor.Clear();
                    txtTelefonoProveedor.Clear();
                    txtDireccionProveedor.Clear();
                    txtIdProveedorBusqueda.Clear();
                    txtIdProveedor.Focus();
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el registro", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtIdProveedor.Clear();
                    txtNombreProveedor.Clear();
                    txtTelefonoProveedor.Clear();
                    txtDireccionProveedor.Clear();
                    txtIdProveedorBusqueda.Clear();
                    txtIdProveedor.Focus();
                }
            }
        }

        private void btnElimar_Click(object sender, EventArgs e)
        {
            if (validarBusqueda())
            {
                errorIcone.Clear();
                Consulta = "Delete from tab_proveedor where Id_Usuario=" + txtIdProveedor.Text;
                if (conexionDB.Eliminar(Consulta))
                {
                    MessageBox.Show("Registro eliminado con exito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvProveedor.DataSource = conexionDB.LlenarGrid("Select * from tab_proveedor");
                    txtIdProveedor.Clear();
                    txtNombreProveedor.Clear();
                    txtTelefonoProveedor.Clear();
                    txtDireccionProveedor.Clear();
                    txtIdProveedorBusqueda.Clear();
                    txtNombreProveedor.Focus();
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el registro", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtIdProveedor.Clear();
                    txtNombreProveedor.Clear();
                    txtTelefonoProveedor.Clear();
                    txtDireccionProveedor.Clear();
                    txtIdProveedorBusqueda.Clear();
                    txtIdProveedor.Focus();
                }
            }
        }

        private void btnBuscarPorID_Click(object sender, EventArgs e)
        {

            if (validarBusqueda())
            {
                errorIcone.Clear();
                dgvProveedor.DataSource = conexionDB.BuscarPorID("Select * from tab_proveedor where Id_Proveedor=" + txtIdProveedorBusqueda.Text);
                txtIdProveedor.Text = Convert.ToString(dgvProveedor.CurrentRow.Cells[0].Value);
                txtNombreProveedor.Text = Convert.ToString(dgvProveedor.CurrentRow.Cells[1].Value);
                txtTelefonoProveedor.Text = Convert.ToString(dgvProveedor.CurrentRow.Cells[2].Value);
                txtDireccionProveedor.Text = Convert.ToString(dgvProveedor.CurrentRow.Cells[3].Value);
                lblCapturaTipoUsuario.Text = CapturarTipoUsuario;
                if (lblCapturaTipoUsuario.Text == "Administrador")
                {
                    btnElimar.Visible = true;
                }
            }
            
        }
        private bool validarBusqueda()
        {
            bool NoError = true;
            if (txtIdProveedorBusqueda.Text == string.Empty)
            {
                errorIcone.SetError(txtIdProveedorBusqueda, "Ingrese id del proveedor");
                NoError = false;
            }
            return NoError;
        }
        private bool EstaValidado()
        {
            bool NoError = true;
            if (txtNombreProveedor.Text == string.Empty)
            {
                errorIcone.SetError(txtNombreProveedor, "Ingrese su nombre de usuario");
                NoError = false;
            }
            if (txtTelefonoProveedor.Text == string.Empty)
            {
                errorIcone.SetError(txtTelefonoProveedor, "Ingrese su nombre de usuario");
                NoError = false;
            }
            if (txtDireccionProveedor.Text == string.Empty)
            {
                errorIcone.SetError(txtDireccionProveedor, "Ingrese su nombre de usuario");
                NoError = false;
            }
            return NoError;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
