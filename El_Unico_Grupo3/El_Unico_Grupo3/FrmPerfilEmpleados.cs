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
    public partial class FrmPerfilEmpleados : Form
    {
        ConexionDataBase conexionDB = new ConexionDataBase();
        public FrmPerfilEmpleados()
        {
            InitializeComponent();
        }

        private void FrmPerfilEmpleados_Load(object sender, EventArgs e)
        {
            
        }
    }
}
