namespace El_Unico_Grupo3
{
    partial class interfazProductos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dGVListadoProductos = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBuscarProducto = new System.Windows.Forms.Button();
            this.txtBuscarProducto = new System.Windows.Forms.TextBox();
            this.btnELiminarProducto = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnActualizarProducto = new System.Windows.Forms.Button();
            this.btnAgregarProductos = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtProveedorDeProducto = new System.Windows.Forms.TextBox();
            this.txtCostoUnitarioProducto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCodigoProducto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIngresarNuevoProducto = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dGVListadoProductos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(266, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Productos";
            // 
            // dGVListadoProductos
            // 
            this.dGVListadoProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVListadoProductos.Location = new System.Drawing.Point(0, 64);
            this.dGVListadoProductos.Name = "dGVListadoProductos";
            this.dGVListadoProductos.Size = new System.Drawing.Size(384, 185);
            this.dGVListadoProductos.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBuscarProducto);
            this.groupBox1.Controls.Add(this.txtBuscarProducto);
            this.groupBox1.Controls.Add(this.dGVListadoProductos);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(23, 117);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(385, 249);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Productos actuales";
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.ForeColor = System.Drawing.Color.Black;
            this.btnBuscarProducto.Location = new System.Drawing.Point(315, 24);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(69, 21);
            this.btnBuscarProducto.TabIndex = 3;
            this.btnBuscarProducto.Text = "Buscar";
            this.btnBuscarProducto.UseVisualStyleBackColor = true;
            // 
            // txtBuscarProducto
            // 
            this.txtBuscarProducto.Location = new System.Drawing.Point(134, 25);
            this.txtBuscarProducto.Name = "txtBuscarProducto";
            this.txtBuscarProducto.Size = new System.Drawing.Size(172, 20);
            this.txtBuscarProducto.TabIndex = 2;
            // 
            // btnELiminarProducto
            // 
            this.btnELiminarProducto.ForeColor = System.Drawing.Color.Black;
            this.btnELiminarProducto.Location = new System.Drawing.Point(124, 156);
            this.btnELiminarProducto.Name = "btnELiminarProducto";
            this.btnELiminarProducto.Size = new System.Drawing.Size(116, 29);
            this.btnELiminarProducto.TabIndex = 4;
            this.btnELiminarProducto.Text = "Eliminar Producto";
            this.btnELiminarProducto.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.ForeColor = System.Drawing.Color.Black;
            this.btnSalir.Location = new System.Drawing.Point(124, 208);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(116, 29);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnActualizarProducto
            // 
            this.btnActualizarProducto.ForeColor = System.Drawing.Color.Black;
            this.btnActualizarProducto.Location = new System.Drawing.Point(6, 208);
            this.btnActualizarProducto.Name = "btnActualizarProducto";
            this.btnActualizarProducto.Size = new System.Drawing.Size(116, 29);
            this.btnActualizarProducto.TabIndex = 5;
            this.btnActualizarProducto.Text = "Actualizar Producto";
            this.btnActualizarProducto.UseVisualStyleBackColor = true;
            // 
            // btnAgregarProductos
            // 
            this.btnAgregarProductos.ForeColor = System.Drawing.Color.Black;
            this.btnAgregarProductos.Location = new System.Drawing.Point(6, 156);
            this.btnAgregarProductos.Name = "btnAgregarProductos";
            this.btnAgregarProductos.Size = new System.Drawing.Size(116, 29);
            this.btnAgregarProductos.TabIndex = 6;
            this.btnAgregarProductos.Text = "Agregar Producto";
            this.btnAgregarProductos.UseVisualStyleBackColor = true;
            this.btnAgregarProductos.Click += new System.EventHandler(this.btnAgregarProductos_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSalir);
            this.groupBox3.Controls.Add(this.btnActualizarProducto);
            this.groupBox3.Controls.Add(this.txtProveedorDeProducto);
            this.groupBox3.Controls.Add(this.txtCostoUnitarioProducto);
            this.groupBox3.Controls.Add(this.btnELiminarProducto);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtCodigoProducto);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txtIngresarNuevoProducto);
            this.groupBox3.Controls.Add(this.btnAgregarProductos);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(433, 117);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(246, 249);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Agregar nuevo producto";
            // 
            // txtProveedorDeProducto
            // 
            this.txtProveedorDeProducto.Location = new System.Drawing.Point(104, 124);
            this.txtProveedorDeProducto.Name = "txtProveedorDeProducto";
            this.txtProveedorDeProducto.Size = new System.Drawing.Size(136, 20);
            this.txtProveedorDeProducto.TabIndex = 14;
            this.txtProveedorDeProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumerosProveedor_KeyPress);
            // 
            // txtCostoUnitarioProducto
            // 
            this.txtCostoUnitarioProducto.Location = new System.Drawing.Point(104, 94);
            this.txtCostoUnitarioProducto.Name = "txtCostoUnitarioProducto";
            this.txtCostoUnitarioProducto.Size = new System.Drawing.Size(136, 20);
            this.txtCostoUnitarioProducto.TabIndex = 13;
            this.txtCostoUnitarioProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeros_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Proveedor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Costo unitario:";
            // 
            // txtCodigoProducto
            // 
            this.txtCodigoProducto.Location = new System.Drawing.Point(104, 41);
            this.txtCodigoProducto.Name = "txtCodigoProducto";
            this.txtCodigoProducto.Size = new System.Drawing.Size(136, 20);
            this.txtCodigoProducto.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Nombre producto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Codigo producto:";
            // 
            // txtIngresarNuevoProducto
            // 
            this.txtIngresarNuevoProducto.Location = new System.Drawing.Point(104, 68);
            this.txtIngresarNuevoProducto.Name = "txtIngresarNuevoProducto";
            this.txtIngresarNuevoProducto.Size = new System.Drawing.Size(136, 20);
            this.txtIngresarNuevoProducto.TabIndex = 7;
            // 
            // interfazProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(709, 399);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "interfazProductos";
            this.Text = "interfazProductos";
            this.Load += new System.EventHandler(this.interfazProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVListadoProductos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dGVListadoProductos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBuscarProducto;
        private System.Windows.Forms.Button btnBuscarProducto;
        private System.Windows.Forms.Button btnELiminarProducto;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnAgregarProductos;
        private System.Windows.Forms.Button btnActualizarProducto;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtIngresarNuevoProducto;
        private System.Windows.Forms.TextBox txtProveedorDeProducto;
        private System.Windows.Forms.TextBox txtCostoUnitarioProducto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCodigoProducto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}