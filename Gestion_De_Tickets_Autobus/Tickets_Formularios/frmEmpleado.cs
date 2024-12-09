using Gestion_De_Tickets_Autobus.Tickets_DAL;
using Gestion_De_Tickets_Autobus.Tickets_Entities;
using Gestion_De_Tickets_Autobus.Tickets_Formularios;
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

        #region CLASES
        PaisesDAL paises = new PaisesDAL();
        DeptosDAL depto = new DeptosDAL();
        CiudadesDAL ciudad = new CiudadesDAL();
        #endregion


        #region VARIABLES
        private int sexo = 0;
        private int empleado = 1;
        private bool extranjero;
        private int id_filaseleccionada;
        #endregion

        #region CRUD
        //INSERTAR
        public void InsertarEmpleados()
        {
            if (rbF.Checked) sexo = 1;
            if (rbM.Checked) sexo = 2;
            if (rbE.Checked) extranjero = true;
            Personas PrEmpleados = new Personas
            {
                per_NombreCompleto = txtNombre.Text,
                per_DNI = mtxtidentidad.Text,
                per_Extranjero = extranjero,
                per_Telefono = txtTelefono.Text,
                per_FechaNacimiento = dtFechaNacimiento.Value,
                per_Sexo = sexo,
                per_Correo = txtEmail.Text,
                per_Ciudad = Convert.ToInt32(cbxciudad.SelectedValue),
                per_Direccion = txtDirE.Text,
                per_Cargo = empleado,
                per_FechaCreacion = DateTime.Now,
                usu_UsuarioCreacion = 1 // Id por mientras, acá va el id del usuario logeado
            };
            
            string resultados = EmpleadosDAL.InsertarEmpleados(PrEmpleados);
            MessageBox.Show(resultados, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void ListarEmpleados()
        {
            dgEmpleados.DataSource = EmpleadosDAL.ListarEmpleados();
        }

        //CARGAR DATOS EDITAR
        public void Editar_CargarDatos(int emp_ID)
        {
            Personas personas = EmpleadosDAL.Editar_CargarDatos(emp_ID);
            if (personas != null)
            {
                txtNombre.Text = personas.per_NombreCompleto;
                extranjero = personas.per_Extranjero;
                if (extranjero == true)
                {
                    txtDNIE.Text = personas.per_DNI;
                    rbE.Checked = true;
                }
                if (extranjero == false)
                {
                    mtxtidentidad.Text = personas.per_DNI;
                    rbH.Checked = true;
                }
                txtTelefono.Text = personas.per_Telefono;
                txtEmail.Text = personas.per_Correo;
                dtFechaNacimiento.Value = personas.per_FechaNacimiento;
                sexo = personas.per_Sexo;
                if (sexo == 1) rbF.Checked = true;
                if (sexo == 2) rbM.Checked = true;
                empleado = personas.per_Cargo;
                txtDirE.Text = personas.per_Direccion;
                cbxpais.SelectedValue = personas.pais_Id;
                CargarDeptoPorPaisCMB(personas.pais_Id);
                cbxdepto.SelectedValue = personas.dept_Id;
                CargarCiudadesporDepartamentoCMB(personas.dept_Id);
                cbxciudad.SelectedValue = personas.per_Ciudad;

            }
        }
        //EDITAR
        public void Editar_Empleados(int per_Id)
        {
            Personas Empleado = new Personas
            {
                per_Id = per_Id,
                per_NombreCompleto = txtNombre.Text,
                per_Correo = txtEmail.Text,
                per_DNI = mtxtidentidad.Text,
                per_Extranjero =extranjero,
                per_Telefono = txtTelefono.Text,
                per_FechaNacimiento = dtFechaNacimiento.Value,
                per_Sexo = sexo,
                per_Cargo = empleado,
                per_Ciudad = Convert.ToInt32(cbxciudad.SelectedValue),
                per_Direccion = txtDirE.Text,
                usu_UsuarioModificacion = 1, // acá se debe de cambiar cuando se haga el LogIn
                per_FechaModificacion = DateTime.Now
            };

            string resultado = EmpleadosDAL.EditarEmpleados(Empleado);

            MessageBox.Show(resultado, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
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

        //VALIDACIONES VACIOS
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
            if (EmpleadosDAL.ExistenciaDNI(mtxtidentidad.Text))
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
            if (EmpleadosDAL.ExistenciaDNI(txtDNIE.Text))
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

        private void frmEmpleado_Load(object sender, EventArgs e)
        {
            ListarEmpleados();
            CargarPaisesCMB();
            cbxdepto.Text = "Seleccione un país.";
            cbxciudad.Text = "Seleccione un departamento.";
            LimpiarCampos();
            panel_OcultarValidaciones();
            MensajeAdvertencia_Hide();

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
        private void dgEmpleadoss_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            boton_mostrarEditar();
            DataGridViewRow fila = dgEmpleados.Rows[e.RowIndex];

            int per_ID = Convert.ToInt32(fila.Cells["per_ID"].Value);
            id_filaseleccionada = per_ID;

            LimpiarCampos();
            panel_OcultarValidaciones();
            Editar_CargarDatos(per_ID);
        }

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

        #region  BOTONES
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            panel_OcultarValidaciones();
            MensajeAdvertencia_Hide();
            boton_mostrarGuardar();
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            bool esValido = ValidacionesVacio();
            if (esValido)
            {
                InsertarEmpleados();
                ListarEmpleados();
                LimpiarCampos();

            }
            else
            {
                MensajeAdvertencia();
                await Task.Delay(5000);
                MensajeAdvertencia_Hide();
            }
        }
        private async void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                bool esValido = ValidacionesVacio();
                if (esValido)
                {
                    Editar_Empleados(id_filaseleccionada);
                    ListarEmpleados();
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
            frmRegistrarPersonaExistenteClientes registroPersonaExistente = new frmRegistrarPersonaExistenteClientes();
            registroPersonaExistente.Show();
        }
        #endregion
    }
}

