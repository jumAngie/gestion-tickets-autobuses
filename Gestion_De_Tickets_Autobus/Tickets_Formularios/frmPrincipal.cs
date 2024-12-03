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
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            PNav.Height = btnInicio.Height;
            PNav.Top = btnInicio.Top;
            btnInicio.BackColor = Color.FromArgb(46, 51, 73);

            //frmEmpleado frmPrincipal_vrb = new frmEmpleado()
            //{
            //    Dock = DockStyle.Fill,
            //    TopLevel = false,
            //    TopMost = true
            //};
            //frmPrincipal_vrb.FormBorderStyle = FormBorderStyle.None;
            //this.PNmenu.Controls.Add(frmPrincipal_vrb);

            //frmPrincipal_vrb.Show();
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
            btnEmpleados.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Empleado";
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
            btnClientes.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Cliente";
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
            btnTickets.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Tickets";
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
            btnAutobuses.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Autobuses";
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
            btnRegistrarVenta.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Crear Ticket";
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
            btnInicio.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Inicio";
            this.PNmenu.Controls.Clear();
        }

        private void btnInicio_Leave(object sender, EventArgs e)
        {
            btnInicio.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnEmpleado_Leave(object sender, EventArgs e)
        {
            btnEmpleados.BackColor = Color.FromArgb(46, 50, 54);
        }
        
        private void btnTickets_Leave(object sender, EventArgs e)
        {
            btnTickets.BackColor = Color.FromArgb(46, 50, 54);
        }
        private void btnAutobus_Leave(object sender, EventArgs e)
        {
            btnAutobuses.BackColor = Color.FromArgb(46, 50, 54);
        }
        private void btnCliente_Leave(object sender, EventArgs e)
        {
            btnClientes.BackColor = Color.FromArgb(46, 50, 54);
        }
        private void btnRegistrarVenta_Leave(object sender, EventArgs e)
        {
            btnRegistrarVenta.BackColor = Color.FromArgb(46, 50, 54);
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            Salir();

        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Salir();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Salir();
        }

        private void PNmenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
