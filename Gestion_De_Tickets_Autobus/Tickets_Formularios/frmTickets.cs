using Gestion_De_Tickets_Autobus.Tickets_DAL;
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

namespace Gestion_De_Tickets_Autobus
{
    public partial class frmTickets : Form
    {
        #region VARIABLES
        private int id_filaseleccionada;
        #endregion
        public frmTickets()
        {
            InitializeComponent();
        }

        #region CRUD
        public void ListarTickets()
        {
            dgTicketEncabezado.DataSource = TicketsDAL.ListarTickets();
        }

        public void CargarTicketsDetalles(int tik_ID)
        {
            List<TicketsDetallesViewModel> ticketDetalles = TicketsDetallesDAL.TicketsDetalles(tik_ID);
            dgTicketDetalle.DataSource = ticketDetalles;
        }

        public void InicializarDataGridViewDetalles()
        {
            dgTicketDetalle.ColumnCount = 2;
            dgTicketDetalle.ColumnHeadersVisible = true;

            // Set the column header style.
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();

            columnHeaderStyle.BackColor = Color.Beige;
            columnHeaderStyle.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Regular);
            dgTicketDetalle.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

            // Set the column header names.
            dgTicketDetalle.Columns[0].Name = "ID";
            dgTicketDetalle.Columns[1].Name = "# Asiento";
        }
        #endregion

        #region EVENTOS DEL FORMULARIO
        private void frmTickets_Load(object sender, EventArgs e)
        {
            ListarTickets();
            InicializarDataGridViewDetalles();
        }
        #endregion

        private void dgTicketEncabezado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = dgTicketEncabezado.Rows[e.RowIndex];
            int tik_ID = Convert.ToInt32(fila.Cells["tik_ID"].Value);
            id_filaseleccionada = tik_ID;

            string numTicket = Convert.ToString(fila.Cells["tik_ID"].Value);
            string nombre = Convert.ToString(fila.Cells["per_NombreCompleto"].Value);
            string metodoPago = Convert.ToString(fila.Cells["meto_Descripcion"].Value);
            string montoTotal = Convert.ToString(fila.Cells["tik_Total"].Value);
            
            if(id_filaseleccionada != 0)
            {
                CargarTicketsDetalles(tik_ID);
                lblNumTicket.Text = numTicket;
                //lblNombreCliente.Text = nombre;
                //lblMetodoPago.Text = metodoPago;
                lblMontoTotal.Text = montoTotal;
            }
        }
    }
}
