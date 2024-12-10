using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gestion_De_Tickets_Autobus.Tickets_DAL;
using Gestion_De_Tickets_Autobus.Tickets_Entities;
using Gestion_De_Tickets_Autobus.Tickets_ViewModels;

namespace Gestion_De_Tickets_Autobus
{
    public partial class frmAutobuses : Form

    {
        #region CLASES
        MarcasDAL marcas = new MarcasDAL();
        ModelosDAL modelos = new ModelosDAL();
        AutobusesDAL autobuses = new AutobusesDAL();
        #endregion

        #region VARIABLES
        private bool esVIP;
        private int id_filaseleccionada;
        #endregion

        public frmAutobuses()
        {
            InitializeComponent();

        }

        #region CRUD

        //INSERTAR
        public void InsertarAutobuses()
        {
            if (rbtEsVIP.Checked) esVIP = true;

            Autobuses aut = new Autobuses
            {
                aut_Matricula = txtMatricula.Text,
                mod_ID = Convert.ToInt32(cbxModelo.SelectedValue),
                aut_cantAsientos = Convert.ToInt32(numAsientos.Value),
                aut_esVIP = esVIP,
                aut_FechaCreacion = DateTime.Now,
                usu_UsuarioCreacion = 1
            };
            string resultados = AutobusesDAL.InsertarAutobuses(aut);
            MessageBox.Show(resultados, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        //listar
        public void CargarAutobuses()
        {
            dgAutobuses.DataSource = AutobusesDAL.ListarAutobuses();
        }
        public void RestablecerListaOriginal()
        {
            txtBuscar.Text = "";
            CargarAutobuses();
        }

        //buscar cliente
        public void BuscarAutobuses()
        {
            string filtro = txtBuscar.Text.Trim().ToLower();
            if (dgAutobuses.DataSource != null)
            {
                if (string.IsNullOrEmpty(filtro))
                {
                    RestablecerListaOriginal();
                    return;
                }

                var listaTickets = (List<AutobusesViewModel>)dgAutobuses.DataSource;
                var listaFiltrada = listaTickets.Where(t =>
                  t.aut_Matricula.ToLower().Contains(filtro) ||
                  t.mod_Descripcion.ToLower().Contains(filtro) ||
                  t.mar_Descripcion.ToLower().Contains(filtro)
                 ).ToList();

                dgAutobuses.DataSource = listaFiltrada;
            }
        }

        //CARGAR DATOS EDITAR
        public void Editar_CargarDatos(int aut_Id)
        {
            Autobuses autobuses = AutobusesDAL.EditarAutobuses_CargarInformacion(aut_Id);
            if (autobuses != null)
            {
                txtMatricula.Text = autobuses.aut_Matricula;
                esVIP = autobuses.aut_esVIP;
                if (esVIP == true)
                {
                    rbtEsVIP.Checked = true;
                }
                if (esVIP == false)
                {
                    rbtNormal.Checked = true;
                }
                cbxMarcas.SelectedValue = autobuses.mar_ID;
                CargarModelosCMB(autobuses.mar_ID);
                cbxModelo.SelectedValue = autobuses.mod_ID;
                numAsientos.Value = autobuses.aut_cantAsientos;

            }
        }

        //EDITAR
        public void Editar_Autobuses(int aut_Id)
        {
            Autobuses autobuses = new Autobuses
            {
                aut_Id = aut_Id,
                aut_Matricula = txtMatricula.Text,
                mar_ID = Convert.ToInt32(cbxMarcas.SelectedValue),
                mod_ID = Convert.ToInt32(cbxModelo.SelectedValue),
                aut_esVIP = esVIP,
                aut_cantAsientos = Convert.ToInt32(numAsientos.Text),
                usu_UsuarioModificacion = 1, // acá se debe de cambiar cuando se haga el LogIn
                aut_FechaModificacion = DateTime.Now
            };

            string resultado = AutobusesDAL.EditarAutobuses(autobuses);

            MessageBox.Show(resultado, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //ELIMINAR Autobuses
        public void Eliminar_Autobuses(int aut_ID)
        {
            Autobuses autobuses = new Autobuses
            {
                aut_Id = aut_ID,
                usu_UsuarioModificacion = 1, // acá se debe de cambiar cuando se haga el LogIn
                aut_FechaModificacion = DateTime.Now
            };

            string resultado = AutobusesDAL.EliminarAutobuses(autobuses);

            MessageBox.Show(resultado, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
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
            if (cbxMarcas.SelectedIndex == 0 || cbxMarcas.SelectedIndex == -1) { pnlMarca.Visible = true; esValido = false; }
            if (cbxModelo.SelectedIndex == 0 || cbxModelo.SelectedIndex == -1) { pnlModelo.Visible = true; esValido = false; }
            if (string.IsNullOrWhiteSpace(txtMatricula.Text)) { pnlMatricula.Visible = true; esValido = false; }
            if (numAsientos.Value <= 0) { pnlAsientos.Visible = true; esValido = false; }

            // Ocultar errores si ya son válidos
            pnlMarca.Visible = cbxMarcas.SelectedIndex == -1 || cbxMarcas.SelectedIndex == 0;
            pnlModelo.Visible = cbxModelo.SelectedIndex == -1 || cbxModelo.SelectedIndex == 0;
            pnlMatricula.Visible = string.IsNullOrWhiteSpace(txtMatricula.Text);
            pnlAsientos.Visible = numAsientos.Value <= 0;

            return esValido;
        }
        public void LimpiarCampos()
        {
            cbxMarcas.SelectedIndex = 0;
            cbxModelo.SelectedIndex = -1;
            cbxModelo.Text = "Seleccione una marca.";
            cbxModelo.Enabled = false;
            txtMatricula.Clear();
            numAsientos.Value = 0;
            rbtEsVIP.Checked = false;
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

        #region LLENANDO COMBOBOX

        // Cargar Modelos
        public void CargarModelosCMB(int mar_ID)
        {
            cbxModelo.DataSource = modelos.CargarModelosPorMarca(mar_ID);
            cbxModelo.ValueMember = "mod_ID";
            cbxModelo.DisplayMember = "mod_Descripcion";
        }

        // Cargar Marcas
        public void CargarMarcasCMB()
        {
            cbxMarcas.DataSource = marcas.CargarMarcas();
            cbxMarcas.ValueMember = "mar_ID";
            cbxMarcas.DisplayMember = "mar_Descripcion";
        }
        #endregion

        #region EVENTOS DE LOS ELEMENTOS DEL FORMULARIO

        private void frmAutobuses_Load(object sender, EventArgs e)
        {
            CargarAutobuses();
            CargarMarcasCMB();
            cbxModelo.Text = "Seleccione una marca.";
            cbxModelo.Enabled = false;
            LimpiarCampos();
            OcultarValidaciones();
            OcultarAdvertencia();

            // Añadiendo el boton de eliminar al final de cada registro.
            DataGridViewButtonColumn btnEliminar = new DataGridViewButtonColumn();
            btnEliminar.HeaderText = "Acciones";
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseColumnTextForButtonValue = true;
            btnEliminar.DefaultCellStyle.BackColor = Color.DarkRed;
            btnEliminar.DefaultCellStyle.ForeColor = Color.DarkRed;
            btnEliminar.DefaultCellStyle.Font = new Font("Nobile", 9, FontStyle.Regular);
            dgAutobuses.Columns.Add(btnEliminar);
        }

        private async void BtnGuardar_Click(object sender, EventArgs e)
        {
            bool esValido = ValidacionesVacio();
            if (esValido)
            {
                InsertarAutobuses();
                CargarAutobuses();
                LimpiarCampos();
            }
            else
            {
                MostrarAdvertencia();
                await Task.Delay(5000);
                OcultarAdvertencia();
            }
        }

        private void cbxMarcas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxMarcas.SelectedValue != null && cbxMarcas.SelectedValue is int)
            {
                cbxModelo.Enabled = true;
                int marca_Id = (int)cbxMarcas.SelectedValue;
                CargarModelosCMB(marca_Id);
            }
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            var result = MessageBox.Show("¿Está seguro de que desea cancelar?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                boton_mostrarGuardar();
                LimpiarCampos();
            }
        }

        private void dgAutobuses_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgAutobuses.Columns["btnEliminar"].Index && e.RowIndex >= 0)
            {

                int aut_Id = Convert.ToInt32(dgAutobuses.Rows[e.RowIndex].Cells["aut_ID"].Value);
                var result = MessageBox.Show("¿Está seguro que desea eliminar este registro?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    Eliminar_Autobuses(aut_Id);
                    CargarAutobuses();
                    LimpiarCampos();
                }
            }
            else if (e.RowIndex >= 0)
            {

                boton_mostrarEditar();
                DataGridViewRow fila = dgAutobuses.Rows[e.RowIndex];

                int aut_ID = Convert.ToInt32(fila.Cells["aut_ID"].Value);
                id_filaseleccionada = aut_ID;

                LimpiarCampos();
                OcultarValidaciones();
                Editar_CargarDatos(aut_ID);
            }
        }
        

        public void boton_mostrarEditar()
        {
            btnEditar.Visible = true;
            btnGuardar.Visible = false;
        }

        public void boton_mostrarGuardar()
        {
            btnEditar.Visible = false;
            btnGuardar.Visible = true;

        }

        #endregion

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            BuscarAutobuses();
        }

        private async void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                bool esValido = ValidacionesVacio();
                if (esValido)
                {
                    Editar_Autobuses(id_filaseleccionada);
                    CargarAutobuses();
                    LimpiarCampos();
                    boton_mostrarGuardar();
                }
                else
                {
                    MostrarAdvertencia();
                    await Task.Delay(4000);
                    OcultarAdvertencia();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
