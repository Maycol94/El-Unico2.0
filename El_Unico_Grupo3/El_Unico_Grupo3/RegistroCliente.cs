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
       

        private void RegistroCliente_Load(object sender, EventArgs e)
        {
            dgvRegistroClientes.DataSource = conectionDB.LlenarGrid("Select * from tab_cliente");

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
