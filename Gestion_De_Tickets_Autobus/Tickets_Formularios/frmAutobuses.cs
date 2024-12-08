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
        #region VARIABLES
        private bool esVIP = false;
        private bool esNormal = false;
        #endregion
        

        public frmAutobuses()
        {
            InitializeComponent();
            
        }      
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
            if (string.IsNullOrWhiteSpace(cbxModelo.Text)) { pnlModelo.Visible = true; esValido = false; }
            if (string.IsNullOrWhiteSpace(txtMatricula.Text)) { pnlMatricula.Visible = true; esValido = false; }
            if (numAsientos.Value <= 0) { pnlAsientos.Visible = true; esValido = false; }

            // Ocultar errores si ya son válidos
            pnlMarca.Visible = cbxMarca.SelectedIndex == -1;
            pnlModelo.Visible = string.IsNullOrWhiteSpace(cbxModelo.Text);
            pnlMatricula.Visible = string.IsNullOrWhiteSpace(txtMatricula.Text);
            pnlAsientos.Visible = numAsientos.Value <= 0;

            return esValido;
        }
        #endregion

        #region limpiar Campos
        public void LimpiarCampos()
        {
            cbxMarca.SelectedIndex = -1;
            cbxModelo.SelectedIndex = -1;
            txtMatricula.Clear();
            numAsientos.Value = 0;
            rbtVip.Checked = false;
            rbtNormal.Checked = false;

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
            var result = MessageBox.Show("¿Está seguro de que desea cancelar?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                LimpiarCampos();
            }
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
            esNormal = !rbtVip.Checked;
        }

        private void rbtNormal_CheckedChanged(object sender, EventArgs e)
        {
            esNormal = rbtNormal.Checked;
            esVIP = !rbtNormal.Checked; 
        }

        private void btnSeleccionarImagen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Archivos de Imagen|*.jpg;*.jpeg;*.png;*.bmp";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    PicBuses.Image = Image.FromFile(ofd.FileName);
                }
            }
        }
        #endregion

      #region LLENANDO COMBOBOX
        public void CargarModeloCMB()
        {
           // cbxModelo.DataSource = Modelo.CargarModelo();
            cbxModelo.ValueMember = "mod_ID";
            cbxModelo.DisplayMember = "mod_Descripcion";
        }

        public void CargarMarcaCMB()
        {
           // cbxMarca.DataSource = Marca.CargarMarca();
            cbxMarca.ValueMember = " mar_ID";
            cbxMarca.DisplayMember = "mod_Descripcion";
        }
       
        #endregion

        #region borrar esto  
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }
        #endregion


    }
}
