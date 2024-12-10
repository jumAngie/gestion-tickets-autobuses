using Gestion_De_Tickets_Autobus.Tickets_DAL;
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
    public partial class frmRegistrarPersonaExistenteClientes : Form
    {

        #region CLASES
        ClientesDAL Clientes = new ClientesDAL();
        EmpleadosDAL Empleados = new EmpleadosDAL();
        #endregion
        public frmRegistrarPersonaExistenteClientes()
        {
            InitializeComponent();
        }

        //COMBOBOX
        public void CargarPersonas()
        {
            cbxDNIREG.DataSource = Clientes.CargarPersonasC();
            cbxDNIREG.ValueMember = "per_Id";
            cbxDNIREG.DisplayMember = "per_NombreCompleto";
        }

        private void frmRegistrarPersonaExistente_Load(object sender, EventArgs e)
        {
            CargarPersonas();
        }

        public void CargarP(int per_Id)
        {

            try
            {
                string resultado = EmpleadosDAL.PersonaExist(per_Id);
                MessageBox.Show(resultado, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la persona: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (cbxDNIREG.SelectedValue != null)
            {
                int per_Id = Convert.ToInt32(cbxDNIREG.SelectedValue);
                CargarP(per_Id);
                CargarPersonas();
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una persona.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
