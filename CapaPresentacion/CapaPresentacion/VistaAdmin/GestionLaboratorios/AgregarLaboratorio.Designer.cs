namespace Proyecto2022.CapaPresentacion.VistaAdmin.GestionLaboratorios
{
    partial class AgregarLaboratorio
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridLaboratorio = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonModificarLaboratorio = new System.Windows.Forms.Button();
            this.buttonRegistrarLaboratorio = new System.Windows.Forms.Button();
            this.textBoxNombreLaboratorio = new System.Windows.Forms.TextBox();
            this.labelLaboratorio = new System.Windows.Forms.Label();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.ColumnActivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLaboratorio)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(760, 559);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridLaboratorio);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 254);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(760, 305);
            this.panel3.TabIndex = 1;
            // 
            // dataGridLaboratorio
            // 
            this.dataGridLaboratorio.AllowCustomTheming = false;
            this.dataGridLaboratorio.AllowUserToAddRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.dataGridLaboratorio.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridLaboratorio.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridLaboratorio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridLaboratorio.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridLaboratorio.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridLaboratorio.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridLaboratorio.ColumnHeadersHeight = 40;
            this.dataGridLaboratorio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.ColumnNombre,
            this.ColumnActivo});
            this.dataGridLaboratorio.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dataGridLaboratorio.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dataGridLaboratorio.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridLaboratorio.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dataGridLaboratorio.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridLaboratorio.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dataGridLaboratorio.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dataGridLaboratorio.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dataGridLaboratorio.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dataGridLaboratorio.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridLaboratorio.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.dataGridLaboratorio.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridLaboratorio.CurrentTheme.Name = null;
            this.dataGridLaboratorio.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridLaboratorio.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dataGridLaboratorio.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridLaboratorio.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dataGridLaboratorio.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridLaboratorio.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridLaboratorio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridLaboratorio.EnableHeadersVisualStyles = false;
            this.dataGridLaboratorio.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dataGridLaboratorio.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dataGridLaboratorio.HeaderBgColor = System.Drawing.Color.Empty;
            this.dataGridLaboratorio.HeaderForeColor = System.Drawing.Color.White;
            this.dataGridLaboratorio.Location = new System.Drawing.Point(0, 0);
            this.dataGridLaboratorio.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridLaboratorio.Name = "dataGridLaboratorio";
            this.dataGridLaboratorio.RowHeadersVisible = false;
            this.dataGridLaboratorio.RowHeadersWidth = 51;
            this.dataGridLaboratorio.RowTemplate.Height = 40;
            this.dataGridLaboratorio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridLaboratorio.Size = new System.Drawing.Size(760, 305);
            this.dataGridLaboratorio.TabIndex = 0;
            this.dataGridLaboratorio.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.dataGridLaboratorio.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridLaboratorio_CellClick);
            // 
            // ColumnId
            // 
            this.ColumnId.HeaderText = "ID";
            this.ColumnId.MinimumWidth = 6;
            this.ColumnId.Name = "ColumnId";
            // 
            // ColumnNombre
            // 
            this.ColumnNombre.HeaderText = "Laboratorio";
            this.ColumnNombre.MinimumWidth = 6;
            this.ColumnNombre.Name = "ColumnNombre";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonEliminar);
            this.panel2.Controls.Add(this.buttonModificarLaboratorio);
            this.panel2.Controls.Add(this.buttonRegistrarLaboratorio);
            this.panel2.Controls.Add(this.textBoxNombreLaboratorio);
            this.panel2.Controls.Add(this.labelLaboratorio);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(760, 254);
            this.panel2.TabIndex = 0;
            // 
            // buttonModificarLaboratorio
            // 
            this.buttonModificarLaboratorio.Enabled = false;
            this.buttonModificarLaboratorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonModificarLaboratorio.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModificarLaboratorio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonModificarLaboratorio.Location = new System.Drawing.Point(283, 149);
            this.buttonModificarLaboratorio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonModificarLaboratorio.Name = "buttonModificarLaboratorio";
            this.buttonModificarLaboratorio.Size = new System.Drawing.Size(176, 38);
            this.buttonModificarLaboratorio.TabIndex = 27;
            this.buttonModificarLaboratorio.Text = "Modificar";
            this.buttonModificarLaboratorio.UseVisualStyleBackColor = true;
            this.buttonModificarLaboratorio.Click += new System.EventHandler(this.buttonModificarLaboratorio_Click);
            // 
            // buttonRegistrarLaboratorio
            // 
            this.buttonRegistrarLaboratorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegistrarLaboratorio.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegistrarLaboratorio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonRegistrarLaboratorio.Location = new System.Drawing.Point(83, 149);
            this.buttonRegistrarLaboratorio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonRegistrarLaboratorio.Name = "buttonRegistrarLaboratorio";
            this.buttonRegistrarLaboratorio.Size = new System.Drawing.Size(176, 38);
            this.buttonRegistrarLaboratorio.TabIndex = 26;
            this.buttonRegistrarLaboratorio.Text = "Registrar";
            this.buttonRegistrarLaboratorio.UseVisualStyleBackColor = true;
            this.buttonRegistrarLaboratorio.Click += new System.EventHandler(this.buttonRegistrarLaboratorio_Click);
            // 
            // textBoxNombreLaboratorio
            // 
            this.textBoxNombreLaboratorio.Location = new System.Drawing.Point(259, 99);
            this.textBoxNombreLaboratorio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxNombreLaboratorio.Multiline = true;
            this.textBoxNombreLaboratorio.Name = "textBoxNombreLaboratorio";
            this.textBoxNombreLaboratorio.Size = new System.Drawing.Size(212, 30);
            this.textBoxNombreLaboratorio.TabIndex = 17;
            this.textBoxNombreLaboratorio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNombreLaboratorio_KeyPress);
            // 
            // labelLaboratorio
            // 
            this.labelLaboratorio.AutoSize = true;
            this.labelLaboratorio.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLaboratorio.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelLaboratorio.Location = new System.Drawing.Point(239, 60);
            this.labelLaboratorio.Name = "labelLaboratorio";
            this.labelLaboratorio.Size = new System.Drawing.Size(252, 23);
            this.labelLaboratorio.TabIndex = 16;
            this.labelLaboratorio.Text = "Nombre del laboratorio";
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Enabled = false;
            this.buttonEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEliminar.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonEliminar.Location = new System.Drawing.Point(484, 149);
            this.buttonEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(176, 38);
            this.buttonEliminar.TabIndex = 28;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // ColumnActivo
            // 
            this.ColumnActivo.HeaderText = "Activo";
            this.ColumnActivo.MinimumWidth = 6;
            this.ColumnActivo.Name = "ColumnActivo";
            // 
            // AgregarLaboratorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(760, 559);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AgregarLaboratorio";
            this.Text = "AgregarLaboratorio";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLaboratorio)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBoxNombreLaboratorio;
        private System.Windows.Forms.Label labelLaboratorio;
        private System.Windows.Forms.Button buttonRegistrarLaboratorio;
        private Bunifu.UI.WinForms.BunifuDataGridView dataGridLaboratorio;
        private System.Windows.Forms.Button buttonModificarLaboratorio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNombre;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnActivo;
    }
}