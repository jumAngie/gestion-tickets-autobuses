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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

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

        public void RestablecerListaOriginal()
        {
            txtBuscar.Text = "";
            ListarTickets();
        }

        public void BuscarTickets()
        {
            string filtro = txtBuscar.Text.Trim().ToLower();

            if (dgTicketEncabezado.DataSource != null)
            {
                if (string.IsNullOrEmpty(filtro))
                {
                    RestablecerListaOriginal();
                    return;
                }

                var listaTickets = (List<TicketsViewModel>)dgTicketEncabezado.DataSource;

                var listaFiltrada = listaTickets.Where(t =>
                    t.per_NombreCompleto.ToLower().Contains(filtro) || 
                    t.tik_ID.ToString().Contains(filtro)    ||
                    t.meto_Descripcion.ToString().Contains(filtro)
                ).ToList();

                
                dgTicketEncabezado.DataSource = listaFiltrada;
            }
            else
            {
            }
        }


        public void CargarDatosEnTextBox(int tik_ID)
        {
            List<TicketsDetallesViewModel> ticketDetalles = TicketsDetallesDAL.TicketsDetalles(tik_ID);

            var detalle = ticketDetalles.FirstOrDefault();

            if (detalle != null)
            {
                txtFecha.Text = detalle.pln_Fecha.ToShortDateString(); 
                txtTipoBus.Text = detalle.aut_esVIP + " - L. " + detalle.pre_precio + " C/U";
                txtHora.Text = detalle.hor_hora;
                txtRuta.Text = detalle.hor_ruta;
                txtAutobus.Text = detalle.aut_Matricula;
                txtSalidaDestino.Text = detalle.desSalida + " A " + detalle.desDestino;
            }
        }

        public void CargarTicketsDetalles(int tik_ID)
        {
            List<TicketsDetallesViewModel> ticketDetalles = TicketsDetallesDAL.TicketsDetalles(tik_ID);
            var datosFiltrados = ticketDetalles.Select(t => new
            {
                ID = t.tdt_ID, 
                Asiento = t.num_Asiento 

            }).ToList();

            dgTicketDetalle.DataSource = datosFiltrados;
        }

       
        #endregion

        #region EVENTOS DEL FORMULARIO
        private void frmTickets_Load(object sender, EventArgs e)
        {
            ListarTickets();
        }

        private void dgTicketEncabezado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return; 

            DataGridViewRow fila = dgTicketEncabezado.Rows[e.RowIndex];
            int tik_ID = Convert.ToInt32(fila.Cells["tik_ID"].Value);
            id_filaseleccionada = tik_ID;

            string numTicket = Convert.ToString(fila.Cells["tik_ID"].Value);
            string nombre = Convert.ToString(fila.Cells["per_NombreCompleto"].Value);
            string metodoPago = Convert.ToString(fila.Cells["meto_Descripcion"].Value);
            string montoTotal = Convert.ToString(fila.Cells["tik_Total"].Value);
            string subtotal = Convert.ToString(fila.Cells["tik_Subtotal"].Value);
            string descuento = Convert.ToString(fila.Cells["tik_Descuento"].Value);
            string impuesto = Convert.ToString(fila.Cells["tik_Impuesto"].Value);

            
            if (id_filaseleccionada != 0)
            {
                CargarTicketsDetalles(tik_ID);
                lblNumTicket.Text = numTicket;
                txtCliente.Text = nombre;
                txtMetodoPago.Text = metodoPago;
                lblMontoTotal.Text = montoTotal;
                lblSubtotal.Text = subtotal;
                lblDescuento.Text = descuento;
                lblImpuesto.Text = impuesto;
                CargarDatosEnTextBox(tik_ID);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            dgTicketDetalle.DataSource = null;
            lblNumTicket.Text = "0";
            lblMontoTotal.Text = "0.00";
            lblSubtotal.Text = "0.00";
            lblDescuento.Text = "0.00";
            lblImpuesto.Text = "0.00";

            txtCliente.Clear();
            txtMetodoPago.Clear();
            txtFecha.Clear();
            txtTipoBus.Clear();
            txtHora.Clear();
            txtRuta.Clear();
            txtAutobus.Clear();
            txtSalidaDestino.Clear();

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            BuscarTickets();
        }


        #endregion
    }
}
