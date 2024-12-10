using Gestion_De_Tickets_Autobus.Tickets_Formularios;
using Gestion_De_Tickets_Autobus.Tickets_ViewModels;
using System;
using System.Collections.Generic;
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

        public DatosUsuarioViewModel UsuarioActual { get; set; }
        public List<PantallasViewModel> pantallasPermitidas { get; set; }

        public string mensajeBienvenida = "";

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            DibujarMenu();
            if (UsuarioActual != null)
            {
                lblUsername.Text = UsuarioActual.usu_Usuario;
                lblRol.Text = UsuarioActual.rol_Descripcion;
                if (UsuarioActual.sex_Id == 1)
                        mensajeBienvenida = $"¡Bienvenida, {UsuarioActual.per_NombreCompleto}!";
                else
                        mensajeBienvenida = $"¡Bienvenido, {UsuarioActual.per_NombreCompleto}!";
                
            }
        }

        private void DibujarMenu()
        {
            int posicionY = 182; // Margen de espacio entre el header y los botones

            foreach (var pantalla in pantallasPermitidas)
            {
                if (pantalla.pant_NombreBoton == "btnClientes")
                {
                    btnClientes.Visible = true;
                    btnClientes.Location = new System.Drawing.Point(0, posicionY);
                    posicionY += btnClientes.Height + btnClientes.Margin.Top + btnClientes.Margin.Bottom;
                }
                else if (pantalla.pant_NombreBoton == "btnEmpleados")
                {
                    btnEmpleados.Visible = true;
                    btnEmpleados.Location = new System.Drawing.Point(0, posicionY);
                    posicionY += btnEmpleados.Height + btnEmpleados.Margin.Top + btnEmpleados.Margin.Bottom;
                }
                else if (pantalla.pant_NombreBoton == "btnAutobuses")
                {
                    btnAutobuses.Visible = true;
                    btnAutobuses.Location = new System.Drawing.Point(0, posicionY);
                    posicionY += btnAutobuses.Height + btnAutobuses.Margin.Top + btnAutobuses.Margin.Bottom;
                }
                else if (pantalla.pant_NombreBoton == "btnRegistrarVenta")
                {
                    btnRegistrarVenta.Visible = true;
                    btnRegistrarVenta.Location = new System.Drawing.Point(0, posicionY);
                    posicionY += btnRegistrarVenta.Height + btnRegistrarVenta.Margin.Top + btnRegistrarVenta.Margin.Bottom;
                }
                else if (pantalla.pant_NombreBoton == "btnTickets")
                {
                    btnTickets.Visible = true;
                    btnTickets.Location = new System.Drawing.Point(0, posicionY);
                    posicionY += btnTickets.Height + btnTickets.Margin.Top + btnTickets.Margin.Bottom;
                }
                else if (pantalla.pant_NombreBoton == "btnPlanificar")
                {
                    btnPlanificar.Visible = false;
                    btnPlanificar.Location = new System.Drawing.Point(0, posicionY);
                    posicionY += btnPlanificar.Height + btnPlanificar.Margin.Top + btnPlanificar.Margin.Bottom;
                }
            }
        }

        private frmDashboard frmPrincipal_vrb;

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            // Configura la posición del menú al botón Inicio
            PNav.Height = btnInicio.Height;
            PNav.Top = btnInicio.Top;
            PNav.Left = btnInicio.Left;

            // Crea el mensaje de bienvenida
            string mensajeBienvenida = "";
            if (UsuarioActual != null)
            {
                if (UsuarioActual.sex_Id == 1)
                    mensajeBienvenida = $"¡Bienvenida, {UsuarioActual.per_NombreCompleto}!";
                else
                    mensajeBienvenida = $"¡Bienvenido, {UsuarioActual.per_NombreCompleto}!";
            }

            // Instancia el frmDashboard y pasa el mensaje
            frmPrincipal_vrb = new frmDashboard()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true,
                MensajeBienvenida = mensajeBienvenida // Configurar la propiedad
            };

            frmPrincipal_vrb.FormBorderStyle = FormBorderStyle.None;
            this.PNmenu.Controls.Add(frmPrincipal_vrb);
            frmPrincipal_vrb.Show();
        }


        public frmPrincipal()
        {
            InitializeComponent();
            tHora.Enabled = true;
            //Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        public void CerrarSesion()
        {
            frmLogin login = new frmLogin();
            login.Show();
            this.Hide();
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

            string mensajeBienvenida = "";
            if (UsuarioActual != null)
            {
                if (UsuarioActual.sex_Id == 1)
                    mensajeBienvenida = $"¡Bienvenida, {UsuarioActual.per_NombreCompleto}!";
                else
                    mensajeBienvenida = $"¡Bienvenido, {UsuarioActual.per_NombreCompleto}!";
            }
            frmDashboard frmPrincipal_vrb = new frmDashboard()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true,
                MensajeBienvenida = mensajeBienvenida
            };
            frmPrincipal_vrb.FormBorderStyle = FormBorderStyle.None;
            this.PNmenu.Controls.Add(frmPrincipal_vrb);

            frmPrincipal_vrb.Show();
        }


        private void btnPlanificar_Click(object sender, EventArgs e)
        {
            PNav.Height = btnPlanificar.Height;
            PNav.Top = btnPlanificar.Top;
            PNav.Left = btnPlanificar.Left;
            //btnInicio.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Gestionar Planificaciones";
            this.PNmenu.Controls.Clear();

            frmPlanificaciones frmPrincipal_vrb = new frmPlanificaciones()
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
            CerrarSesion();
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
