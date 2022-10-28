namespace CapaPresentacion.VistaVendedor.Ventas
{
    partial class NuevaVenta
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonFinalizarCompra = new System.Windows.Forms.Button();
            this.buttonBuscarProducto = new System.Windows.Forms.Button();
            this.buttonBuscarCliente = new System.Windows.Forms.Button();
            this.panelCliente = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.labelCliente = new System.Windows.Forms.Label();
            this.labelNombreC = new System.Windows.Forms.Label();
            this.labelApellidoC = new System.Windows.Forms.Label();
            this.labelEmailC = new System.Windows.Forms.Label();
            this.labelDniC = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelApellido = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelDni = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.dataGridViewCarrito = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnImagen = new System.Windows.Forms.DataGridViewImageColumn();
            this.ColumnTitulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSubtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAccion = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel6 = new System.Windows.Forms.Panel();
            this.labelProductos = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.buttonCancelarCompra = new System.Windows.Forms.Button();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelT = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelCliente.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCarrito)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.panelCliente);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(570, 217);
            this.panel3.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.buttonFinalizarCompra);
            this.panel1.Controls.Add(this.buttonBuscarProducto);
            this.panel1.Controls.Add(this.buttonBuscarCliente);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(296, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(274, 217);
            this.panel1.TabIndex = 1;
            // 
            // buttonFinalizarCompra
            // 
            this.buttonFinalizarCompra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFinalizarCompra.Enabled = false;
            this.buttonFinalizarCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFinalizarCompra.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFinalizarCompra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonFinalizarCompra.Location = new System.Drawing.Point(27, 156);
            this.buttonFinalizarCompra.Margin = new System.Windows.Forms.Padding(2);
            this.buttonFinalizarCompra.Name = "buttonFinalizarCompra";
            this.buttonFinalizarCompra.Size = new System.Drawing.Size(218, 31);
            this.buttonFinalizarCompra.TabIndex = 41;
            this.buttonFinalizarCompra.Text = "Finalizar compra";
            this.buttonFinalizarCompra.UseVisualStyleBackColor = true;
            this.buttonFinalizarCompra.Click += new System.EventHandler(this.buttonFinalizarCompra_Click);
            // 
            // buttonBuscarProducto
            // 
            this.buttonBuscarProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBuscarProducto.Enabled = false;
            this.buttonBuscarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuscarProducto.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscarProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonBuscarProducto.Location = new System.Drawing.Point(27, 93);
            this.buttonBuscarProducto.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBuscarProducto.Name = "buttonBuscarProducto";
            this.buttonBuscarProducto.Size = new System.Drawing.Size(218, 31);
            this.buttonBuscarProducto.TabIndex = 40;
            this.buttonBuscarProducto.Text = "Buscar producto";
            this.buttonBuscarProducto.UseVisualStyleBackColor = true;
            this.buttonBuscarProducto.Click += new System.EventHandler(this.buttonBuscarProducto_Click);
            // 
            // buttonBuscarCliente
            // 
            this.buttonBuscarCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuscarCliente.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscarCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonBuscarCliente.Location = new System.Drawing.Point(27, 28);
            this.buttonBuscarCliente.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBuscarCliente.Name = "buttonBuscarCliente";
            this.buttonBuscarCliente.Size = new System.Drawing.Size(218, 31);
            this.buttonBuscarCliente.TabIndex = 39;
            this.buttonBuscarCliente.Text = "Buscar cliente";
            this.buttonBuscarCliente.UseVisualStyleBackColor = true;
            this.buttonBuscarCliente.Click += new System.EventHandler(this.buttonBuscarCliente_Click);
            // 
            // panelCliente
            // 
            this.panelCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(47)))));
            this.panelCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCliente.Controls.Add(this.panel4);
            this.panelCliente.Controls.Add(this.labelNombreC);
            this.panelCliente.Controls.Add(this.labelApellidoC);
            this.panelCliente.Controls.Add(this.labelEmailC);
            this.panelCliente.Controls.Add(this.labelDniC);
            this.panelCliente.Controls.Add(this.labelNombre);
            this.panelCliente.Controls.Add(this.labelApellido);
            this.panelCliente.Controls.Add(this.labelEmail);
            this.panelCliente.Controls.Add(this.labelDni);
            this.panelCliente.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelCliente.Location = new System.Drawing.Point(0, 0);
            this.panelCliente.Name = "panelCliente";
            this.panelCliente.Size = new System.Drawing.Size(296, 217);
            this.panelCliente.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.labelCliente);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(294, 38);
            this.panel4.TabIndex = 15;
            // 
            // labelCliente
            // 
            this.labelCliente.AutoSize = true;
            this.labelCliente.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCliente.ForeColor = System.Drawing.Color.White;
            this.labelCliente.Location = new System.Drawing.Point(105, 7);
            this.labelCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCliente.Name = "labelCliente";
            this.labelCliente.Size = new System.Drawing.Size(80, 22);
            this.labelCliente.TabIndex = 7;
            this.labelCliente.Text = "Cliente";
            // 
            // labelNombreC
            // 
            this.labelNombreC.AutoSize = true;
            this.labelNombreC.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreC.ForeColor = System.Drawing.Color.White;
            this.labelNombreC.Location = new System.Drawing.Point(78, 64);
            this.labelNombreC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNombreC.Name = "labelNombreC";
            this.labelNombreC.Size = new System.Drawing.Size(0, 19);
            this.labelNombreC.TabIndex = 14;
            // 
            // labelApellidoC
            // 
            this.labelApellidoC.AutoSize = true;
            this.labelApellidoC.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelApellidoC.ForeColor = System.Drawing.Color.White;
            this.labelApellidoC.Location = new System.Drawing.Point(96, 98);
            this.labelApellidoC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelApellidoC.Name = "labelApellidoC";
            this.labelApellidoC.Size = new System.Drawing.Size(0, 19);
            this.labelApellidoC.TabIndex = 13;
            // 
            // labelEmailC
            // 
            this.labelEmailC.AutoSize = true;
            this.labelEmailC.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmailC.ForeColor = System.Drawing.Color.White;
            this.labelEmailC.Location = new System.Drawing.Point(69, 165);
            this.labelEmailC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEmailC.Name = "labelEmailC";
            this.labelEmailC.Size = new System.Drawing.Size(0, 19);
            this.labelEmailC.TabIndex = 12;
            // 
            // labelDniC
            // 
            this.labelDniC.AutoSize = true;
            this.labelDniC.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDniC.ForeColor = System.Drawing.Color.White;
            this.labelDniC.Location = new System.Drawing.Point(51, 131);
            this.labelDniC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDniC.Name = "labelDniC";
            this.labelDniC.Size = new System.Drawing.Size(0, 19);
            this.labelDniC.TabIndex = 11;
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.ForeColor = System.Drawing.Color.White;
            this.labelNombre.Location = new System.Drawing.Point(2, 64);
            this.labelNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(72, 19);
            this.labelNombre.TabIndex = 10;
            this.labelNombre.Text = "Nombre:";
            // 
            // labelApellido
            // 
            this.labelApellido.AutoSize = true;
            this.labelApellido.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelApellido.ForeColor = System.Drawing.Color.White;
            this.labelApellido.Location = new System.Drawing.Point(2, 98);
            this.labelApellido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelApellido.Name = "labelApellido";
            this.labelApellido.Size = new System.Drawing.Size(90, 19);
            this.labelApellido.TabIndex = 9;
            this.labelApellido.Text = "Apellido:";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.ForeColor = System.Drawing.Color.White;
            this.labelEmail.Location = new System.Drawing.Point(2, 165);
            this.labelEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(63, 19);
            this.labelEmail.TabIndex = 8;
            this.labelEmail.Text = "Email:";
            // 
            // labelDni
            // 
            this.labelDni.AutoSize = true;
            this.labelDni.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDni.ForeColor = System.Drawing.Color.White;
            this.labelDni.Location = new System.Drawing.Point(2, 131);
            this.labelDni.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDni.Name = "labelDni";
            this.labelDni.Size = new System.Drawing.Size(45, 19);
            this.labelDni.TabIndex = 7;
            this.labelDni.Text = "DNI:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 217);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(570, 238);
            this.panel2.TabIndex = 3;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.dataGridViewCarrito);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 24);
            this.panel7.Margin = new System.Windows.Forms.Padding(2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(570, 184);
            this.panel7.TabIndex = 2;
            // 
            // dataGridViewCarrito
            // 
            this.dataGridViewCarrito.AllowCustomTheming = false;
            this.dataGridViewCarrito.AllowUserToAddRows = false;
            this.dataGridViewCarrito.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewCarrito.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCarrito.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCarrito.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewCarrito.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewCarrito.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCarrito.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewCarrito.ColumnHeadersHeight = 40;
            this.dataGridViewCarrito.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.ColumnImagen,
            this.ColumnTitulo,
            this.ColumnCantidad,
            this.ColumnSubtotal,
            this.ColumnAccion});
            this.dataGridViewCarrito.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dataGridViewCarrito.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dataGridViewCarrito.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewCarrito.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dataGridViewCarrito.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewCarrito.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dataGridViewCarrito.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dataGridViewCarrito.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dataGridViewCarrito.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dataGridViewCarrito.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridViewCarrito.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.dataGridViewCarrito.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewCarrito.CurrentTheme.Name = null;
            this.dataGridViewCarrito.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewCarrito.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dataGridViewCarrito.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewCarrito.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dataGridViewCarrito.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewCarrito.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewCarrito.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewCarrito.EnableHeadersVisualStyles = false;
            this.dataGridViewCarrito.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dataGridViewCarrito.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dataGridViewCarrito.HeaderBgColor = System.Drawing.Color.Empty;
            this.dataGridViewCarrito.HeaderForeColor = System.Drawing.Color.White;
            this.dataGridViewCarrito.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewCarrito.Name = "dataGridViewCarrito";
            this.dataGridViewCarrito.RowHeadersVisible = false;
            this.dataGridViewCarrito.RowHeadersWidth = 51;
            this.dataGridViewCarrito.RowTemplate.Height = 40;
            this.dataGridViewCarrito.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCarrito.Size = new System.Drawing.Size(570, 184);
            this.dataGridViewCarrito.TabIndex = 2;
            this.dataGridViewCarrito.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.dataGridViewCarrito.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCarrito_CellClick);
            this.dataGridViewCarrito.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCarrito_CellLeave);
            this.dataGridViewCarrito.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridViewCarrito_EditingControlShowing);
            this.dataGridViewCarrito.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dataGridViewCarrito_KeyPress);
            // 
            // ColumnId
            // 
            this.ColumnId.HeaderText = "Id";
            this.ColumnId.Name = "ColumnId";
            // 
            // ColumnImagen
            // 
            this.ColumnImagen.HeaderText = "Imagen";
            this.ColumnImagen.MinimumWidth = 6;
            this.ColumnImagen.Name = "ColumnImagen";
            this.ColumnImagen.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnImagen.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ColumnTitulo
            // 
            this.ColumnTitulo.HeaderText = "Titulo";
            this.ColumnTitulo.MinimumWidth = 6;
            this.ColumnTitulo.Name = "ColumnTitulo";
            // 
            // ColumnCantidad
            // 
            this.ColumnCantidad.HeaderText = "Cantidad";
            this.ColumnCantidad.MinimumWidth = 6;
            this.ColumnCantidad.Name = "ColumnCantidad";
            this.ColumnCantidad.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ColumnSubtotal
            // 
            this.ColumnSubtotal.HeaderText = "Subtotal";
            this.ColumnSubtotal.MinimumWidth = 6;
            this.ColumnSubtotal.Name = "ColumnSubtotal";
            // 
            // ColumnAccion
            // 
            this.ColumnAccion.HeaderText = "Accion";
            this.ColumnAccion.MinimumWidth = 6;
            this.ColumnAccion.Name = "ColumnAccion";
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.labelProductos);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(570, 24);
            this.panel6.TabIndex = 1;
            // 
            // labelProductos
            // 
            this.labelProductos.AutoSize = true;
            this.labelProductos.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelProductos.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProductos.ForeColor = System.Drawing.Color.White;
            this.labelProductos.Location = new System.Drawing.Point(0, 0);
            this.labelProductos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelProductos.Name = "labelProductos";
            this.labelProductos.Size = new System.Drawing.Size(90, 19);
            this.labelProductos.TabIndex = 8;
            this.labelProductos.Text = "Productos";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.buttonCancelarCompra);
            this.panel5.Controls.Add(this.labelTotal);
            this.panel5.Controls.Add(this.labelT);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 208);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(570, 30);
            this.panel5.TabIndex = 0;
            // 
            // buttonCancelarCompra
            // 
            this.buttonCancelarCompra.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonCancelarCompra.Enabled = false;
            this.buttonCancelarCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancelarCompra.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelarCompra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonCancelarCompra.Location = new System.Drawing.Point(400, 0);
            this.buttonCancelarCompra.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCancelarCompra.Name = "buttonCancelarCompra";
            this.buttonCancelarCompra.Size = new System.Drawing.Size(168, 28);
            this.buttonCancelarCompra.TabIndex = 42;
            this.buttonCancelarCompra.Text = "Cancelar Compra";
            this.buttonCancelarCompra.UseVisualStyleBackColor = true;
            this.buttonCancelarCompra.Click += new System.EventHandler(this.buttonCancelarCompra_Click);
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.ForeColor = System.Drawing.Color.White;
            this.labelTotal.Location = new System.Drawing.Point(60, 3);
            this.labelTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(0, 19);
            this.labelTotal.TabIndex = 13;
            // 
            // labelT
            // 
            this.labelT.AutoSize = true;
            this.labelT.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelT.ForeColor = System.Drawing.Color.White;
            this.labelT.Location = new System.Drawing.Point(3, 3);
            this.labelT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelT.Name = "labelT";
            this.labelT.Size = new System.Drawing.Size(63, 19);
            this.labelT.TabIndex = 9;
            this.labelT.Text = "Total:";
            // 
            // NuevaVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(570, 455);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NuevaVenta";
            this.Text = "NuevaVenta";
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panelCliente.ResumeLayout(false);
            this.panelCliente.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCarrito)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelCliente;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelApellido;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelDni;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonFinalizarCompra;
        private System.Windows.Forms.Button buttonBuscarProducto;
        private System.Windows.Forms.Button buttonBuscarCliente;
        private System.Windows.Forms.Label labelNombreC;
        private System.Windows.Forms.Label labelApellidoC;
        private System.Windows.Forms.Label labelEmailC;
        private System.Windows.Forms.Label labelDniC;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label labelCliente;
        private System.Windows.Forms.Panel panel7;
        private Bunifu.UI.WinForms.BunifuDataGridView dataGridViewCarrito;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label labelProductos;
        private System.Windows.Forms.Label labelT;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Button buttonCancelarCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.DataGridViewImageColumn ColumnImagen;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTitulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSubtotal;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnAccion;
    }
}