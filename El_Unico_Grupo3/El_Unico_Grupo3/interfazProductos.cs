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
        ConexionDataBase ConexionBase = new ConexionDataBase();
        private string Agregar;
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
            if (txtIngresarNuevoProducto.Text == string.Empty)// si el cuadro de texto es vacio
            {
                MessageBox.Show("Aun no ha ingresado nada en el campo", "error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);               
            }
            else
            {
                
                     Agregar = "INSERT INTO tab_producto (Codigo_Producto,Nombre_Producto,CostoUnitario_Producto,FK_Proveedor_Producto)VALUES (" + txtCodigoProducto + ",'" + txtIngresarNuevoProducto + ",'" + txtCostoUnitarioProducto + ",'" + txtProveedorDeProducto + ")";
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
    }
}
