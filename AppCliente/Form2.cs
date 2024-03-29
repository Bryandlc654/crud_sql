﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppCliente
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            
            Form1 ofrm = new Form1();
            ofrm.ShowDialog();
            Form2_Load(sender, e);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Cliente objCliente = new Cliente();
            dgvDatos.DataSource = null;
            dgvDatos.AutoGenerateColumns = false;
            dgvDatos.DataSource = objCliente.Listar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Form1 ofrm = new Form1();
            ofrm.codigo = dgvDatos.CurrentRow.Cells[0].Value.ToString();
            ofrm.apellidos = dgvDatos.CurrentRow.Cells[1].Value.ToString();
            ofrm.nombres = dgvDatos.CurrentRow.Cells[2].Value.ToString();
            ofrm.dni = dgvDatos.CurrentRow.Cells[3].Value.ToString();
            ofrm.direccion = dgvDatos.CurrentRow.Cells[4].Value.ToString();
            ofrm.celular = dgvDatos.CurrentRow.Cells[5].Value.ToString();
            ofrm.ShowDialog();
            Form2_Load(sender, e);

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Deseas eliminar el registro?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado==DialogResult.Yes)
            {
                Cliente objCliente = new Cliente();
                int codigo =int.Parse( dgvDatos.CurrentRow.Cells[0].Value.ToString());

                objCliente.IdCliente = codigo;
                objCliente.Eliminar();

                MessageBox.Show("Eliminado", "info");
                Form2_Load(sender, e);
            }
        }
    }
}
