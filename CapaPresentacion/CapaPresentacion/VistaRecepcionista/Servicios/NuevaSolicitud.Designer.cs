namespace CapaPresentacion.VistaRecepcionista.Servicios
{
    partial class NuevaSolicitud
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
            this.label6 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnFinalizarCompra = new System.Windows.Forms.Button();
            this.btnBuscarServicio = new System.Windows.Forms.Button();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.datagridCarrito = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnActivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelNombreC = new System.Windows.Forms.Label();
            this.labelApellidoC = new System.Windows.Forms.Label();
            this.labelDniC = new System.Windows.Forms.Label();
            this.labelEmailC = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridCarrito)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelTotal);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(587, 195);
            this.panel1.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 8.5F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(2, 178);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(301, 14);
            this.label6.TabIndex = 49;
            this.label6.Text = "Listado de servicios incluidos en la venta";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.btnFinalizarCompra);
            this.panel5.Controls.Add(this.btnBuscarServicio);
            this.panel5.Controls.Add(this.btnBuscarCliente);
            this.panel5.Location = new System.Drawing.Point(295, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(292, 162);
            this.panel5.TabIndex = 48;
            // 
            // btnFinalizarCompra
            // 
            this.btnFinalizarCompra.Enabled = false;
            this.btnFinalizarCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizarCompra.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizarCompra.ForeColor = System.Drawing.Color.Salmon;
            this.btnFinalizarCompra.Location = new System.Drawing.Point(18, 114);
            this.btnFinalizarCompra.Margin = new System.Windows.Forms.Padding(2);
            this.btnFinalizarCompra.Name = "btnFinalizarCompra";
            this.btnFinalizarCompra.Size = new System.Drawing.Size(262, 31);
            this.btnFinalizarCompra.TabIndex = 44;
            this.btnFinalizarCompra.Text = "Finalizar Compra";
            this.btnFinalizarCompra.UseVisualStyleBackColor = true;
            this.btnFinalizarCompra.Click += new System.EventHandler(this.btnFinalizarCompra_Click);
            // 
            // btnBuscarServicio
            // 
            this.btnBuscarServicio.Enabled = false;
            this.btnBuscarServicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarServicio.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarServicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnBuscarServicio.Location = new System.Drawing.Point(18, 67);
            this.btnBuscarServicio.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscarServicio.Name = "btnBuscarServicio";
            this.btnBuscarServicio.Size = new System.Drawing.Size(262, 31);
            this.btnBuscarServicio.TabIndex = 43;
            this.btnBuscarServicio.Text = "Buscar Servicio";
            this.btnBuscarServicio.UseVisualStyleBackColor = true;
            this.btnBuscarServicio.Click += new System.EventHandler(this.btnBuscarServicio_Click);
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Enabled = false;
            this.btnBuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarCliente.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnBuscarCliente.Location = new System.Drawing.Point(18, 19);
            this.btnBuscarCliente.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(262, 31);
            this.btnBuscarCliente.TabIndex = 42;
            this.btnBuscarCliente.Text = "Buscar Cliente";
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.labelEmailC);
            this.panel4.Controls.Add(this.labelDniC);
            this.panel4.Controls.Add(this.labelApellidoC);
            this.panel4.Controls.Add(this.labelNombreC);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(3, 44);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(292, 121);
            this.panel4.TabIndex = 47;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(7, 33);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 19);
            this.label4.TabIndex = 44;
            this.label4.Text = "Apellido: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(7, 4);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 19);
            this.label3.TabIndex = 41;
            this.label3.Text = "Nombre: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(7, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 19);
            this.label2.TabIndex = 40;
            this.label2.Text = "DNI:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(7, 85);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 19);
            this.label1.TabIndex = 43;
            this.label1.Text = "Email:";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(292, 35);
            this.panel3.TabIndex = 46;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(102, 5);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 19);
            this.label5.TabIndex = 45;
            this.label5.Text = "Cliente";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.datagridCarrito);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 195);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(587, 260);
            this.panel2.TabIndex = 1;
            // 
            // datagridCarrito
            // 
            this.datagridCarrito.AllowCustomTheming = false;
            this.datagridCarrito.AllowUserToAddRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.datagridCarrito.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.datagridCarrito.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridCarrito.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagridCarrito.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.datagridCarrito.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridCarrito.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.datagridCarrito.ColumnHeadersHeight = 40;
            this.datagridCarrito.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.ColumnNombre,
            this.ColumnPrecio,
            this.ColumnCategoria,
            this.ColumnActivo});
            this.datagridCarrito.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.datagridCarrito.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.datagridCarrito.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.datagridCarrito.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.datagridCarrito.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.datagridCarrito.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.datagridCarrito.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.datagridCarrito.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.datagridCarrito.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.datagridCarrito.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.datagridCarrito.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.datagridCarrito.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.datagridCarrito.CurrentTheme.Name = null;
            this.datagridCarrito.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.datagridCarrito.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.datagridCarrito.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.datagridCarrito.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.datagridCarrito.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagridCarrito.DefaultCellStyle = dataGridViewCellStyle6;
            this.datagridCarrito.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datagridCarrito.EnableHeadersVisualStyles = false;
            this.datagridCarrito.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.datagridCarrito.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.datagridCarrito.HeaderBgColor = System.Drawing.Color.Empty;
            this.datagridCarrito.HeaderForeColor = System.Drawing.Color.White;
            this.datagridCarrito.Location = new System.Drawing.Point(0, 0);
            this.datagridCarrito.Margin = new System.Windows.Forms.Padding(2);
            this.datagridCarrito.Name = "datagridCarrito";
            this.datagridCarrito.RowHeadersVisible = false;
            this.datagridCarrito.RowHeadersWidth = 51;
            this.datagridCarrito.RowTemplate.Height = 40;
            this.datagridCarrito.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridCarrito.Size = new System.Drawing.Size(587, 260);
            this.datagridCarrito.TabIndex = 1;
            this.datagridCarrito.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // ColumnId
            // 
            this.ColumnId.HeaderText = "ID";
            this.ColumnId.MinimumWidth = 6;
            this.ColumnId.Name = "ColumnId";
            // 
            // ColumnNombre
            // 
            this.ColumnNombre.HeaderText = "Nombre";
            this.ColumnNombre.MinimumWidth = 6;
            this.ColumnNombre.Name = "ColumnNombre";
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
            // ColumnActivo
            // 
            this.ColumnActivo.HeaderText = "Activo";
            this.ColumnActivo.MinimumWidth = 6;
            this.ColumnActivo.Name = "ColumnActivo";
            // 
            // labelNombreC
            // 
            this.labelNombreC.AutoSize = true;
            this.labelNombreC.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreC.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelNombreC.Location = new System.Drawing.Point(73, 5);
            this.labelNombreC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNombreC.Name = "labelNombreC";
            this.labelNombreC.Size = new System.Drawing.Size(18, 19);
            this.labelNombreC.TabIndex = 42;
            this.labelNombreC.Text = "N";
            this.labelNombreC.Visible = false;
            // 
            // labelApellidoC
            // 
            this.labelApellidoC.AutoSize = true;
            this.labelApellidoC.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelApellidoC.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelApellidoC.Location = new System.Drawing.Point(98, 33);
            this.labelApellidoC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelApellidoC.Name = "labelApellidoC";
            this.labelApellidoC.Size = new System.Drawing.Size(18, 19);
            this.labelApellidoC.TabIndex = 45;
            this.labelApellidoC.Text = "A";
            this.labelApellidoC.Visible = false;
            // 
            // labelDniC
            // 
            this.labelDniC.AutoSize = true;
            this.labelDniC.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDniC.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelDniC.Location = new System.Drawing.Point(52, 60);
            this.labelDniC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDniC.Name = "labelDniC";
            this.labelDniC.Size = new System.Drawing.Size(18, 19);
            this.labelDniC.TabIndex = 46;
            this.labelDniC.Text = "D";
            this.labelDniC.Visible = false;
            // 
            // labelEmailC
            // 
            this.labelEmailC.AutoSize = true;
            this.labelEmailC.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmailC.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelEmailC.Location = new System.Drawing.Point(72, 85);
            this.labelEmailC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEmailC.Name = "labelEmailC";
            this.labelEmailC.Size = new System.Drawing.Size(18, 19);
            this.labelEmailC.TabIndex = 47;
            this.labelEmailC.Text = "E";
            this.labelEmailC.Visible = false;
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelTotal.Location = new System.Drawing.Point(383, 168);
            this.labelTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(72, 19);
            this.labelTotal.TabIndex = 44;
            this.labelTotal.Text = "Total: ";
            // 
            // NuevaSolicitud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(587, 455);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NuevaSolicitud";
            this.Text = "NuevaSolicitud";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagridCarrito)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.UI.WinForms.BunifuDataGridView datagridCarrito;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnActivo;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnFinalizarCompra;
        private System.Windows.Forms.Button btnBuscarServicio;
        private System.Windows.Forms.Label labelNombreC;
        private System.Windows.Forms.Label labelDniC;
        private System.Windows.Forms.Label labelApellidoC;
        private System.Windows.Forms.Label labelEmailC;
        private System.Windows.Forms.Label labelTotal;
    }
}