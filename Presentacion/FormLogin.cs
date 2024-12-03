using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Datos;

namespace Presentacion
{
    public partial class FormLogin : Form
    {
        private NClient nClient = new NClient();
        public FormLogin()
        {
            InitializeComponent();
        }

        private void AbrirFormularioSecundario(Form formularioSecundario)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                formularioSecundario.WindowState = FormWindowState.Maximized;
            }
            else
            {
                formularioSecundario.WindowState = FormWindowState.Normal;
            }

            formularioSecundario.Show();
        }

        private void btnRegistrar_Click(object sender, EventArgs e) //era btnIngresar xd
        {
            DClient dClient = new DClient();
            Client clientTemp=  nClient.Login(tbUser.Texts.Trim(), tbContrasenia.Texts.Trim());
            if (clientTemp == null)
            {
                MessageBox.Show("El usuario no existe");
                return;
            }

            FormProductos form = new FormProductos();
            AbrirFormularioSecundario(form);
            this.Hide(); 
            form.FormClosed += (s, args) => this.Close(); 
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblHidePassword_Click(object sender, EventArgs e)
        {
            tbContrasenia.PasswordChar = true;
            lblHidePassword.Visible = false;
            lblShowPassword.Visible = true;
        }

        private void lblShowPassword_Click(object sender, EventArgs e)
        {
            tbContrasenia.PasswordChar = false;
            lblHidePassword.Visible = true;
            lblShowPassword.Visible = false;
        }
    }
}
