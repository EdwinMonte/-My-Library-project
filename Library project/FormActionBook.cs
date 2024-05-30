using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_project
{
    public partial class FormActionBook : Form
    {
        private Biblioteca biblioteca;
        private string titulo;
        private string autor;
        private int paginas;
        private decimal precio;

        public Libro LibroSeleccionado { get; private set; }
        public FormActionBook(string titulo, string autor, int paginas, decimal precio)
        {
            InitializeComponent();
            lblTitle.Text = $"Título: {titulo}";
            lblPrice.Text = $"Precio: {precio:C}";
            LibroSeleccionado = new Libro(titulo, autor, paginas, precio);
        }

        private void btnToLend_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"El libro '{LibroSeleccionado.Titulo}' ha sido prestado.");
            
        }

        private void btnPrice_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"El libro '{LibroSeleccionado.Titulo}' ha sido vendido.");
            
        }
    }
}

