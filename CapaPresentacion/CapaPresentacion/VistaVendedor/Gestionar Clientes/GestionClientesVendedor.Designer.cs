namespace CapaPresentacion.VistaVendedor.Gestionar_Clientes
{
    partial class GestionClientesVendedor
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonEliminarCliente = new System.Windows.Forms.Button();
            this.buttonModificarCliente = new System.Windows.Forms.Button();
            this.buttonRegistrar = new System.Windows.Forms.Button();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.labelPhone = new System.Windows.Forms.Label();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.labelAddress = new System.Windows.Forms.Label();
            this.textBoxDni = new System.Windows.Forms.TextBox();
            this.labelDni = new System.Windows.Forms.Label();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.labelSurname = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridViewClientes = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.textBoxDniBuscar = new System.Windows.Forms.TextBox();
            this.labelDniBuscar = new System.Windows.Forms.Label();
            this.buttonBuscarCliente = new System.Windows.Forms.Button();
            this.ColumnNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDireccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnActivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonBuscarCliente);
            this.panel1.Controls.Add(this.textBoxDniBuscar);
            this.panel1.Controls.Add(this.labelDniBuscar);
            this.panel1.Controls.Add(this.buttonEliminarCliente);
            this.panel1.Controls.Add(this.buttonModificarCliente);
            this.panel1.Controls.Add(this.buttonRegistrar);
            this.panel1.Controls.Add(this.textBoxEmail);
            this.panel1.Controls.Add(this.labelEmail);
            this.panel1.Controls.Add(this.textBoxPhone);
            this.panel1.Controls.Add(this.labelPhone);
            this.panel1.Controls.Add(this.textBoxAddress);
            this.panel1.Controls.Add(this.labelAddress);
            this.panel1.Controls.Add(this.textBoxDni);
            this.panel1.Controls.Add(this.labelDni);
            this.panel1.Controls.Add(this.textBoxSurname);
            this.panel1.Controls.Add(this.labelSurname);
            this.panel1.Controls.Add(this.textBoxName);
            this.panel1.Controls.Add(this.labelName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(760, 377);
            this.panel1.TabIndex = 0;
            // 
            // buttonEliminarCliente
            // 
            this.buttonEliminarCliente.Enabled = false;
            this.buttonEliminarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEliminarCliente.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminarCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonEliminarCliente.Location = new System.Drawing.Point(592, 292);
            this.buttonEliminarCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEliminarCliente.Name = "buttonEliminarCliente";
            this.buttonEliminarCliente.Size = new System.Drawing.Size(128, 38);
            this.buttonEliminarCliente.TabIndex = 31;
            this.buttonEliminarCliente.Text = "Eliminar";
            this.buttonEliminarCliente.UseVisualStyleBackColor = true;
            this.buttonEliminarCliente.Click += new System.EventHandler(this.buttonEliminarCliente_Click);
            // 
            // buttonModificarCliente
            // 
            this.buttonModificarCliente.Enabled = false;
            this.buttonModificarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonModificarCliente.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModificarCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonModificarCliente.Location = new System.Drawing.Point(458, 292);
            this.buttonModificarCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonModificarCliente.Name = "buttonModificarCliente";
            this.buttonModificarCliente.Size = new System.Drawing.Size(128, 38);
            this.buttonModificarCliente.TabIndex = 30;
            this.buttonModificarCliente.Text = "Modificar";
            this.buttonModificarCliente.UseVisualStyleBackColor = true;
            this.buttonModificarCliente.Click += new System.EventHandler(this.buttonModificarCliente_Click);
            // 
            // buttonRegistrar
            // 
            this.buttonRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegistrar.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegistrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonRegistrar.Location = new System.Drawing.Point(324, 292);
            this.buttonRegistrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonRegistrar.Name = "buttonRegistrar";
            this.buttonRegistrar.Size = new System.Drawing.Size(128, 38);
            this.buttonRegistrar.TabIndex = 29;
            this.buttonRegistrar.Text = "Registrar";
            this.buttonRegistrar.UseVisualStyleBackColor = true;
            this.buttonRegistrar.Click += new System.EventHandler(this.buttonRegistrar_Click);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(531, 234);
            this.textBoxEmail.Multiline = true;
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(159, 29);
            this.textBoxEmail.TabIndex = 11;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.ForeColor = System.Drawing.Color.White;
            this.labelEmail.Location = new System.Drawing.Point(526, 204);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(65, 23);
            this.labelEmail.TabIndex = 10;
            this.labelEmail.Text = "Email";
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(352, 150);
            this.textBoxPhone.Multiline = true;
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(159, 29);
            this.textBoxPhone.TabIndex = 9;
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhone.ForeColor = System.Drawing.Color.White;
            this.labelPhone.Location = new System.Drawing.Point(347, 120);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(98, 23);
            this.labelPhone.TabIndex = 8;
            this.labelPhone.Text = "Teléfono";
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(530, 150);
            this.textBoxAddress.Multiline = true;
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(159, 29);
            this.textBoxAddress.TabIndex = 7;
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddress.ForeColor = System.Drawing.Color.White;
            this.labelAddress.Location = new System.Drawing.Point(525, 120);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(109, 23);
            this.labelAddress.TabIndex = 6;
            this.labelAddress.Text = "Dirección";
            // 
            // textBoxDni
            // 
            this.textBoxDni.Location = new System.Drawing.Point(353, 234);
            this.textBoxDni.Multiline = true;
            this.textBoxDni.Name = "textBoxDni";
            this.textBoxDni.Size = new System.Drawing.Size(158, 29);
            this.textBoxDni.TabIndex = 5;
            this.textBoxDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDni_KeyPress);
            // 
            // labelDni
            // 
            this.labelDni.AutoSize = true;
            this.labelDni.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDni.ForeColor = System.Drawing.Color.White;
            this.labelDni.Location = new System.Drawing.Point(348, 204);
            this.labelDni.Name = "labelDni";
            this.labelDni.Size = new System.Drawing.Size(43, 23);
            this.labelDni.TabIndex = 4;
            this.labelDni.Text = "DNI";
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(533, 56);
            this.textBoxSurname.Multiline = true;
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(159, 29);
            this.textBoxSurname.TabIndex = 3;
            this.textBoxSurname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSurname_KeyPress);
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSurname.ForeColor = System.Drawing.Color.White;
            this.labelSurname.Location = new System.Drawing.Point(528, 26);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(98, 23);
            this.labelSurname.TabIndex = 2;
            this.labelSurname.Text = "Apellido";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(350, 56);
            this.textBoxName.Multiline = true;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(163, 29);
            this.textBoxName.TabIndex = 1;
            this.textBoxName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxName_KeyPress);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.Color.White;
            this.labelName.Location = new System.Drawing.Point(345, 26);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(76, 23);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Nombre";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridViewClientes);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 377);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(760, 182);
            this.panel2.TabIndex = 1;
            // 
            // dataGridViewClientes
            // 
            this.dataGridViewClientes.AllowCustomTheming = false;
            this.dataGridViewClientes.AllowUserToAddRows = false;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewClientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridViewClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewClientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewClientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dataGridViewClientes.ColumnHeadersHeight = 40;
            this.dataGridViewClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnNombre,
            this.ColumnApellido,
            this.ColumnDni,
            this.ColumnDireccion,
            this.ColumnEmail,
            this.ColumnTelefono,
            this.ColumnActivo});
            this.dataGridViewClientes.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dataGridViewClientes.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dataGridViewClientes.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewClientes.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dataGridViewClientes.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewClientes.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dataGridViewClientes.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dataGridViewClientes.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dataGridViewClientes.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dataGridViewClientes.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridViewClientes.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.dataGridViewClientes.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewClientes.CurrentTheme.Name = null;
            this.dataGridViewClientes.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewClientes.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dataGridViewClientes.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewClientes.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dataGridViewClientes.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewClientes.DefaultCellStyle = dataGridViewCellStyle18;
            this.dataGridViewClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewClientes.EnableHeadersVisualStyles = false;
            this.dataGridViewClientes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dataGridViewClientes.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dataGridViewClientes.HeaderBgColor = System.Drawing.Color.Empty;
            this.dataGridViewClientes.HeaderForeColor = System.Drawing.Color.White;
            this.dataGridViewClientes.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewClientes.Name = "dataGridViewClientes";
            this.dataGridViewClientes.RowHeadersVisible = false;
            this.dataGridViewClientes.RowHeadersWidth = 51;
            this.dataGridViewClientes.RowTemplate.Height = 40;
            this.dataGridViewClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewClientes.Size = new System.Drawing.Size(760, 182);
            this.dataGridViewClientes.TabIndex = 0;
            this.dataGridViewClientes.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.dataGridViewClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewClientes_CellClick);
            // 
            // textBoxDniBuscar
            // 
            this.textBoxDniBuscar.Location = new System.Drawing.Point(12, 150);
            this.textBoxDniBuscar.Multiline = true;
            this.textBoxDniBuscar.Name = "textBoxDniBuscar";
            this.textBoxDniBuscar.Size = new System.Drawing.Size(163, 29);
            this.textBoxDniBuscar.TabIndex = 33;
            this.textBoxDniBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDniBuscar_KeyPress);
            // 
            // labelDniBuscar
            // 
            this.labelDniBuscar.AutoSize = true;
            this.labelDniBuscar.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDniBuscar.ForeColor = System.Drawing.Color.White;
            this.labelDniBuscar.Location = new System.Drawing.Point(74, 113);
            this.labelDniBuscar.Name = "labelDniBuscar";
            this.labelDniBuscar.Size = new System.Drawing.Size(43, 23);
            this.labelDniBuscar.TabIndex = 32;
            this.labelDniBuscar.Text = "DNI";
            // 
            // buttonBuscarCliente
            // 
            this.buttonBuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuscarCliente.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscarCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonBuscarCliente.Location = new System.Drawing.Point(28, 198);
            this.buttonBuscarCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBuscarCliente.Name = "buttonBuscarCliente";
            this.buttonBuscarCliente.Size = new System.Drawing.Size(128, 38);
            this.buttonBuscarCliente.TabIndex = 34;
            this.buttonBuscarCliente.Text = "Buscar";
            this.buttonBuscarCliente.UseVisualStyleBackColor = true;
            this.buttonBuscarCliente.Click += new System.EventHandler(this.buttonBuscarCliente_Click);
            // 
            // ColumnNombre
            // 
            this.ColumnNombre.HeaderText = "Nombre";
            this.ColumnNombre.MinimumWidth = 6;
            this.ColumnNombre.Name = "ColumnNombre";
            // 
            // ColumnApellido
            // 
            this.ColumnApellido.HeaderText = "Apellido";
            this.ColumnApellido.MinimumWidth = 6;
            this.ColumnApellido.Name = "ColumnApellido";
            // 
            // ColumnDni
            // 
            this.ColumnDni.HeaderText = "DNI";
            this.ColumnDni.MinimumWidth = 6;
            this.ColumnDni.Name = "ColumnDni";
            // 
            // ColumnDireccion
            // 
            this.ColumnDireccion.HeaderText = "Dirección";
            this.ColumnDireccion.MinimumWidth = 6;
            this.ColumnDireccion.Name = "ColumnDireccion";
            // 
            // ColumnEmail
            // 
            this.ColumnEmail.HeaderText = "Email";
            this.ColumnEmail.MinimumWidth = 6;
            this.ColumnEmail.Name = "ColumnEmail";
            // 
            // ColumnTelefono
            // 
            this.ColumnTelefono.HeaderText = "Teléfono";
            this.ColumnTelefono.MinimumWidth = 6;
            this.ColumnTelefono.Name = "ColumnTelefono";
            // 
            // ColumnActivo
            // 
            this.ColumnActivo.HeaderText = "Activo";
            this.ColumnActivo.MinimumWidth = 6;
            this.ColumnActivo.Name = "ColumnActivo";
            // 
            // GestionClientesVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(760, 559);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GestionClientesVendedor";
            this.Text = "AgregarCliente";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.TextBox textBoxDni;
        private System.Windows.Forms.Label labelDni;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.UI.WinForms.BunifuDataGridView dataGridViewClientes;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Button buttonRegistrar;
        private System.Windows.Forms.Button buttonEliminarCliente;
        private System.Windows.Forms.Button buttonModificarCliente;
        private System.Windows.Forms.Button buttonBuscarCliente;
        private System.Windows.Forms.TextBox textBoxDniBuscar;
        private System.Windows.Forms.Label labelDniBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDni;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDireccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnActivo;
    }
}