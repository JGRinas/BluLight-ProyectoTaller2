namespace CapaPresentacion.CapaPresentacion.VistaRecepcionista.Servicios.Childrenforms
{
    partial class FinalizarCompra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FinalizarCompra));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties9 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties10 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties11 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties12 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelNombreServicio = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnAgregarServicio = new System.Windows.Forms.Button();
            this.labelVendedor = new System.Windows.Forms.Label();
            this.labelDni = new System.Windows.Forms.Label();
            this.labelCliente = new System.Windows.Forms.Label();
            this.textBoxServicios = new Bunifu.UI.WinForms.BunifuTextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.textBoxServicios);
            this.panel1.Controls.Add(this.labelNombreServicio);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(494, 208);
            this.panel1.TabIndex = 0;
            // 
            // labelNombreServicio
            // 
            this.labelNombreServicio.AutoSize = true;
            this.labelNombreServicio.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreServicio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelNombreServicio.Location = new System.Drawing.Point(10, 15);
            this.labelNombreServicio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNombreServicio.Name = "labelNombreServicio";
            this.labelNombreServicio.Size = new System.Drawing.Size(225, 19);
            this.labelNombreServicio.TabIndex = 64;
            this.labelNombreServicio.Text = "Solicitudes de servicios";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.labelVendedor);
            this.panel2.Controls.Add(this.labelDni);
            this.panel2.Controls.Add(this.labelCliente);
            this.panel2.Location = new System.Drawing.Point(0, 208);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(494, 241);
            this.panel2.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(127, 121);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(212, 21);
            this.comboBox1.TabIndex = 70;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(164, 99);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 19);
            this.label1.TabIndex = 69;
            this.label1.Text = "Método de pago";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnAgregarServicio);
            this.panel3.Location = new System.Drawing.Point(2, 155);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(488, 82);
            this.panel3.TabIndex = 68;
            // 
            // btnAgregarServicio
            // 
            this.btnAgregarServicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarServicio.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarServicio.ForeColor = System.Drawing.Color.Tomato;
            this.btnAgregarServicio.Location = new System.Drawing.Point(124, 25);
            this.btnAgregarServicio.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarServicio.Name = "btnAgregarServicio";
            this.btnAgregarServicio.Size = new System.Drawing.Size(215, 31);
            this.btnAgregarServicio.TabIndex = 69;
            this.btnAgregarServicio.Text = "Finalizar Venta";
            this.btnAgregarServicio.UseVisualStyleBackColor = true;
            this.btnAgregarServicio.Click += new System.EventHandler(this.buttonFinalizarCompra_Click);
            // 
            // labelVendedor
            // 
            this.labelVendedor.AutoSize = true;
            this.labelVendedor.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVendedor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelVendedor.Location = new System.Drawing.Point(19, 70);
            this.labelVendedor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelVendedor.Name = "labelVendedor";
            this.labelVendedor.Size = new System.Drawing.Size(99, 19);
            this.labelVendedor.TabIndex = 67;
            this.labelVendedor.Text = "Vendedor: ";
            // 
            // labelDni
            // 
            this.labelDni.AutoSize = true;
            this.labelDni.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDni.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelDni.Location = new System.Drawing.Point(19, 39);
            this.labelDni.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDni.Name = "labelDni";
            this.labelDni.Size = new System.Drawing.Size(54, 19);
            this.labelDni.TabIndex = 66;
            this.labelDni.Text = "DNI: ";
            // 
            // labelCliente
            // 
            this.labelCliente.AutoSize = true;
            this.labelCliente.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCliente.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelCliente.Location = new System.Drawing.Point(19, 11);
            this.labelCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCliente.Name = "labelCliente";
            this.labelCliente.Size = new System.Drawing.Size(90, 19);
            this.labelCliente.TabIndex = 65;
            this.labelCliente.Text = "Cliente: ";
            // 
            // textBoxServicios
            // 
            this.textBoxServicios.AcceptsReturn = false;
            this.textBoxServicios.AcceptsTab = false;
            this.textBoxServicios.AnimationSpeed = 200;
            this.textBoxServicios.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.textBoxServicios.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.textBoxServicios.AutoSizeHeight = true;
            this.textBoxServicios.BackColor = System.Drawing.Color.White;
            this.textBoxServicios.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("textBoxServicios.BackgroundImage")));
            this.textBoxServicios.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.textBoxServicios.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.textBoxServicios.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.textBoxServicios.BorderColorIdle = System.Drawing.Color.Navy;
            this.textBoxServicios.BorderRadius = 1;
            this.textBoxServicios.BorderThickness = 1;
            this.textBoxServicios.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.textBoxServicios.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxServicios.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.textBoxServicios.DefaultText = "";
            this.textBoxServicios.FillColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxServicios.HideSelection = true;
            this.textBoxServicios.IconLeft = null;
            this.textBoxServicios.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxServicios.IconPadding = 10;
            this.textBoxServicios.IconRight = null;
            this.textBoxServicios.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxServicios.Lines = new string[0];
            this.textBoxServicios.Location = new System.Drawing.Point(12, 37);
            this.textBoxServicios.MaxLength = 32767;
            this.textBoxServicios.MinimumSize = new System.Drawing.Size(1, 1);
            this.textBoxServicios.Modified = false;
            this.textBoxServicios.Multiline = false;
            this.textBoxServicios.Name = "textBoxServicios";
            stateProperties9.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties9.FillColor = System.Drawing.Color.Empty;
            stateProperties9.ForeColor = System.Drawing.Color.Empty;
            stateProperties9.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.textBoxServicios.OnActiveState = stateProperties9;
            stateProperties10.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties10.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties10.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.textBoxServicios.OnDisabledState = stateProperties10;
            stateProperties11.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties11.FillColor = System.Drawing.Color.Empty;
            stateProperties11.ForeColor = System.Drawing.Color.Empty;
            stateProperties11.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.textBoxServicios.OnHoverState = stateProperties11;
            stateProperties12.BorderColor = System.Drawing.Color.Navy;
            stateProperties12.FillColor = System.Drawing.SystemColors.WindowFrame;
            stateProperties12.ForeColor = System.Drawing.Color.Empty;
            stateProperties12.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.textBoxServicios.OnIdleState = stateProperties12;
            this.textBoxServicios.Padding = new System.Windows.Forms.Padding(3);
            this.textBoxServicios.PasswordChar = '\0';
            this.textBoxServicios.PlaceholderForeColor = System.Drawing.Color.DarkSlateGray;
            this.textBoxServicios.PlaceholderText = "";
            this.textBoxServicios.ReadOnly = true;
            this.textBoxServicios.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxServicios.SelectedText = "";
            this.textBoxServicios.SelectionLength = 0;
            this.textBoxServicios.SelectionStart = 0;
            this.textBoxServicios.ShortcutsEnabled = true;
            this.textBoxServicios.Size = new System.Drawing.Size(436, 154);
            this.textBoxServicios.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.textBoxServicios.TabIndex = 65;
            this.textBoxServicios.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBoxServicios.TextMarginBottom = 0;
            this.textBoxServicios.TextMarginLeft = 3;
            this.textBoxServicios.TextMarginTop = 1;
            this.textBoxServicios.TextPlaceholder = "";
            this.textBoxServicios.UseSystemPasswordChar = false;
            this.textBoxServicios.WordWrap = true;
            // 
            // FinalizarCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(495, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FinalizarCompra";
            this.Text = "FinalizarCompra";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelNombreServicio;
        private System.Windows.Forms.Label labelVendedor;
        private System.Windows.Forms.Label labelDni;
        private System.Windows.Forms.Label labelCliente;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnAgregarServicio;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuTextBox textBoxServicios;
    }
}