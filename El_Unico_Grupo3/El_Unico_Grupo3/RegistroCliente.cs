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
    public partial class RegistroCliente : Form
    {
        public RegistroCliente()
        {
            InitializeComponent();
        }
        ConexionDataBase conectionDB = new ConexionDataBase();

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
            //Consulta
            string consulta = "insert into Tab_Cliente(Nombre_Cliente,Apellido_Cliente,Dui_Cliente,Direccion_Cliente,Telefono_CLiente,Correo_Cliente,FK_Usuario_Cliente) value('" + txtNombre.Text + "', '" + txtApellido.Text + "','" + txtDui.Text + "','" + txtDireccion.Text + "','" + txtTel.Text + "','" + txtCoerro.Text + "',1);";
           //Condicion
            if (conectionDB.Insertar(consulta))
            {
                MessageBox.Show("Los datos fueron registrados exitosamente");
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
}
