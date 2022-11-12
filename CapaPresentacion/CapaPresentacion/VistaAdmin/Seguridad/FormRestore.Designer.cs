namespace CapaPresentacion.CapaPresentacion.VistaAdmin.Seguridad
{
    partial class FormRestore
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRestore));
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonMinimizar = new Bunifu.UI.WinForms.BunifuImageButton();
            this.buttonMaximizar = new Bunifu.UI.WinForms.BunifuImageButton();
            this.bunifuImageButton1 = new Bunifu.UI.WinForms.BunifuImageButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonRestaurarBackup = new System.Windows.Forms.Button();
            this.buttonBuscarRuta = new System.Windows.Forms.Button();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.label1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.textBoxRuta = new System.Windows.Forms.TextBox();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.buttonMinimizar);
            this.panel3.Controls.Add(this.buttonMaximizar);
            this.panel3.Controls.Add(this.bunifuImageButton1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(444, 40);
            this.panel3.TabIndex = 57;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
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
            this.buttonMinimizar.ImageSize = new System.Drawing.Size(25, 16);
            this.buttonMinimizar.ImageZoomSize = new System.Drawing.Size(45, 36);
            this.buttonMinimizar.InitialImage = ((System.Drawing.Image)(resources.GetObject("buttonMinimizar.InitialImage")));
            this.buttonMinimizar.Location = new System.Drawing.Point(305, 0);
            this.buttonMinimizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonMinimizar.Name = "buttonMinimizar";
            this.buttonMinimizar.Rotation = 0;
            this.buttonMinimizar.ShowActiveImage = true;
            this.buttonMinimizar.ShowCursorChanges = true;
            this.buttonMinimizar.ShowImageBorders = true;
            this.buttonMinimizar.ShowSizeMarkers = false;
            this.buttonMinimizar.Size = new System.Drawing.Size(45, 36);
            this.buttonMinimizar.TabIndex = 18;
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
            this.buttonMaximizar.ImageSize = new System.Drawing.Size(25, 16);
            this.buttonMaximizar.ImageZoomSize = new System.Drawing.Size(45, 36);
            this.buttonMaximizar.InitialImage = ((System.Drawing.Image)(resources.GetObject("buttonMaximizar.InitialImage")));
            this.buttonMaximizar.Location = new System.Drawing.Point(350, 0);
            this.buttonMaximizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonMaximizar.Name = "buttonMaximizar";
            this.buttonMaximizar.Rotation = 0;
            this.buttonMaximizar.ShowActiveImage = true;
            this.buttonMaximizar.ShowCursorChanges = true;
            this.buttonMaximizar.ShowImageBorders = true;
            this.buttonMaximizar.ShowSizeMarkers = false;
            this.buttonMaximizar.Size = new System.Drawing.Size(45, 36);
            this.buttonMaximizar.TabIndex = 17;
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
            this.bunifuImageButton1.ImageSize = new System.Drawing.Size(25, 16);
            this.bunifuImageButton1.ImageZoomSize = new System.Drawing.Size(45, 36);
            this.bunifuImageButton1.InitialImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.InitialImage")));
            this.bunifuImageButton1.Location = new System.Drawing.Point(395, 0);
            this.bunifuImageButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Rotation = 0;
            this.bunifuImageButton1.ShowActiveImage = true;
            this.bunifuImageButton1.ShowCursorChanges = true;
            this.bunifuImageButton1.ShowImageBorders = true;
            this.bunifuImageButton1.ShowSizeMarkers = false;
            this.bunifuImageButton1.Size = new System.Drawing.Size(45, 36);
            this.bunifuImageButton1.TabIndex = 16;
            this.bunifuImageButton1.ToolTipText = "";
            this.bunifuImageButton1.WaitOnLoad = false;
            this.bunifuImageButton1.Zoom = 20;
            this.bunifuImageButton1.ZoomSpeed = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.buttonRestaurarBackup);
            this.panel1.Controls.Add(this.buttonBuscarRuta);
            this.panel1.Controls.Add(this.bunifuLabel1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBoxRuta);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(444, 366);
            this.panel1.TabIndex = 58;
            // 
            // buttonRestaurarBackup
            // 
            this.buttonRestaurarBackup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRestaurarBackup.Enabled = false;
            this.buttonRestaurarBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRestaurarBackup.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRestaurarBackup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonRestaurarBackup.Location = new System.Drawing.Point(88, 196);
            this.buttonRestaurarBackup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonRestaurarBackup.Name = "buttonRestaurarBackup";
            this.buttonRestaurarBackup.Size = new System.Drawing.Size(261, 98);
            this.buttonRestaurarBackup.TabIndex = 60;
            this.buttonRestaurarBackup.Text = "Restaurar backup";
            this.buttonRestaurarBackup.UseVisualStyleBackColor = true;
            this.buttonRestaurarBackup.Click += new System.EventHandler(this.buttonRestaurarBackup_Click);
            // 
            // buttonBuscarRuta
            // 
            this.buttonBuscarRuta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBuscarRuta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuscarRuta.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscarRuta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonBuscarRuta.Location = new System.Drawing.Point(315, 104);
            this.buttonBuscarRuta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBuscarRuta.Name = "buttonBuscarRuta";
            this.buttonBuscarRuta.Size = new System.Drawing.Size(112, 29);
            this.buttonBuscarRuta.TabIndex = 59;
            this.buttonBuscarRuta.Text = "Buscar ruta";
            this.buttonBuscarRuta.UseVisualStyleBackColor = true;
            this.buttonBuscarRuta.Click += new System.EventHandler(this.buttonBuscarRuta_Click);
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.CursorType = null;
            this.bunifuLabel1.Font = new System.Drawing.Font("Consolas", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel1.ForeColor = System.Drawing.Color.Gray;
            this.bunifuLabel1.Location = new System.Drawing.Point(14, 138);
            this.bunifuLabel1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(238, 15);
            this.bunifuLabel1.TabIndex = 58;
            this.bunifuLabel1.Text = "Busque el archivo .bak a restaurar";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // label1
            // 
            this.label1.AllowParentOverrides = false;
            this.label1.AutoEllipsis = false;
            this.label1.CursorType = null;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(14, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(4);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(49, 28);
            this.label1.TabIndex = 57;
            this.label1.Text = "Ruta:";
            this.label1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.label1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // textBoxRuta
            // 
            this.textBoxRuta.Enabled = false;
            this.textBoxRuta.Location = new System.Drawing.Point(14, 106);
            this.textBoxRuta.Multiline = true;
            this.textBoxRuta.Name = "textBoxRuta";
            this.textBoxRuta.Size = new System.Drawing.Size(294, 29);
            this.textBoxRuta.TabIndex = 56;
            // 
            // FormRestore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(444, 406);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormRestore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormRestore";
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private Bunifu.UI.WinForms.BunifuImageButton buttonMinimizar;
        private Bunifu.UI.WinForms.BunifuImageButton buttonMaximizar;
        private Bunifu.UI.WinForms.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonRestaurarBackup;
        private System.Windows.Forms.Button buttonBuscarRuta;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuLabel label1;
        private System.Windows.Forms.TextBox textBoxRuta;
    }
}