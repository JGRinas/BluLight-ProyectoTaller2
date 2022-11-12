namespace CapaPresentacion.VistaRecepcionista.Jornadas
{
    partial class Bajas
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
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelDni = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelJornada = new System.Windows.Forms.Label();
            this.btnBuscarJornada = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxJornada = new System.Windows.Forms.TextBox();
            this.btnBajaJornada = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonRegistrarAuditorio = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxBuscarDni = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.datagridJornadas = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnHora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnJefeLab = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAuditorio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridJornadas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelNombre);
            this.panel1.Controls.Add(this.labelDni);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.labelJornada);
            this.panel1.Controls.Add(this.btnBuscarJornada);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBoxJornada);
            this.panel1.Controls.Add(this.btnBajaJornada);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.buttonRegistrarAuditorio);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBoxBuscarDni);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(587, 224);
            this.panel1.TabIndex = 0;
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelNombre.Location = new System.Drawing.Point(168, 108);
            this.labelNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(18, 19);
            this.labelNombre.TabIndex = 37;
            this.labelNombre.Text = "N";
            this.labelNombre.Visible = false;
            // 
            // labelDni
            // 
            this.labelDni.AutoSize = true;
            this.labelDni.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDni.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelDni.Location = new System.Drawing.Point(60, 148);
            this.labelDni.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDni.Name = "labelDni";
            this.labelDni.Size = new System.Drawing.Size(18, 19);
            this.labelDni.TabIndex = 36;
            this.labelDni.Text = "D";
            this.labelDni.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(11, 148);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 19);
            this.label5.TabIndex = 35;
            this.label5.Text = "DNI: ";
            // 
            // labelJornada
            // 
            this.labelJornada.AutoSize = true;
            this.labelJornada.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJornada.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelJornada.Location = new System.Drawing.Point(96, 169);
            this.labelJornada.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelJornada.Name = "labelJornada";
            this.labelJornada.Size = new System.Drawing.Size(18, 19);
            this.labelJornada.TabIndex = 34;
            this.labelJornada.Text = "J";
            this.labelJornada.Visible = false;
            // 
            // btnBuscarJornada
            // 
            this.btnBuscarJornada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarJornada.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarJornada.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnBuscarJornada.Location = new System.Drawing.Point(319, 87);
            this.btnBuscarJornada.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscarJornada.Name = "btnBuscarJornada";
            this.btnBuscarJornada.Size = new System.Drawing.Size(132, 31);
            this.btnBuscarJornada.TabIndex = 33;
            this.btnBuscarJornada.Text = "Buscar";
            this.btnBuscarJornada.UseVisualStyleBackColor = true;
            this.btnBuscarJornada.Click += new System.EventHandler(this.btnBuscarJornada_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(309, 5);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 19);
            this.label4.TabIndex = 32;
            this.label4.Text = "Nombre de jornada";
            // 
            // textBoxJornada
            // 
            this.textBoxJornada.Location = new System.Drawing.Point(279, 26);
            this.textBoxJornada.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxJornada.Multiline = true;
            this.textBoxJornada.Name = "textBoxJornada";
            this.textBoxJornada.Size = new System.Drawing.Size(214, 57);
            this.textBoxJornada.TabIndex = 31;
            // 
            // btnBajaJornada
            // 
            this.btnBajaJornada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBajaJornada.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBajaJornada.ForeColor = System.Drawing.Color.Tomato;
            this.btnBajaJornada.Location = new System.Drawing.Point(319, 147);
            this.btnBajaJornada.Margin = new System.Windows.Forms.Padding(2);
            this.btnBajaJornada.Name = "btnBajaJornada";
            this.btnBajaJornada.Size = new System.Drawing.Size(132, 31);
            this.btnBajaJornada.TabIndex = 30;
            this.btnBajaJornada.Text = "Dar de baja";
            this.btnBajaJornada.UseVisualStyleBackColor = true;
            this.btnBajaJornada.Click += new System.EventHandler(this.btnBajaJornada_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(11, 108);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 19);
            this.label3.TabIndex = 29;
            this.label3.Text = "Nombre completo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(11, 169);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 19);
            this.label2.TabIndex = 28;
            this.label2.Text = "Jornada:";
            // 
            // buttonRegistrarAuditorio
            // 
            this.buttonRegistrarAuditorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegistrarAuditorio.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegistrarAuditorio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonRegistrarAuditorio.Location = new System.Drawing.Point(83, 52);
            this.buttonRegistrarAuditorio.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRegistrarAuditorio.Name = "buttonRegistrarAuditorio";
            this.buttonRegistrarAuditorio.Size = new System.Drawing.Size(132, 31);
            this.buttonRegistrarAuditorio.TabIndex = 27;
            this.buttonRegistrarAuditorio.Text = "Buscar";
            this.buttonRegistrarAuditorio.UseVisualStyleBackColor = true;
            this.buttonRegistrarAuditorio.Click += new System.EventHandler(this.btnBuscarDni_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(133, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "DNI";
            // 
            // textBoxBuscarDni
            // 
            this.textBoxBuscarDni.Location = new System.Drawing.Point(83, 26);
            this.textBoxBuscarDni.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxBuscarDni.Multiline = true;
            this.textBoxBuscarDni.Name = "textBoxBuscarDni";
            this.textBoxBuscarDni.Size = new System.Drawing.Size(134, 22);
            this.textBoxBuscarDni.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.datagridJornadas);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 224);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(587, 231);
            this.panel2.TabIndex = 1;
            // 
            // datagridJornadas
            // 
            this.datagridJornadas.AllowCustomTheming = false;
            this.datagridJornadas.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.datagridJornadas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.datagridJornadas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridJornadas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagridJornadas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.datagridJornadas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridJornadas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.datagridJornadas.ColumnHeadersHeight = 40;
            this.datagridJornadas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.ColumnNombre,
            this.ColumnCupo,
            this.ColumnFecha,
            this.ColumnHora,
            this.ColumnJefeLab,
            this.ColumnAuditorio});
            this.datagridJornadas.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.datagridJornadas.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.datagridJornadas.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.datagridJornadas.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.datagridJornadas.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.datagridJornadas.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.datagridJornadas.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.datagridJornadas.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.datagridJornadas.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.datagridJornadas.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.datagridJornadas.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.datagridJornadas.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.datagridJornadas.CurrentTheme.Name = null;
            this.datagridJornadas.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.datagridJornadas.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.datagridJornadas.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.datagridJornadas.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.datagridJornadas.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagridJornadas.DefaultCellStyle = dataGridViewCellStyle3;
            this.datagridJornadas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datagridJornadas.EnableHeadersVisualStyles = false;
            this.datagridJornadas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.datagridJornadas.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.datagridJornadas.HeaderBgColor = System.Drawing.Color.Empty;
            this.datagridJornadas.HeaderForeColor = System.Drawing.Color.White;
            this.datagridJornadas.Location = new System.Drawing.Point(0, 0);
            this.datagridJornadas.Margin = new System.Windows.Forms.Padding(2);
            this.datagridJornadas.Name = "datagridJornadas";
            this.datagridJornadas.RowHeadersVisible = false;
            this.datagridJornadas.RowHeadersWidth = 51;
            this.datagridJornadas.RowTemplate.Height = 40;
            this.datagridJornadas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridJornadas.Size = new System.Drawing.Size(587, 231);
            this.datagridJornadas.TabIndex = 1;
            this.datagridJornadas.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.datagridJornadas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridJornadas_CellClick);
            this.datagridJornadas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridJornadas_CellClick);
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
            // Bajas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(587, 455);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Bajas";
            this.Text = "Bajas";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagridJornadas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.UI.WinForms.BunifuDataGridView datagridJornadas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCupo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnHora;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnJefeLab;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAuditorio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxBuscarDni;
        private System.Windows.Forms.Button btnBajaJornada;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonRegistrarAuditorio;
        private System.Windows.Forms.Button btnBuscarJornada;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxJornada;
        private System.Windows.Forms.Label labelJornada;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelDni;
    }
}