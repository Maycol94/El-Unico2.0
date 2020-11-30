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
    public partial class Existencia : Form
    {
        ConexionDataBase ConexionDB = new ConexionDataBase();
        public Existencia()
        {
            InitializeComponent();
        }

        private void Existencia_Load(object sender, EventArgs e)
        {
            dgvExistencias.DataSource = ConexionDB.LlenarGrid("select ex.Fecha_Existencia,ex.Cantidad_Existencia,ex.PrecioUnitario_Existencia,pr.Nombre_Producto  " +
           "from Tab_Existencia ex inner join Tab_Producto pr on pr.Id_Producto = ex.FK_Producto_Existencia; ");
        }
    }
}
