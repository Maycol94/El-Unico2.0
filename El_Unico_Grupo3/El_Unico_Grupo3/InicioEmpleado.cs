﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace El_Unico_Grupo3
{
    public partial class frmRegistroClientes : Form
    {
        public frmRegistroClientes()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmElUnico login = new frmElUnico();
            login.Show();
        }

        private void btnExpandir_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnExpandir.Visible = false;
            btnMaximizar.Visible = true;

        }



        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnExpandir.Visible = true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            
        }
        private void AbrirFormEnPanel(object formhija)
        {
            if (this.pnContenedor.Controls.Count > 0)
                this.pnContenedor.Controls.RemoveAt(0);
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.pnContenedor.Controls.Add(fh);
            this.pnContenedor.Tag = fh;
            fh.Show();

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FrmInicio());
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            
            
            AbrirFormEnPanel(new RegistroCliente());
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmElUnico login = new frmElUnico();
            login.Show();
        }

        private void btnFactura_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new RegistroFactura());
        }
    }
}
