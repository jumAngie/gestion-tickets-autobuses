using Gestion_De_Tickets_Autobus.Tickets_DAL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Gestion_De_Tickets_Autobus
{
    public partial class frmCrearTicket : Form
    {
        #region CLASES
        DestinosDAL destinos = new DestinosDAL();
        AutobusesDAL autobuses = new AutobusesDAL();
        ClientesDAL clientes = new ClientesDAL();
        #endregion

        List<int> asientosSeleccionados = new List<int>();
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
            cmbClientes.DataSource = clientes.CargarPersonasC();
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

        public void Autobus_Precio(int audes_ID)
        {
            string precio = AutobusesDAL.Autobus_Precio(audes_ID);
            lblPrecio.Text = precio;
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

            // Cambiar estado del botón
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReservarAsientos();
        }
    }
}
