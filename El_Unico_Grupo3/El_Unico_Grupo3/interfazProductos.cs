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
    public partial class interfazProductos : Form
    {

        private string Agregar;
        ConexionDataBase ConexionBase = new ConexionDataBase();
       
        public interfazProductos()
        {
            InitializeComponent();
        }

        private void interfazProductos_Load(object sender, EventArgs e)
        {
            dGVListadoProductos.DataSource = ConexionBase.LlenarGrid("SELECT pr.Codigo_Producto , pr.Nombre_Producto,pr.CostoUnitario_Producto,p.Nombre_Proveedor,p.Telefono_Proveedor FROM Tab_Producto pr Inner join Tab_Proveedor p on p.Id_Proveedor = pr.FK_Proveedor_Producto ");
        }

        private void btnAgregarProductos_Click(object sender, EventArgs e)
        {

            if (txtIngresarNuevoProducto.Text == string.Empty || txtCodigoProducto.Text==string.Empty || txtCostoUnitarioProducto.Text==string.Empty || txtProveedorDeProducto.Text==string.Empty)// si el cuadro de texto es vacio
            {
                MessageBox.Show("Complete los campos solicitados para añadir un nuevo producto", "error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                Agregar = "INSERT INTO tab_producto(Codigo_Producto,Nombre_Producto,CostoUnitario_Producto,FK_Proveedor_Producto) VALUES ('" + txtCodigoProducto.Text + "','" + txtIngresarNuevoProducto.Text + "','" + txtCostoUnitarioProducto.Text + "','" + txtProveedorDeProducto.Text + "')";

            if (ConexionBase.Insertar(Agregar))
                    {
                        MessageBox.Show("Exito al insertar producto", "Informacion",
                           MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dGVListadoProductos.DataSource = ConexionBase.LlenarGrid("SELECT pr.Codigo_Producto , pr.Nombre_Producto,pr.CostoUnitario_Producto,p.Nombre_Proveedor,p.Telefono_Proveedor FROM Tab_Producto pr Inner join Tab_Proveedor p on p.Id_Proveedor = pr.FK_Proveedor_Producto ");
                    }
                    else
                    {
                        MessageBox.Show("No se pudo insertar nada", "error",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

            }
        }

        private void txtNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;
                return;
            }

        }

        private void txtNumerosProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;
                return;
            }

        }
    }
}
