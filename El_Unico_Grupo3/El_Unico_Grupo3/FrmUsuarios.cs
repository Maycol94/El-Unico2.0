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
        private string Consulta;
        ConexionDataBase conexionDB = new ConexionDataBase();
        public FrmUsuarios()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            usuario = txtUsuario.Text;
            Contraseña = txtContraseña.Text;
            if(EstaValidado())
            {
                Consulta = "INSERT INTO tab_usuario (Nombre_Usuario, Contrasena_Usuario) VALUES ('"+usuario +"', '"+ Contraseña + "');";
                if (conexionDB.Insertar(Consulta))
                {
                    MessageBox.Show("Registro guardato con exito","Información", MessageBoxButtons.OK,MessageBoxIcon.Information);
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


            return NoError;
        }
    }
}
