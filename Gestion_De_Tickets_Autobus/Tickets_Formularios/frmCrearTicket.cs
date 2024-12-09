using Gestion_De_Tickets_Autobus.Tickets_DAL;
using System.Drawing;
using System.Windows.Forms;

namespace Gestion_De_Tickets_Autobus
{
    public partial class frmCrearTicket : Form
    {
        #region CLASES
        DestinosDAL destinos = new DestinosDAL();
        AutobusesDAL autobuses = new AutobusesDAL();
        #endregion
        public frmCrearTicket()
        {
            InitializeComponent();
        }

        #region COMBOBOX
        public void CargarSalidas()
        {
            cmbSalida.DataSource = destinos.CargarSalidas();
            cmbSalida.ValueMember = "des_ID";
            cmbSalida.DisplayMember = "des_Descripcion";
        }

        public void CargarClientes()
        {
            cmbClientes.DataSource = destinos.CargarSalidas();
            cmbClientes.ValueMember = "des_ID";
            cmbClientes.DisplayMember = "des_Descripcion";
        }

        public void CargarDestinos(int des_ID)
        {
            cbmDestino.DataSource = destinos.CargarDestinosPorSalidas(des_ID);
            cbmDestino.ValueMember = "pre_ID";
            cbmDestino.DisplayMember = "des_Descripcion";
        }

        public void CargarAutobuses(int pre_ID)
        {
            cmbAutobus.DataSource = autobuses.CargarAutobuses(pre_ID);
            cmbAutobus.ValueMember = "audes_ID";
            cmbAutobus.DisplayMember = "Autobus";
        }

        public void Autobus_Precio(int audes_ID)
        {
            string precio = AutobusesDAL.Autobus_Precio(audes_ID);
            lblPrecio.Text = precio;
        }
        #endregion

        private void btnAsiento_Click(object sender, System.EventArgs e)
        {
            
        }

        private void frmCrearTicket_Load(object sender, System.EventArgs e)
        {
            CargarSalidas();
        }

        private void cmbSalida_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (cmbSalida.SelectedValue != null && cmbSalida.SelectedValue is int)
            {
                cbmDestino.Enabled = true;
                int des_ID = (int)cmbSalida.SelectedValue;
                CargarDestinos(des_ID);
            }
        }

        private void cbmDestino_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (cbmDestino.SelectedValue != null && cbmDestino.SelectedValue is int)
            {
                cmbAutobus.Enabled = true;
                int pre_ID = (int)cbmDestino.SelectedValue;
                CargarAutobuses(pre_ID);
            }
        }

        private void cmbAutobus_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (cmbAutobus.SelectedValue != null && cmbAutobus.SelectedValue is int)
            {
                int audes_ID = (int)cmbAutobus.SelectedValue;
                Autobus_Precio(audes_ID);
            }
        }
    }
}
