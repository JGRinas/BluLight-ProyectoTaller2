namespace Proyecto2022.CapaPresentacion.VistaJefeLaboratorio
{
    partial class FormJefeLabInicio
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormJefeLabInicio));
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.panelServicios = new System.Windows.Forms.Panel();
            this.buttonNuevoServicio = new System.Windows.Forms.Button();
            this.buttonServicio = new System.Windows.Forms.Button();
            this.panelCursos = new System.Windows.Forms.Panel();
            this.buttonAgregarCurso = new System.Windows.Forms.Button();
            this.buttonCurso = new System.Windows.Forms.Button();
            this.panelReportes = new System.Windows.Forms.Panel();
            this.buttonListaReportes = new System.Windows.Forms.Button();
            this.buttonNuevoReporte = new System.Windows.Forms.Button();
            this.buttonReportes = new System.Windows.Forms.Button();
            this.panelSolicitudes = new System.Windows.Forms.Panel();
            this.buttonSolicitudesFinalizadas = new System.Windows.Forms.Button();
            this.buttonSolicitudesActivas = new System.Windows.Forms.Button();
            this.buttonSolicitudesPendientes = new System.Windows.Forms.Button();
            this.buttonSolicitudes = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.labelApellido = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.buttonMinimizar = new Bunifu.UI.WinForms.BunifuImageButton();
            this.buttonMaximizar = new Bunifu.UI.WinForms.BunifuImageButton();
            this.bunifuImageButton1 = new Bunifu.UI.WinForms.BunifuImageButton();
            this.panelHijoJ = new System.Windows.Forms.Panel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel2.SuspendLayout();
            this.panelServicios.SuspendLayout();
            this.panelCursos.SuspendLayout();
            this.panelReportes.SuspendLayout();
            this.panelSolicitudes.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panel2.Controls.Add(this.buttonLogout);
            this.panel2.Controls.Add(this.panelServicios);
            this.panel2.Controls.Add(this.buttonServicio);
            this.panel2.Controls.Add(this.panelCursos);
            this.panel2.Controls.Add(this.buttonCurso);
            this.panel2.Controls.Add(this.panelReportes);
            this.panel2.Controls.Add(this.buttonReportes);
            this.panel2.Controls.Add(this.panelSolicitudes);
            this.panel2.Controls.Add(this.buttonSolicitudes);
            this.panel2.Controls.Add(this.panelLogo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(180, 488);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // buttonLogout
            // 
            this.buttonLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.buttonLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonLogout.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogout.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogout.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonLogout.Location = new System.Drawing.Point(0, 457);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(180, 31);
            this.buttonLogout.TabIndex = 19;
            this.buttonLogout.Text = "Cerrar Sesión";
            this.buttonLogout.UseVisualStyleBackColor = false;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // panelServicios
            // 
            this.panelServicios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelServicios.Controls.Add(this.buttonNuevoServicio);
            this.panelServicios.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelServicios.Location = new System.Drawing.Point(0, 390);
            this.panelServicios.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelServicios.Name = "panelServicios";
            this.panelServicios.Size = new System.Drawing.Size(180, 36);
            this.panelServicios.TabIndex = 18;
            // 
            // buttonNuevoServicio
            // 
            this.buttonNuevoServicio.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonNuevoServicio.FlatAppearance.BorderSize = 0;
            this.buttonNuevoServicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNuevoServicio.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNuevoServicio.ForeColor = System.Drawing.Color.LightGray;
            this.buttonNuevoServicio.Location = new System.Drawing.Point(0, 0);
            this.buttonNuevoServicio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonNuevoServicio.Name = "buttonNuevoServicio";
            this.buttonNuevoServicio.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.buttonNuevoServicio.Size = new System.Drawing.Size(180, 24);
            this.buttonNuevoServicio.TabIndex = 2;
            this.buttonNuevoServicio.Text = "Gestión";
            this.buttonNuevoServicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonNuevoServicio.UseVisualStyleBackColor = true;
            this.buttonNuevoServicio.Click += new System.EventHandler(this.buttonNuevoServicio_Click);
            // 
            // buttonServicio
            // 
            this.buttonServicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.buttonServicio.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonServicio.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonServicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonServicio.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonServicio.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonServicio.Location = new System.Drawing.Point(0, 365);
            this.buttonServicio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonServicio.Name = "buttonServicio";
            this.buttonServicio.Size = new System.Drawing.Size(180, 25);
            this.buttonServicio.TabIndex = 17;
            this.buttonServicio.Text = "Servicios";
            this.buttonServicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonServicio.UseVisualStyleBackColor = false;
            this.buttonServicio.Click += new System.EventHandler(this.buttonServicio_Click);
            // 
            // panelCursos
            // 
            this.panelCursos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelCursos.Controls.Add(this.buttonAgregarCurso);
            this.panelCursos.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCursos.Location = new System.Drawing.Point(0, 332);
            this.panelCursos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelCursos.Name = "panelCursos";
            this.panelCursos.Size = new System.Drawing.Size(180, 33);
            this.panelCursos.TabIndex = 16;
            // 
            // buttonAgregarCurso
            // 
            this.buttonAgregarCurso.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAgregarCurso.FlatAppearance.BorderSize = 0;
            this.buttonAgregarCurso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAgregarCurso.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAgregarCurso.ForeColor = System.Drawing.Color.LightGray;
            this.buttonAgregarCurso.Location = new System.Drawing.Point(0, 0);
            this.buttonAgregarCurso.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAgregarCurso.Name = "buttonAgregarCurso";
            this.buttonAgregarCurso.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.buttonAgregarCurso.Size = new System.Drawing.Size(180, 25);
            this.buttonAgregarCurso.TabIndex = 2;
            this.buttonAgregarCurso.Text = "Gestión";
            this.buttonAgregarCurso.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAgregarCurso.UseVisualStyleBackColor = true;
            this.buttonAgregarCurso.Click += new System.EventHandler(this.buttonAgregarCurso_Click);
            // 
            // buttonCurso
            // 
            this.buttonCurso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.buttonCurso.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonCurso.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonCurso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCurso.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCurso.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonCurso.Location = new System.Drawing.Point(0, 307);
            this.buttonCurso.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCurso.Name = "buttonCurso";
            this.buttonCurso.Size = new System.Drawing.Size(180, 25);
            this.buttonCurso.TabIndex = 15;
            this.buttonCurso.Text = "Jornadas";
            this.buttonCurso.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCurso.UseVisualStyleBackColor = false;
            this.buttonCurso.Click += new System.EventHandler(this.buttonCurso_Click);
            // 
            // panelReportes
            // 
            this.panelReportes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelReportes.Controls.Add(this.buttonListaReportes);
            this.panelReportes.Controls.Add(this.buttonNuevoReporte);
            this.panelReportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelReportes.Location = new System.Drawing.Point(0, 253);
            this.panelReportes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelReportes.Name = "panelReportes";
            this.panelReportes.Size = new System.Drawing.Size(180, 54);
            this.panelReportes.TabIndex = 14;
            // 
            // buttonListaReportes
            // 
            this.buttonListaReportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonListaReportes.FlatAppearance.BorderSize = 0;
            this.buttonListaReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonListaReportes.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonListaReportes.ForeColor = System.Drawing.Color.LightGray;
            this.buttonListaReportes.Location = new System.Drawing.Point(0, 25);
            this.buttonListaReportes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonListaReportes.Name = "buttonListaReportes";
            this.buttonListaReportes.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.buttonListaReportes.Size = new System.Drawing.Size(180, 25);
            this.buttonListaReportes.TabIndex = 3;
            this.buttonListaReportes.Text = "Reportes";
            this.buttonListaReportes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonListaReportes.UseVisualStyleBackColor = true;
            this.buttonListaReportes.Click += new System.EventHandler(this.buttonListaReportes_Click);
            // 
            // buttonNuevoReporte
            // 
            this.buttonNuevoReporte.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonNuevoReporte.FlatAppearance.BorderSize = 0;
            this.buttonNuevoReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNuevoReporte.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNuevoReporte.ForeColor = System.Drawing.Color.LightGray;
            this.buttonNuevoReporte.Location = new System.Drawing.Point(0, 0);
            this.buttonNuevoReporte.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonNuevoReporte.Name = "buttonNuevoReporte";
            this.buttonNuevoReporte.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.buttonNuevoReporte.Size = new System.Drawing.Size(180, 25);
            this.buttonNuevoReporte.TabIndex = 2;
            this.buttonNuevoReporte.Text = "Nuevo Reporte";
            this.buttonNuevoReporte.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonNuevoReporte.UseVisualStyleBackColor = true;
            this.buttonNuevoReporte.Click += new System.EventHandler(this.buttonNuevoReporte_Click);
            // 
            // buttonReportes
            // 
            this.buttonReportes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.buttonReportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonReportes.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReportes.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReportes.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonReportes.Location = new System.Drawing.Point(0, 228);
            this.buttonReportes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonReportes.Name = "buttonReportes";
            this.buttonReportes.Size = new System.Drawing.Size(180, 25);
            this.buttonReportes.TabIndex = 13;
            this.buttonReportes.Text = "Reportes";
            this.buttonReportes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonReportes.UseVisualStyleBackColor = false;
            this.buttonReportes.Click += new System.EventHandler(this.buttonReportes_Click);
            // 
            // panelSolicitudes
            // 
            this.panelSolicitudes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelSolicitudes.Controls.Add(this.buttonSolicitudesFinalizadas);
            this.panelSolicitudes.Controls.Add(this.buttonSolicitudesActivas);
            this.panelSolicitudes.Controls.Add(this.buttonSolicitudesPendientes);
            this.panelSolicitudes.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSolicitudes.Location = new System.Drawing.Point(0, 147);
            this.panelSolicitudes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelSolicitudes.Name = "panelSolicitudes";
            this.panelSolicitudes.Size = new System.Drawing.Size(180, 81);
            this.panelSolicitudes.TabIndex = 9;
            // 
            // buttonSolicitudesFinalizadas
            // 
            this.buttonSolicitudesFinalizadas.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSolicitudesFinalizadas.FlatAppearance.BorderSize = 0;
            this.buttonSolicitudesFinalizadas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSolicitudesFinalizadas.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSolicitudesFinalizadas.ForeColor = System.Drawing.Color.LightGray;
            this.buttonSolicitudesFinalizadas.Location = new System.Drawing.Point(0, 50);
            this.buttonSolicitudesFinalizadas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSolicitudesFinalizadas.Name = "buttonSolicitudesFinalizadas";
            this.buttonSolicitudesFinalizadas.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.buttonSolicitudesFinalizadas.Size = new System.Drawing.Size(180, 25);
            this.buttonSolicitudesFinalizadas.TabIndex = 4;
            this.buttonSolicitudesFinalizadas.Text = "Finalizadas";
            this.buttonSolicitudesFinalizadas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSolicitudesFinalizadas.UseVisualStyleBackColor = true;
            this.buttonSolicitudesFinalizadas.Click += new System.EventHandler(this.buttonSolicitudesFinalizadas_Click);
            // 
            // buttonSolicitudesActivas
            // 
            this.buttonSolicitudesActivas.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSolicitudesActivas.FlatAppearance.BorderSize = 0;
            this.buttonSolicitudesActivas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSolicitudesActivas.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSolicitudesActivas.ForeColor = System.Drawing.Color.LightGray;
            this.buttonSolicitudesActivas.Location = new System.Drawing.Point(0, 25);
            this.buttonSolicitudesActivas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSolicitudesActivas.Name = "buttonSolicitudesActivas";
            this.buttonSolicitudesActivas.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.buttonSolicitudesActivas.Size = new System.Drawing.Size(180, 25);
            this.buttonSolicitudesActivas.TabIndex = 3;
            this.buttonSolicitudesActivas.Text = "Activas";
            this.buttonSolicitudesActivas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSolicitudesActivas.UseVisualStyleBackColor = true;
            this.buttonSolicitudesActivas.Click += new System.EventHandler(this.buttonSolicitudesActivas_Click);
            // 
            // buttonSolicitudesPendientes
            // 
            this.buttonSolicitudesPendientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSolicitudesPendientes.FlatAppearance.BorderSize = 0;
            this.buttonSolicitudesPendientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSolicitudesPendientes.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSolicitudesPendientes.ForeColor = System.Drawing.Color.LightGray;
            this.buttonSolicitudesPendientes.Location = new System.Drawing.Point(0, 0);
            this.buttonSolicitudesPendientes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSolicitudesPendientes.Name = "buttonSolicitudesPendientes";
            this.buttonSolicitudesPendientes.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.buttonSolicitudesPendientes.Size = new System.Drawing.Size(180, 25);
            this.buttonSolicitudesPendientes.TabIndex = 2;
            this.buttonSolicitudesPendientes.Text = "Pendientes";
            this.buttonSolicitudesPendientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSolicitudesPendientes.UseVisualStyleBackColor = true;
            this.buttonSolicitudesPendientes.Click += new System.EventHandler(this.buttonSolicitudesPendientes_Click);
            // 
            // buttonSolicitudes
            // 
            this.buttonSolicitudes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.buttonSolicitudes.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSolicitudes.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonSolicitudes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSolicitudes.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSolicitudes.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonSolicitudes.Location = new System.Drawing.Point(0, 122);
            this.buttonSolicitudes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSolicitudes.Name = "buttonSolicitudes";
            this.buttonSolicitudes.Size = new System.Drawing.Size(180, 25);
            this.buttonSolicitudes.TabIndex = 8;
            this.buttonSolicitudes.Text = "Solicitudes";
            this.buttonSolicitudes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSolicitudes.UseVisualStyleBackColor = false;
            this.buttonSolicitudes.Click += new System.EventHandler(this.buttonSolicitudes_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.labelApellido);
            this.panelLogo.Controls.Add(this.labelNombre);
            this.panelLogo.Controls.Add(this.label1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(180, 122);
            this.panelLogo.TabIndex = 7;
            // 
            // labelApellido
            // 
            this.labelApellido.AutoSize = true;
            this.labelApellido.BackColor = System.Drawing.Color.Transparent;
            this.labelApellido.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelApellido.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelApellido.Location = new System.Drawing.Point(28, 90);
            this.labelApellido.Name = "labelApellido";
            this.labelApellido.Size = new System.Drawing.Size(63, 15);
            this.labelApellido.TabIndex = 6;
            this.labelApellido.Text = "apellido";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.BackColor = System.Drawing.Color.Transparent;
            this.labelNombre.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelNombre.Location = new System.Drawing.Point(14, 74);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(49, 15);
            this.labelNombre.TabIndex = 5;
            this.labelNombre.Text = "nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(6, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 57);
            this.label1.TabIndex = 2;
            this.label1.Text = "BluLight";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panel5.Controls.Add(this.buttonMinimizar);
            this.panel5.Controls.Add(this.buttonMaximizar);
            this.panel5.Controls.Add(this.bunifuImageButton1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(180, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(570, 32);
            this.panel5.TabIndex = 3;
            // 
            // buttonMinimizar
            // 
            this.buttonMinimizar.ActiveImage = null;
            this.buttonMinimizar.AllowAnimations = true;
            this.buttonMinimizar.AllowBuffering = false;
            this.buttonMinimizar.AllowToggling = false;
            this.buttonMinimizar.AllowZooming = true;
            this.buttonMinimizar.AllowZoomingOnFocus = false;
            this.buttonMinimizar.BackColor = System.Drawing.Color.Transparent;
            this.buttonMinimizar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.buttonMinimizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonMinimizar.ErrorImage = ((System.Drawing.Image)(resources.GetObject("buttonMinimizar.ErrorImage")));
            this.buttonMinimizar.FadeWhenInactive = false;
            this.buttonMinimizar.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.buttonMinimizar.Image = global::CapaPresentacion.Properties.Resources.boton_menos;
            this.buttonMinimizar.ImageActive = null;
            this.buttonMinimizar.ImageLocation = null;
            this.buttonMinimizar.ImageMargin = 20;
            this.buttonMinimizar.ImageSize = new System.Drawing.Size(14, 12);
            this.buttonMinimizar.ImageZoomSize = new System.Drawing.Size(34, 32);
            this.buttonMinimizar.InitialImage = ((System.Drawing.Image)(resources.GetObject("buttonMinimizar.InitialImage")));
            this.buttonMinimizar.Location = new System.Drawing.Point(468, 0);
            this.buttonMinimizar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonMinimizar.Name = "buttonMinimizar";
            this.buttonMinimizar.Rotation = 0;
            this.buttonMinimizar.ShowActiveImage = true;
            this.buttonMinimizar.ShowCursorChanges = true;
            this.buttonMinimizar.ShowImageBorders = true;
            this.buttonMinimizar.ShowSizeMarkers = false;
            this.buttonMinimizar.Size = new System.Drawing.Size(34, 32);
            this.buttonMinimizar.TabIndex = 15;
            this.buttonMinimizar.ToolTipText = "";
            this.buttonMinimizar.WaitOnLoad = false;
            this.buttonMinimizar.Zoom = 20;
            this.buttonMinimizar.ZoomSpeed = 10;
            this.buttonMinimizar.Click += new System.EventHandler(this.buttonMinimizar_Click);
            // 
            // buttonMaximizar
            // 
            this.buttonMaximizar.ActiveImage = null;
            this.buttonMaximizar.AllowAnimations = true;
            this.buttonMaximizar.AllowBuffering = false;
            this.buttonMaximizar.AllowToggling = false;
            this.buttonMaximizar.AllowZooming = true;
            this.buttonMaximizar.AllowZoomingOnFocus = false;
            this.buttonMaximizar.BackColor = System.Drawing.Color.Transparent;
            this.buttonMaximizar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.buttonMaximizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonMaximizar.ErrorImage = ((System.Drawing.Image)(resources.GetObject("buttonMaximizar.ErrorImage")));
            this.buttonMaximizar.FadeWhenInactive = false;
            this.buttonMaximizar.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.buttonMaximizar.Image = global::CapaPresentacion.Properties.Resources.maximizar;
            this.buttonMaximizar.ImageActive = null;
            this.buttonMaximizar.ImageLocation = null;
            this.buttonMaximizar.ImageMargin = 20;
            this.buttonMaximizar.ImageSize = new System.Drawing.Size(14, 12);
            this.buttonMaximizar.ImageZoomSize = new System.Drawing.Size(34, 32);
            this.buttonMaximizar.InitialImage = ((System.Drawing.Image)(resources.GetObject("buttonMaximizar.InitialImage")));
            this.buttonMaximizar.Location = new System.Drawing.Point(502, 0);
            this.buttonMaximizar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonMaximizar.Name = "buttonMaximizar";
            this.buttonMaximizar.Rotation = 0;
            this.buttonMaximizar.ShowActiveImage = true;
            this.buttonMaximizar.ShowCursorChanges = true;
            this.buttonMaximizar.ShowImageBorders = true;
            this.buttonMaximizar.ShowSizeMarkers = false;
            this.buttonMaximizar.Size = new System.Drawing.Size(34, 32);
            this.buttonMaximizar.TabIndex = 14;
            this.buttonMaximizar.ToolTipText = "";
            this.buttonMaximizar.WaitOnLoad = false;
            this.buttonMaximizar.Zoom = 20;
            this.buttonMaximizar.ZoomSpeed = 10;
            this.buttonMaximizar.Click += new System.EventHandler(this.buttonMaximizar_Click);
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
            this.bunifuImageButton1.Image = global::CapaPresentacion.Properties.Resources.apagado;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.ImageLocation = null;
            this.bunifuImageButton1.ImageMargin = 20;
            this.bunifuImageButton1.ImageSize = new System.Drawing.Size(14, 12);
            this.bunifuImageButton1.ImageZoomSize = new System.Drawing.Size(34, 32);
            this.bunifuImageButton1.InitialImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.InitialImage")));
            this.bunifuImageButton1.Location = new System.Drawing.Point(536, 0);
            this.bunifuImageButton1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Rotation = 0;
            this.bunifuImageButton1.ShowActiveImage = true;
            this.bunifuImageButton1.ShowCursorChanges = true;
            this.bunifuImageButton1.ShowImageBorders = true;
            this.bunifuImageButton1.ShowSizeMarkers = false;
            this.bunifuImageButton1.Size = new System.Drawing.Size(34, 32);
            this.bunifuImageButton1.TabIndex = 13;
            this.bunifuImageButton1.ToolTipText = "";
            this.bunifuImageButton1.WaitOnLoad = false;
            this.bunifuImageButton1.Zoom = 20;
            this.bunifuImageButton1.ZoomSpeed = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // panelHijoJ
            // 
            this.panelHijoJ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.panelHijoJ.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHijoJ.Location = new System.Drawing.Point(180, 32);
            this.panelHijoJ.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelHijoJ.Name = "panelHijoJ";
            this.panelHijoJ.Size = new System.Drawing.Size(570, 456);
            this.panelHijoJ.TabIndex = 4;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // FormJefeLabInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 488);
            this.Controls.Add(this.panelHijoJ);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormJefeLabInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormJefeLabInicio";
            this.panel2.ResumeLayout(false);
            this.panelServicios.ResumeLayout(false);
            this.panelCursos.ResumeLayout(false);
            this.panelReportes.ResumeLayout(false);
            this.panelSolicitudes.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelSolicitudes;
        private System.Windows.Forms.Button buttonSolicitudesFinalizadas;
        private System.Windows.Forms.Button buttonSolicitudesActivas;
        private System.Windows.Forms.Button buttonSolicitudesPendientes;
        private System.Windows.Forms.Button buttonSolicitudes;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelReportes;
        private System.Windows.Forms.Button buttonListaReportes;
        private System.Windows.Forms.Button buttonNuevoReporte;
        private System.Windows.Forms.Button buttonReportes;
        private System.Windows.Forms.Panel panelCursos;
        private System.Windows.Forms.Button buttonAgregarCurso;
        private System.Windows.Forms.Button buttonCurso;
        private System.Windows.Forms.Panel panelServicios;
        private System.Windows.Forms.Button buttonNuevoServicio;
        private System.Windows.Forms.Button buttonServicio;
        private System.Windows.Forms.Panel panel5;
        private Bunifu.UI.WinForms.BunifuImageButton buttonMinimizar;
        private Bunifu.UI.WinForms.BunifuImageButton buttonMaximizar;
        private Bunifu.UI.WinForms.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.Panel panelHijoJ;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelApellido;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Button buttonLogout;
    }
}