using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Gestion_De_Tickets_Autobus
{
    public partial class frmEmpleado : Form
    {



        #region VARIABLES
        private int sexo = 0;
        private int empleado = 1;
        #endregion
        public frmEmpleado()
        {
            InitializeComponent();
        }


        #region VALIDACIONES Y LIMPIEZA DE CAMPOS
        public void panel_OcultarValidaciones()
        {
            pnlnombre.Visible = false;
            pnlDNI.Visible = false;
            pnlTel.Visible = false;
            pnlcorreo.Visible = false;

            pnlpais.Visible = false;
            pnldepto.Visible = false;
            pnlciudad.Visible = false;

            pnlDIRE.Visible = false;
            pnlDNIE.Visible = false;
        }
        public bool ValidacionesVacio()
        {
            bool esvalido = true;

            // mostrar error
            if (txtNombre.Text == "") { pnlnombre.Visible = true; esvalido = false; }
            if (txtEmail.Text == "") { pnlcorreo.Visible = true; esvalido = false; }
            if (txtTelefono.Text == "") { pnlTel.Visible = true; esvalido = false; }

            // Validación condicional del DNI y DNIE
            if (rbH.Checked && !mtxtidentidad.MaskFull) // Si está seleccionado el radio button de DNI
            {
                pnlDNI.Visible = true;
                esvalido = false;
            }
            else
            {
                pnlDNI.Visible = false;
            }

            if (rbE.Checked && txtDNIE.Text == "") // Si está seleccionado el radio button de DNIE
            {
                pnlDNIE.Visible = true;
                esvalido = false;
            }
            else
            {
                pnlDNIE.Visible = false;
            }

            if (cbxpais.SelectedIndex == 0 || cbxpais.SelectedIndex == -1) { pnlpais.Visible = true; esvalido = false; }
            if (cbxdepto.SelectedIndex == 0 || cbxdepto.SelectedIndex == -1) { pnldepto.Visible = true; esvalido = false; }
            if (cbxciudad.SelectedIndex == 0 || cbxciudad.SelectedIndex == -1) { pnlciudad.Visible = true; esvalido = false; }
            if (txtDirE.Text == "") { pnlDIRE.Visible = true; esvalido = false; }

            // esconder error
            pnlnombre.Visible = txtNombre.Text == "";
            pnlcorreo.Visible = txtEmail.Text == "";
            pnlTel.Visible = txtTelefono.Text == "";
            pnlpais.Visible = cbxpais.SelectedIndex == 0 || cbxpais.SelectedIndex == -1;
            pnldepto.Visible = cbxdepto.SelectedIndex == 0 || cbxdepto.SelectedIndex == -1;
            pnlciudad.Visible = cbxciudad.SelectedIndex == 0 || cbxciudad.SelectedIndex == -1;
            pnlDIRE.Visible = txtDirE.Text == "";

            return esvalido;
        }

        //LIMPIEZA DE CAMPOS
        public void LimpiarCampos()
        {
            txtNombre.Clear();
            txtTelefono.Clear();
            txtDirE.Clear();
            txtEmail.Clear();
            mtxtidentidad.Clear();
            txtDNIE.Clear();
            rbH.Checked = false;
            rbE.Checked = false;
            rbF.Checked = false;
            rbM.Checked = false;
            cbxciudad.Enabled = false;
            cbxdepto.Enabled = false;
            cbxdepto.Text = "Seleccione un país.";
            cbxciudad.Text = "Seleccione un departamento.";
            //cbxpais.SelectedIndex = 0;
            dtFechaNacimiento.Value = DateTime.Now;
            lblidentidad.Visible = false;
            mtxtidentidad.Visible = false;
            lblDNIE.Visible = false;
            txtDNIE.Visible = false;

        }
        #endregion

        #region MENSAJES
        public void MensajeAdvertencia()
        {
            lblAdvertencia.Visible = true;
        }
        public void MensajeAdvertencia_Hide()
        {
            lblAdvertencia.Visible = false;
        }
        #endregion

        #region EVENTOS DE LOS ELEMENTOS DEL FORMULARIO
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            panel_OcultarValidaciones();
            MensajeAdvertencia_Hide();
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            bool esValido = ValidacionesVacio();
            if (esValido)
            {
               
                LimpiarCampos();

            }
            else
            {
                MensajeAdvertencia();
                await Task.Delay(5000);
                MensajeAdvertencia_Hide();
            }
        }
        private void rbH_CheckedChanged(object sender, EventArgs e)
        {
            lblidentidad.Visible = true;
            mtxtidentidad.Visible = true;
            lblDNIE.Visible = false;
            txtDNIE.Visible = false;
        }

        private void rbE_CheckedChanged(object sender, EventArgs e)
        {
            lblidentidad.Visible = false;
            mtxtidentidad.Visible = false;
            lblDNIE.Visible = true;
            txtDNIE.Visible = true;

        }
        #endregion

    }
}

