namespace CapaPresentacion.CapaPresentacion.VistaAdmin.GestionEmpleado
{
    partial class GestionEmpleadosA
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
            this.dataGridViewEmpleados = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.ColumnActivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTitulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnLaboratorio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.labelLaboratorio = new System.Windows.Forms.Label();
            this.comboBoxLaboratorio = new System.Windows.Forms.ComboBox();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.textBoxTitulo = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelTelefono = new System.Windows.Forms.Label();
            this.textBoxTelefono = new System.Windows.Forms.TextBox();
            this.labelDni = new System.Windows.Forms.Label();
            this.textBoxDni = new System.Windows.Forms.TextBox();
            this.labelApellido = new System.Windows.Forms.Label();
            this.textBoxApellido = new System.Windows.Forms.TextBox();
            this.labelNombre = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.buttonRegistrarUsuario = new System.Windows.Forms.Button();
            this.buttonModificar = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.textBoxDniBuscar = new System.Windows.Forms.TextBox();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.buttonBuscar);
            this.panel1.Controls.Add(this.textBoxDniBuscar);
            this.panel1.Controls.Add(this.buttonEliminar);
            this.panel1.Controls.Add(this.buttonModificar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.labelLaboratorio);
            this.panel1.Controls.Add(this.comboBoxLaboratorio);
            this.panel1.Controls.Add(this.labelTitulo);
            this.panel1.Controls.Add(this.textBoxTitulo);
            this.panel1.Controls.Add(this.labelEmail);
            this.panel1.Controls.Add(this.textBoxEmail);
            this.panel1.Controls.Add(this.labelTelefono);
            this.panel1.Controls.Add(this.textBoxTelefono);
            this.panel1.Controls.Add(this.labelDni);
            this.panel1.Controls.Add(this.textBoxDni);
            this.panel1.Controls.Add(this.labelApellido);
            this.panel1.Controls.Add(this.textBoxApellido);
            this.panel1.Controls.Add(this.labelNombre);
            this.panel1.Controls.Add(this.textBoxNombre);
            this.panel1.Controls.Add(this.buttonRegistrarUsuario);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(760, 318);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridViewEmpleados);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 318);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(760, 241);
            this.panel2.TabIndex = 1;
            // 
            // dataGridViewEmpleados
            // 
            this.dataGridViewEmpleados.AllowCustomTheming = false;
            this.dataGridViewEmpleados.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewEmpleados.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewEmpleados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewEmpleados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewEmpleados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewEmpleados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewEmpleados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewEmpleados.ColumnHeadersHeight = 40;
            this.dataGridViewEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnActivo,
            this.ColumnName,
            this.ColumnSurname,
            this.ColumnDni,
            this.ColumnTelefono,
            this.ColumnEmail,
            this.ColumnTitulo,
            this.ColumnLaboratorio});
            this.dataGridViewEmpleados.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dataGridViewEmpleados.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dataGridViewEmpleados.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewEmpleados.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dataGridViewEmpleados.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewEmpleados.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dataGridViewEmpleados.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dataGridViewEmpleados.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dataGridViewEmpleados.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dataGridViewEmpleados.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridViewEmpleados.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.dataGridViewEmpleados.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewEmpleados.CurrentTheme.Name = null;
            this.dataGridViewEmpleados.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridViewEmpleados.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dataGridViewEmpleados.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewEmpleados.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dataGridViewEmpleados.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewEmpleados.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewEmpleados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewEmpleados.EnableHeadersVisualStyles = false;
            this.dataGridViewEmpleados.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dataGridViewEmpleados.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dataGridViewEmpleados.HeaderBgColor = System.Drawing.Color.Empty;
            this.dataGridViewEmpleados.HeaderForeColor = System.Drawing.Color.White;
            this.dataGridViewEmpleados.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewEmpleados.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewEmpleados.Name = "dataGridViewEmpleados";
            this.dataGridViewEmpleados.RowHeadersVisible = false;
            this.dataGridViewEmpleados.RowHeadersWidth = 51;
            this.dataGridViewEmpleados.RowTemplate.Height = 40;
            this.dataGridViewEmpleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewEmpleados.Size = new System.Drawing.Size(760, 241);
            this.dataGridViewEmpleados.TabIndex = 7;
            this.dataGridViewEmpleados.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.dataGridViewEmpleados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEmpleados_CellClick);
            // 
            // ColumnActivo
            // 
            this.ColumnActivo.HeaderText = "Activo";
            this.ColumnActivo.MinimumWidth = 6;
            this.ColumnActivo.Name = "ColumnActivo";
            // 
            // ColumnName
            // 
            this.ColumnName.HeaderText = "Nombre";
            this.ColumnName.MinimumWidth = 6;
            this.ColumnName.Name = "ColumnName";
            // 
            // ColumnSurname
            // 
            this.ColumnSurname.HeaderText = "Apellido";
            this.ColumnSurname.MinimumWidth = 6;
            this.ColumnSurname.Name = "ColumnSurname";
            // 
            // ColumnDni
            // 
            this.ColumnDni.HeaderText = "DNI";
            this.ColumnDni.MinimumWidth = 6;
            this.ColumnDni.Name = "ColumnDni";
            // 
            // ColumnTelefono
            // 
            this.ColumnTelefono.HeaderText = "Tel.";
            this.ColumnTelefono.MinimumWidth = 6;
            this.ColumnTelefono.Name = "ColumnTelefono";
            // 
            // ColumnEmail
            // 
            this.ColumnEmail.HeaderText = "Email";
            this.ColumnEmail.MinimumWidth = 6;
            this.ColumnEmail.Name = "ColumnEmail";
            // 
            // ColumnTitulo
            // 
            this.ColumnTitulo.HeaderText = "Titulo";
            this.ColumnTitulo.MinimumWidth = 6;
            this.ColumnTitulo.Name = "ColumnTitulo";
            // 
            // ColumnLaboratorio
            // 
            this.ColumnLaboratorio.HeaderText = "Lab.";
            this.ColumnLaboratorio.MinimumWidth = 6;
            this.ColumnLaboratorio.Name = "ColumnLaboratorio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(538, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 14);
            this.label1.TabIndex = 76;
            this.label1.Text = "Dejar vacío si no corresponde";
            // 
            // labelLaboratorio
            // 
            this.labelLaboratorio.AutoSize = true;
            this.labelLaboratorio.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLaboratorio.ForeColor = System.Drawing.Color.White;
            this.labelLaboratorio.Location = new System.Drawing.Point(572, 97);
            this.labelLaboratorio.Name = "labelLaboratorio";
            this.labelLaboratorio.Size = new System.Drawing.Size(120, 22);
            this.labelLaboratorio.TabIndex = 75;
            this.labelLaboratorio.Text = "Laboratorio";
            // 
            // comboBoxLaboratorio
            // 
            this.comboBoxLaboratorio.FormattingEnabled = true;
            this.comboBoxLaboratorio.Location = new System.Drawing.Point(565, 123);
            this.comboBoxLaboratorio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxLaboratorio.Name = "comboBoxLaboratorio";
            this.comboBoxLaboratorio.Size = new System.Drawing.Size(145, 24);
            this.comboBoxLaboratorio.TabIndex = 74;
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.ForeColor = System.Drawing.Color.White;
            this.labelTitulo.Location = new System.Drawing.Point(390, 91);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(70, 22);
            this.labelTitulo.TabIndex = 73;
            this.labelTitulo.Text = "Titulo";
            // 
            // textBoxTitulo
            // 
            this.textBoxTitulo.Location = new System.Drawing.Point(394, 122);
            this.textBoxTitulo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxTitulo.Multiline = true;
            this.textBoxTitulo.Name = "textBoxTitulo";
            this.textBoxTitulo.Size = new System.Drawing.Size(131, 29);
            this.textBoxTitulo.TabIndex = 72;
            this.textBoxTitulo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTitulo_KeyPress);
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.ForeColor = System.Drawing.Color.White;
            this.labelEmail.Location = new System.Drawing.Point(390, 176);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(60, 22);
            this.labelEmail.TabIndex = 71;
            this.labelEmail.Text = "Email";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(394, 207);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxEmail.Multiline = true;
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(131, 29);
            this.textBoxEmail.TabIndex = 70;
            // 
            // labelTelefono
            // 
            this.labelTelefono.AutoSize = true;
            this.labelTelefono.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTelefono.ForeColor = System.Drawing.Color.White;
            this.labelTelefono.Location = new System.Drawing.Point(222, 175);
            this.labelTelefono.Name = "labelTelefono";
            this.labelTelefono.Size = new System.Drawing.Size(90, 22);
            this.labelTelefono.TabIndex = 69;
            this.labelTelefono.Text = "Telefono";
            // 
            // textBoxTelefono
            // 
            this.textBoxTelefono.Location = new System.Drawing.Point(226, 206);
            this.textBoxTelefono.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxTelefono.Multiline = true;
            this.textBoxTelefono.Name = "textBoxTelefono";
            this.textBoxTelefono.Size = new System.Drawing.Size(131, 29);
            this.textBoxTelefono.TabIndex = 68;
            this.textBoxTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTelefono_KeyPress);
            // 
            // labelDni
            // 
            this.labelDni.AutoSize = true;
            this.labelDni.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDni.ForeColor = System.Drawing.Color.White;
            this.labelDni.Location = new System.Drawing.Point(390, 5);
            this.labelDni.Name = "labelDni";
            this.labelDni.Size = new System.Drawing.Size(40, 22);
            this.labelDni.TabIndex = 67;
            this.labelDni.Text = "DNI";
            // 
            // textBoxDni
            // 
            this.textBoxDni.Location = new System.Drawing.Point(393, 36);
            this.textBoxDni.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxDni.Multiline = true;
            this.textBoxDni.Name = "textBoxDni";
            this.textBoxDni.Size = new System.Drawing.Size(132, 29);
            this.textBoxDni.TabIndex = 66;
            this.textBoxDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDni_KeyPress);
            // 
            // labelApellido
            // 
            this.labelApellido.AutoSize = true;
            this.labelApellido.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelApellido.ForeColor = System.Drawing.Color.White;
            this.labelApellido.Location = new System.Drawing.Point(222, 90);
            this.labelApellido.Name = "labelApellido";
            this.labelApellido.Size = new System.Drawing.Size(90, 22);
            this.labelApellido.TabIndex = 65;
            this.labelApellido.Text = "Apellido";
            // 
            // textBoxApellido
            // 
            this.textBoxApellido.Location = new System.Drawing.Point(226, 121);
            this.textBoxApellido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxApellido.Multiline = true;
            this.textBoxApellido.Name = "textBoxApellido";
            this.textBoxApellido.Size = new System.Drawing.Size(131, 29);
            this.textBoxApellido.TabIndex = 64;
            this.textBoxApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxApellido_KeyPress);
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.ForeColor = System.Drawing.Color.White;
            this.labelNombre.Location = new System.Drawing.Point(221, 4);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(70, 22);
            this.labelNombre.TabIndex = 63;
            this.labelNombre.Text = "Nombre";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(225, 36);
            this.textBoxNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxNombre.Multiline = true;
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(131, 29);
            this.textBoxNombre.TabIndex = 62;
            this.textBoxNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNombre_KeyPress);
            // 
            // buttonRegistrarUsuario
            // 
            this.buttonRegistrarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegistrarUsuario.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegistrarUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonRegistrarUsuario.Location = new System.Drawing.Point(180, 264);
            this.buttonRegistrarUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonRegistrarUsuario.Name = "buttonRegistrarUsuario";
            this.buttonRegistrarUsuario.Size = new System.Drawing.Size(176, 38);
            this.buttonRegistrarUsuario.TabIndex = 61;
            this.buttonRegistrarUsuario.Text = "Registrar";
            this.buttonRegistrarUsuario.UseVisualStyleBackColor = true;
            this.buttonRegistrarUsuario.Click += new System.EventHandler(this.buttonRegistrarUsuario_Click);
            // 
            // buttonModificar
            // 
            this.buttonModificar.Enabled = false;
            this.buttonModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonModificar.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModificar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonModificar.Location = new System.Drawing.Point(376, 264);
            this.buttonModificar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(176, 38);
            this.buttonModificar.TabIndex = 77;
            this.buttonModificar.Text = "Modificar";
            this.buttonModificar.UseVisualStyleBackColor = true;
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Enabled = false;
            this.buttonEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEliminar.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonEliminar.Location = new System.Drawing.Point(565, 264);
            this.buttonEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(176, 38);
            this.buttonEliminar.TabIndex = 78;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            // 
            // textBoxDniBuscar
            // 
            this.textBoxDniBuscar.Location = new System.Drawing.Point(32, 123);
            this.textBoxDniBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxDniBuscar.Multiline = true;
            this.textBoxDniBuscar.Name = "textBoxDniBuscar";
            this.textBoxDniBuscar.Size = new System.Drawing.Size(131, 29);
            this.textBoxDniBuscar.TabIndex = 79;
            this.textBoxDniBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDniBuscar_KeyPress);
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuscar.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonBuscar.Location = new System.Drawing.Point(12, 156);
            this.buttonBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(176, 38);
            this.buttonBuscar.TabIndex = 80;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(78, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 22);
            this.label2.TabIndex = 81;
            this.label2.Text = "DNI";
            // 
            // GestionEmpleadosA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(760, 559);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GestionEmpleadosA";
            this.Text = "GestionEmpleadosA";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmpleados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.UI.WinForms.BunifuDataGridView dataGridViewEmpleados;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnActivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDni;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTitulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnLaboratorio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelLaboratorio;
        private System.Windows.Forms.ComboBox comboBoxLaboratorio;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.TextBox textBoxTitulo;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelTelefono;
        private System.Windows.Forms.TextBox textBoxTelefono;
        private System.Windows.Forms.Label labelDni;
        private System.Windows.Forms.TextBox textBoxDni;
        private System.Windows.Forms.Label labelApellido;
        private System.Windows.Forms.TextBox textBoxApellido;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Button buttonRegistrarUsuario;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonModificar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.TextBox textBoxDniBuscar;
    }
}