namespace CapaPresentacion.VistaVendedor
{
    partial class ListadoProductos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonBuscarProductoCateYColor = new System.Windows.Forms.Button();
            this.labelColor = new System.Windows.Forms.Label();
            this.comboBoxColor = new System.Windows.Forms.ComboBox();
            this.labelCategoria = new System.Windows.Forms.Label();
            this.comboBoxCategoria = new System.Windows.Forms.ComboBox();
            this.textBoxNombreProducto = new System.Windows.Forms.TextBox();
            this.buttonBuscarProductoNombre = new System.Windows.Forms.Button();
            this.labelSearchProduct = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridViewProduct = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnImagen = new System.Windows.Forms.DataGridViewImageColumn();
            this.ColumnTitulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonBuscarProductoCateYColor);
            this.panel1.Controls.Add(this.labelColor);
            this.panel1.Controls.Add(this.comboBoxColor);
            this.panel1.Controls.Add(this.labelCategoria);
            this.panel1.Controls.Add(this.comboBoxCategoria);
            this.panel1.Controls.Add(this.textBoxNombreProducto);
            this.panel1.Controls.Add(this.buttonBuscarProductoNombre);
            this.panel1.Controls.Add(this.labelSearchProduct);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(760, 258);
            this.panel1.TabIndex = 0;
            // 
            // buttonBuscarProductoCateYColor
            // 
            this.buttonBuscarProductoCateYColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuscarProductoCateYColor.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscarProductoCateYColor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonBuscarProductoCateYColor.Location = new System.Drawing.Point(399, 142);
            this.buttonBuscarProductoCateYColor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBuscarProductoCateYColor.Name = "buttonBuscarProductoCateYColor";
            this.buttonBuscarProductoCateYColor.Size = new System.Drawing.Size(160, 38);
            this.buttonBuscarProductoCateYColor.TabIndex = 41;
            this.buttonBuscarProductoCateYColor.Text = "Filtrar";
            this.buttonBuscarProductoCateYColor.UseVisualStyleBackColor = true;
            this.buttonBuscarProductoCateYColor.Click += new System.EventHandler(this.buttonBuscarProductoCateYColor_Click);
            // 
            // labelColor
            // 
            this.labelColor.AutoSize = true;
            this.labelColor.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelColor.ForeColor = System.Drawing.Color.White;
            this.labelColor.Location = new System.Drawing.Point(555, 67);
            this.labelColor.Name = "labelColor";
            this.labelColor.Size = new System.Drawing.Size(65, 23);
            this.labelColor.TabIndex = 40;
            this.labelColor.Text = "Color";
            // 
            // comboBoxColor
            // 
            this.comboBoxColor.FormattingEnabled = true;
            this.comboBoxColor.Location = new System.Drawing.Point(510, 93);
            this.comboBoxColor.Name = "comboBoxColor";
            this.comboBoxColor.Size = new System.Drawing.Size(159, 24);
            this.comboBoxColor.TabIndex = 39;
            // 
            // labelCategoria
            // 
            this.labelCategoria.AutoSize = true;
            this.labelCategoria.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCategoria.ForeColor = System.Drawing.Color.White;
            this.labelCategoria.Location = new System.Drawing.Point(328, 67);
            this.labelCategoria.Name = "labelCategoria";
            this.labelCategoria.Size = new System.Drawing.Size(109, 23);
            this.labelCategoria.TabIndex = 38;
            this.labelCategoria.Text = "Categoría";
            // 
            // comboBoxCategoria
            // 
            this.comboBoxCategoria.FormattingEnabled = true;
            this.comboBoxCategoria.Location = new System.Drawing.Point(310, 93);
            this.comboBoxCategoria.Name = "comboBoxCategoria";
            this.comboBoxCategoria.Size = new System.Drawing.Size(159, 24);
            this.comboBoxCategoria.TabIndex = 37;
            // 
            // textBoxNombreProducto
            // 
            this.textBoxNombreProducto.Location = new System.Drawing.Point(47, 93);
            this.textBoxNombreProducto.Multiline = true;
            this.textBoxNombreProducto.Name = "textBoxNombreProducto";
            this.textBoxNombreProducto.Size = new System.Drawing.Size(163, 29);
            this.textBoxNombreProducto.TabIndex = 36;
            // 
            // buttonBuscarProductoNombre
            // 
            this.buttonBuscarProductoNombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuscarProductoNombre.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscarProductoNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonBuscarProductoNombre.Location = new System.Drawing.Point(47, 142);
            this.buttonBuscarProductoNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBuscarProductoNombre.Name = "buttonBuscarProductoNombre";
            this.buttonBuscarProductoNombre.Size = new System.Drawing.Size(160, 38);
            this.buttonBuscarProductoNombre.TabIndex = 35;
            this.buttonBuscarProductoNombre.Text = "Buscar";
            this.buttonBuscarProductoNombre.UseVisualStyleBackColor = true;
            this.buttonBuscarProductoNombre.Click += new System.EventHandler(this.buttonBuscarProductoNombre_Click);
            // 
            // labelSearchProduct
            // 
            this.labelSearchProduct.AutoSize = true;
            this.labelSearchProduct.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearchProduct.ForeColor = System.Drawing.Color.White;
            this.labelSearchProduct.Location = new System.Drawing.Point(23, 67);
            this.labelSearchProduct.Name = "labelSearchProduct";
            this.labelSearchProduct.Size = new System.Drawing.Size(219, 23);
            this.labelSearchProduct.TabIndex = 1;
            this.labelSearchProduct.Text = "Nombre del producto";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridViewProduct);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 258);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(760, 301);
            this.panel2.TabIndex = 1;
            // 
            // dataGridViewProduct
            // 
            this.dataGridViewProduct.AllowCustomTheming = false;
            this.dataGridViewProduct.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewProduct.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewProduct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewProduct.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewProduct.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewProduct.ColumnHeadersHeight = 40;
            this.dataGridViewProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.ColumnImagen,
            this.ColumnTitulo,
            this.ColumnStock,
            this.ColumnPrecio,
            this.ColumnCategoria,
            this.ColumnColor,
            this.ColumnEstado});
            this.dataGridViewProduct.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dataGridViewProduct.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dataGridViewProduct.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewProduct.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dataGridViewProduct.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewProduct.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dataGridViewProduct.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dataGridViewProduct.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dataGridViewProduct.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dataGridViewProduct.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridViewProduct.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.dataGridViewProduct.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewProduct.CurrentTheme.Name = null;
            this.dataGridViewProduct.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewProduct.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dataGridViewProduct.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewProduct.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dataGridViewProduct.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewProduct.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewProduct.EnableHeadersVisualStyles = false;
            this.dataGridViewProduct.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dataGridViewProduct.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dataGridViewProduct.HeaderBgColor = System.Drawing.Color.Empty;
            this.dataGridViewProduct.HeaderForeColor = System.Drawing.Color.White;
            this.dataGridViewProduct.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewProduct.Name = "dataGridViewProduct";
            this.dataGridViewProduct.RowHeadersVisible = false;
            this.dataGridViewProduct.RowHeadersWidth = 51;
            this.dataGridViewProduct.RowTemplate.Height = 40;
            this.dataGridViewProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProduct.Size = new System.Drawing.Size(760, 301);
            this.dataGridViewProduct.TabIndex = 3;
            this.dataGridViewProduct.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // ColumnId
            // 
            this.ColumnId.HeaderText = "Codigo";
            this.ColumnId.MinimumWidth = 6;
            this.ColumnId.Name = "ColumnId";
            // 
            // ColumnImagen
            // 
            this.ColumnImagen.HeaderText = "Imagen";
            this.ColumnImagen.MinimumWidth = 6;
            this.ColumnImagen.Name = "ColumnImagen";
            // 
            // ColumnTitulo
            // 
            this.ColumnTitulo.HeaderText = "Titulo";
            this.ColumnTitulo.MinimumWidth = 6;
            this.ColumnTitulo.Name = "ColumnTitulo";
            // 
            // ColumnStock
            // 
            this.ColumnStock.HeaderText = "Stock";
            this.ColumnStock.MinimumWidth = 6;
            this.ColumnStock.Name = "ColumnStock";
            // 
            // ColumnPrecio
            // 
            this.ColumnPrecio.HeaderText = "Precio";
            this.ColumnPrecio.MinimumWidth = 6;
            this.ColumnPrecio.Name = "ColumnPrecio";
            // 
            // ColumnCategoria
            // 
            this.ColumnCategoria.HeaderText = "Categoria";
            this.ColumnCategoria.MinimumWidth = 6;
            this.ColumnCategoria.Name = "ColumnCategoria";
            // 
            // ColumnColor
            // 
            this.ColumnColor.HeaderText = "Color";
            this.ColumnColor.MinimumWidth = 6;
            this.ColumnColor.Name = "ColumnColor";
            // 
            // ColumnEstado
            // 
            this.ColumnEstado.HeaderText = "Activo";
            this.ColumnEstado.MinimumWidth = 6;
            this.ColumnEstado.Name = "ColumnEstado";
            // 
            // ListadoProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(760, 559);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListadoProductos";
            this.Text = "ListadoProductos";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelSearchProduct;
        private System.Windows.Forms.Button buttonBuscarProductoNombre;
        private System.Windows.Forms.Label labelCategoria;
        private System.Windows.Forms.ComboBox comboBoxCategoria;
        private System.Windows.Forms.TextBox textBoxNombreProducto;
        private Bunifu.UI.WinForms.BunifuDataGridView dataGridViewProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.DataGridViewImageColumn ColumnImagen;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTitulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnColor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEstado;
        private System.Windows.Forms.Label labelColor;
        private System.Windows.Forms.ComboBox comboBoxColor;
        private System.Windows.Forms.Button buttonBuscarProductoCateYColor;
    }
}