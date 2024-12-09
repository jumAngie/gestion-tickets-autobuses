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

namespace Gestion_De_Tickets_Autobus
{
    public partial class frmTickets : Form
    {
        public frmTickets()
        {
            InitializeComponent();
        }

        #region CRUD
        public void ListarTickets()
        {
            dgTicketEncabezado.DataSource = TicketsDAL.ListarTickets();
        }
        #endregion

        #region EVENTOS DEL FORMULARIO
        private void frmTickets_Load(object sender, EventArgs e)
        {
            ListarTickets();
        }
        #endregion
    }
}
