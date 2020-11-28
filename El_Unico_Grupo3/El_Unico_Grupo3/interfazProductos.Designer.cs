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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.dGVListadoProductos = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnVolveraMostrarTodosLosRegistros = new System.Windows.Forms.Button();
            this.btnBuscarProducto = new System.Windows.Forms.Button();
            this.txtBuscarProducto = new System.Windows.Forms.TextBox();
            this.btnELiminarProducto = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnActualizarProducto = new System.Windows.Forms.Button();
            this.btnAgregarProductos = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtIdProducto = new System.Windows.Forms.TextBox();
            this.txtProveedorDeProducto = new System.Windows.Forms.TextBox();
            this.txtCostoUnitarioProducto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCodigoProducto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIngresarNuevoProducto = new System.Windows.Forms.TextBox();
            this.ttMensajeAyuda = new System.Windows.Forms.ToolTip(this.components);
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
            this.dGVListadoProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dGVListadoProductos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dGVListadoProductos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dGVListadoProductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dGVListadoProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGVListadoProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dGVListadoProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVListadoProductos.EnableHeadersVisualStyles = false;
            this.dGVListadoProductos.Location = new System.Drawing.Point(0, 64);
            this.dGVListadoProductos.Name = "dGVListadoProductos";
            this.dGVListadoProductos.RowHeadersVisible = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.dGVListadoProductos.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dGVListadoProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVListadoProductos.Size = new System.Drawing.Size(384, 185);
            this.dGVListadoProductos.TabIndex = 1;
            this.dGVListadoProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVListadoProductos_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnVolveraMostrarTodosLosRegistros);
            this.groupBox1.Controls.Add(this.btnBuscarProducto);
            this.groupBox1.Controls.Add(this.txtBuscarProducto);
            this.groupBox1.Controls.Add(this.dGVListadoProductos);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(23, 117);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(385, 249);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Productos actuales";
            // 
            // btnVolveraMostrarTodosLosRegistros
            // 
            this.btnVolveraMostrarTodosLosRegistros.ForeColor = System.Drawing.Color.Black;
            this.btnVolveraMostrarTodosLosRegistros.Location = new System.Drawing.Point(309, 41);
            this.btnVolveraMostrarTodosLosRegistros.Name = "btnVolveraMostrarTodosLosRegistros";
            this.btnVolveraMostrarTodosLosRegistros.Size = new System.Drawing.Size(75, 21);
            this.btnVolveraMostrarTodosLosRegistros.TabIndex = 8;
            this.btnVolveraMostrarTodosLosRegistros.Text = "Mostrar todo";
            this.btnVolveraMostrarTodosLosRegistros.UseVisualStyleBackColor = true;
            this.btnVolveraMostrarTodosLosRegistros.Click += new System.EventHandler(this.btnVolveraMostrarTodosLosRegistros_Click);
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.ForeColor = System.Drawing.Color.Black;
            this.btnBuscarProducto.Location = new System.Drawing.Point(309, 14);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(75, 20);
            this.btnBuscarProducto.TabIndex = 3;
            this.btnBuscarProducto.Text = "Buscar";
            this.btnBuscarProducto.UseVisualStyleBackColor = true;
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click);
            // 
            // txtBuscarProducto
            // 
            this.txtBuscarProducto.Location = new System.Drawing.Point(131, 14);
            this.txtBuscarProducto.Multiline = true;
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
            this.btnELiminarProducto.Click += new System.EventHandler(this.btnELiminarProducto_Click);
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
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
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
            this.btnActualizarProducto.Click += new System.EventHandler(this.btnActualizarProducto_Click);
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
            this.groupBox3.Controls.Add(this.txtIdProducto);
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
            // txtIdProducto
            // 
            this.txtIdProducto.Location = new System.Drawing.Point(104, 14);
            this.txtIdProducto.Name = "txtIdProducto";
            this.txtIdProducto.Size = new System.Drawing.Size(136, 20);
            this.txtIdProducto.TabIndex = 11;
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
            // ttMensajeAyuda
            // 
            this.ttMensajeAyuda.IsBalloon = true;
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
        private System.Windows.Forms.Button btnVolveraMostrarTodosLosRegistros;
        private System.Windows.Forms.TextBox txtIdProducto;
        private System.Windows.Forms.ToolTip ttMensajeAyuda;
    }
}