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
        public interfazProductos()
        {
            InitializeComponent();
        }

        private void interfazProductos_Load(object sender, EventArgs e)
        {
            dGVListadoProductos.DataSource = ConexionBase.LlenarGrid("SELECT * FROM tab_producto");
        }

        private void btnAgregarProductos_Click(object sender, EventArgs e)
        {

        }
    }
}
