using Gestion_De_Tickets_Autobus.Tickets_Formularios;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Gestion_De_Tickets_Autobus
{
    public partial class frmPrincipal : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
         int nLeftRect,
         int nTopRect,
         int nRightRect,
         int nBottomRect,
         int nWidthEllipse,
         int nHeightEllipse
         );

        public frmPrincipal()
        {
            InitializeComponent();
            tHora.Enabled = true;
            //Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            PNav.Height = btnInicio.Height;
            PNav.Top = btnInicio.Top;
            PNav.Left = btnInicio.Left;
            // btnInicio.BackColor = Color.FromArgb(46, 51, 73);

            /*frmDashboard frmPrincipal_vrb = new frmDashboard()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            frmPrincipal_vrb.FormBorderStyle = FormBorderStyle.None;
            this.PNmenu.Controls.Add(frmPrincipal_vrb);

            frmPrincipal_vrb.Show();*/
        }

        public void Salir()
        {
            Application.Exit();
        }

        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            PNav.Height = btnEmpleados.Height;
            PNav.Top = btnEmpleados.Top;
            PNav.Left = btnEmpleados.Left;
           // btnEmpleados.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Gestionar Empleados";
            this.PNmenu.Controls.Clear();

            frmEmpleado frmPrincipal_vrb = new frmEmpleado()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            frmPrincipal_vrb.FormBorderStyle = FormBorderStyle.None;
            this.PNmenu.Controls.Add(frmPrincipal_vrb);

            frmPrincipal_vrb.Show();

        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            PNav.Height = btnClientes.Height;
            PNav.Top = btnClientes.Top;
            PNav.Left = btnClientes.Left;
            //btnClientes.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Gestionar Clientes";
            this.PNmenu.Controls.Clear();

            frmCliente frmPrincipal_vrb = new frmCliente()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            frmPrincipal_vrb.FormBorderStyle = FormBorderStyle.None;
            this.PNmenu.Controls.Add(frmPrincipal_vrb);

            frmPrincipal_vrb.Show();
        }

        private void btnTickets_Click(object sender, EventArgs e)
        {
            PNav.Height = btnTickets.Height;
            PNav.Top = btnTickets.Top;
            PNav.Left = btnTickets.Left;
            //btnTickets.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Ver Tickets y Asientos Vendidos";
            this.PNmenu.Controls.Clear();

            frmTickets frmPrincipal_vrb = new frmTickets()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            frmPrincipal_vrb.FormBorderStyle = FormBorderStyle.None;
            this.PNmenu.Controls.Add(frmPrincipal_vrb);

            frmPrincipal_vrb.Show();
        }

        private void btnAutobus_Click(object sender, EventArgs e)
        {
            PNav.Height = btnAutobuses.Height;
            PNav.Top = btnAutobuses.Top;
            PNav.Left = btnAutobuses.Left;
            //btnAutobuses.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Gestionar Autobuses";
            this.PNmenu.Controls.Clear();

            frmAutobuses frmPrincipal_vrb = new frmAutobuses()

            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            frmPrincipal_vrb.FormBorderStyle = FormBorderStyle.None;
            this.PNmenu.Controls.Add(frmPrincipal_vrb);

            frmPrincipal_vrb.Show();
        }

        private void btnRegistrarVenta_Click(object sender, EventArgs e)
        {
            PNav.Height = btnRegistrarVenta.Height;
            PNav.Top = btnRegistrarVenta.Top;
            PNav.Left = btnRegistrarVenta.Left;
            //btnRegistrarVenta.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Registrar Venta";
            this.PNmenu.Controls.Clear();

            frmCrearTicket frmPrincipal_vrb = new frmCrearTicket()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            frmPrincipal_vrb.FormBorderStyle = FormBorderStyle.None;
            this.PNmenu.Controls.Add(frmPrincipal_vrb);

            frmPrincipal_vrb.Show();
        }
        private void btnInicio_Click(object sender, EventArgs e)
        {
            PNav.Height = btnInicio.Height;
            PNav.Top = btnInicio.Top;
            PNav.Left = btnInicio.Left;
            //btnInicio.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Inicio";
            this.PNmenu.Controls.Clear();

            frmDashboard frmPrincipal_vrb = new frmDashboard()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            frmPrincipal_vrb.FormBorderStyle = FormBorderStyle.None;
            this.PNmenu.Controls.Add(frmPrincipal_vrb);

            frmPrincipal_vrb.Show();
        }

        private void btnInicio_Leave(object sender, EventArgs e)
        {
            //btnInicio.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnEmpleado_Leave(object sender, EventArgs e)
        {
            //btnEmpleados.BackColor = Color.FromArgb(46, 51, 73);
        }
       
        private void btnTickets_Leave(object sender, EventArgs e)
        {
           // btnTickets.BackColor = Color.FromArgb(46, 51, 73);
        }
        private void btnAutobus_Leave(object sender, EventArgs e)
        {
            //btnAutobuses.BackColor = Color.FromArgb(46, 51, 73);
        }
        private void btnCliente_Leave(object sender, EventArgs e)
        {
           // btnClientes.BackColor = Color.FromArgb(46, 51, 73);
        }
        private void btnRegistrarVenta_Leave(object sender, EventArgs e)
        {
           // btnRegistrarVenta.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Salir();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToShortDateString();
        }

        private void tHora_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("hh:mm tt");
        }
    }
}
