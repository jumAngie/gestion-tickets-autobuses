using Gestion_De_Tickets_Autobus.Tickets_DAL;
using Gestion_De_Tickets_Autobus.Tickets_Entities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_De_Tickets_Autobus
{
    public partial class frmCrearTicket : Form
    {
        #region CLASES
        DestinosDAL destinos = new DestinosDAL();
        AutobusesDAL autobuses = new AutobusesDAL();
        ClientesDAL clientes = new ClientesDAL();
        TicketsDAL tickets = new TicketsDAL();
        #endregion

        List<int> asientosSeleccionados = new List<int>();
        public frmCrearTicket()
        {
            InitializeComponent();
        }

        #region VALIDACIONES Y LIMPIEZA DE CAMPOS
        public void Panel_OcultarValidaciones()
        {
            pnlSalida.Visible = false;
            pnlDestino.Visible = false;
            pnlBus.Visible = false;
            lblMetodoPago.Visible = false;
            pnlCliente.Visible = false;
        }
        
        public bool ValidacionesVacio()
        {
            bool esvalido = true;

            if (cmbSalida.SelectedIndex == 0 || cmbSalida.SelectedIndex == -1) { pnlSalida.Visible = true; esvalido = false; }
            if (cbmDestino.SelectedIndex == 0 || cbmDestino.SelectedIndex == -1) { pnlDestino.Visible = true; esvalido = false; }
            if (cmbAutobus.SelectedIndex == 0 || cmbAutobus.SelectedIndex == -1) { pnlBus.Visible = true; esvalido = false; }
            if(cmbClientes.SelectedIndex == 0 || cmbClientes.SelectedIndex == -1) { pnlCliente.Visible =true; esvalido = false; }
            if(rbE.Checked == false && rbT.Checked == false) { lblMetodoPago.Visible = true; esvalido=false; }
            
            // esconder error
            pnlSalida.Visible = cmbSalida.SelectedIndex == 0 || cmbSalida.SelectedIndex == -1;
            pnlDestino.Visible = cbmDestino.SelectedIndex == 0 || cbmDestino.SelectedIndex == -1;
            pnlBus.Visible = cmbAutobus.SelectedIndex == 0 || cmbAutobus.SelectedIndex == -1;
            pnlCliente.Visible = cmbClientes.SelectedIndex == 0 || cmbAutobus.SelectedIndex == -1;
            lblMetodoPago.Visible = rbE.Checked == false && rbT.Checked == false;

            return esvalido;
        }

        public void LimpiarCampos()
        {
            cmbSalida.SelectedIndex = 0;
            cbmDestino.SelectedIndex = 0;
            cmbAutobus.SelectedIndex = 0;
            cmbClientes.SelectedIndex = 0;
        }
        #endregion

        #region COMBOBOX
        public void CargarSalidas()
        {
            cmbSalida.DataSource = destinos.CargarSalidas();
            cmbSalida.ValueMember = "des_ID";
            cmbSalida.DisplayMember = "des_Descripcion";
        }

        public void CargarClientes()
        {
            cmbClientes.DataSource = tickets.CargarClientes();
            cmbClientes.ValueMember = "per_ID";
            cmbClientes.DisplayMember = "per_NombreCompleto";
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

        public void InsertarTicket()
        {
            int metodoPago = 1;
            if (rbE.Checked == true) metodoPago = 1;
            if (rbT.Checked == true) metodoPago = 2;
            
            if (asientosSeleccionados == null || asientosSeleccionados.Count == 0)
            {
                MessageBox.Show("Debe seleccionar al menos un asiento.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            string listaAsientos = string.Join(",", asientosSeleccionados);

            TicketEncabezado ticket = new TicketEncabezado
            {
                per_ID = Convert.ToInt32(cmbClientes.SelectedValue),
                meto_ID = metodoPago,
                tik_Subtotal = Convert.ToDecimal(txtSubtotal.Text),
                tik_Impuesto = Convert.ToDecimal(txtISV.Text),
                tik_Total = Convert.ToDecimal(txtTotal.Text),
                usu_UsuarioCreacion = 1,
                tik_FechaCreacion = DateTime.Now,
                listaAsientos = listaAsientos 
            };

            string resultados = TicketsDAL.InsertarTicketCompleto(ticket);
            MessageBox.Show(resultados, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        public void Autobus_Precio(int audes_ID)
        {
            string precio = AutobusesDAL.Autobus_Precio(audes_ID);
            lblPrecio.Text = precio;
        }

        private void ActualizarCantidadYTotal()
        {
            
            int cantidad = asientosSeleccionados.Count;

            
            txtCantidad.Text = cantidad.ToString();

            
            double precio = 0;
            if (double.TryParse(lblPrecio.Text, out precio))
            {
                
                double totalPagar = precio * cantidad;
                double impuesto = totalPagar * (0.15);
                double total = totalPagar + impuesto;
              


                txtTotalAPagar.Text = totalPagar.ToString("F2");
                txtSubtotal.Text = totalPagar.ToString("F2");
                txtISV.Text = impuesto.ToString("F2");
                txtTotal.Text = total.ToString("F2");
            }
            else
            {
                MessageBox.Show("El precio del autobús no es válido.");
            }
        }

        #endregion

        private void DibujarAsientos(int audes_ID)
        {
            // Limpia los botones existentes
            pnlAsientos.Controls.Clear();

            // Obtener los asientos desde la base de datos
            var listaAsientos = AutobusesDAL.ObtenerAsientos(audes_ID);

            // Configuración de filas y columnas
            int maxColumnas = 6;
            int espacioX = 55; // Espaciado horizontal
            int espacioY = 30; // Espaciado vertical
            int inicioX = 5;
            int inicioY = 5;

            int fila = 0, columna = 0;

            // Crear los botones
            foreach (var asiento in listaAsientos)
            {
                Button btnAsiento = new Button();

                // Configurar botón
                btnAsiento.Name = "btnAsiento" + asiento.pas_ID;
                btnAsiento.Text = asiento.num_Asiento.ToString();
                btnAsiento.Size = new Size(50, 30);
                btnAsiento.BackColor = asiento.disponibilidad ? Color.Maroon : Color.ForestGreen;
                btnAsiento.ForeColor = Color.White;

                // Posición del botón
                btnAsiento.Location = new Point(inicioX + (columna * espacioX), inicioY + (fila * espacioY));

                // Evento Click
                btnAsiento.Click += (s, e) => BotonAsiento_Click(s, e, asiento.pas_ID, asiento.disponibilidad, btnAsiento);

                // Agregar al panel
                pnlAsientos.Controls.Add(btnAsiento);

                // Actualizar filas y columnas
                columna++;
                if (columna >= maxColumnas)
                {
                    columna = 0;
                    fila++;
                }
            }
        }

        private void ReservarAsientos()
        {
            // Si no hay asientos seleccionados, mostrar mensaje
            if (asientosSeleccionados.Count == 0)
            {
                MessageBox.Show("Por favor, selecciona al menos un asiento.");
                return;
            }

            // Lógica para guardar los asientos seleccionados en la base de datos
            foreach (var asientoID in asientosSeleccionados)
            {
                //ACÁ VA EL DAL
            }

        }

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

        private void frmCrearTicket_Load(object sender, System.EventArgs e)
        {
            CargarSalidas();
            CargarClientes();
            
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
                DibujarAsientos(audes_ID);
                txtCantidad.Text = "0";
                txtTotalAPagar.Text = "0.00";
                txtSubtotal.Text = "0.00";
                txtISV.Text = "0.00";
                txtTotal.Text = "0.00";
            }
        }

        private void BotonAsiento_Click(object sender, EventArgs e, int pas_ID, bool disponibilidad, Button btnAsiento)
        {
            // Si el asiento ya está ocupado desde la base de datos, no hacer nada
            if (disponibilidad)
            {
                MessageBox.Show("Este asiento ya está ocupado.");
                return;
            }

            // Cambiar estado del botón y actualizar la lista
            if (btnAsiento.BackColor == Color.ForestGreen)
            {
                // El asiento ha sido seleccionado
                btnAsiento.BackColor = Color.Orange; // Marcar como seleccionado
                asientosSeleccionados.Add(pas_ID); // Agregar ID a la lista de seleccionados
            }
            else if (btnAsiento.BackColor == Color.Orange)
            {
                // El asiento ha sido deseleccionado
                btnAsiento.BackColor = Color.ForestGreen; // Desmarcar
                asientosSeleccionados.Remove(pas_ID); // Eliminar ID de la lista de seleccionados
            }

            // Actualizar cantidad y total a pagar
            ActualizarCantidadYTotal();
        }

        private  async void btnGuardar_Click(object sender, EventArgs e)
        {
            bool esValido = ValidacionesVacio();
            if (esValido)
            {
                InsertarTicket();
                LimpiarCampos();

            }
            else
            {
                MensajeAdvertencia();
                await Task.Delay(5000);
                MensajeAdvertencia_Hide();
            }

        }
    }
}
