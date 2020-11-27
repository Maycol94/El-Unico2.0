using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace El_Unico_Grupo3
{
    public partial class FrmUsuarios : Form
    {
        private string usuario;
        private string Contraseña;
        private string TipoUsuario;
        private string Consulta;
        public string CapturarTipoUsuario;
        ConexionDataBase conexionDB = new ConexionDataBase();
        public FrmUsuarios()
        {
            InitializeComponent();
            lblCapturaTipoUsuario.Text = CapturarTipoUsuario;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

            if (EstaValidado())
            {
                usuario = txtUsuario.Text;
                Contraseña = txtContraseña.Text;
                TipoUsuario = cbxTipoUsuario.SelectedItem.ToString();
                Consulta = "INSERT INTO tab_usuario (Nombre_Usuario, Contrasena_Usuario, Tipo_Usuario) VALUES ('" + usuario + "', '" + Contraseña + "', '" + TipoUsuario + "');";
                if (conexionDB.Insertar(Consulta))
                {
                    MessageBox.Show("Registro guardato con exito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvUsuarios.DataSource = conexionDB.LlenarGrid("Select * from tab_usuario");
                }
                else
                {
                    MessageBox.Show("No se pudo realizar registro", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsuario.Clear();
                    txtContraseña.Clear();
                    txtUsuario.Focus();
                }
            }
        }
        private bool EstaValidado()
        {
            bool NoError = true;
            if (txtUsuario.Text == string.Empty)
            {
                errorIConRegistroUser.SetError(txtUsuario, "Ingrese su nombre de usuario");
                NoError = false;
            }

            if (txtContraseña.Text == string.Empty)
            {
                errorIConRegistroUser.SetError(txtContraseña, "Debe ingresar su contraseña");
                NoError = false;
            }

            if (txtContraseña.Text != txtConfirmarContraseña.Text)
            {
                errorIConRegistroUser.SetError(txtConfirmarContraseña, "Contraseña no coincide");
                NoError = false;

            }

            if (cbxTipoUsuario.SelectedItem == null)
            {
                errorIConRegistroUser.SetError(cbxTipoUsuario, "Seleccione el tipo de usuario");
                NoError = false;

            }

            return NoError;
        }

        private void btnBuscarPorID_Click(object sender, EventArgs e)
        {
            dgvUsuarios.DataSource = conexionDB.BuscarPorID("Select Id_Usuario, Nombre_Usuario, Tipo_Usuario from tab_usuario where Id_Usuario=" + txtIdUsuarioBusqueda.Text);
            txtIdUsuario.Text = Convert.ToString(dgvUsuarios.CurrentRow.Cells[0].Value);
            txtUsuario.Text = Convert.ToString(dgvUsuarios.CurrentRow.Cells[1].Value);
            cbxTipoUsuario.SelectedItem = Convert.ToString(dgvUsuarios.CurrentRow.Cells[2].Value);
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            //comboBox1.DataSource = conexionDB.LlenarGrid("Select * from tab_producto");
            //comboBox1.DisplayMember = "Nombre_Producto";
            //comboBox1.ValueMember = "Id_Producto";
            //MessageBox.Show(CapturarTipoUsuario);
            //dgvUsuarios.DataSource = conexionDB.LlenarGrid("Select * from tab_usuario");
            //lblCapturaTipoUsuario.Text = CapturarTipoUsuario;
        }

        private void txtIdUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtConfirmarContraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbxTipoUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (EstaValidado())
            {
                Consulta = "Update tab_usuario SET Nombre_Usuario='" + txtUsuario.Text + "', Contrasena_Usuario='" + txtContraseña.Text + "', Tipo_Usuario='" + cbxTipoUsuario.SelectedItem.ToString() + "' where Id_Usuario=" + txtIdUsuario.Text;
                if (conexionDB.Actualizar(Consulta))
                {
                    MessageBox.Show("Registro actualizado con exito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvUsuarios.DataSource = conexionDB.LlenarGrid("Select * from tab_usuario");
                    txtUsuario.Clear();
                    txtContraseña.Clear();
                    txtConfirmarContraseña.Clear();
                    txtIdUsuario.Clear();
                    txtIdUsuarioBusqueda.Clear();
                    cbxTipoUsuario.SelectedItem = null;
                    txtUsuario.Focus();
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el registro", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsuario.Clear();
                    txtContraseña.Clear();
                    txtIdUsuario.Clear();
                    cbxTipoUsuario.SelectedItem = null;
                    txtUsuario.Focus();
                }
            }

        }

        private void btnElimar_Click(object sender, EventArgs e)
        {
            if (CapturarTipoUsuario == "Administrador")
            {
                Consulta = "Delete from tab_usuario where Id_Usuario=" + txtIdUsuario.Text;
                if (conexionDB.Eliminar(Consulta))
                {
                    MessageBox.Show("Registro eliminado con exito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvUsuarios.DataSource = conexionDB.LlenarGrid("Select * from tab_usuario");
                    txtUsuario.Clear();
                    txtContraseña.Clear();
                    txtIdUsuario.Clear();
                    txtIdUsuarioBusqueda.Clear();
                    cbxTipoUsuario.SelectedItem = null;
                    txtUsuario.Focus();
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el registro", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsuario.Clear();
                    txtContraseña.Clear();
                    txtIdUsuario.Clear();
                    cbxTipoUsuario.SelectedItem = null;
                    txtUsuario.Focus();
                }
            }
            else
            {
                MessageBox.Show("No tinene permiso de administrador");
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SelectIndex(object sender, EventArgs e)
        {
            //string ObtenerPrecio = "select PrecioVentaUnitario_Inventario from tab_inventario where FK_Producto_Inventario = " + (comboBox1.SelectedIndex = int.Parse(comboBox1.ValueMember));
            //txtIdUsuarioBusqueda.Text = conexionDB.PrecioVenta(ObtenerPrecio);
        }

        private void btnAdministrar_Click(object sender, EventArgs e)
        {
            lblCapturaTipoUsuario.Text = CapturarTipoUsuario ;
            if (lblCapturaTipoUsuario.Text == "Administrador") 
            {

                dgvUsuarios.Visible = true;
                dgvUsuarios.DataSource = conexionDB.LlenarGrid("Select * from tab_usuario");
                btnRegistrar.Visible = true;
                btnElimar.Visible = true;
                btnActualizar.Visible = true;
                btnBuscarPorID.Visible = true;
                btnCerrar.Visible = true;
                txtIdUsuario.Visible = true;
                txtUsuario.Visible = true;
                txtContraseña.Visible = true;
                txtConfirmarContraseña.Visible = true;
                txtIdUsuarioBusqueda.Visible = true;
                cbxTipoUsuario.Visible = true;
                lblConfirmarContraseña.Visible = true;
                lblContraseña.Visible = true;
                lblIdBusquedaUsuario.Visible = true;
                lblIdUsuario.Visible = true;
                lblTipoUsuario.Visible = true;
                lblUsuario.Visible = true;
            }
            else 
            {
                dgvUsuarios.Visible = true;
                btnActualizar.Visible = true;
                btnBuscarPorID.Visible = true;
                btnCerrar.Visible = true;
                txtIdUsuario.Visible = true;
                txtUsuario.Visible = true;
                txtContraseña.Visible = true;
                txtConfirmarContraseña.Visible = true;
                txtIdUsuarioBusqueda.Visible = true;
                cbxTipoUsuario.Visible = true;
                lblConfirmarContraseña.Visible = true;
                lblContraseña.Visible = true;
                lblIdBusquedaUsuario.Visible = true;
                lblIdUsuario.Visible = true;
                lblTipoUsuario.Visible = true;
                lblUsuario.Visible = true;
            }
    }
       
    }
    
        
    
}
