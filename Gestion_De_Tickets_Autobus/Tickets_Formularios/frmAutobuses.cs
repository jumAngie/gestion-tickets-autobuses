using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_De_Tickets_Autobus
{
    public partial class frmAutobuses : Form
    {
        public frmAutobuses()
        {
            InitializeComponent();
        }

        #region VARIABLES
        private bool esVIP = false;
        #endregion

        #region VALIDACIONES Y LIMPIEZA DE CAMPOS
        public void OcultarValidaciones()
        {
            pnlMarca.Visible = false;
            pnlModelo.Visible = false;
            pnlMatricula.Visible = false;
            pnlAsientos.Visible = false;
        }

        public bool ValidacionesVacio()
        {
            bool esValido = true;

            // Validar campos
            if (cbxMarca.SelectedIndex == -1) { pnlMarca.Visible = true; esValido = false; }
            if (string.IsNullOrWhiteSpace(txtModelo.Text)) { pnlModelo.Visible = true; esValido = false; }
            if (string.IsNullOrWhiteSpace(txtMatricula.Text)) { pnlMatricula.Visible = true; esValido = false; }
            if (numAsientos.Value <= 0) { pnlAsientos.Visible = true; esValido = false; }

            // Ocultar errores si ya son válidos
            pnlMarca.Visible = cbxMarca.SelectedIndex == -1;
            pnlModelo.Visible = string.IsNullOrWhiteSpace(txtModelo.Text);
            pnlMatricula.Visible = string.IsNullOrWhiteSpace(txtMatricula.Text);
            pnlAsientos.Visible = numAsientos.Value <= 0;

            return esValido;
        }
        #endregion

        #region limpiar Campos
        public void LimpiarCampos()
        {
            cbxMarca.SelectedIndex = -1;
            txtModelo.Clear();
            txtMatricula.Clear();
            numAsientos.Value = 0;
            rbtVip.Checked = false;

            OcultarValidaciones();
        }
        #endregion

        #region MENSAJES
        public void MostrarAdvertencia()
        {
            lblAdvertencia.Visible = true;
        }

        public void OcultarAdvertencia()
        {
            lblAdvertencia.Visible = false;
        }
        #endregion

        #region EVENTOS DE LOS ELEMENTOS DEL FORMULARIO
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            OcultarAdvertencia();
        }

        private async void BtnGuardar_Click(object sender, EventArgs e)
        {
            bool esValido = ValidacionesVacio();
            if (esValido)
            {
                // Lógica para guardar los datos
                MessageBox.Show("Datos guardados correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimpiarCampos();
            }
            else
            {
                MostrarAdvertencia();
                await Task.Delay(5000);
                OcultarAdvertencia();
            }
        }

        private void btVip_CheckedChanged(object sender, EventArgs e)
        {
            esVIP = rbtVip.Checked;
        }
        #endregion
        #region Botones
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }
        #endregion


    }
}
