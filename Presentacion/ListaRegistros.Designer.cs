namespace Presentacion
{
    partial class ListaRegistros
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.fechahasta = new System.Windows.Forms.DateTimePicker();
            this.BuscaFecha = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.ListaTabla = new System.Windows.Forms.DataGridView();
            this.Iddocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreVendedor1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rfc1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.facturaNumero1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentosTablaBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.EditarRegistro = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.documentosTablaBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.documentosTablaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.documentosTablaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListaTabla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentosTablaBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentosTablaBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentosTablaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentosTablaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel1.Controls.Add(this.iconButton2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.fechahasta);
            this.panel1.Controls.Add(this.BuscaFecha);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.iconButton4);
            this.panel1.Controls.Add(this.ListaTabla);
            this.panel1.Controls.Add(this.iconButton3);
            this.panel1.Controls.Add(this.EditarRegistro);
            this.panel1.Controls.Add(this.iconButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(771, 500);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(351, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 21);
            this.label2.TabIndex = 10;
            this.label2.Text = "HASTA:";
            // 
            // fechahasta
            // 
            this.fechahasta.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fechahasta.Location = new System.Drawing.Point(417, 73);
            this.fechahasta.Name = "fechahasta";
            this.fechahasta.Size = new System.Drawing.Size(261, 23);
            this.fechahasta.TabIndex = 9;
            // 
            // BuscaFecha
            // 
            this.BuscaFecha.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BuscaFecha.Location = new System.Drawing.Point(73, 74);
            this.BuscaFecha.Name = "BuscaFecha";
            this.BuscaFecha.Size = new System.Drawing.Size(272, 23);
            this.BuscaFecha.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "DESDE:";
            // 
            // iconButton4
            // 
            this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton4.IconColor = System.Drawing.Color.Black;
            this.iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton4.Location = new System.Drawing.Point(684, 73);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Size = new System.Drawing.Size(75, 23);
            this.iconButton4.TabIndex = 6;
            this.iconButton4.Text = "Buscar";
            this.iconButton4.UseVisualStyleBackColor = true;
            this.iconButton4.Click += new System.EventHandler(this.iconButton4_Click);
            // 
            // ListaTabla
            // 
            this.ListaTabla.AutoGenerateColumns = false;
            this.ListaTabla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.ListaTabla.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ListaTabla.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(65)))), ((int)(((byte)(91)))));
            this.ListaTabla.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListaTabla.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ListaTabla.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ListaTabla.ColumnHeadersHeight = 42;
            this.ListaTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.ListaTabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Iddocumento,
            this.nombreVendedor1DataGridViewTextBoxColumn,
            this.rfc1DataGridViewTextBoxColumn,
            this.facturaNumero1DataGridViewTextBoxColumn,
            this.fecha1DataGridViewTextBoxColumn});
            this.ListaTabla.DataSource = this.documentosTablaBindingSource3;
            this.ListaTabla.EnableHeadersVisualStyles = false;
            this.ListaTabla.GridColor = System.Drawing.Color.SteelBlue;
            this.ListaTabla.Location = new System.Drawing.Point(3, 119);
            this.ListaTabla.MultiSelect = false;
            this.ListaTabla.Name = "ListaTabla";
            this.ListaTabla.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ListaTabla.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ListaTabla.RowHeadersWidth = 30;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(65)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.ListaTabla.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.ListaTabla.RowTemplate.Height = 25;
            this.ListaTabla.Size = new System.Drawing.Size(656, 378);
            this.ListaTabla.TabIndex = 2;
            // 
            // Iddocumento
            // 
            this.Iddocumento.DataPropertyName = "Iddocumento";
            this.Iddocumento.HeaderText = "Iddocumento";
            this.Iddocumento.Name = "Iddocumento";
            this.Iddocumento.Visible = false;
            this.Iddocumento.Width = 134;
            // 
            // nombreVendedor1DataGridViewTextBoxColumn
            // 
            this.nombreVendedor1DataGridViewTextBoxColumn.DataPropertyName = "NombreVendedor1";
            this.nombreVendedor1DataGridViewTextBoxColumn.HeaderText = "NOMBRE DEL VENDEDOR";
            this.nombreVendedor1DataGridViewTextBoxColumn.Name = "nombreVendedor1DataGridViewTextBoxColumn";
            this.nombreVendedor1DataGridViewTextBoxColumn.Width = 214;
            // 
            // rfc1DataGridViewTextBoxColumn
            // 
            this.rfc1DataGridViewTextBoxColumn.DataPropertyName = "Rfc1";
            this.rfc1DataGridViewTextBoxColumn.HeaderText = "RFC";
            this.rfc1DataGridViewTextBoxColumn.Name = "rfc1DataGridViewTextBoxColumn";
            this.rfc1DataGridViewTextBoxColumn.Width = 61;
            // 
            // facturaNumero1DataGridViewTextBoxColumn
            // 
            this.facturaNumero1DataGridViewTextBoxColumn.DataPropertyName = "FacturaNumero1";
            this.facturaNumero1DataGridViewTextBoxColumn.HeaderText = "NUMERO DE FACTURA";
            this.facturaNumero1DataGridViewTextBoxColumn.Name = "facturaNumero1DataGridViewTextBoxColumn";
            this.facturaNumero1DataGridViewTextBoxColumn.Width = 193;
            // 
            // fecha1DataGridViewTextBoxColumn
            // 
            this.fecha1DataGridViewTextBoxColumn.DataPropertyName = "Fecha1";
            this.fecha1DataGridViewTextBoxColumn.HeaderText = "FECHA";
            this.fecha1DataGridViewTextBoxColumn.Name = "fecha1DataGridViewTextBoxColumn";
            this.fecha1DataGridViewTextBoxColumn.Width = 81;
            // 
            // documentosTablaBindingSource3
            // 
            this.documentosTablaBindingSource3.DataSource = typeof(Domain.DocumentosTabla);
            // 
            // iconButton3
            // 
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton3.IconColor = System.Drawing.Color.Black;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.Location = new System.Drawing.Point(684, 243);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(75, 23);
            this.iconButton3.TabIndex = 4;
            this.iconButton3.Text = "Imprimir";
            this.iconButton3.UseVisualStyleBackColor = true;
            this.iconButton3.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // EditarRegistro
            // 
            this.EditarRegistro.IconChar = FontAwesome.Sharp.IconChar.None;
            this.EditarRegistro.IconColor = System.Drawing.Color.Black;
            this.EditarRegistro.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.EditarRegistro.Location = new System.Drawing.Point(684, 175);
            this.EditarRegistro.Name = "EditarRegistro";
            this.EditarRegistro.Size = new System.Drawing.Size(75, 23);
            this.EditarRegistro.TabIndex = 3;
            this.EditarRegistro.Text = "Editar";
            this.EditarRegistro.UseVisualStyleBackColor = true;
            this.EditarRegistro.Click += new System.EventHandler(this.EditarRegistro_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.iconButton1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.iconButton1.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonFace;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(3, 3);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(81, 34);
            this.iconButton1.TabIndex = 1;
            this.iconButton1.Text = "Volver ";
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // documentosTablaBindingSource2
            // 
            this.documentosTablaBindingSource2.DataSource = typeof(Domain.DocumentosTabla);
            // 
            // documentosTablaBindingSource1
            // 
            this.documentosTablaBindingSource1.DataSource = typeof(Domain.DocumentosTabla);
            // 
            // documentosTablaBindingSource
            // 
            this.documentosTablaBindingSource.DataSource = typeof(Domain.DocumentosTabla);
            // 
            // iconButton2
            // 
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.Location = new System.Drawing.Point(684, 304);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(75, 23);
            this.iconButton2.TabIndex = 11;
            this.iconButton2.Text = "iconButton2";
            this.iconButton2.UseVisualStyleBackColor = true;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // ListaRegistros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 500);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListaRegistros";
            this.Text = "ListaRegistros";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListaTabla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentosTablaBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentosTablaBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentosTablaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentosTablaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton EditarRegistro;
        private System.Windows.Forms.DataGridView ListaTabla;
        private System.Windows.Forms.BindingSource documentosTablaBindingSource;
        private System.Windows.Forms.BindingSource documentosTablaBindingSource1;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton iconButton4;
        private System.Windows.Forms.DateTimePicker BuscaFecha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker fechahasta;
        private System.Windows.Forms.BindingSource documentosTablaBindingSource2;
        private System.Windows.Forms.BindingSource documentosTablaBindingSource3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Iddocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreVendedor1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rfc1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn facturaNumero1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha1DataGridViewTextBoxColumn;
        private FontAwesome.Sharp.IconButton iconButton2;
    }
}