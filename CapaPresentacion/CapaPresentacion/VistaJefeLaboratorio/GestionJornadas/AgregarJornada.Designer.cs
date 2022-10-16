namespace Proyecto2022.CapaPresentacion.VistaJefeLaboratorio.GestionCursos
{
    partial class AgregarJornada
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxAuditorios = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnRegistrarJornada = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerHora = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFecha = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCupo = new System.Windows.Forms.TextBox();
            this.Nombre = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridJornadas = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnHora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnJefeLab = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAuditorio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnEliminarJornada = new System.Windows.Forms.Button();
            this.btnModificarJornada = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridJornadas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnModificarJornada);
            this.panel1.Controls.Add(this.btnEliminarJornada);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.comboBoxAuditorios);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnRegistrarJornada);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dateTimePickerHora);
            this.panel1.Controls.Add(this.dateTimePickerFecha);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBoxCupo);
            this.panel1.Controls.Add(this.Nombre);
            this.panel1.Controls.Add(this.textBoxNombre);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(749, 324);
            this.panel1.TabIndex = 0;
            // 
            // comboBoxAuditorios
            // 
            this.comboBoxAuditorios.FormattingEnabled = true;
            this.comboBoxAuditorios.Location = new System.Drawing.Point(503, 101);
            this.comboBoxAuditorios.Name = "comboBoxAuditorios";
            this.comboBoxAuditorios.Size = new System.Drawing.Size(201, 24);
            this.comboBoxAuditorios.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(499, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 23);
            this.label5.TabIndex = 28;
            this.label5.Text = "Auditorio";
            // 
            // btnRegistrarJornada
            // 
            this.btnRegistrarJornada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarJornada.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarJornada.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnRegistrarJornada.Location = new System.Drawing.Point(74, 235);
            this.btnRegistrarJornada.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegistrarJornada.Name = "btnRegistrarJornada";
            this.btnRegistrarJornada.Size = new System.Drawing.Size(176, 38);
            this.btnRegistrarJornada.TabIndex = 26;
            this.btnRegistrarJornada.Text = "Registrar";
            this.btnRegistrarJornada.UseVisualStyleBackColor = true;
            this.btnRegistrarJornada.Click += new System.EventHandler(this.btnRegistrarJornada_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(332, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "Hora";
            // 
            // dateTimePickerHora
            // 
            this.dateTimePickerHora.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerHora.Location = new System.Drawing.Point(336, 128);
            this.dateTimePickerHora.Name = "dateTimePickerHora";
            this.dateTimePickerHora.Size = new System.Drawing.Size(96, 22);
            this.dateTimePickerHora.TabIndex = 7;
            // 
            // dateTimePickerFecha
            // 
            this.dateTimePickerFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFecha.Location = new System.Drawing.Point(336, 49);
            this.dateTimePickerFecha.Name = "dateTimePickerFecha";
            this.dateTimePickerFecha.Size = new System.Drawing.Size(116, 22);
            this.dateTimePickerFecha.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(332, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Fecha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(43, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cupo";
            // 
            // textBoxCupo
            // 
            this.textBoxCupo.Location = new System.Drawing.Point(47, 175);
            this.textBoxCupo.Multiline = true;
            this.textBoxCupo.Name = "textBoxCupo";
            this.textBoxCupo.Size = new System.Drawing.Size(177, 26);
            this.textBoxCupo.TabIndex = 2;
            this.textBoxCupo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCupo_KeyPress);
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Nombre.Location = new System.Drawing.Point(42, 18);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(76, 23);
            this.Nombre.TabIndex = 1;
            this.Nombre.Text = "Nombre";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(46, 44);
            this.textBoxNombre.Multiline = true;
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(232, 71);
            this.textBoxNombre.TabIndex = 0;
            this.textBoxNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNombre_KeyPress);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridJornadas);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 324);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(749, 237);
            this.panel2.TabIndex = 1;
            // 
            // dataGridJornadas
            // 
            this.dataGridJornadas.AllowCustomTheming = false;
            this.dataGridJornadas.AllowUserToAddRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.dataGridJornadas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridJornadas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridJornadas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridJornadas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridJornadas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridJornadas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridJornadas.ColumnHeadersHeight = 40;
            this.dataGridJornadas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.ColumnNombre,
            this.ColumnCupo,
            this.ColumnFecha,
            this.ColumnHora,
            this.ColumnJefeLab,
            this.ColumnAuditorio});
            this.dataGridJornadas.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dataGridJornadas.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dataGridJornadas.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridJornadas.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dataGridJornadas.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridJornadas.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dataGridJornadas.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dataGridJornadas.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dataGridJornadas.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dataGridJornadas.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridJornadas.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.dataGridJornadas.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridJornadas.CurrentTheme.Name = null;
            this.dataGridJornadas.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridJornadas.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dataGridJornadas.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridJornadas.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dataGridJornadas.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridJornadas.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridJornadas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridJornadas.EnableHeadersVisualStyles = false;
            this.dataGridJornadas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dataGridJornadas.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dataGridJornadas.HeaderBgColor = System.Drawing.Color.Empty;
            this.dataGridJornadas.HeaderForeColor = System.Drawing.Color.White;
            this.dataGridJornadas.Location = new System.Drawing.Point(0, 0);
            this.dataGridJornadas.Name = "dataGridJornadas";
            this.dataGridJornadas.RowHeadersVisible = false;
            this.dataGridJornadas.RowHeadersWidth = 51;
            this.dataGridJornadas.RowTemplate.Height = 40;
            this.dataGridJornadas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridJornadas.Size = new System.Drawing.Size(749, 237);
            this.dataGridJornadas.TabIndex = 0;
            this.dataGridJornadas.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.dataGridJornadas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridJornadas_CellClick);
            // 
            // ColumnId
            // 
            this.ColumnId.HeaderText = "Id";
            this.ColumnId.MinimumWidth = 6;
            this.ColumnId.Name = "ColumnId";
            // 
            // ColumnNombre
            // 
            this.ColumnNombre.HeaderText = "Nombre";
            this.ColumnNombre.MinimumWidth = 6;
            this.ColumnNombre.Name = "ColumnNombre";
            // 
            // ColumnCupo
            // 
            this.ColumnCupo.HeaderText = "Cupo";
            this.ColumnCupo.MinimumWidth = 6;
            this.ColumnCupo.Name = "ColumnCupo";
            // 
            // ColumnFecha
            // 
            this.ColumnFecha.HeaderText = "Fecha";
            this.ColumnFecha.MinimumWidth = 6;
            this.ColumnFecha.Name = "ColumnFecha";
            // 
            // ColumnHora
            // 
            this.ColumnHora.HeaderText = "Hora";
            this.ColumnHora.MinimumWidth = 6;
            this.ColumnHora.Name = "ColumnHora";
            // 
            // ColumnJefeLab
            // 
            this.ColumnJefeLab.HeaderText = "Jefe Lab.";
            this.ColumnJefeLab.MinimumWidth = 6;
            this.ColumnJefeLab.Name = "ColumnJefeLab";
            // 
            // ColumnAuditorio
            // 
            this.ColumnAuditorio.HeaderText = "Auditorio";
            this.ColumnAuditorio.MinimumWidth = 6;
            this.ColumnAuditorio.Name = "ColumnAuditorio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(3, 304);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(220, 16);
            this.label4.TabIndex = 31;
            this.label4.Text = "Listado de Jornadas del laboratorio";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(44, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 16);
            this.label6.TabIndex = 32;
            this.label6.Text = "Máx. 150 caracteres";
            // 
            // btnEliminarJornada
            // 
            this.btnEliminarJornada.Enabled = false;
            this.btnEliminarJornada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarJornada.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarJornada.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnEliminarJornada.Location = new System.Drawing.Point(483, 235);
            this.btnEliminarJornada.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminarJornada.Name = "btnEliminarJornada";
            this.btnEliminarJornada.Size = new System.Drawing.Size(176, 38);
            this.btnEliminarJornada.TabIndex = 33;
            this.btnEliminarJornada.Text = "Eliminar";
            this.btnEliminarJornada.UseVisualStyleBackColor = true;
            // 
            // btnModificarJornada
            // 
            this.btnModificarJornada.Enabled = false;
            this.btnModificarJornada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarJornada.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarJornada.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnModificarJornada.Location = new System.Drawing.Point(276, 235);
            this.btnModificarJornada.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModificarJornada.Name = "btnModificarJornada";
            this.btnModificarJornada.Size = new System.Drawing.Size(176, 38);
            this.btnModificarJornada.TabIndex = 34;
            this.btnModificarJornada.Text = "Modificar";
            this.btnModificarJornada.UseVisualStyleBackColor = true;
            // 
            // AgregarJornada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(749, 561);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AgregarJornada";
            this.Text = "AgregarCurso";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridJornadas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.UI.WinForms.BunifuDataGridView dataGridJornadas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCupo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnHora;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnJefeLab;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAuditorio;
        private System.Windows.Forms.DateTimePicker dateTimePickerFecha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCupo;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePickerHora;
        private System.Windows.Forms.ComboBox comboBoxAuditorios;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnRegistrarJornada;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnModificarJornada;
        private System.Windows.Forms.Button btnEliminarJornada;
    }
}