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
        private string EliminarRegistro;
        private string ActualizarProducto;
        ConexionDataBase ConexionBase = new ConexionDataBase();
        

        public interfazProductos()
        {
            InitializeComponent();
        }

        private void interfazProductos_Load(object sender, EventArgs e)
        {
            dGVListadoProductos.DataSource = ConexionBase.LlenarGrid("SELECT pr.Id_Producto , pr.Codigo_Producto , pr.Nombre_Producto," +
                                                                     "pr.CostoUnitario_Producto,p.Nombre_Proveedor FROM Tab_Producto pr" +
                                                                     " Inner join Tab_Proveedor p on p.Id_Proveedor = pr.FK_Proveedor_Producto ");
            txtCodigoProducto.Focus();
            txtIdProducto.Enabled = false;
            btnELiminarProducto.Enabled = false;
        }

        private void btnAgregarProductos_Click(object sender, EventArgs e)
        {
            
            if (txtIngresarNuevoProducto.Text == string.Empty || txtCodigoProducto.Text==string.Empty
               || txtCostoUnitarioProducto.Text==string.Empty || txtProveedorDeProducto.Text==string.Empty)// si el cuadro de texto es vacio
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
                    Agregar = "INSERT INTO tab_producto(Codigo_Producto,Nombre_Producto,CostoUnitario_Producto,FK_Proveedor_Producto) " +
                              "VALUES ('" + txtCodigoProducto.Text + "','" + txtIngresarNuevoProducto.Text + "','" + Costo + "','" + txtProveedorDeProducto.Text + "')";

                    if (ConexionBase.Insertar(Agregar))
                    {
                        MessageBox.Show("Exito al insertar producto", "Informacion",
                           MessageBoxButtons.OK, MessageBoxIcon.Information);                    
                        dGVListadoProductos.DataSource = ConexionBase.LlenarGrid("SELECT pr.Id_Producto ,pr.Codigo_Producto , pr.Nombre_Producto," +
                                                                                 "pr.CostoUnitario_Producto,p.Nombre_Proveedor FROM Tab_Producto pr" +
                                                                                 "Inner join Tab_Proveedor p on p.Id_Proveedor = pr.FK_Proveedor_Producto ");
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
            if (txtBuscarProducto.Text == string.Empty)
            {
                MessageBox.Show("Ingresa el nombre del producto que deseas buscar", "error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    BuscarCodigo = txtBuscarProducto.Text;
                    dGVListadoProductos.DataSource = ConexionBase.LlenarGrid("SELECT pr.Id_Producto , pr.Codigo_Producto , pr.Nombre_Producto,pr.CostoUnitario_Producto,p.Nombre_Proveedor,p.Telefono_Proveedor FROM Tab_Producto pr Inner join Tab_Proveedor p on p.Id_Proveedor = pr.FK_Proveedor_Producto Where pr.Nombre_Producto =  '" + BuscarCodigo + "'");
                }
                catch (Exception)
                {
                    MessageBox.Show("no se pudo hacer la consulta", "error",
                             MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void btnVolveraMostrarTodosLosRegistros_Click(object sender, EventArgs e)
        {
            dGVListadoProductos.DataSource = ConexionBase.LlenarGrid("SELECT pr.Id_Producto ,pr.Codigo_Producto , pr.Nombre_Producto,pr.CostoUnitario_Producto," +
                                                                     "p.Nombre_Proveedor FROM Tab_Producto pr Inner join Tab_Proveedor p on p.Id_Proveedor = pr.FK_Proveedor_Producto ");
            txtBuscarProducto.Clear();
        }

        private void dGVListadoProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0)
            {
                DataGridViewRow row = this.dGVListadoProductos.Rows[e.RowIndex];            
                txtIdProducto.Text = row.Cells["Id_Producto"].Value.ToString();
                txtCodigoProducto.Text = row.Cells["Codigo_Producto"].Value.ToString();
                txtIngresarNuevoProducto.Text = row.Cells["Nombre_Producto"].Value.ToString();
                txtCostoUnitarioProducto.Text = row.Cells["CostoUnitario_Producto"].Value.ToString();
                txtProveedorDeProducto.Text = row.Cells["Nombre_Proveedor"].Value.ToString();
                btnELiminarProducto.Enabled = true;
            }
       
            
        }

        private void btnELiminarProducto_Click(object sender, EventArgs e)
        {
            EliminarRegistro = "delete from Tab_Producto where Id_Producto =" + txtIdProducto.Text;
            DialogResult opcion; // declarando una variable de tipo  DialogResult
            opcion = MessageBox.Show("Desea Eliminar definitivamente el registro?", "Eliminar",
                                   MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            //guardara el boton cliqueado por el usuario.
            if (opcion == DialogResult.Yes)
            {
                if (ConexionBase.Eliminar(EliminarRegistro))
                {

                    MessageBox.Show("Exito al eliminar producto", "Informacion",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dGVListadoProductos.DataSource = ConexionBase.LlenarGrid("SELECT  pr.Id_Producto,pr.Codigo_Producto , pr.Nombre_Producto," +
                                                                             "pr.CostoUnitario_Producto,p.Nombre_Proveedor FROM Tab_Producto" +
                                                                             " pr Inner join Tab_Proveedor p on p.Id_Proveedor = pr.FK_Proveedor_Producto ");
                    txtCodigoProducto.Clear();
                    txtCostoUnitarioProducto.Clear();
                    txtIngresarNuevoProducto.Clear();
                    txtProveedorDeProducto.Clear();
                    txtIdProducto.Clear();
                    btnELiminarProducto.Enabled = false;
                }
                else
                {
                    MessageBox.Show("No se pudo Eliminar, debes seleccionar en el cuadro de registro el producto que deseas eliminar", "error",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnActualizarProducto_Click(object sender, EventArgs e)
        {
            ActualizarProducto = "update tab_producto set Codigo_Producto ='" + txtCodigoProducto.Text +  "',Nombre_Producto='" + txtIngresarNuevoProducto.Text +
                                 "',CostoUnitario_Producto='"+ txtCostoUnitarioProducto.Text +"'where Id_Producto='" + txtIdProducto.Text + "';";
  

            DialogResult opcion; // declarando una variable de tipo  DialogResult
            opcion = MessageBox.Show("Desea Actualizar el registro?", "Actualizar",
                                   MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            //guardara el boton cliqueado por el usuario.
            if (opcion == DialogResult.Yes)
            {
                if (ConexionBase.Actualizar(ActualizarProducto))
                {

                    MessageBox.Show("Exito al actualizar el producto", "Informacion",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dGVListadoProductos.DataSource = ConexionBase.LlenarGrid("SELECT  pr.Id_Producto,pr.Codigo_Producto , pr.Nombre_Producto," +
                                                                             "pr.CostoUnitario_Producto,p.Nombre_Proveedor FROM Tab_Producto" +
                                                                             "pr Inner join Tab_Proveedor p on p.Id_Proveedor = pr.FK_Proveedor_Producto ");
                    txtCodigoProducto.Clear();
                    txtCostoUnitarioProducto.Clear();
                    txtIngresarNuevoProducto.Clear();
                    txtProveedorDeProducto.Clear();
                    txtIdProducto.Clear();
                }
                else
                {
                    MessageBox.Show("No se pudo Actualizar, debes seleccionar en el cuadro de registro el producto a eliminar ", "error",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
