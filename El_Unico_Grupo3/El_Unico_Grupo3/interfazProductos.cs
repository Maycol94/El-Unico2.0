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
        private double Costo;
        private string BuscarCodigo;
        ConexionDataBase ConexionBase = new ConexionDataBase();
        List<string> ListaProductos = new List<string>();

        public interfazProductos()
        {
            InitializeComponent();
        }

        private void interfazProductos_Load(object sender, EventArgs e)
        {
            dGVListadoProductos.DataSource = ConexionBase.LlenarGrid("SELECT pr.Codigo_Producto , pr.Nombre_Producto,pr.CostoUnitario_Producto,p.Nombre_Proveedor,p.Telefono_Proveedor FROM Tab_Producto pr Inner join Tab_Proveedor p on p.Id_Proveedor = pr.FK_Proveedor_Producto ");
            txtCodigoProducto.Focus();
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
                //Costo = double.Parse(txtCostoUnitarioProducto.Text);
                try
                {
                    Costo = double.Parse(txtCostoUnitarioProducto.Text);
                    while (Costo<0)
                    {
                        MessageBox.Show("Ingrese Costo Mayor a cero", "error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtCostoUnitarioProducto.Clear();
                        Costo=double.Parse(txtCostoUnitarioProducto.Text);
                    }
                    Agregar = "INSERT INTO tab_producto(Codigo_Producto,Nombre_Producto,CostoUnitario_Producto,FK_Proveedor_Producto) VALUES ('" + txtCodigoProducto.Text + "','" + txtIngresarNuevoProducto.Text + "','" + Costo + "','" + txtProveedorDeProducto.Text + "')";

                    if (ConexionBase.Insertar(Agregar))
                    {
                        MessageBox.Show("Exito al insertar producto", "Informacion",
                           MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //int cantidadEmpleados;
                        //string CodigoProducto;
                        //string NombreProducto;
                        //string CostoProducto;
                        //string IdProveedor;
                        //CodigoProducto = txtCodigoProducto.Text;
                        //ListaProductos.Add(CodigoProducto);
                        //NombreProducto = txtIngresarNuevoProducto.Text;
                        //ListaProductos.Add(NombreProducto);
                        //CostoProducto = txtCostoUnitarioProducto.Text;
                        //ListaProductos.Add(CostoProducto);
                        //IdProveedor = txtProveedorDeProducto.Text;
                        //ListaProductos.Add(IdProveedor);
                        dGVListadoProductos.DataSource = ConexionBase.LlenarGrid("SELECT pr.Codigo_Producto , pr.Nombre_Producto,pr.CostoUnitario_Producto,p.Nombre_Proveedor,p.Telefono_Proveedor FROM Tab_Producto pr Inner join Tab_Proveedor p on p.Id_Proveedor = pr.FK_Proveedor_Producto ");
                    }
                    else
                    {
                        MessageBox.Show("No se pudo insertar nada", "error",
                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                

                }
                catch
                {

                    MessageBox.Show("Ingrese un valor valido en el campo costo", "error",
                          MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Salir del programa","DEseaSalir",);
            DialogResult opcion; // declarando una variable de tipo  DialogResult
            opcion = MessageBox.Show("Desea volver al menu principal?", "Salir",
                                   MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //guardara el boton cliqueado por el usuario.
            if (opcion == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            try
            {

                BuscarCodigo = txtBuscarProducto.Text;

                dGVListadoProductos.DataSource = ConexionBase.LlenarGrid("SELECT pr.Codigo_Producto , pr.Nombre_Producto,pr.CostoUnitario_Producto,p.Nombre_Proveedor,p.Telefono_Proveedor FROM Tab_Producto pr Inner join Tab_Proveedor p on p.Id_Proveedor = pr.FK_Proveedor_Producto Where pr.Codigo_Producto =  '" + BuscarCodigo + "'");
            }
            catch (Exception)
            {
                MessageBox.Show("no se pudo hacer la consulta", "error",
                         MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnVolveraMostrarTodosLosRegistros_Click(object sender, EventArgs e)
        {
            dGVListadoProductos.DataSource = ConexionBase.LlenarGrid("SELECT pr.Codigo_Producto , pr.Nombre_Producto,pr.CostoUnitario_Producto,p.Nombre_Proveedor,p.Telefono_Proveedor FROM Tab_Producto pr Inner join Tab_Proveedor p on p.Id_Proveedor = pr.FK_Proveedor_Producto ");
            txtBuscarProducto.Clear();
        }

        private void dGVListadoProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtCodigoProducto.Text = dGVListadoProductos.CurrentRow.Cells[1].Value.ToString();
                txtIngresarNuevoProducto.Text = dGVListadoProductos.CurrentRow.Cells[2].Value.ToString();
                txtCostoUnitarioProducto.Text = dGVListadoProductos.CurrentRow.Cells[3].Value.ToString();
                txtProveedorDeProducto.Text = dGVListadoProductos.CurrentRow.Cells[4].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Rayos algo anda mal", "error",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
