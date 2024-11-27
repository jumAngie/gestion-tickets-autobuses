using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

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
        }  

        private void FormPrincipal_Load (object sender, EventArgs e)
        {

        }

        private void btnDashboard_Click(object sender, EventArgs e)
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
        }

        private void btnAutobus_Click(object sender, EventArgs e)
        {
            PNav.Height = btnAutobus.Height;
            PNav.Top = btnAutobus.Top;
            btnAutobus.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            PNav.Height = btnRegistro.Height;
            PNav.Top = btnRegistro.Top;
            btnRegistro.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            PNav.Height = btnSalir.Height;
            PNav.Top = btnSalir.Top;
            PNav.Left = btnSalir.Left;
            btnSalir.BackColor = Color.FromArgb(46, 51, 73);
        }
        private void btnDashboard_Leave(object sender, EventArgs e)
        {           
            btnCliente.BackColor = Color.FromArgb(46, 50, 54);
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
        private void btnSalir_Leave(object sender, EventArgs e)
        {
            btnSalir.BackColor = Color.FromArgb(46, 50, 54);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
