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
    /// <summary>
    /// ESTA INTERFAZ SE CREO POR OSCAR LEONEL SEGURA VALENCIA CARNET:SV20008 ESTUDIANTE DE LA UNIVERSIDAD DE EL SALVADOR.
    /// ESTE PROGRAMA LLEVA EL CONTROL DE REGISTROS DE PRODUCTOS.
    /// EL PROGRAMA REGISTRA NUEVOS PRODUCTOS, ELIMINA, ACTUALIZA Y BUSCA
    /// </summary>
    /// <remarks>
    /// PARA REGISTRAR, ELIMINAR, ACTUALIZAR PRODUCTOS SE HA UTILIZADO LA CLASE ConexionDatabase, ES AHI DONDE ESTAN LOS METODOS
    /// PARA REGISTRAR, ELIMINAR, ACTUALIZAR.
    /// </remarks>
    public partial class interfazProductos : Form
    {
        //CREACION DE VARIABLES PRIVATE
        private string Agregar;
        private double Costo;
        private string BuscarCodigo;
        private string EliminarRegistro;
        private string ActualizarProducto;
        ConexionDataBase ConexionBase = new ConexionDataBase();
        

        public interfazProductos()
        {
            //AYUDA AL USUARIO CUANDO EL PUNTEO DEL MOUSE ESTA ENCIMA DE ALGUN TEXBOX O BUTTOM
            InitializeComponent();
            this.ttMensajeAyuda.SetToolTip(this.txtBuscarProducto, "Busque por medio de el nombre prpoducto");
            this.ttMensajeAyuda.SetToolTip(this.btnActualizarProducto, "Primero seleccione el registro que desea actualizar");
            this.ttMensajeAyuda.SetToolTip(this.btnELiminarProducto, "Primero seleccione el registro que desea eliminar");
        }

        private void interfazProductos_Load(object sender, EventArgs e)
        {
            //CARGAMOS POR DEFECTO EL DATAGRIEDVIEW CON LOS REGISTROS PRODUCTOS
            dGVListadoProductos.DataSource = ConexionBase.LlenarGrid("SELECT pr.Id_Producto , pr.Codigo_Producto , pr.Nombre_Producto," +
                                                                     "pr.CostoUnitario_Producto,p.Nombre_Proveedor,p.Telefono_Proveedor FROM Tab_Producto pr" +
                                                                     " Inner join Tab_Proveedor p on p.Id_Proveedor = pr.FK_Proveedor_Producto ");
            txtCodigoProducto.Focus();
            txtIdProducto.Enabled = false;
            btnELiminarProducto.Enabled = false;
        }

        private void btnAgregarProductos_Click(object sender, EventArgs e)
        {
            //AGREGAMOS NUEVOS REGISTROS(PRODUCTOS)
            if (txtIngresarNuevoProducto.Text == string.Empty || txtCodigoProducto.Text == string.Empty || txtCostoUnitarioProducto.Text == string.Empty || txtProveedorDeProducto.Text == string.Empty)// si el cuadro de texto es vacio
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
                    while (Costo < 0)
                    {
                        MessageBox.Show("Ingrese Costo Mayor a cero", "error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtCostoUnitarioProducto.Clear();
                        Costo = double.Parse(txtCostoUnitarioProducto.Text);
                    }
                    Agregar = "INSERT INTO tab_producto(Codigo_Producto,Nombre_Producto,CostoUnitario_Producto,FK_Proveedor_Producto) VALUES ('" + txtCodigoProducto.Text + "','" + txtIngresarNuevoProducto.Text + "','" + Costo + "','" + txtProveedorDeProducto.Text + "')";

                    if (ConexionBase.Insertar(Agregar))
                    {
                        MessageBox.Show("Exito al insertar producto", "Informacion",
                           MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dGVListadoProductos.DataSource = ConexionBase.LlenarGrid("SELECT pr.Id_Producto, pr.Codigo_Producto , pr.Nombre_Producto,pr.CostoUnitario_Producto,p.Nombre_Proveedor,p.Telefono_Proveedor FROM Tab_Producto pr Inner join Tab_Proveedor p on p.Id_Proveedor = pr.FK_Proveedor_Producto ");
                        txtCodigoProducto.Clear();
                        txtCostoUnitarioProducto.Clear();
                        txtIngresarNuevoProducto.Clear();
                        txtProveedorDeProducto.Clear();
                        txtIdProducto.Clear();
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
            //ESTE METODO VALIDA QUE EL USUSARIO SOLO PUEDA TENER COMO DATOS DE ENTRADA NUMEROS ENTEROS Y NO LETRAS
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
            //BUSCA POR NOMBRE DE PRODUCTOS
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
                                                                     "p.Nombre_Proveedor,p.Telefono_Proveedor FROM Tab_Producto pr Inner join Tab_Proveedor p on p.Id_Proveedor = pr.FK_Proveedor_Producto ");
            txtBuscarProducto.Clear();
        }

        private void dGVListadoProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //METODO QUE PARA LOS DATOS DEL DATAGRIEDVIEW A LOS TEXBOX CUANDO EL USUARIO DA CLICK EN UNOS DE
            //ELLOS PARA LUEGO PROCEDER A ELIMINAR O ACTUALIZAR
                if (e.RowIndex >= 0)
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
            //ELIMINA REGISTROS
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
                                                                             "pr.CostoUnitario_Producto,p.Nombre_Proveedor,p.Telefono_Proveedor FROM Tab_Producto" +
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
            //ACTUALIZA REGISTROS
            ActualizarProducto = "update tab_producto set Codigo_Producto ='" + txtCodigoProducto.Text +  "',Nombre_Producto='" + txtIngresarNuevoProducto.Text +  "',CostoUnitario_Producto='"+ txtCostoUnitarioProducto.Text +"'where Id_Producto='" + txtIdProducto.Text + "';";
  

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
                                                                             "pr.CostoUnitario_Producto,p.Nombre_Proveedor,p.Telefono_Proveedor FROM Tab_Producto" +
                                                                             " pr Inner join Tab_Proveedor p on p.Id_Proveedor = pr.FK_Proveedor_Producto ");
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
