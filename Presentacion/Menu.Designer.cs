namespace Presentacion
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtRegisUsu = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.LbName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FormPrincipal = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            this.FormPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.iconButton3);
            this.panel1.Controls.Add(this.iconButton1);
            this.panel1.Controls.Add(this.iconButton2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.txtRegisUsu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 568);
            this.panel1.TabIndex = 1;
            // 
            // iconButton3
            // 
            this.iconButton3.FlatAppearance.BorderSize = 0;
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.ArrowCircleRight;
            this.iconButton3.IconColor = System.Drawing.Color.Black;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.IconSize = 40;
            this.iconButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton3.Location = new System.Drawing.Point(12, 525);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(179, 40);
            this.iconButton3.TabIndex = 6;
            this.iconButton3.Text = "Terminar Sesión";
            this.iconButton3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton3.UseCompatibleTextRendering = true;
            this.iconButton3.UseVisualStyleBackColor = true;
            this.iconButton3.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.iconButton1.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonFace;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(12, 201);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(174, 40);
            this.iconButton1.TabIndex = 5;
            this.iconButton1.Text = "Lista de Registros";
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // iconButton2
            // 
            this.iconButton2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.iconButton2.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonFace;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.Location = new System.Drawing.Point(12, 155);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(174, 40);
            this.iconButton2.TabIndex = 4;
            this.iconButton2.Text = "Nuevo Registro";
            this.iconButton2.UseVisualStyleBackColor = false;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 129);
            this.panel2.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(21, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 101);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // txtRegisUsu
            // 
            this.txtRegisUsu.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.txtRegisUsu.FlatAppearance.BorderSize = 0;
            this.txtRegisUsu.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.txtRegisUsu.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtRegisUsu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtRegisUsu.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRegisUsu.IconChar = FontAwesome.Sharp.IconChar.None;
            this.txtRegisUsu.IconColor = System.Drawing.Color.Black;
            this.txtRegisUsu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.txtRegisUsu.Location = new System.Drawing.Point(12, 409);
            this.txtRegisUsu.Name = "txtRegisUsu";
            this.txtRegisUsu.Size = new System.Drawing.Size(174, 40);
            this.txtRegisUsu.TabIndex = 0;
            this.txtRegisUsu.Text = "Registar Usuarios";
            this.txtRegisUsu.UseVisualStyleBackColor = false;
            this.txtRegisUsu.Visible = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.btnMinimizar);
            this.panel3.Controls.Add(this.LbName);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(200, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(771, 68);
            this.panel3.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(381, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(61, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(739, 12);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(20, 20);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 10;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // LbName
            // 
            this.LbName.AutoSize = true;
            this.LbName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LbName.Location = new System.Drawing.Point(447, 20);
            this.LbName.Name = "LbName";
            this.LbName.Size = new System.Drawing.Size(77, 21);
            this.LbName.TabIndex = 0;
            this.LbName.Text = "USUARO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(448, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "______________________________";
            // 
            // FormPrincipal
            // 
            this.FormPrincipal.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.FormPrincipal.Controls.Add(this.label3);
            this.FormPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FormPrincipal.Location = new System.Drawing.Point(200, 68);
            this.FormPrincipal.Name = "FormPrincipal";
            this.FormPrincipal.Size = new System.Drawing.Size(771, 500);
            this.FormPrincipal.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(286, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 39);
            this.label3.TabIndex = 0;
            this.label3.Text = "BIENVENIDO";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(971, 568);
            this.Controls.Add(this.FormPrincipal);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            this.FormPrincipal.ResumeLayout(false);
            this.FormPrincipal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton txtRegisUsu;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label LbName;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton iconButton3;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel FormPrincipal;
        private System.Windows.Forms.Label label3;
    }
}