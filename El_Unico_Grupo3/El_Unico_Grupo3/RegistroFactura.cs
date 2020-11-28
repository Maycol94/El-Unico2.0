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
    public partial class RegistroFactura : Form
    {
        ConexionDataBase conexionDB = new ConexionDataBase();
      
        
        public RegistroFactura()
        {
            InitializeComponent();
           
        }
        
        private void RegistroFactura_Load(object sender, EventArgs e)
        {
            //Fecha automatica
            lblFecha.Text = DateTime.Now.ToString("d");
            cbbProductos.DataSource = conexionDB.LlenarGrid("Select * from tab_usuario");
            cbbProductos.DisplayMember = "Nombre_Usuario";
            cbbProductos.ValueMember = "Id_Usuario";


            //  dgvProductoFacturado.DataSource = conexionDB.LlenarGrid("select * from tab_Ventas");

        }
      

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cbvClientesFactura_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnRegistrarVenta_Click(object sender, EventArgs e)
        {
        /*    //Calculo de total de venta Registrada
            Cantidad = int.Parse(txtCantidadVenta.Text);
            presioUnitario = double.Parse(txtPresioUnitario.Text);
            total = Cantidad* presioUnitario;
            //Mostrar total
            txtTotal.Text = total.ToString("N2");*/

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtPresioUnitario.Text = "";
            txtCantidadVenta.Text = "";
            txtCantidadVenta.Focus();

        }

        private void btnCobrar_Click(object sender, EventArgs e)
        {
            
        }

        
       

        private void cbbProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void cbbProductos_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            txtPresioUnitario.Text = cbbProductos.Text;
        }
    }
}
