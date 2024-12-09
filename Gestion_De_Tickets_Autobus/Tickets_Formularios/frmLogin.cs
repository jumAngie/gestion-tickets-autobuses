using Gestion_De_Tickets_Autobus.Tickets_ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_De_Tickets_Autobus.Tickets_Formularios
{
    public partial class frmLogin : Form
    {
        LoginDAL login = new LoginDAL();
        public frmLogin()
        {
            InitializeComponent();
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {

        }
        ErrorProvider txtusuarioError = new ErrorProvider();
        ErrorProvider txtContraseniaError = new ErrorProvider();

        public bool ValidarVacio()
        {
            bool esValido = false;
            // Mostrar advertencias
            if (txtUsuario.Text == "")
            {
                pnlValidarUsuario.Visible = true;
                txtusuarioError.SetError(txtUsuario, "Usuario inválido.");
            }
            if (txtContrasenia.Text == "")
            {
                pnlValidarContra.Visible = true;
                txtContraseniaError.SetError(txtContrasenia, "Contraseña inválida.");
            }

            // Quitar advertencias
            if (txtUsuario.Text != "")
            {
                pnlValidarUsuario.Visible = false;
                txtusuarioError.Clear();
            }
            if (txtContrasenia.Text != "")
            {
                pnlValidarContra.Visible = false;
                txtContraseniaError.Clear();
            }

            if (txtUsuario.Text != "" && txtContrasenia.Text != "") esValido = true;

            return esValido;
        }

        private void txtUsuario_Click(object sender, EventArgs e)
        {
            txtUsuario.BackColor = Color.WhiteSmoke;
            pnlUsuario.BackColor = Color.WhiteSmoke;
            pnlContrasenia.BackColor = Color.White;
            txtContrasenia.BackColor = Color.White;
        }

        private void txtContrasenia_Click(object sender, EventArgs e)
        {
            txtContrasenia.BackColor = Color.WhiteSmoke;
            pnlContrasenia.BackColor = Color.WhiteSmoke;
            txtUsuario.BackColor = Color.White;
            pnlUsuario.BackColor = Color.White;
        }

        private void pbxUsuario_MouseDown(object sender, MouseEventArgs e)
        {
            txtUsuario.BackColor = Color.WhiteSmoke;
            pnlUsuario.BackColor = Color.WhiteSmoke;
            pnlContrasenia.BackColor = Color.White;
            txtContrasenia.BackColor = Color.White;
        }

        private void pbxContrasenia_MouseDown(object sender, MouseEventArgs e)
        {
            txtContrasenia.UseSystemPasswordChar = false;
            txtContrasenia.BackColor = Color.WhiteSmoke;
            pnlContrasenia.BackColor = Color.WhiteSmoke;
            txtUsuario.BackColor = Color.White;
            pnlUsuario.BackColor = Color.White;
        }

        private void pbxContrasenia_MouseUp(object sender, MouseEventArgs e)
        {
            txtContrasenia.UseSystemPasswordChar = true;
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            bool puedeAutenticar = ValidarVacio();
            if (puedeAutenticar)
            {
                string Usuario = txtUsuario.Text;
                string Contrasenia = txtContrasenia.Text;
                DatosUsuarioViewModel usuarioAutenticado = login.AutenticarUsuario(Usuario, Contrasenia);
                if (usuarioAutenticado != null)
                {
                    lblError.Visible = false;
                    List<PantallasViewModel> pantallasPermitidas = login.ObtenerPantallasPermitidas(usuarioAutenticado.role_Id);
                    frmPrincipal formularioPrincipal = new frmPrincipal
                    {
                        UsuarioActual = usuarioAutenticado,
                        pantallasPermitidas = pantallasPermitidas
                    };
                    formularioPrincipal.Show();
                    this.Hide();
                }
                else
                {
                    lblError.Visible = true;
                }
            }
        }
    }
}
