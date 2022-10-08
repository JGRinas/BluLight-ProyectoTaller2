namespace CapaPresentacion.VistaDirector
{
    partial class FormDirectorInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDirectorInicio));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonCerrarSesion = new System.Windows.Forms.Button();
            this.panelEstadistica = new System.Windows.Forms.Panel();
            this.buttonClientes = new System.Windows.Forms.Button();
            this.buttonEmpleado = new System.Windows.Forms.Button();
            this.buttonServicios = new System.Windows.Forms.Button();
            this.buttonJornadas = new System.Windows.Forms.Button();
            this.buttonVentas = new System.Windows.Forms.Button();
            this.buttonEstadistica = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.labelApellido = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bunifuImageButton3 = new Bunifu.UI.WinForms.BunifuImageButton();
            this.bunifuImageButton1 = new Bunifu.UI.WinForms.BunifuImageButton();
            this.buttonCloseForm = new Bunifu.UI.WinForms.BunifuImageButton();
            this.panelss = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panelEstadistica.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panel1.Controls.Add(this.buttonCerrarSesion);
            this.panel1.Controls.Add(this.panelEstadistica);
            this.panel1.Controls.Add(this.buttonEstadistica);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 601);
            this.panel1.TabIndex = 1;
            // 
            // buttonCerrarSesion
            // 
            this.buttonCerrarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.buttonCerrarSesion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonCerrarSesion.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCerrarSesion.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCerrarSesion.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonCerrarSesion.Location = new System.Drawing.Point(0, 570);
            this.buttonCerrarSesion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCerrarSesion.Name = "buttonCerrarSesion";
            this.buttonCerrarSesion.Size = new System.Drawing.Size(240, 31);
            this.buttonCerrarSesion.TabIndex = 7;
            this.buttonCerrarSesion.Text = "Cerrar Sesión";
            this.buttonCerrarSesion.UseVisualStyleBackColor = false;
            this.buttonCerrarSesion.Click += new System.EventHandler(this.buttonCerrarSesion_Click);
            // 
            // panelEstadistica
            // 
            this.panelEstadistica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelEstadistica.Controls.Add(this.buttonClientes);
            this.panelEstadistica.Controls.Add(this.buttonEmpleado);
            this.panelEstadistica.Controls.Add(this.buttonServicios);
            this.panelEstadistica.Controls.Add(this.buttonJornadas);
            this.panelEstadistica.Controls.Add(this.buttonVentas);
            this.panelEstadistica.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelEstadistica.Location = new System.Drawing.Point(0, 181);
            this.panelEstadistica.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelEstadistica.Name = "panelEstadistica";
            this.panelEstadistica.Size = new System.Drawing.Size(240, 156);
            this.panelEstadistica.TabIndex = 4;
            // 
            // buttonClientes
            // 
            this.buttonClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonClientes.FlatAppearance.BorderSize = 0;
            this.buttonClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClientes.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClientes.ForeColor = System.Drawing.Color.LightGray;
            this.buttonClientes.Location = new System.Drawing.Point(0, 124);
            this.buttonClientes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonClientes.Name = "buttonClientes";
            this.buttonClientes.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.buttonClientes.Size = new System.Drawing.Size(240, 31);
            this.buttonClientes.TabIndex = 6;
            this.buttonClientes.Text = "Clientes";
            this.buttonClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonClientes.UseVisualStyleBackColor = true;
            this.buttonClientes.Click += new System.EventHandler(this.buttonClientes_Click);
            // 
            // buttonEmpleado
            // 
            this.buttonEmpleado.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonEmpleado.FlatAppearance.BorderSize = 0;
            this.buttonEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEmpleado.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEmpleado.ForeColor = System.Drawing.Color.LightGray;
            this.buttonEmpleado.Location = new System.Drawing.Point(0, 93);
            this.buttonEmpleado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEmpleado.Name = "buttonEmpleado";
            this.buttonEmpleado.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.buttonEmpleado.Size = new System.Drawing.Size(240, 31);
            this.buttonEmpleado.TabIndex = 5;
            this.buttonEmpleado.Text = "Empleados";
            this.buttonEmpleado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEmpleado.UseVisualStyleBackColor = true;
            this.buttonEmpleado.Click += new System.EventHandler(this.buttonEmpleado_Click);
            // 
            // buttonServicios
            // 
            this.buttonServicios.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonServicios.FlatAppearance.BorderSize = 0;
            this.buttonServicios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonServicios.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonServicios.ForeColor = System.Drawing.Color.LightGray;
            this.buttonServicios.Location = new System.Drawing.Point(0, 62);
            this.buttonServicios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonServicios.Name = "buttonServicios";
            this.buttonServicios.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.buttonServicios.Size = new System.Drawing.Size(240, 31);
            this.buttonServicios.TabIndex = 4;
            this.buttonServicios.Text = "Servicios";
            this.buttonServicios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonServicios.UseVisualStyleBackColor = true;
            this.buttonServicios.Click += new System.EventHandler(this.buttonServicios_Click);
            // 
            // buttonJornadas
            // 
            this.buttonJornadas.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonJornadas.FlatAppearance.BorderSize = 0;
            this.buttonJornadas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonJornadas.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonJornadas.ForeColor = System.Drawing.Color.LightGray;
            this.buttonJornadas.Location = new System.Drawing.Point(0, 31);
            this.buttonJornadas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonJornadas.Name = "buttonJornadas";
            this.buttonJornadas.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.buttonJornadas.Size = new System.Drawing.Size(240, 31);
            this.buttonJornadas.TabIndex = 3;
            this.buttonJornadas.Text = "Jornadas";
            this.buttonJornadas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonJornadas.UseVisualStyleBackColor = true;
            this.buttonJornadas.Click += new System.EventHandler(this.buttonJornadas_Click);
            // 
            // buttonVentas
            // 
            this.buttonVentas.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonVentas.FlatAppearance.BorderSize = 0;
            this.buttonVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVentas.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVentas.ForeColor = System.Drawing.Color.LightGray;
            this.buttonVentas.Location = new System.Drawing.Point(0, 0);
            this.buttonVentas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonVentas.Name = "buttonVentas";
            this.buttonVentas.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.buttonVentas.Size = new System.Drawing.Size(240, 31);
            this.buttonVentas.TabIndex = 2;
            this.buttonVentas.Text = "Ventas";
            this.buttonVentas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonVentas.UseVisualStyleBackColor = true;
            this.buttonVentas.Click += new System.EventHandler(this.buttonVentas_Click);
            // 
            // buttonEstadistica
            // 
            this.buttonEstadistica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.buttonEstadistica.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonEstadistica.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonEstadistica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEstadistica.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEstadistica.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonEstadistica.Location = new System.Drawing.Point(0, 150);
            this.buttonEstadistica.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEstadistica.Name = "buttonEstadistica";
            this.buttonEstadistica.Size = new System.Drawing.Size(240, 31);
            this.buttonEstadistica.TabIndex = 3;
            this.buttonEstadistica.Text = "Estadisticas ";
            this.buttonEstadistica.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEstadistica.UseVisualStyleBackColor = false;
            this.buttonEstadistica.Click += new System.EventHandler(this.buttonEstadistica_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.labelApellido);
            this.panel5.Controls.Add(this.labelNombre);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(240, 150);
            this.panel5.TabIndex = 0;
            // 
            // labelApellido
            // 
            this.labelApellido.AutoSize = true;
            this.labelApellido.BackColor = System.Drawing.Color.Transparent;
            this.labelApellido.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelApellido.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelApellido.Location = new System.Drawing.Point(43, 106);
            this.labelApellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelApellido.Name = "labelApellido";
            this.labelApellido.Size = new System.Drawing.Size(81, 20);
            this.labelApellido.TabIndex = 6;
            this.labelApellido.Text = "apellido";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.BackColor = System.Drawing.Color.Transparent;
            this.labelNombre.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelNombre.Location = new System.Drawing.Point(24, 86);
            this.labelNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(63, 20);
            this.labelNombre.TabIndex = 5;
            this.labelNombre.Text = "nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(3, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 71);
            this.label1.TabIndex = 2;
            this.label1.Text = "BluLight";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panel3.Controls.Add(this.bunifuImageButton3);
            this.panel3.Controls.Add(this.bunifuImageButton1);
            this.panel3.Controls.Add(this.buttonCloseForm);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(240, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(760, 41);
            this.panel3.TabIndex = 2;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            // 
            // bunifuImageButton3
            // 
            this.bunifuImageButton3.ActiveImage = null;
            this.bunifuImageButton3.AllowAnimations = true;
            this.bunifuImageButton3.AllowBuffering = false;
            this.bunifuImageButton3.AllowToggling = false;
            this.bunifuImageButton3.AllowZooming = true;
            this.bunifuImageButton3.AllowZoomingOnFocus = false;
            this.bunifuImageButton3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton3.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuImageButton3.Dock = System.Windows.Forms.DockStyle.Right;
            this.bunifuImageButton3.ErrorImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton3.ErrorImage")));
            this.bunifuImageButton3.FadeWhenInactive = false;
            this.bunifuImageButton3.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.bunifuImageButton3.Image = global::CapaPresentacion.Properties.Resources.boton_menos;
            this.bunifuImageButton3.ImageActive = null;
            this.bunifuImageButton3.ImageLocation = null;
            this.bunifuImageButton3.ImageMargin = 20;
            this.bunifuImageButton3.ImageSize = new System.Drawing.Size(25, 21);
            this.bunifuImageButton3.ImageZoomSize = new System.Drawing.Size(45, 41);
            this.bunifuImageButton3.InitialImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton3.InitialImage")));
            this.bunifuImageButton3.Location = new System.Drawing.Point(625, 0);
            this.bunifuImageButton3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bunifuImageButton3.Name = "bunifuImageButton3";
            this.bunifuImageButton3.Rotation = 0;
            this.bunifuImageButton3.ShowActiveImage = true;
            this.bunifuImageButton3.ShowCursorChanges = true;
            this.bunifuImageButton3.ShowImageBorders = true;
            this.bunifuImageButton3.ShowSizeMarkers = false;
            this.bunifuImageButton3.Size = new System.Drawing.Size(45, 41);
            this.bunifuImageButton3.TabIndex = 15;
            this.bunifuImageButton3.ToolTipText = "";
            this.bunifuImageButton3.WaitOnLoad = false;
            this.bunifuImageButton3.Zoom = 20;
            this.bunifuImageButton3.ZoomSpeed = 10;
            this.bunifuImageButton3.Click += new System.EventHandler(this.bunifuImageButton3_Click);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.ActiveImage = null;
            this.bunifuImageButton1.AllowAnimations = true;
            this.bunifuImageButton1.AllowBuffering = false;
            this.bunifuImageButton1.AllowToggling = false;
            this.bunifuImageButton1.AllowZooming = true;
            this.bunifuImageButton1.AllowZoomingOnFocus = false;
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuImageButton1.Dock = System.Windows.Forms.DockStyle.Right;
            this.bunifuImageButton1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.ErrorImage")));
            this.bunifuImageButton1.FadeWhenInactive = false;
            this.bunifuImageButton1.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.bunifuImageButton1.Image = global::CapaPresentacion.Properties.Resources.maximizar;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.ImageLocation = null;
            this.bunifuImageButton1.ImageMargin = 20;
            this.bunifuImageButton1.ImageSize = new System.Drawing.Size(25, 21);
            this.bunifuImageButton1.ImageZoomSize = new System.Drawing.Size(45, 41);
            this.bunifuImageButton1.InitialImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.InitialImage")));
            this.bunifuImageButton1.Location = new System.Drawing.Point(670, 0);
            this.bunifuImageButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Rotation = 0;
            this.bunifuImageButton1.ShowActiveImage = true;
            this.bunifuImageButton1.ShowCursorChanges = true;
            this.bunifuImageButton1.ShowImageBorders = true;
            this.bunifuImageButton1.ShowSizeMarkers = false;
            this.bunifuImageButton1.Size = new System.Drawing.Size(45, 41);
            this.bunifuImageButton1.TabIndex = 14;
            this.bunifuImageButton1.ToolTipText = "";
            this.bunifuImageButton1.WaitOnLoad = false;
            this.bunifuImageButton1.Zoom = 20;
            this.bunifuImageButton1.ZoomSpeed = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // buttonCloseForm
            // 
            this.buttonCloseForm.ActiveImage = null;
            this.buttonCloseForm.AllowAnimations = true;
            this.buttonCloseForm.AllowBuffering = false;
            this.buttonCloseForm.AllowToggling = false;
            this.buttonCloseForm.AllowZooming = true;
            this.buttonCloseForm.AllowZoomingOnFocus = false;
            this.buttonCloseForm.BackColor = System.Drawing.Color.Transparent;
            this.buttonCloseForm.DialogResult = System.Windows.Forms.DialogResult.None;
            this.buttonCloseForm.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonCloseForm.ErrorImage = ((System.Drawing.Image)(resources.GetObject("buttonCloseForm.ErrorImage")));
            this.buttonCloseForm.FadeWhenInactive = false;
            this.buttonCloseForm.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.buttonCloseForm.Image = global::CapaPresentacion.Properties.Resources.apagado;
            this.buttonCloseForm.ImageActive = null;
            this.buttonCloseForm.ImageLocation = null;
            this.buttonCloseForm.ImageMargin = 20;
            this.buttonCloseForm.ImageSize = new System.Drawing.Size(25, 21);
            this.buttonCloseForm.ImageZoomSize = new System.Drawing.Size(45, 41);
            this.buttonCloseForm.InitialImage = ((System.Drawing.Image)(resources.GetObject("buttonCloseForm.InitialImage")));
            this.buttonCloseForm.Location = new System.Drawing.Point(715, 0);
            this.buttonCloseForm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCloseForm.Name = "buttonCloseForm";
            this.buttonCloseForm.Rotation = 0;
            this.buttonCloseForm.ShowActiveImage = true;
            this.buttonCloseForm.ShowCursorChanges = true;
            this.buttonCloseForm.ShowImageBorders = true;
            this.buttonCloseForm.ShowSizeMarkers = false;
            this.buttonCloseForm.Size = new System.Drawing.Size(45, 41);
            this.buttonCloseForm.TabIndex = 13;
            this.buttonCloseForm.ToolTipText = "";
            this.buttonCloseForm.WaitOnLoad = false;
            this.buttonCloseForm.Zoom = 20;
            this.buttonCloseForm.ZoomSpeed = 10;
            this.buttonCloseForm.Click += new System.EventHandler(this.buttonCloseForm_Click);
            // 
            // panelss
            // 
            this.panelss.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.panelss.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelss.Location = new System.Drawing.Point(240, 41);
            this.panelss.Margin = new System.Windows.Forms.Padding(4);
            this.panelss.Name = "panelss";
            this.panelss.Size = new System.Drawing.Size(760, 560);
            this.panelss.TabIndex = 3;
            // 
            // FormDirectorInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 601);
            this.Controls.Add(this.panelss);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormDirectorInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDirectorInicio";
            this.panel1.ResumeLayout(false);
            this.panelEstadistica.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonCerrarSesion;
        private System.Windows.Forms.Panel panelEstadistica;
        private System.Windows.Forms.Button buttonJornadas;
        private System.Windows.Forms.Button buttonVentas;
        private System.Windows.Forms.Button buttonEstadistica;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.UI.WinForms.BunifuImageButton bunifuImageButton3;
        private Bunifu.UI.WinForms.BunifuImageButton bunifuImageButton1;
        private Bunifu.UI.WinForms.BunifuImageButton buttonCloseForm;
        private System.Windows.Forms.Panel panelss;
        private System.Windows.Forms.Button buttonServicios;
        private System.Windows.Forms.Button buttonClientes;
        private System.Windows.Forms.Button buttonEmpleado;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelApellido;
        private System.Windows.Forms.Label labelNombre;
    }
}