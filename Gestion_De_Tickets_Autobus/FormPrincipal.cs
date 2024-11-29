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
         //quitar esas dos tambien xd
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            
        }

        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            PNav.Height = btnEmpleado.Height;
            PNav.Top = btnEmpleado.Top;
            PNav.Left = btnEmpleado.Left;
            btnEmpleado.BackColor = Color.FromArgb(46, 51, 73);

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
            PNav.Height = btnCliente.Height;
            PNav.Top = btnCliente.Top;
            PNav.Left = btnCliente.Left;
            btnCliente.BackColor = Color.FromArgb(46, 51, 73);
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
            PNav.Height = btnAutobus.Height;
            PNav.Top = btnAutobus.Top;
            btnAutobus.BackColor = Color.FromArgb(46, 51, 73);

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

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            PNav.Height = btnRegistro.Height;
            PNav.Top = btnRegistro.Top;
            btnRegistro.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Tickets";
            this.PNmenu.Controls.Clear();

            frmRegistro frmPrincipal_vrb = new frmRegistro
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true
            };
            frmPrincipal_vrb.FormBorderStyle = FormBorderStyle.None;
            this.PNmenu.Controls.Add(frmPrincipal_vrb);

            frmPrincipal_vrb.Show();
        }
        private void btnEmpleado_Leave(object sender, EventArgs e)
        {
            btnEmpleado.BackColor = Color.FromArgb(46, 50, 54);
        }
        
        private void btnTickets_Leave(object sender, EventArgs e)
        {
            btnTickets.BackColor = Color.FromArgb(46, 50, 54);
        }
        private void btnAutobus_Leave(object sender, EventArgs e)
        {
            btnAutobus.BackColor = Color.FromArgb(46, 50, 54);
        }
        private void btnRegistro_Leave(object sender, EventArgs e)
        {
            btnRegistro.BackColor = Color.FromArgb(46, 50, 54);
        }
        private void btnCliente_Leave(object sender, EventArgs e)
        {
            btnCliente.BackColor = Color.FromArgb(46, 50, 54);
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
