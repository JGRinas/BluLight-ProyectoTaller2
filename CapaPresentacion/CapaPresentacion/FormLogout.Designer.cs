namespace CapaPresentacion
{
    partial class FormLogout
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
            this.bunifuPictureBox1 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.labelLogout = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.progressBar1 = new Bunifu.UI.WinForms.BunifuCircleProgress();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuPictureBox1
            // 
            this.bunifuPictureBox1.AllowFocused = false;
            this.bunifuPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuPictureBox1.AutoSizeHeight = true;
            this.bunifuPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.bunifuPictureBox1.BorderRadius = 0;
            this.bunifuPictureBox1.Image = global::CapaPresentacion.Properties.Resources.marca;
            this.bunifuPictureBox1.IsCircle = false;
            this.bunifuPictureBox1.Location = new System.Drawing.Point(163, -182);
            this.bunifuPictureBox1.Name = "bunifuPictureBox1";
            this.bunifuPictureBox1.Size = new System.Drawing.Size(684, 684);
            this.bunifuPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuPictureBox1.TabIndex = 1;
            this.bunifuPictureBox1.TabStop = false;
            this.bunifuPictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            // 
            // labelLogout
            // 
            this.labelLogout.AutoSize = true;
            this.labelLogout.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogout.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelLogout.Location = new System.Drawing.Point(382, 322);
            this.labelLogout.Name = "labelLogout";
            this.labelLogout.Size = new System.Drawing.Size(210, 33);
            this.labelLogout.TabIndex = 2;
            this.labelLogout.Text = "¡Hasta luego!";
            // 
            // timer1
            // 
            this.timer1.Interval = 40;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 40;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // progressBar1
            // 
            this.progressBar1.Animated = false;
            this.progressBar1.AnimationInterval = 1;
            this.progressBar1.AnimationSpeed = 1;
            this.progressBar1.BackColor = System.Drawing.Color.Transparent;
            this.progressBar1.CircleMargin = 10;
            this.progressBar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold);
            this.progressBar1.ForeColor = System.Drawing.Color.Transparent;
            this.progressBar1.IsPercentage = false;
            this.progressBar1.LineProgressThickness = 10;
            this.progressBar1.LineThickness = 10;
            this.progressBar1.Location = new System.Drawing.Point(388, 404);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.ProgressAnimationSpeed = 200;
            this.progressBar1.ProgressBackColor = System.Drawing.Color.Transparent;
            this.progressBar1.ProgressColor = System.Drawing.Color.WhiteSmoke;
            this.progressBar1.ProgressColor2 = System.Drawing.Color.PowderBlue;
            this.progressBar1.ProgressEndCap = Bunifu.UI.WinForms.BunifuCircleProgress.CapStyles.Round;
            this.progressBar1.ProgressFillStyle = Bunifu.UI.WinForms.BunifuCircleProgress.FillStyles.Solid;
            this.progressBar1.ProgressStartCap = Bunifu.UI.WinForms.BunifuCircleProgress.CapStyles.Round;
            this.progressBar1.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.progressBar1.Size = new System.Drawing.Size(184, 184);
            this.progressBar1.SubScriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.progressBar1.SubScriptMargin = new System.Windows.Forms.Padding(5, -20, 0, 0);
            this.progressBar1.SubScriptText = "";
            this.progressBar1.SuperScriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.progressBar1.SuperScriptMargin = new System.Windows.Forms.Padding(5, 20, 0, 0);
            this.progressBar1.SuperScriptText = "";
            this.progressBar1.TabIndex = 16;
            this.progressBar1.Text = "30";
            this.progressBar1.TextMargin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.progressBar1.Value = 30;
            this.progressBar1.ValueByTransition = 30;
            this.progressBar1.ValueMargin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            // 
            // FormLogout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.labelLogout);
            this.Controls.Add(this.bunifuPictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLogout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLogout";
            this.Load += new System.EventHandler(this.FormLogout_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox1;
        private System.Windows.Forms.Label labelLogout;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private Bunifu.UI.WinForms.BunifuCircleProgress progressBar1;
    }
}