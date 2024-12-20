﻿using Gestion_De_Tickets_Autobus.Tickets_DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_De_Tickets_Autobus.Tickets_Formularios
{
    public partial class frmDashboard : Form
    {
        DashboardDAL dashboard = new DashboardDAL();
        public string MensajeBienvenida
        {
            get { return lblMensajeBienvenida.Text; }
            set { lblMensajeBienvenida.Text = value; }
        }

        public frmDashboard()
        {
            InitializeComponent();
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            lblClientesRegistrados.Text = DashboardDAL.CantidadDeClientesRegistrdos();
            lblEmpleadosRegistrados.Text = DashboardDAL.CantidadDeEmpleadosRegistrdos();
            lblTicketsVendidos.Text = DashboardDAL.CantidadDeTicketsVendidos();
        }

    }
}
