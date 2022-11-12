namespace CapaPresentacion.CapaPresentacion.VistaAdmin.Seguridad
{
    partial class FormContrasena
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormContrasena));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuImageButton1 = new Bunifu.UI.WinForms.BunifuImageButton();
            this.textBoxContrasena = new Bunifu.UI.WinForms.BunifuTextBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.textBoxContrasena);
            this.panel1.Controls.Add(this.buttonAceptar);
            this.panel1.Controls.Add(this.bunifuLabel1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(387, 162);
            this.panel1.TabIndex = 0;
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAceptar.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAceptar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonAceptar.Location = new System.Drawing.Point(133, 114);
            this.buttonAceptar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(112, 29);
            this.buttonAceptar.TabIndex = 61;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.CursorType = null;
            this.bunifuLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuLabel1.Location = new System.Drawing.Point(82, 46);
            this.bunifuLabel1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(211, 28);
            this.bunifuLabel1.TabIndex = 59;
            this.bunifuLabel1.Text = "Ingrese su contraseña:";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.bunifuImageButton1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(383, 40);
            this.panel3.TabIndex = 58;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            // 
            // label1
            // 
            this.label1.AllowParentOverrides = false;
            this.label1.AutoEllipsis = false;
            this.label1.CursorType = null;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(4, 2);
            this.label1.Margin = new System.Windows.Forms.Padding(4);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(252, 28);
            this.label1.TabIndex = 58;
            this.label1.Text = "Confirmación de identidad";
            this.label1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.label1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
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
            this.bunifuImageButton1.Location = new System.Drawing.Point(334, 0);
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
            // textBoxContrasena
            // 
            this.textBoxContrasena.AcceptsReturn = false;
            this.textBoxContrasena.AcceptsTab = false;
            this.textBoxContrasena.AnimationSpeed = 200;
            this.textBoxContrasena.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.textBoxContrasena.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.textBoxContrasena.AutoSizeHeight = true;
            this.textBoxContrasena.BackColor = System.Drawing.Color.Transparent;
            this.textBoxContrasena.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("textBoxContrasena.BackgroundImage")));
            this.textBoxContrasena.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.textBoxContrasena.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.textBoxContrasena.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.textBoxContrasena.BorderColorIdle = System.Drawing.Color.Silver;
            this.textBoxContrasena.BorderRadius = 1;
            this.textBoxContrasena.BorderThickness = 1;
            this.textBoxContrasena.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.textBoxContrasena.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxContrasena.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.textBoxContrasena.DefaultText = "";
            this.textBoxContrasena.FillColor = System.Drawing.Color.White;
            this.textBoxContrasena.HideSelection = true;
            this.textBoxContrasena.IconLeft = null;
            this.textBoxContrasena.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxContrasena.IconPadding = 10;
            this.textBoxContrasena.IconRight = null;
            this.textBoxContrasena.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxContrasena.Lines = new string[0];
            this.textBoxContrasena.Location = new System.Drawing.Point(92, 74);
            this.textBoxContrasena.MaxLength = 32767;
            this.textBoxContrasena.MinimumSize = new System.Drawing.Size(1, 1);
            this.textBoxContrasena.Modified = false;
            this.textBoxContrasena.Multiline = false;
            this.textBoxContrasena.Name = "textBoxContrasena";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.textBoxContrasena.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.textBoxContrasena.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.textBoxContrasena.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.textBoxContrasena.OnIdleState = stateProperties4;
            this.textBoxContrasena.Padding = new System.Windows.Forms.Padding(3);
            this.textBoxContrasena.PasswordChar = '\0';
            this.textBoxContrasena.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.textBoxContrasena.PlaceholderText = "Contraseña";
            this.textBoxContrasena.ReadOnly = false;
            this.textBoxContrasena.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxContrasena.SelectedText = "";
            this.textBoxContrasena.SelectionLength = 0;
            this.textBoxContrasena.SelectionStart = 0;
            this.textBoxContrasena.ShortcutsEnabled = true;
            this.textBoxContrasena.Size = new System.Drawing.Size(187, 35);
            this.textBoxContrasena.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.textBoxContrasena.TabIndex = 62;
            this.textBoxContrasena.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBoxContrasena.TextMarginBottom = 0;
            this.textBoxContrasena.TextMarginLeft = 3;
            this.textBoxContrasena.TextMarginTop = 1;
            this.textBoxContrasena.TextPlaceholder = "Contraseña";
            this.textBoxContrasena.UseSystemPasswordChar = true;
            this.textBoxContrasena.WordWrap = true;
            // 
            // FormContrasena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(387, 162);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormContrasena";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormContrasena";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.UI.WinForms.BunifuImageButton bunifuImageButton1;
        private Bunifu.UI.WinForms.BunifuLabel label1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private System.Windows.Forms.Button buttonAceptar;
        private Bunifu.UI.WinForms.BunifuTextBox textBoxContrasena;
    }
}