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
        private string Consulta;
        public string CapturarTipoUsuario;
        ConexionDataBase conexionDB = new ConexionDataBase();
        public InterfazPedidos()
        {
            InitializeComponent();
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

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

        private void SelectedValueChanged(object sender, EventArgs e)
        {
            txtIdProveedor.Text = cbxProveedor.SelectedValue.ToString() ;
        }

        private void SelectedValueChangedProducto(object sender, EventArgs e)
        {
            txtIdProducto.Text = cbxProducto.SelectedValue.ToString();
            cbxCostoUnitarioProducto.DataSource = conexionDB.BuscarPorID("Select CostoUnitario_Producto from tab_producto where Id_Producto=" + txtIdProducto.Text);
            //cbxProducto.ValueMember = "Id_Producto";
            //cbxProducto.DisplayMember = "CostoUnitario_Producto";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dGVListadoProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
