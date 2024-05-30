using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_project
{
    public partial class FormBienvenida : Form
    {
        public string Nombre { get; private set; }
        public string Correo { get; private set; }
        public FormBienvenida()
        {
            InitializeComponent();
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            {
                if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtCorreo.Text))
                {
                    MessageBox.Show("Por favor, ingresa tu nombre y correo electrónico.");
                    return;
                }

                Nombre = txtNombre.Text;
                Correo = txtCorreo.Text;

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
