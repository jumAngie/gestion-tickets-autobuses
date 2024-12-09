using Gestion_De_Tickets_Autobus.Tickets_DAL;
using Gestion_De_Tickets_Autobus.Tickets_Entities;
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
    public partial class frmRegistrarPersonaExistenteEmpleados : Form
    {

        #region CLASES
        ClientesDAL Clientes = new ClientesDAL();
        EmpleadosDAL Empleados = new EmpleadosDAL();
        #endregion
        //public int per_ID;
        public frmRegistrarPersonaExistenteEmpleados()
        {
            InitializeComponent();
        }

        //COMBOBOX
        public void CargarPersonas()
        {
            cbxDNIREG.DataSource = Empleados.CargarPersonasE();
            cbxDNIREG.ValueMember = "per_Id";
            cbxDNIREG.DisplayMember = "per_NombreCompleto";
        }
       
        private void frmRegistrarPersonaExistente_Load(object sender, EventArgs e)
        {
            CargarPersonas();
        }
        public void CargarP(int per_Id)
        {
            per_Id =Convert.ToInt32(cbxDNIREG.SelectedIndex);

            string resultado = ClientesDAL.PersonaExist(per_Id);

            MessageBox.Show(resultado, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            CargarP(per_ID); 
        }
    }
}
