namespace Proyecto2022.CapaPresentacion.VistaJefeLaboratorio.GestionSolicitudes
{
    partial class SolicitudesFinalizadas
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
            this.btnMostrarTodos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxBuscarDni = new System.Windows.Forms.TextBox();
            this.btnBuscarDni = new System.Windows.Forms.Button();
            this.btnFiltrarServicio = new System.Windows.Forms.Button();
            this.comboBoxServicios = new System.Windows.Forms.ComboBox();
            this.textBoxBuscarId = new System.Windows.Forms.TextBox();
            this.btnBuscarId = new System.Windows.Forms.Button();
            this.labelPrincipal = new System.Windows.Forms.Label();
            this.dataGridSolicitudes = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.columnIdSolicitud = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnNombreServicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDniCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnNombreCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnMailCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnAccion = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSolicitudes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMostrarTodos
            // 
            this.btnMostrarTodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarTodos.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarTodos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnMostrarTodos.Location = new System.Drawing.Point(385, 80);
            this.btnMostrarTodos.Margin = new System.Windows.Forms.Padding(2);
            this.btnMostrarTodos.Name = "btnMostrarTodos";
            this.btnMostrarTodos.Size = new System.Drawing.Size(132, 46);
            this.btnMostrarTodos.TabIndex = 67;
            this.btnMostrarTodos.Text = "Mostrar todas";
            this.btnMostrarTodos.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(5, 197);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 13);
            this.label1.TabIndex = 63;
            this.label1.Text = "Listado de solicitudes de servicio finalizadas";
            // 
            // textBoxBuscarDni
            // 
            this.textBoxBuscarDni.Location = new System.Drawing.Point(34, 96);
            this.textBoxBuscarDni.Name = "textBoxBuscarDni";
            this.textBoxBuscarDni.Size = new System.Drawing.Size(162, 20);
            this.textBoxBuscarDni.TabIndex = 73;
            this.textBoxBuscarDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxBuscarDni_KeyPress);
            // 
            // btnBuscarDni
            // 
            this.btnBuscarDni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarDni.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarDni.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnBuscarDni.Location = new System.Drawing.Point(217, 90);
            this.btnBuscarDni.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscarDni.Name = "btnBuscarDni";
            this.btnBuscarDni.Size = new System.Drawing.Size(132, 31);
            this.btnBuscarDni.TabIndex = 72;
            this.btnBuscarDni.Text = "Buscar por DNI";
            this.btnBuscarDni.UseVisualStyleBackColor = true;
            // 
            // btnFiltrarServicio
            // 
            this.btnFiltrarServicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrarServicio.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrarServicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnFiltrarServicio.Location = new System.Drawing.Point(217, 136);
            this.btnFiltrarServicio.Margin = new System.Windows.Forms.Padding(2);
            this.btnFiltrarServicio.Name = "btnFiltrarServicio";
            this.btnFiltrarServicio.Size = new System.Drawing.Size(132, 46);
            this.btnFiltrarServicio.TabIndex = 71;
            this.btnFiltrarServicio.Text = "Filtrar por servicio";
            this.btnFiltrarServicio.UseVisualStyleBackColor = true;
            // 
            // comboBoxServicios
            // 
            this.comboBoxServicios.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxServicios.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxServicios.FormattingEnabled = true;
            this.comboBoxServicios.Location = new System.Drawing.Point(34, 148);
            this.comboBoxServicios.Name = "comboBoxServicios";
            this.comboBoxServicios.Size = new System.Drawing.Size(162, 21);
            this.comboBoxServicios.TabIndex = 70;
            // 
            // textBoxBuscarId
            // 
            this.textBoxBuscarId.Location = new System.Drawing.Point(34, 48);
            this.textBoxBuscarId.Name = "textBoxBuscarId";
            this.textBoxBuscarId.Size = new System.Drawing.Size(162, 20);
            this.textBoxBuscarId.TabIndex = 69;
            this.textBoxBuscarId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxBuscarId_KeyPress);
            // 
            // btnBuscarId
            // 
            this.btnBuscarId.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarId.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnBuscarId.Location = new System.Drawing.Point(217, 42);
            this.btnBuscarId.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscarId.Name = "btnBuscarId";
            this.btnBuscarId.Size = new System.Drawing.Size(132, 31);
            this.btnBuscarId.TabIndex = 68;
            this.btnBuscarId.Text = "Buscar por ID";
            this.btnBuscarId.UseVisualStyleBackColor = true;
            // 
            // labelPrincipal
            // 
            this.labelPrincipal.AutoSize = true;
            this.labelPrincipal.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrincipal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelPrincipal.Location = new System.Drawing.Point(181, 9);
            this.labelPrincipal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPrincipal.Name = "labelPrincipal";
            this.labelPrincipal.Size = new System.Drawing.Size(216, 19);
            this.labelPrincipal.TabIndex = 75;
            this.labelPrincipal.Text = "Solicitudes Finalizadas";
            // 
            // dataGridSolicitudes
            // 
            this.dataGridSolicitudes.AllowCustomTheming = false;
            this.dataGridSolicitudes.AllowUserToAddRows = false;
            this.dataGridSolicitudes.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dataGridSolicitudes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridSolicitudes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridSolicitudes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridSolicitudes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridSolicitudes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridSolicitudes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridSolicitudes.ColumnHeadersHeight = 40;
            this.dataGridSolicitudes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnIdSolicitud,
            this.columnNombreServicio,
            this.columnCantidad,
            this.columnDniCliente,
            this.columnNombreCliente,
            this.columnMailCliente,
            this.columnTelefono,
            this.columnAccion});
            this.dataGridSolicitudes.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dataGridSolicitudes.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dataGridSolicitudes.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridSolicitudes.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dataGridSolicitudes.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridSolicitudes.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dataGridSolicitudes.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dataGridSolicitudes.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dataGridSolicitudes.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dataGridSolicitudes.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridSolicitudes.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.dataGridSolicitudes.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridSolicitudes.CurrentTheme.Name = null;
            this.dataGridSolicitudes.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridSolicitudes.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dataGridSolicitudes.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridSolicitudes.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dataGridSolicitudes.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridSolicitudes.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridSolicitudes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridSolicitudes.EnableHeadersVisualStyles = false;
            this.dataGridSolicitudes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dataGridSolicitudes.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dataGridSolicitudes.HeaderBgColor = System.Drawing.Color.Empty;
            this.dataGridSolicitudes.HeaderForeColor = System.Drawing.Color.White;
            this.dataGridSolicitudes.Location = new System.Drawing.Point(0, 210);
            this.dataGridSolicitudes.Name = "dataGridSolicitudes";
            this.dataGridSolicitudes.ReadOnly = true;
            this.dataGridSolicitudes.RowHeadersVisible = false;
            this.dataGridSolicitudes.RowTemplate.Height = 40;
            this.dataGridSolicitudes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridSolicitudes.Size = new System.Drawing.Size(562, 246);
            this.dataGridSolicitudes.TabIndex = 76;
            this.dataGridSolicitudes.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.dataGridSolicitudes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridSolicitudes_CellContentClick);
            // 
            // columnIdSolicitud
            // 
            this.columnIdSolicitud.HeaderText = "Id. Solicitud";
            this.columnIdSolicitud.Name = "columnIdSolicitud";
            this.columnIdSolicitud.ReadOnly = true;
            // 
            // columnNombreServicio
            // 
            this.columnNombreServicio.HeaderText = "Servicio";
            this.columnNombreServicio.Name = "columnNombreServicio";
            this.columnNombreServicio.ReadOnly = true;
            // 
            // columnCantidad
            // 
            this.columnCantidad.HeaderText = "Cant.";
            this.columnCantidad.Name = "columnCantidad";
            this.columnCantidad.ReadOnly = true;
            // 
            // columnDniCliente
            // 
            this.columnDniCliente.HeaderText = "DniCliente";
            this.columnDniCliente.Name = "columnDniCliente";
            this.columnDniCliente.ReadOnly = true;
            // 
            // columnNombreCliente
            // 
            this.columnNombreCliente.HeaderText = "Nombre Cliente";
            this.columnNombreCliente.Name = "columnNombreCliente";
            this.columnNombreCliente.ReadOnly = true;
            // 
            // columnMailCliente
            // 
            this.columnMailCliente.HeaderText = "Email";
            this.columnMailCliente.Name = "columnMailCliente";
            this.columnMailCliente.ReadOnly = true;
            // 
            // columnTelefono
            // 
            this.columnTelefono.HeaderText = "Telefono";
            this.columnTelefono.Name = "columnTelefono";
            this.columnTelefono.ReadOnly = true;
            // 
            // columnAccion
            // 
            this.columnAccion.HeaderText = "Acción";
            this.columnAccion.Name = "columnAccion";
            this.columnAccion.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Help;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.3F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(59, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 77;
            this.label2.Text = "ingresar formato 1-1-1";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // SolicitudesFinalizadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(562, 456);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridSolicitudes);
            this.Controls.Add(this.labelPrincipal);
            this.Controls.Add(this.textBoxBuscarDni);
            this.Controls.Add(this.btnBuscarDni);
            this.Controls.Add(this.btnFiltrarServicio);
            this.Controls.Add(this.comboBoxServicios);
            this.Controls.Add(this.textBoxBuscarId);
            this.Controls.Add(this.btnBuscarId);
            this.Controls.Add(this.btnMostrarTodos);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SolicitudesFinalizadas";
            this.Text = "SolicitudesFinalizadas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSolicitudes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMostrarTodos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxBuscarDni;
        private System.Windows.Forms.Button btnBuscarDni;
        private System.Windows.Forms.Button btnFiltrarServicio;
        private System.Windows.Forms.ComboBox comboBoxServicios;
        private System.Windows.Forms.TextBox textBoxBuscarId;
        private System.Windows.Forms.Button btnBuscarId;
        private System.Windows.Forms.Label labelPrincipal;
        private Bunifu.UI.WinForms.BunifuDataGridView dataGridSolicitudes;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnIdSolicitud;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnNombreServicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnDniCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnNombreCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnMailCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnTelefono;
        private System.Windows.Forms.DataGridViewButtonColumn columnAccion;
        private System.Windows.Forms.Label label2;
    }
}