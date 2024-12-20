﻿using Gestion_De_Tickets_Autobus.Tickets_DAL;
using Gestion_De_Tickets_Autobus.Tickets_Entities;
using Gestion_De_Tickets_Autobus.Tickets_Formularios;
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
using System.Xml.Linq;

namespace Gestion_De_Tickets_Autobus
{
    public partial class frmCliente : Form
    {
        #region CLASES
        PaisesDAL paises = new PaisesDAL();
        DeptosDAL depto = new DeptosDAL();
        CiudadesDAL ciudad = new CiudadesDAL();
        #endregion

        #region VARIABLES
        private int sexo = 0;
        private int cliente = 2;
        private bool extranjero;
        private int id_filaseleccionada;
        #endregion

        #region CRUD
        //INSERTAR
        public void InsertarClientes()
        {
            if (rbF.Checked) sexo = 1;
            if (rbM.Checked) sexo = 2;
            
            if (rbE.Checked) extranjero = true;
            if (rbH.Checked) extranjero= false;

            string DNI;
            if(extranjero)
            {
                DNI = txtDNIE.Text;
            }
            else
            {
                DNI = mtxtidentidad.Text;
            }

            Personas Pr = new Personas
            {
                per_NombreCompleto = txtNombre.Text,
                per_DNI = DNI,
                per_Extranjero = extranjero,
                per_Telefono = txtTelefono.Text,
                per_FechaNacimiento = dtFechaNacimiento.Value,
                per_Sexo = sexo,
                per_Correo = txtEmail.Text,
                per_Ciudad = Convert.ToInt32(cbxciudad.SelectedValue),
                per_Direccion = txtDirE.Text,
                per_Cargo = cliente,
                per_FechaCreacion = DateTime.Now,
                usu_UsuarioCreacion = 1 // Id por mientras, acá va el id del usuario logeado
            };
          
                string resultados = ClientesDAL.InsertarClientes(Pr);
                MessageBox.Show(resultados, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
          
            
        }

        //LISTAR
        public void ListarClientes()
        {
            dgClientes.DataSource = ClientesDAL.ListarClientes();
        }
        public void RestablecerListaOriginal()
        {
            txtBuscar.Text = "";
            ListarClientes();
        }

        public void BuscarClientes()
        {
            string filtro = txtBuscar.Text.Trim().ToLower();

            if (dgClientes.DataSource != null)
            {
                if (string.IsNullOrEmpty(filtro))
                {
                    RestablecerListaOriginal();
                    return;
                }

                var listaTickets = (List<ClientesViewModel>)dgClientes.DataSource;

                var listaFiltrada = listaTickets.Where(t =>
                    t.NombreCompleto.ToLower().Contains(filtro) ||
                    t.per_ID.ToString().Contains(filtro) ||
                    t.DNI.ToString().Contains(filtro) ||
                    t.Telefono.ToLower().Contains(filtro) ||
                    t.Correo.ToLower().Contains(filtro)
                ).ToList();


                dgClientes.DataSource = listaFiltrada;
            }
        }

        //CARGAR DATOS EDITAR
        public void Editar_CargarDatos(int clien_Id)
        {
            Personas personas = ClientesDAL.Editar_CargarDatos(clien_Id);
            if (personas != null)
            {
                txtNombre.Text = personas.per_NombreCompleto;
                extranjero = personas.per_Extranjero;
                if (extranjero == true)
                {
                    txtDNIE.Text = personas.per_DNI;
                    rbE.Checked = true;
                    rbH.Checked = false;
                }
                if (extranjero == false)
                {
                    mtxtidentidad.Text = personas.per_DNI;
                    rbH.Checked = true;
                    rbE.Checked = false;
                }
                txtTelefono.Text = personas.per_Telefono;
                txtEmail.Text = personas.per_Correo;
                dtFechaNacimiento.Value = personas.per_FechaNacimiento;
                sexo = personas.per_Sexo;
                if (sexo == 1) rbF.Checked = true;
                if (sexo == 2) rbM.Checked = true;
                cliente = personas.per_Cargo;
                txtDirE.Text = personas.per_Direccion;
                cbxpais.SelectedValue = personas.pais_Id;
                CargarDeptoPorPaisCMB(personas.pais_Id);
                cbxdepto.SelectedValue = personas.dept_Id;
                CargarCiudadesporDepartamentoCMB(personas.dept_Id);
                cbxciudad.SelectedValue = personas.per_Ciudad;

            }
        }
                //EDITAR
                public void Editar_Clientes(int per_Id)
        {
            if (rbF.Checked) sexo = 1;
            if (rbM.Checked) sexo = 2;

            if (rbE.Checked) extranjero = true;
                if (rbH.Checked) extranjero = false;

                string DNI;
                if (extranjero)
                {
                    DNI = txtDNIE.Text;
                }
                else
                {
                    DNI = mtxtidentidad.Text;
                }
            Personas Cliente = new Personas
            {
                per_Id = per_Id,
                per_NombreCompleto = txtNombre.Text,
                per_Correo = txtEmail.Text,
                per_DNI = DNI,
                per_Extranjero = extranjero,
                per_Telefono = txtTelefono.Text,
                per_FechaNacimiento = dtFechaNacimiento.Value,
                per_Sexo = sexo,
                per_Cargo = cliente,
                per_Ciudad = Convert.ToInt32(cbxciudad.SelectedValue),
                per_Direccion = txtDirE.Text,
                usu_UsuarioModificacion = 1, // acá se debe de cambiar cuando se haga el LogIn
                per_FechaModificacion = DateTime.Now
            };

            string resultado = ClientesDAL.EditarClientes(Cliente);

            MessageBox.Show(resultado, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        //ELIMINAR CLIENTES
        public void Eliminar_Clientes(int per_ID)
        {
            Personas persona = new Personas
            {
                per_Id = per_ID,
                usu_UsuarioModificacion = 1, // acá se debe de cambiar cuando se haga el LogIn
                per_FechaModificacion = DateTime.Now
            };

            string resultado = ClientesDAL.EliminarClientes(persona);

            MessageBox.Show(resultado, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion

        public frmCliente()
        {
            InitializeComponent();
        }


        #region VALIDACIONES Y LIMPIEZA DE CAMPOS
        public void Panel_OcultarValidaciones()
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
            cbxpais.SelectedIndex = 0;
            dtFechaNacimiento.Value = DateTime.Now;
            lblidentidad.Visible = false;
            mtxtidentidad.Visible = false;
            lblDNIE.Visible = false;
            txtDNIE.Visible = false;

        }
        //VALIDACIONES NÚMEROS
        ErrorProvider errortelefono = new ErrorProvider();
        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool esValido = Validaciones.soloNumeros(e);
            if (!esValido)
            {
                btnGuardar.Enabled = false;
                errortelefono.SetError(txtTelefono, "Por favor, ingrese solo números.");
            }
            else
            {
                btnGuardar.Enabled = true;
                errortelefono.Clear();
            }
        }


        ErrorProvider errorDNI = new ErrorProvider();
        private void mtxtidentidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool esValido = Validaciones.soloNumeros(e);
            if (!esValido)
            {
                btnGuardar.Enabled = false;
                errorDNI.SetError(mtxtidentidad, "Por favor, ingrese solo números.");
            }
            else
            {
                btnGuardar.Enabled = true;
                errorDNI.Clear();
            }
        }

        //VALIDACIONES EMAIL
        ErrorProvider erroremail = new ErrorProvider();
        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (!Validaciones.validarEmail(txtEmail.Text))
                erroremail.SetError(txtEmail, "Correo no válido");
            else
                erroremail.Clear();
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

        //VALIDAR DNI EXISTENTES
        private void mtxtidentidad_Leave(object sender, EventArgs e)
        {
            if (ClientesDAL.ExistenciaDNI(mtxtidentidad.Text))
            {
                MessageBox.Show("El DNI ya está registrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnGuardar.Enabled = false;
                return; // Salir del método si el DNI ya está registrado
            }
            else
            {
                btnGuardar.Enabled = true;
            }
        }

        private void txtDNIE_Leave(object sender, EventArgs e)
        {
            if (ClientesDAL.ExistenciaDNI(txtDNIE.Text))
            {
                MessageBox.Show("El DNI ya está registrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnGuardar.Enabled = false;
                return; // Salir del método si el DNI ya está registrado
            }
            else
            {
                btnGuardar.Enabled = true;
            }
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
        private void frmCliente_Load(object sender, EventArgs e)
        {
            CargarPaisesCMB();
            ListarClientes();
            cbxdepto.Text = "Seleccione un país.";
            cbxciudad.Text = "Seleccione un departamento.";
            LimpiarCampos();
            Panel_OcultarValidaciones();
            MensajeAdvertencia_Hide();

            // Añadiendo el boton de eliminar al final de cada registro.
            DataGridViewButtonColumn btnEliminar = new DataGridViewButtonColumn();
            btnEliminar.HeaderText = "Acciones";
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseColumnTextForButtonValue = true;
            btnEliminar.DefaultCellStyle.BackColor = Color.DarkRed;
            btnEliminar.DefaultCellStyle.ForeColor = Color.DarkRed;
            btnEliminar.DefaultCellStyle.Font = new Font("Nobile", 9, FontStyle.Regular);
            dgClientes.Columns.Add(btnEliminar);
        }

        private void cbxPais_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxpais.SelectedValue != null && cbxpais.SelectedValue is int)
            {
                cbxdepto.Enabled = true;
                int pais_Id = (int)cbxpais.SelectedValue;
                CargarDeptoPorPaisCMB(pais_Id);
            }
        }

        private void cbxDepto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxdepto.SelectedValue != null && cbxdepto.SelectedValue is int)
            {

                int dept_Id = (int)cbxdepto.SelectedValue;
                if (dept_Id > 0) // verifica que sea un valor válidop
                {
                    cbxciudad.Enabled = true;
                    CargarCiudadesporDepartamentoCMB(dept_Id);
                }
            }
            else
            {
                cbxciudad.DataSource = null;
                cbxciudad.Enabled = false;
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


        private void dgClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == dgClientes.Columns["btnEliminar"].Index && e.RowIndex >= 0)
            {

                int per_Id = Convert.ToInt32(dgClientes.Rows[e.RowIndex].Cells["per_ID"].Value);
                var result = MessageBox.Show("¿Está seguro que desea eliminar este registro?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    Eliminar_Clientes(per_Id);
                    ListarClientes();
                    LimpiarCampos();
                }
            }
            else if (e.RowIndex >= 0)
            {
                boton_mostrarEditar();
                DataGridViewRow fila = dgClientes.Rows[e.RowIndex];

                int per_ID = Convert.ToInt32(fila.Cells["per_ID"].Value);
                id_filaseleccionada = per_ID;

                LimpiarCampos();
                Panel_OcultarValidaciones();
                Editar_CargarDatos(per_ID);

            }
            
        }
        #endregion

        #region BOTONES
        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            bool esValido = ValidacionesVacio();
            if (esValido)
            {
                InsertarClientes();
                ListarClientes();
                LimpiarCampos();

            }
            else
            {
                MensajeAdvertencia();
                await Task.Delay(5000);
                MensajeAdvertencia_Hide();
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            Panel_OcultarValidaciones();
            MensajeAdvertencia_Hide();
            boton_mostrarGuardar();
        }
        private async void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                bool esValido = ValidacionesVacio();
                if (esValido)
                {
                    Editar_Clientes(id_filaseleccionada);
                    ListarClientes();
                    LimpiarCampos();
                    boton_mostrarGuardar();
                }
                else
                {
                    MensajeAdvertencia();
                    await Task.Delay(4000);
                    MensajeAdvertencia_Hide();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPersonaExistente_Click(object sender, EventArgs e)
        {
            frmRegistrarPersonaExistenteEmpleados registroPersonaExistente= new frmRegistrarPersonaExistenteEmpleados();
            registroPersonaExistente.Show();
        }
        #endregion


        #region LLENANDO COMBOBOX
        public void CargarPaisesCMB()
        {
            cbxpais.DataSource = paises.CargarPaises();
            cbxpais.ValueMember = "pais_Id";
            cbxpais.DisplayMember = "pais_Descripcion";
        }

        private void CargarDeptoPorPaisCMB(int pais_Id)
        {
            cbxdepto.DataSource = depto.CargarDepartamentosPorPais(pais_Id);
            cbxdepto.ValueMember = "dept_Id";
            cbxdepto.DisplayMember = "dept_Descripcion";
        }
        public void CargarCiudadesporDepartamentoCMB(int dept_Id)
        {
            cbxciudad.DataSource = ciudad.CargarCiudadesPorDepto(dept_Id);
            cbxciudad.ValueMember = "ciud_Id";
            cbxciudad.DisplayMember = "ciud_Descripcion";
        }

        #endregion

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            BuscarClientes();
        }
    }
}

