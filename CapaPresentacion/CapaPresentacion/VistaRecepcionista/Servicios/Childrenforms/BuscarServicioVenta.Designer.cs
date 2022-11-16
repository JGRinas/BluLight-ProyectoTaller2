namespace CapaPresentacion.CapaPresentacion.VistaRecepcionista.Servicios.Childrenforms
{
    partial class BuscarServicioVenta
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelIdServicio = new System.Windows.Forms.Label();
            this.labelCantidad = new System.Windows.Forms.Label();
            this.labelLab = new System.Windows.Forms.Label();
            this.labelNombreServ = new System.Windows.Forms.Label();
            this.textBoxCantidad = new System.Windows.Forms.TextBox();
            this.btnAgregarServicio = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.labelNombreServicio = new System.Windows.Forms.Label();
            this.textBoxNombreServicio = new System.Windows.Forms.TextBox();
            this.btnTodos = new System.Windows.Forms.Button();
            this.labelLaboratorio = new System.Windows.Forms.Label();
            this.labelCategoria = new System.Windows.Forms.Label();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.comboBoxLab = new System.Windows.Forms.ComboBox();
            this.comboBoxCategoria = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.datagridServicios = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnLab = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridServicios)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(911, 208);
            this.panel1.TabIndex = 60;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.labelIdServicio);
            this.panel2.Controls.Add(this.labelCantidad);
            this.panel2.Controls.Add(this.labelLab);
            this.panel2.Controls.Add(this.labelNombreServ);
            this.panel2.Controls.Add(this.textBoxCantidad);
            this.panel2.Controls.Add(this.btnAgregarServicio);
            this.panel2.Location = new System.Drawing.Point(559, 1);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(427, 205);
            this.panel2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(4, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 23);
            this.label3.TabIndex = 62;
            this.label3.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(4, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 23);
            this.label2.TabIndex = 61;
            this.label2.Text = "Lab.:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(3, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 23);
            this.label1.TabIndex = 60;
            this.label1.Text = "Servicio:";
            // 
            // labelIdServicio
            // 
            this.labelIdServicio.AutoSize = true;
            this.labelIdServicio.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.labelIdServicio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelIdServicio.Location = new System.Drawing.Point(48, 54);
            this.labelIdServicio.Name = "labelIdServicio";
            this.labelIdServicio.Size = new System.Drawing.Size(27, 20);
            this.labelIdServicio.TabIndex = 59;
            this.labelIdServicio.Text = "ID";
            // 
            // labelCantidad
            // 
            this.labelCantidad.AutoSize = true;
            this.labelCantidad.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCantidad.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelCantidad.Location = new System.Drawing.Point(164, 87);
            this.labelCantidad.Name = "labelCantidad";
            this.labelCantidad.Size = new System.Drawing.Size(98, 23);
            this.labelCantidad.TabIndex = 58;
            this.labelCantidad.Text = "Cantidad";
            // 
            // labelLab
            // 
            this.labelLab.AutoSize = true;
            this.labelLab.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.labelLab.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelLab.Location = new System.Drawing.Point(72, 28);
            this.labelLab.Name = "labelLab";
            this.labelLab.Size = new System.Drawing.Size(18, 20);
            this.labelLab.TabIndex = 57;
            this.labelLab.Text = "L";
            // 
            // labelNombreServ
            // 
            this.labelNombreServ.AutoSize = true;
            this.labelNombreServ.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Bold);
            this.labelNombreServ.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelNombreServ.Location = new System.Drawing.Point(125, 5);
            this.labelNombreServ.Name = "labelNombreServ";
            this.labelNombreServ.Size = new System.Drawing.Size(16, 17);
            this.labelNombreServ.TabIndex = 56;
            this.labelNombreServ.Text = "S";
            // 
            // textBoxCantidad
            // 
            this.textBoxCantidad.Location = new System.Drawing.Point(169, 114);
            this.textBoxCantidad.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCantidad.Name = "textBoxCantidad";
            this.textBoxCantidad.Size = new System.Drawing.Size(101, 22);
            this.textBoxCantidad.TabIndex = 55;
            this.textBoxCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCantidad_KeyPress_1);
            // 
            // btnAgregarServicio
            // 
            this.btnAgregarServicio.Enabled = false;
            this.btnAgregarServicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarServicio.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarServicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAgregarServicio.Location = new System.Drawing.Point(77, 155);
            this.btnAgregarServicio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregarServicio.Name = "btnAgregarServicio";
            this.btnAgregarServicio.Size = new System.Drawing.Size(195, 38);
            this.btnAgregarServicio.TabIndex = 54;
            this.btnAgregarServicio.Text = "Agregar Servicio";
            this.btnAgregarServicio.UseVisualStyleBackColor = true;
            this.btnAgregarServicio.Click += new System.EventHandler(this.buttonAgregarServicio_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnBuscar);
            this.panel3.Controls.Add(this.labelNombreServicio);
            this.panel3.Controls.Add(this.textBoxNombreServicio);
            this.panel3.Controls.Add(this.btnTodos);
            this.panel3.Controls.Add(this.labelLaboratorio);
            this.panel3.Controls.Add(this.labelCategoria);
            this.panel3.Controls.Add(this.btnFiltrar);
            this.panel3.Controls.Add(this.comboBoxLab);
            this.panel3.Controls.Add(this.comboBoxCategoria);
            this.panel3.Location = new System.Drawing.Point(0, 1);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(557, 205);
            this.panel3.TabIndex = 2;
            // 
            // btnBuscar
            // 
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnBuscar.Location = new System.Drawing.Point(188, 59);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(112, 33);
            this.btnBuscar.TabIndex = 64;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.buttonBuscarServicioNombre_Click);
            // 
            // labelNombreServicio
            // 
            this.labelNombreServicio.AutoSize = true;
            this.labelNombreServicio.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreServicio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelNombreServicio.Location = new System.Drawing.Point(125, 1);
            this.labelNombreServicio.Name = "labelNombreServicio";
            this.labelNombreServicio.Size = new System.Drawing.Size(219, 23);
            this.labelNombreServicio.TabIndex = 63;
            this.labelNombreServicio.Text = "Nombre del servicio";
            // 
            // textBoxNombreServicio
            // 
            this.textBoxNombreServicio.Location = new System.Drawing.Point(124, 28);
            this.textBoxNombreServicio.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNombreServicio.Name = "textBoxNombreServicio";
            this.textBoxNombreServicio.Size = new System.Drawing.Size(241, 22);
            this.textBoxNombreServicio.TabIndex = 62;
            this.textBoxNombreServicio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNombreServicio_KeyPress_1);
            // 
            // btnTodos
            // 
            this.btnTodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTodos.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTodos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnTodos.Location = new System.Drawing.Point(391, 161);
            this.btnTodos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTodos.Name = "btnTodos";
            this.btnTodos.Size = new System.Drawing.Size(96, 34);
            this.btnTodos.TabIndex = 61;
            this.btnTodos.Text = "Todos";
            this.btnTodos.UseVisualStyleBackColor = true;
            this.btnTodos.Click += new System.EventHandler(this.buttonMostrarTodos_Click);
            // 
            // labelLaboratorio
            // 
            this.labelLaboratorio.AutoSize = true;
            this.labelLaboratorio.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLaboratorio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelLaboratorio.Location = new System.Drawing.Point(307, 100);
            this.labelLaboratorio.Name = "labelLaboratorio";
            this.labelLaboratorio.Size = new System.Drawing.Size(131, 23);
            this.labelLaboratorio.TabIndex = 60;
            this.labelLaboratorio.Text = "Laboratorio";
            // 
            // labelCategoria
            // 
            this.labelCategoria.AutoSize = true;
            this.labelCategoria.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCategoria.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelCategoria.Location = new System.Drawing.Point(71, 100);
            this.labelCategoria.Name = "labelCategoria";
            this.labelCategoria.Size = new System.Drawing.Size(109, 23);
            this.labelCategoria.TabIndex = 59;
            this.labelCategoria.Text = "Categoría";
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrar.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnFiltrar.Location = new System.Drawing.Point(147, 159);
            this.btnFiltrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(188, 38);
            this.btnFiltrar.TabIndex = 55;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltro_Click);
            // 
            // comboBoxLab
            // 
            this.comboBoxLab.FormattingEnabled = true;
            this.comboBoxLab.Location = new System.Drawing.Point(261, 127);
            this.comboBoxLab.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxLab.Name = "comboBoxLab";
            this.comboBoxLab.Size = new System.Drawing.Size(224, 24);
            this.comboBoxLab.TabIndex = 1;
            // 
            // comboBoxCategoria
            // 
            this.comboBoxCategoria.FormattingEnabled = true;
            this.comboBoxCategoria.Location = new System.Drawing.Point(25, 127);
            this.comboBoxCategoria.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxCategoria.Name = "comboBoxCategoria";
            this.comboBoxCategoria.Size = new System.Drawing.Size(219, 24);
            this.comboBoxCategoria.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.datagridServicios);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 208);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(911, 228);
            this.panel4.TabIndex = 61;
            // 
            // datagridServicios
            // 
            this.datagridServicios.AllowCustomTheming = false;
            this.datagridServicios.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.datagridServicios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.datagridServicios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridServicios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagridServicios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.datagridServicios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridServicios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.datagridServicios.ColumnHeadersHeight = 40;
            this.datagridServicios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.ColumnNombre,
            this.ColumnLab,
            this.ColumnPrecio,
            this.ColumnCategoria});
            this.datagridServicios.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.datagridServicios.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.datagridServicios.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.datagridServicios.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.datagridServicios.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.datagridServicios.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.datagridServicios.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.datagridServicios.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.datagridServicios.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.datagridServicios.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.datagridServicios.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.datagridServicios.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.datagridServicios.CurrentTheme.Name = null;
            this.datagridServicios.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.datagridServicios.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.datagridServicios.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.datagridServicios.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.datagridServicios.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagridServicios.DefaultCellStyle = dataGridViewCellStyle3;
            this.datagridServicios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datagridServicios.EnableHeadersVisualStyles = false;
            this.datagridServicios.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.datagridServicios.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.datagridServicios.HeaderBgColor = System.Drawing.Color.Empty;
            this.datagridServicios.HeaderForeColor = System.Drawing.Color.White;
            this.datagridServicios.Location = new System.Drawing.Point(0, 0);
            this.datagridServicios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.datagridServicios.Name = "datagridServicios";
            this.datagridServicios.RowHeadersVisible = false;
            this.datagridServicios.RowHeadersWidth = 51;
            this.datagridServicios.RowTemplate.Height = 40;
            this.datagridServicios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridServicios.Size = new System.Drawing.Size(911, 228);
            this.datagridServicios.TabIndex = 4;
            this.datagridServicios.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.datagridServicios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridServicios_CellClick);
            // 
            // ColumnId
            // 
            this.ColumnId.HeaderText = "ID Servicio";
            this.ColumnId.MinimumWidth = 6;
            this.ColumnId.Name = "ColumnId";
            // 
            // ColumnNombre
            // 
            this.ColumnNombre.HeaderText = "Nombre";
            this.ColumnNombre.MinimumWidth = 6;
            this.ColumnNombre.Name = "ColumnNombre";
            // 
            // ColumnLab
            // 
            this.ColumnLab.HeaderText = "Lab.";
            this.ColumnLab.MinimumWidth = 6;
            this.ColumnLab.Name = "ColumnLab";
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
            // BuscarServicioVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(911, 436);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BuscarServicioVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BuscarServicioVenta";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagridServicios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelIdServicio;
        private System.Windows.Forms.Label labelCantidad;
        private System.Windows.Forms.Label labelLab;
        private System.Windows.Forms.Label labelNombreServ;
        private System.Windows.Forms.TextBox textBoxCantidad;
        private System.Windows.Forms.Button btnAgregarServicio;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label labelNombreServicio;
        private System.Windows.Forms.TextBox textBoxNombreServicio;
        private System.Windows.Forms.Button btnTodos;
        private System.Windows.Forms.Label labelLaboratorio;
        private System.Windows.Forms.Label labelCategoria;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.ComboBox comboBoxLab;
        private System.Windows.Forms.ComboBox comboBoxCategoria;
        private System.Windows.Forms.Panel panel4;
        private Bunifu.UI.WinForms.BunifuDataGridView datagridServicios;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnLab;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCategoria;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}