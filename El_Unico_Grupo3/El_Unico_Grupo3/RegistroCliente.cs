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
    public partial class RegistroCliente : Form
    {
        ConexionDataBase conectionDB = new ConexionDataBase();
        private String nombre;
        private String apellido;
        private String dui;
        private String tel;
        private String correo;
        private String direccion;
        public string CapturarTipoUsuario;
       
        public RegistroCliente()
        {
            InitializeComponent();
        }
       

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDui.Text = "";
            txtTel.Text = "";
            txtCoerro.Text = "";
            txtDireccion.Text = "";
            txtNombre.Focus();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (EstaValidado())
            {
                erroIcon.Clear();
                nombre = txtNombre.Text;
                apellido = txtApellido.Text;
                dui = txtDui.Text;
                tel = txtTel.Text;
                correo = txtCoerro.Text;
                direccion = txtDireccion.Text;

                //Consulta
                string consulta = "insert into Tab_Cliente(Nombre_Cliente,Apellido_Cliente,Dui_Cliente,Direccion_Cliente,Telefono_CLiente,Correo_Cliente,FK_Usuario_Cliente) value('" + nombre + "', '" + apellido + "','" + dui + "','" + direccion + "','" + tel + "','" + correo + "',1);";
                //Condicion
                if (conectionDB.Insertar(consulta))
                {
                    MessageBox.Show("Los datos fueron registrados exitosamente");
                    dgvRegistroClientes.DataSource = conectionDB.LlenarGrid("Select * from tab_cliente");
                }
                else
                {
                    MessageBox.Show("Error al guardar Datos");
                }
                //Limpiar 
                txtNombre.Text = "";
                txtApellido.Text = "";
                txtDui.Text = "";
                txtTel.Text = "";
                txtCoerro.Text = "";
                txtDireccion.Text = "";
                txtNombre.Focus();
            }

        }
       

        private void RegistroCliente_Load(object sender, EventArgs e)
        {
            dgvRegistroClientes.DataSource = conectionDB.LlenarGrid("Select * from tab_cliente");

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscarClienteID_Click(object sender, EventArgs e)
        {
            if (validarBusqueda())
            {
                erroIcon.Clear();
                dgvRegistroClientes.DataSource = conectionDB.BuscarPorID("Select * from tab_cliente where Id_Cliente=" + txtBusquedaClienteID.Text);
                txtIdCliente.Text = Convert.ToString(dgvRegistroClientes.CurrentRow.Cells[0].Value);
                txtNombre.Text = Convert.ToString(dgvRegistroClientes.CurrentRow.Cells[1].Value);
                txtApellido.Text = Convert.ToString(dgvRegistroClientes.CurrentRow.Cells[2].Value);
                txtDui.Text = Convert.ToString(dgvRegistroClientes.CurrentRow.Cells[3].Value);
                txtDireccion.Text = Convert.ToString(dgvRegistroClientes.CurrentRow.Cells[4].Value);
                txtTel.Text = Convert.ToString(dgvRegistroClientes.CurrentRow.Cells[5].Value);
                txtCoerro.Text = Convert.ToString(dgvRegistroClientes.CurrentRow.Cells[6].Value);
                lblCapturarUsuario.Text = CapturarTipoUsuario;
                if (lblCapturarUsuario.Text == "Administrador")
                {
                    btnEliminar.Visible = true;
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string Consulta = "Delete from tab_cliente where Id_Cliente=" + txtIdCliente.Text;
            if (conectionDB.Eliminar(Consulta))
            {
                MessageBox.Show("Registro eliminado con exito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvRegistroClientes.DataSource = conectionDB.LlenarGrid("Select * from tab_cliente");
                txtIdCliente.Clear();
                txtNombre.Clear();
                txtApellido.Clear();
                txtDui.Clear();
                txtTel.Clear();
                txtCoerro.Clear();
                txtDireccion.Clear();
                txtNombre.Focus();
            }
            else
            {
                MessageBox.Show("No se pudo eliminar el registro", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtIdCliente.Clear();
                txtNombre.Clear();
                txtApellido.Clear();
                txtDui.Clear();
                txtTel.Clear();
                txtCoerro.Clear();
                txtDireccion.Clear();
                txtNombre.Focus();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
                string Consulta = "Update tab_cliente SET Nombre_Cliente='" + txtNombre.Text + "', Apellido_Cliente='" + txtApellido.Text + "', Dui_Cliente='" + txtDui.Text + "', Direccion_Cliente='" + txtDireccion.Text + "', Telefono_Cliente='" + txtTel.Text + "', Correo_Cliente='" + txtCoerro.Text + "' where Id_Cliente=" + txtIdCliente.Text;
                if (conectionDB.Actualizar(Consulta))
                {
                    MessageBox.Show("Registro actualizado con exito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvRegistroClientes.DataSource = conectionDB.LlenarGrid("Select * from tab_cliente");
                    txtIdCliente.Clear();
                    txtNombre.Clear();
                    txtApellido.Clear();
                    txtDui.Clear();
                    txtTel.Clear();
                    txtCoerro.Clear();
                    txtDireccion.Clear();
                    txtNombre.Focus();
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el registro", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtIdCliente.Clear();
                    txtNombre.Clear();
                    txtApellido.Clear();
                    txtDui.Clear();
                    txtTel.Clear();
                    txtCoerro.Clear();
                    txtDireccion.Clear();
                    txtNombre.Focus();
                }
            
        }
        private bool EstaValidado()
        {
            bool NoError = true;
            if (txtNombre.Text == string.Empty)
            {
                erroIcon.SetError(txtNombre, "Ingrese el nombre del cliente");
                NoError = false;
            }
            if (txtApellido.Text == string.Empty)
            {
                erroIcon.SetError(txtApellido, "Ingrese el apellido del cliente");
                NoError = false;
            }
            if (txtDui.Text == string.Empty)
            {
                erroIcon.SetError(txtDui, "Debe ingresar el DUI del cliente");
                NoError = false;
            }

            if (txtDireccion.Text == string.Empty)
            {
                erroIcon.SetError(txtDireccion, "Ingrese direccion");
                NoError = false;

            }

            if (txtTel.Text == string.Empty)
            {
                erroIcon.SetError(txtTel, "Ingrese el numero de telefono");
                NoError = false;

            }
            if (txtCoerro.Text == string.Empty)
            {
                erroIcon.SetError(txtCoerro, "Debe ingresar el correo");
                NoError = false;

            }
            
            return NoError;
        }
        private bool validarBusqueda()
        {
            bool NoError = true;
            if (txtBusquedaClienteID.Text == string.Empty)
            {
                erroIcon.SetError(txtBusquedaClienteID, "Debe ingresar id de busqueda");
                NoError = false;

            }
            return NoError;
        }

    }
}
