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
{   /// <summary>
/// /Formulario hecho por: Maycol Duque
/// Universidad:UES
/// Carrera:Ingenieria en Sistemas
/// Ciclo: II/2020
/// Titulo Formulario: Inventario
/// </summary>
/// <remarks>
/// El formulario muestra los pedido registrados y se luede modificar y eliminar el inventario 
/// </remarks>
/// 
    public partial class frmInventario : Form
    {
        ConexionDataBase conexionDB = new ConexionDataBase();
        public frmInventario()
        {
            InitializeComponent();
        }

        private void frmInventario_Load(object sender, EventArgs e)
        {
            //Carga el contenido del formulario
            dgbInventario.DataSource = conexionDB.LlenarGrid("select iv.FechaIngreso_Inventario,iv.Cantidad_inventario,iv.Descripcion_Inventario,iv.PrecioVentaUnitario_Inventario,pr.Nombre_Producto,p.Nombre_Proveedor" +
                " from tab_Inventario iv Inner join Tab_Producto pr on pr.Id_Producto = iv.FK_Producto_Inventario Inner join Tab_Proveedor p on p.Id_Proveedor = iv.FK_Proveedor_Inventario; ");
            gbActualizar.Visible = false;
            ccbProductoInventario.DataSource = conexionDB.LlenarGrid("Select *  from Tab_Producto; ");
            ccbProductoInventario.DisplayMember = "Nombre_Producto";
            ccbProductoInventario.ValueMember = "Id_Producto";

        }

        //oculta el formulario el formulario
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

       

        private void pnActualizarInventario_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            gbActualizar.Visible = true;


        }

        private void dgbInventario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
        }

        //Llena segundo conbobox de precio Inventario
      
       

        private void ccbProductoInventario_SelectedIndexChanged(object sender, EventArgs e)
        {
            
           // cbbPrecio.DataSource = conexionDB.BuscarPorID("Select PrecioVentaUnitario_Inventario  from Tab_Inventario where FK_Producto_Inventario = "+ccbProductoInventario.SelectedValue+";");
        }
    }
}
