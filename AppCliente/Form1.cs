using System;
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
    public partial class Form1 : Form
    {
        public string codigo;
        public string apellidos;
        public string nombres;
        public string dni;
        public string direccion;
        public string celular;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente objCliente =new Cliente();
                objCliente.Apellidos = txtApellidos.Text;
                objCliente.Nombres = txtNombres.Text;
                objCliente.DNI = txtDNI.Text;
                objCliente.Direccion = txtDireccion.Text;
                objCliente.Celular = txtCelular.Text;

                if(txtId.Text == "0")
                {
                    objCliente.Guardar();
                    MessageBox.Show("Guardado", "Info");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error", ex.Message);
                throw;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (codigo != "0")
            {
                txtId.Text = codigo;
                txtApellidos.Text = apellidos;
                txtNombres.Text = nombres;
                txtDNI.Text = dni;
                txtDireccion.Text = direccion;
                txtCelular.Text = celular;

            }
        }
    }
}
