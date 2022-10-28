namespace CapaPresentacion.CapaPresentacion.VistaVendedor.Ventas.NuevaVentaSubForms
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
            this.panelBarra = new System.Windows.Forms.Panel();
            this.buttonMinimizar = new Bunifu.UI.WinForms.BunifuImageButton();
            this.buttonMaximizar = new Bunifu.UI.WinForms.BunifuImageButton();
            this.bunifuImageButton1 = new Bunifu.UI.WinForms.BunifuImageButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonFinalizarCompra = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelCliente = new System.Windows.Forms.Label();
            this.labelVendedor = new System.Windows.Forms.Label();
            this.textBoxProductos = new System.Windows.Forms.TextBox();
            this.panelBarra.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBarra
            // 
            this.panelBarra.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelBarra.Controls.Add(this.buttonMinimizar);
            this.panelBarra.Controls.Add(this.buttonMaximizar);
            this.panelBarra.Controls.Add(this.bunifuImageButton1);
            this.panelBarra.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarra.Location = new System.Drawing.Point(0, 0);
            this.panelBarra.Name = "panelBarra";
            this.panelBarra.Size = new System.Drawing.Size(400, 34);
            this.panelBarra.TabIndex = 1;
            this.panelBarra.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelBarra_MouseDown);
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
            this.buttonMinimizar.ImageSize = new System.Drawing.Size(14, 10);
            this.buttonMinimizar.ImageZoomSize = new System.Drawing.Size(34, 30);
            this.buttonMinimizar.InitialImage = ((System.Drawing.Image)(resources.GetObject("buttonMinimizar.InitialImage")));
            this.buttonMinimizar.Location = new System.Drawing.Point(294, 0);
            this.buttonMinimizar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonMinimizar.Name = "buttonMinimizar";
            this.buttonMinimizar.Rotation = 0;
            this.buttonMinimizar.ShowActiveImage = true;
            this.buttonMinimizar.ShowCursorChanges = true;
            this.buttonMinimizar.ShowImageBorders = true;
            this.buttonMinimizar.ShowSizeMarkers = false;
            this.buttonMinimizar.Size = new System.Drawing.Size(34, 30);
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
            this.buttonMaximizar.ImageSize = new System.Drawing.Size(14, 10);
            this.buttonMaximizar.ImageZoomSize = new System.Drawing.Size(34, 30);
            this.buttonMaximizar.InitialImage = ((System.Drawing.Image)(resources.GetObject("buttonMaximizar.InitialImage")));
            this.buttonMaximizar.Location = new System.Drawing.Point(328, 0);
            this.buttonMaximizar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonMaximizar.Name = "buttonMaximizar";
            this.buttonMaximizar.Rotation = 0;
            this.buttonMaximizar.ShowActiveImage = true;
            this.buttonMaximizar.ShowCursorChanges = true;
            this.buttonMaximizar.ShowImageBorders = true;
            this.buttonMaximizar.ShowSizeMarkers = false;
            this.buttonMaximizar.Size = new System.Drawing.Size(34, 30);
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
            this.bunifuImageButton1.ImageSize = new System.Drawing.Size(14, 10);
            this.bunifuImageButton1.ImageZoomSize = new System.Drawing.Size(34, 30);
            this.bunifuImageButton1.InitialImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.InitialImage")));
            this.bunifuImageButton1.Location = new System.Drawing.Point(362, 0);
            this.bunifuImageButton1.Margin = new System.Windows.Forms.Padding(2);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Rotation = 0;
            this.bunifuImageButton1.ShowActiveImage = true;
            this.bunifuImageButton1.ShowCursorChanges = true;
            this.bunifuImageButton1.ShowImageBorders = true;
            this.bunifuImageButton1.ShowSizeMarkers = false;
            this.bunifuImageButton1.Size = new System.Drawing.Size(34, 30);
            this.bunifuImageButton1.TabIndex = 13;
            this.bunifuImageButton1.ToolTipText = "";
            this.bunifuImageButton1.WaitOnLoad = false;
            this.bunifuImageButton1.Zoom = 20;
            this.bunifuImageButton1.ZoomSpeed = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.textBoxProductos);
            this.panel1.Controls.Add(this.labelVendedor);
            this.panel1.Controls.Add(this.labelCliente);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 369);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.buttonFinalizarCompra);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 403);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(400, 47);
            this.panel2.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(10, 301);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(168, 21);
            this.comboBox1.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(10, 279);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 19);
            this.label1.TabIndex = 46;
            this.label1.Text = "Método de pago";
            // 
            // buttonFinalizarCompra
            // 
            this.buttonFinalizarCompra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFinalizarCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFinalizarCompra.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFinalizarCompra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonFinalizarCompra.Location = new System.Drawing.Point(121, 6);
            this.buttonFinalizarCompra.Margin = new System.Windows.Forms.Padding(2);
            this.buttonFinalizarCompra.Name = "buttonFinalizarCompra";
            this.buttonFinalizarCompra.Size = new System.Drawing.Size(154, 31);
            this.buttonFinalizarCompra.TabIndex = 45;
            this.buttonFinalizarCompra.Text = "Finalizar Compra";
            this.buttonFinalizarCompra.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(10, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 19);
            this.label2.TabIndex = 47;
            this.label2.Text = "Productos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(10, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 19);
            this.label3.TabIndex = 48;
            this.label3.Text = "Cliente:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(10, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 19);
            this.label4.TabIndex = 49;
            this.label4.Text = "Vendedor:";
            // 
            // labelCliente
            // 
            this.labelCliente.AutoSize = true;
            this.labelCliente.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCliente.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelCliente.Location = new System.Drawing.Point(97, 174);
            this.labelCliente.Name = "labelCliente";
            this.labelCliente.Size = new System.Drawing.Size(18, 19);
            this.labelCliente.TabIndex = 50;
            this.labelCliente.Text = "C";
            // 
            // labelVendedor
            // 
            this.labelVendedor.AutoSize = true;
            this.labelVendedor.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVendedor.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelVendedor.Location = new System.Drawing.Point(97, 223);
            this.labelVendedor.Name = "labelVendedor";
            this.labelVendedor.Size = new System.Drawing.Size(18, 19);
            this.labelVendedor.TabIndex = 51;
            this.labelVendedor.Text = "V";
            // 
            // textBoxProductos
            // 
            this.textBoxProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.textBoxProductos.Enabled = false;
            this.textBoxProductos.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxProductos.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxProductos.Location = new System.Drawing.Point(15, 44);
            this.textBoxProductos.Multiline = true;
            this.textBoxProductos.Name = "textBoxProductos";
            this.textBoxProductos.Size = new System.Drawing.Size(371, 118);
            this.textBoxProductos.TabIndex = 52;
            // 
            // FinalizarCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(400, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelBarra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FinalizarCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FinalizarCompra";
            this.panelBarra.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBarra;
        private Bunifu.UI.WinForms.BunifuImageButton buttonMinimizar;
        private Bunifu.UI.WinForms.BunifuImageButton buttonMaximizar;
        private Bunifu.UI.WinForms.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button buttonFinalizarCompra;
        private System.Windows.Forms.Label labelVendedor;
        private System.Windows.Forms.Label labelCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxProductos;
    }
}