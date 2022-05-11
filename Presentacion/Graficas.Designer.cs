namespace Presentacion
{
    partial class Graficas
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.chart = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.chart);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.ForeColor = System.Drawing.SystemColors.Control;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(771, 500);
            this.panel1.TabIndex = 0;
            // 
            // chart
            // 
            this.chart.BorderAppearance.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(100)))), ((int)(((byte)(142)))));
            this.chart.BorderAppearance.Interior.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(140)))), ((int)(((byte)(171)))));
            this.chart.ChartArea.BorderColor = System.Drawing.Color.Transparent;
            this.chart.ChartArea.CursorLocation = new System.Drawing.Point(0, 0);
            this.chart.ChartArea.CursorReDraw = false;
            this.chart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chart.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.chart.IsWindowLess = false;
            // 
            // 
            // 
            this.chart.Legend.Location = new System.Drawing.Point(662, 75);
            this.chart.Localize = null;
            this.chart.Location = new System.Drawing.Point(0, 0);
            this.chart.Name = "chart";
            this.chart.Palette = Syncfusion.Windows.Forms.Chart.ChartColorPalette.Metro;
            this.chart.PrimaryXAxis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.chart.PrimaryXAxis.GridLineType.ForeColor = System.Drawing.Color.LightGray;
            this.chart.PrimaryXAxis.LineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.chart.PrimaryXAxis.LogLabelsDisplayMode = Syncfusion.Windows.Forms.Chart.LogLabelsDisplayMode.Default;
            this.chart.PrimaryXAxis.Margin = true;
            this.chart.PrimaryXAxis.MinorGridLineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.chart.PrimaryXAxis.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.chart.PrimaryXAxis.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.chart.PrimaryXAxis.TitleFont = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chart.PrimaryYAxis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.chart.PrimaryYAxis.GridLineType.ForeColor = System.Drawing.Color.LightGray;
            this.chart.PrimaryYAxis.LineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.chart.PrimaryYAxis.LogLabelsDisplayMode = Syncfusion.Windows.Forms.Chart.LogLabelsDisplayMode.Default;
            this.chart.PrimaryYAxis.Margin = true;
            this.chart.PrimaryYAxis.MinorGridLineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.chart.PrimaryYAxis.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.chart.PrimaryYAxis.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.chart.PrimaryYAxis.TitleFont = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chart.Series3D = true;
            this.chart.Size = new System.Drawing.Size(771, 500);
            this.chart.Skins = Syncfusion.Windows.Forms.Chart.Skins.Metro;
            this.chart.Style3D = true;
            this.chart.TabIndex = 0;
            this.chart.Text = "Autos Comprados";
            // 
            // 
            // 
            this.chart.Title.Name = "Default";
            this.chart.Titles.Add(this.chart.Title);
            this.chart.VisualTheme = "";
            // 
            // Graficas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 500);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Graficas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Graficas";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private OxyPlot.WindowsForms.PlotView plotView1;
        private Syncfusion.Windows.Forms.Chart.ChartControl chart;
    }
}