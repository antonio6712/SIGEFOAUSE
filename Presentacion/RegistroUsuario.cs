using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Domain;
using SIGEFOAUSE;

namespace Presentacion
{
    public partial class RegistroUsuario : Form
    {
        public RegistroUsuario()
        {
            InitializeComponent();
            
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


        private void txtIngreso_Enter(object sender, EventArgs e)
        {
            if (txtIngreso.Text == "(CLICK AQUI)")
            {
                txtIngreso.Text = "";
                txtIngreso.ForeColor = Color.Black;
            }
        }

        private void txtIngreso_Leave(object sender, EventArgs e)
        {
            if (txtIngreso.Text == "")
            {
                txtIngreso.Text = "(CLICK AQUI)";
                txtIngreso.ForeColor = Color.Black;
            }
        }

        private void txtpass_Enter(object sender, EventArgs e)
        {
            if (txtpass.Text == "(CLICK AQUI)")
            {
                txtpass.Text = "";
                txtpass.ForeColor = Color.Black;
                txtpass.UseSystemPasswordChar = true;
            }
        }

        private void txtpass_Leave(object sender, EventArgs e)
        {
            if (txtpass.Text == "")
            {
                txtpass.Text = "(CLICK AQUI)";
                txtpass.ForeColor = Color.Black;
                txtpass.UseSystemPasswordChar = false;
            }
        }

        private void txtNombres_Enter(object sender, EventArgs e)
        {
            if (txtNombres.Text == "(CLICK AQUI)")
            {
                txtNombres.Text = "";
                txtNombres.ForeColor = Color.Black;
            }
        }

        private void txtNombres_Leave(object sender, EventArgs e)
        {
            if (txtNombres.Text == "")
            {
                txtNombres.Text = "(CLICK AQUI)";
                txtNombres.ForeColor = Color.Black;
            }
        }


        private void txtApellidos_Enter(object sender, EventArgs e)
        {
            if (txtApellidos.Text == "(CLICK AQUI)")
            {
                txtApellidos.Text = "";
                txtApellidos.ForeColor = Color.Black;
            }
        }

        private void txtApellidos_Leave(object sender, EventArgs e)
        {
            if (txtApellidos.Text == "")
            {
                txtApellidos.Text = "(CLICK AQUI)";
                txtApellidos.ForeColor = Color.Black;
            }
        }

        private void txtCorreo_Enter(object sender, EventArgs e)
        {
            if (txtCorreo.Text == "(CLICK AQUI)")
            {
                txtCorreo.Text = "";
                txtCorreo.ForeColor = Color.Black;
            }
        }

        private void txtCorreo_Leave(object sender, EventArgs e)
        {
            if (txtCorreo.Text == "")
            {
                txtCorreo.Text = "(CLICK AQUI)";
                txtCorreo.ForeColor = Color.Black;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void RegistroUsuario_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        public void limpiar()
        {
            txtIngreso.Clear();
            txtpass.Clear();
            txtNombres.Clear();
            txtApellidos.Clear();
            txtCorreo.Clear();
        }
              

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Usuarios usuario = new Usuarios();
            usuario.LoginName1 = txtIngreso.Text;
            usuario.Password1 = txtpass.Text;
            usuario.FirstName1 = txtNombres.Text;
            usuario.LastName1 = txtApellidos.Text;
            usuario.Email1 = txtCorreo.Text;

            try
            {
                Control control = new Control();
                string respuesta = control.ctrlRegistro(usuario);

                if (respuesta.Length > 0)
                {
                    MessageBox.Show(respuesta, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Usuario Registrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
                
    }
}
