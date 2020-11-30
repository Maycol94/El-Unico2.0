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
    public partial class InterfazPedidos : Form
    {
        public string CapturarTipoUsuario;
        ConexionDataBase conexionDB = new ConexionDataBase();
        private string Consulta;
        public float costoProducto;
        public float CostoTotalPedido;
        public InterfazPedidos()
        {
            InitializeComponent();
        }

        private void InterfazPedidos_Load(object sender, EventArgs e)
        {
            dGVListadoProductos.DataSource = conexionDB.LlenarGrid("Select * from tab_pedido");
            cbxProveedor.DataSource = conexionDB.LlenarGrid("Select * from tab_proveedor");
            cbxProveedor.ValueMember = "Id_Proveedor";
            cbxProveedor.DisplayMember = "Nombre_Proveedor";
            

            cbxProducto.DataSource = conexionDB.LlenarGrid("Select * from tab_producto");
            cbxProducto.ValueMember = "Id_Producto";
            cbxProducto.DisplayMember = "Nombre_Producto";
            

        }

        private void SelectedValueChangedProveedor(object sender, EventArgs e)
        {
            txtIdProveedor.Text = cbxProveedor.SelectedValue.ToString();
        }

        private void SelectedValueChangedProducto(object sender, EventArgs e)
        {
            txtIdProducto.Text = cbxProducto.SelectedValue.ToString();
            if (txtIdProducto.Text != string.Empty)
            {
                
                //cbxCostoProducto.ValueMember = "Id_Producto";
                //cbxCostoProducto.DisplayMember = "CostoUnitario_Producto";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCargarCosto_Click(object sender, EventArgs e)
        {
            costoProducto = float.Parse(conexionDB.CostoUnitario("SELECT CostoUnitario_Producto FROM tab_producto where Id_Producto=" + txtIdProducto.Text));
            txtCostoProducto.Text = "$ " + costoProducto.ToString();
        }

        private void btnAgregarCostoTotal_Click(object sender, EventArgs e)
        {
            CostoTotalPedido = float.Parse(txtCantidadPedido.Text) * costoProducto;
            txtCostoTotal.Text = "$ " + CostoTotalPedido.ToString();
        }

        private void btnAgregarProductos_Click(object sender, EventArgs e)
        {
            if (EstaValidado())
            {
                errorIcone.Clear();
                Consulta = "INSERT INTO tab_pedido (Cantidad_Pedido, Fecha_Pedido, PrecioUnitario_Pedido,FK_Proveedor_Pedido,FK_Producto_Pedido,CostoTotal_Pedido,Descripcion_Pedido) VALUES ('" + txtCantidadPedido.Text + "', '" + dtpFechaPedido.Value.ToString("yyyy-MM-dd") + "', '" + costoProducto.ToString() + "', '" + txtIdProveedor.Text + "', '" + txtIdProducto.Text + "', '" + CostoTotalPedido.ToString() + "', '" + txtDescripcionProducto.Text + "');";
                if (conexionDB.Insertar(Consulta))
                {
                    MessageBox.Show("Registro guardato con exito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dGVListadoProductos.DataSource = conexionDB.LlenarGrid("Select * from tab_pedido");
                    txtCantidadPedido.Clear();
                    txtCostoProducto.Clear();
                    txtCostoTotal.Clear();
                    txtDescripcionProducto.Clear();
                    txtIdPedido.Clear();
                    txtIdProducto.Clear();
                    txtIdProveedor.Clear();
                    txtCantidadPedido.Focus();
                }
                else
                {
                    MessageBox.Show("No se pudo realizar registro", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private bool EstaValidado()
        {
            bool NoError = true;
            if (txtCantidadPedido.Text == string.Empty)
            {
                errorIcone.SetError(txtCantidadPedido, "Ingrese la cantidad de productos para pedido");
                NoError = false;
            }
            if (dtpFechaPedido.Value == null)
            {
                errorIcone.SetError(dtpFechaPedido, "Seleccione la fecha");
                NoError = false;
            }
            if (dtpFechaPedido.Value == null)
            {
                errorIcone.SetError(dtpFechaPedido, "Seleccione la fecha");
                NoError = false;
            }
            if (txtIdProveedor.Text == string.Empty)
            {
                errorIcone.SetError(txtIdProveedor, "Seleccione el proveedor de la lista");
                NoError = false;
            }
            if (txtIdProducto.Text == string.Empty)
            {
                errorIcone.SetError(txtIdProducto, "Seleccione el producto de la lista");
                NoError = false;
            }
            if (txtCostoProducto.Text == string.Empty)
            {
                errorIcone.SetError(txtCostoProducto, "Agregue el costo del producto");
                NoError = false;
            }
            if (txtCostoTotal.Text == string.Empty)
            {
                errorIcone.SetError(txtCostoTotal, "Agregue el costo total del pedido");
                NoError = false;
            }
            if (txtDescripcionProducto.Text == string.Empty)
            {
                errorIcone.SetError(txtDescripcionProducto, "Agregue una descripcion del producto");
                NoError = false;
            }
            return NoError;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
    }
