using Domain;
using SIGEFOAUSE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            BotonVisible();
            PresentarDatosUsuario();
        }

        public void BotonVisible()
        {
            Modelo modelo = new Modelo();

            if (modelo.BuscarRol())
            {
                txtRegisUsu.Visible = true;

            }
        }

        public void PresentarDatosUsuario()
        {
            Modelo modelo = new Modelo();

            if (modelo.DatosUsuario())
            {
                string nombres = llegadaDatos.FirstName;
                string apellidos = llegadaDatos.LastName;
                LbName.Text = nombres + " " + apellidos;

            }
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        private Form FormularioActivo = null;
        private void AbrirFormulario(Form FormularioHijo)
        {
            if (FormularioActivo != null)
            {
                FormularioActivo.Close();
            }
            FormularioActivo = FormularioHijo;
            FormularioHijo.TopLevel = false;
            FormularioHijo.FormBorderStyle = FormBorderStyle.None;
            FormularioHijo.Dock = DockStyle.Fill;
            FormPrincipal.Controls.Add(FormularioHijo);
            FormPrincipal.Tag = FormularioHijo;
            FormularioHijo.BringToFront();
            FormularioHijo.Show();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new RegistrarDatos());

        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estas Seguro de Cerrar Sesíón?", "Atención",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
                FormLogin fl = new FormLogin();
                fl.Show();
            }

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (FormularioActivo == null)
            {
                AbrirFormulario(new ListaRegistros());
                
            }
            else
            {
                                
                if (MessageBox.Show("¿Deseas Cancelar la Operación Anterior?", "Atención",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    AbrirFormulario(new ListaRegistros());
                    FormularioActivo = null;
                    
                }
            }
        }
    }
}

