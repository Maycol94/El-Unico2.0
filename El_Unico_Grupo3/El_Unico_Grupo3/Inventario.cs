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
    public partial class frmInventario : Form
    {
        ConexionDataBase conexionDB = new ConexionDataBase();
        public frmInventario()
        {
            InitializeComponent();
        }

        private void frmInventario_Load(object sender, EventArgs e)
        {
            dgbInventario.DataSource = conexionDB.LlenarGrid("select iv.FechaIngreso_Inventario,iv.Cantidad_inventario,iv.Descripcion_Inventario,iv.PrecioVentaUnitario_Inventario,pr.Nombre_Producto,p.Nombre_Proveedor" +
                " from tab_Inventario iv Inner join Tab_Producto pr on pr.Id_Producto = iv.FK_Producto_Inventario Inner join Tab_Proveedor p on p.Id_Proveedor = iv.FK_Proveedor_Inventario; ");
        }
    }
}
