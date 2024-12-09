using Gestion_De_Tickets_Autobus.Tickets_DAL;
using System.Drawing;
using System.Windows.Forms;

namespace Gestion_De_Tickets_Autobus
{
    public partial class frmCrearTicket : Form
    {
        #region CLASES
        DestinosDAL destinos = new DestinosDAL();
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
        #endregion

        private void btnAsiento_Click(object sender, System.EventArgs e)
        {
            
        }

        private void frmCrearTicket_Load(object sender, System.EventArgs e)
        {
            CargarSalidas();
        }
    }
}
