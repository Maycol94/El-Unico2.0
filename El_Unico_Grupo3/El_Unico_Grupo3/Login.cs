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
    public partial class frmElUnico : Form
    {
        ConexionDataBase conexionDB = new ConexionDataBase();
        public string TipoUsuario;

        public frmElUnico()
        {
            InitializeComponent();
            bool Conectado = conexionDB.Conectar();
            if (Conectado == true)
            {
                MessageBox.Show("Conectado");
            }
            else
            {
                MessageBox.Show("Error al conectar");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            InicioAdmin Admin = new InicioAdmin();
            FrmUsuarios usuarios = new FrmUsuarios();
            frmRegistroClientes Empleado = new frmRegistroClientes();
            if (EstaValidado())
            {
                string consulta = "SELECT * FROM tab_usuario WHERE Nombre_Usuario='" + txtUsuario.Text + "' AND Contrasena_Usuario='" + txtContraseña.Text + "'";
                if (conexionDB.Login(consulta))
                {
                    MessageBox.Show("Bienvenido");  

                    TipoUsuario = "SELECT Tipo_Usuario FROM tab_usuario WHERE Nombre_Usuario='" + txtUsuario.Text + "' AND Contrasena_Usuario='" + txtContraseña.Text + "'";
                    MessageBox.Show(conexionDB.TipoUsuario(TipoUsuario));
                    //if (conexionDB.TipoUsuario(TipoUsuario).ToString() == "Administrador")
                    //{
                        Admin.TipoUSuario = conexionDB.TipoUsuario(TipoUsuario).ToString();
                        usuarios.CapturarTipoUsuario = conexionDB.TipoUsuario(TipoUsuario).ToString();
                        
                    this.Hide();
                        Admin.Show();
                    //}

                    //else
                    //{
                    //    this.Hide();
                    //    Empleado.Show();
                    //}
                }
                else
                {
                    MessageBox.Show("Usuario no existe en la base de datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                erroIcon.SetError(txtUsuario, "Ingrese su nombre de usuario");
                NoError = false;
            }
            
            if (txtContraseña.Text == string.Empty)
            {
                erroIcon.SetError(txtContraseña, "Debe ingresar su contraseña");
                NoError = false;
            }
            

            return NoError;
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Usuario")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.LightGray;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "Usuario";
                txtUsuario.ForeColor = Color.Silver;
            }
        }

        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "Contraseña")
            {
                txtContraseña.Text = "";
                txtContraseña.ForeColor = Color.LightGray;
                txtContraseña.UseSystemPasswordChar = true;
            }
        }

        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "")
            {
                txtContraseña.Text = "Contraseña";
                txtContraseña.ForeColor = Color.Silver;
                txtContraseña.UseSystemPasswordChar = false;
            }
        }

        private void frmElUnico_Load(object sender, EventArgs e)
        {

        }
    }
}
