namespace Proyecto2022.CapaPresentacion.VistaAdmin.Estadisticas
{
    partial class EstadisticasServicios
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.panelCategorias = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartGlobales = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelGlobales = new System.Windows.Forms.Panel();
            this.checkedListBoxCategorias = new System.Windows.Forms.CheckedListBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.saveFileDialog2 = new System.Windows.Forms.SaveFileDialog();
            this.panel2 = new System.Windows.Forms.Panel();
            this.checkedListBoxAnio = new System.Windows.Forms.CheckedListBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.checkBoxTodos = new System.Windows.Forms.CheckBox();
            this.panelCategorias.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartGlobales)).BeginInit();
            this.panelGlobales.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCategorias
            // 
            this.panelCategorias.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCategorias.Controls.Add(this.chart2);
            this.panelCategorias.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelCategorias.Location = new System.Drawing.Point(678, 18);
            this.panelCategorias.Name = "panelCategorias";
            this.panelCategorias.Size = new System.Drawing.Size(591, 728);
            this.panelCategorias.TabIndex = 23;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel1.Controls.Add(this.labelTitulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1269, 18);
            this.panel1.TabIndex = 21;
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.labelTitulo.ForeColor = System.Drawing.Color.White;
            this.labelTitulo.Location = new System.Drawing.Point(453, 0);
            this.labelTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(324, 19);
            this.labelTitulo.TabIndex = 2;
            this.labelTitulo.Text = "Estadísticas de Ventas de Servicios";
            // 
            // chart2
            // 
            chartArea1.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart2.Legends.Add(legend1);
            this.chart2.Location = new System.Drawing.Point(28, 335);
            this.chart2.Name = "chart2";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart2.Series.Add(series1);
            this.chart2.Size = new System.Drawing.Size(524, 343);
            this.chart2.TabIndex = 1;
            this.chart2.Text = "chart2";
            // 
            // chartGlobales
            // 
            chartArea2.Name = "ChartArea1";
            this.chartGlobales.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartGlobales.Legends.Add(legend2);
            this.chartGlobales.Location = new System.Drawing.Point(29, 335);
            this.chartGlobales.Name = "chartGlobales";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartGlobales.Series.Add(series2);
            this.chartGlobales.Size = new System.Drawing.Size(524, 343);
            this.chartGlobales.TabIndex = 2;
            this.chartGlobales.Text = "chartGlobales";
            title1.Name = "Title1";
            this.chartGlobales.Titles.Add(title1);
            // 
            // panelGlobales
            // 
            this.panelGlobales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGlobales.Controls.Add(this.panel2);
            this.panelGlobales.Controls.Add(this.chartGlobales);
            this.panelGlobales.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelGlobales.Location = new System.Drawing.Point(0, 18);
            this.panelGlobales.Name = "panelGlobales";
            this.panelGlobales.Size = new System.Drawing.Size(690, 728);
            this.panelGlobales.TabIndex = 22;
            // 
            // checkedListBoxCategorias
            // 
            this.checkedListBoxCategorias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.checkedListBoxCategorias.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.checkedListBoxCategorias.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.checkedListBoxCategorias.FormattingEnabled = true;
            this.checkedListBoxCategorias.Location = new System.Drawing.Point(16, 40);
            this.checkedListBoxCategorias.Name = "checkedListBoxCategorias";
            this.checkedListBoxCategorias.Size = new System.Drawing.Size(175, 122);
            this.checkedListBoxCategorias.TabIndex = 3;
            this.checkedListBoxCategorias.SelectedValueChanged += new System.EventHandler(this.checkedListBoxCategoria_SelectedValueChanged);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.checkedListBoxAnio);
            this.panel2.Location = new System.Drawing.Point(-1, 112);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(690, 195);
            this.panel2.TabIndex = 3;
            // 
            // checkedListBoxAnio
            // 
            this.checkedListBoxAnio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.checkedListBoxAnio.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.checkedListBoxAnio.FormattingEnabled = true;
            this.checkedListBoxAnio.Items.AddRange(new object[] {
            "2022",
            "2021"});
            this.checkedListBoxAnio.Location = new System.Drawing.Point(87, 80);
            this.checkedListBoxAnio.Name = "checkedListBoxAnio";
            this.checkedListBoxAnio.Size = new System.Drawing.Size(114, 49);
            this.checkedListBoxAnio.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.checkBoxTodos);
            this.panel3.Controls.Add(this.checkedListBoxCategorias);
            this.panel3.Location = new System.Drawing.Point(289, 14);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(218, 166);
            this.panel3.TabIndex = 5;
            // 
            // checkBoxTodos
            // 
            this.checkBoxTodos.AutoSize = true;
            this.checkBoxTodos.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.checkBoxTodos.Location = new System.Drawing.Point(16, 17);
            this.checkBoxTodos.Name = "checkBoxTodos";
            this.checkBoxTodos.Size = new System.Drawing.Size(56, 17);
            this.checkBoxTodos.TabIndex = 4;
            this.checkBoxTodos.Text = "Todos";
            this.checkBoxTodos.UseVisualStyleBackColor = true;
            this.checkBoxTodos.CheckStateChanged += new System.EventHandler(this.checkBoxTodos_CheckStateChanged);
            // 
            // EstadisticasServicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1269, 746);
            this.Controls.Add(this.panelCategorias);
            this.Controls.Add(this.panelGlobales);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "EstadisticasServicios";
            this.Text = "EstadisticasServicios";
            this.panelCategorias.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartGlobales)).EndInit();
            this.panelGlobales.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelCategorias;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGlobales;
        private System.Windows.Forms.Panel panelGlobales;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckedListBox checkedListBoxCategorias;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog2;
        private System.Windows.Forms.CheckedListBox checkedListBoxAnio;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckBox checkBoxTodos;
    }
}