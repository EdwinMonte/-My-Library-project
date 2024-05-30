namespace Library_project
{
    public partial class Form1 : Form
    {
        public string NombreUsuario { get; set; }
        public string CorreoUsuario { get; set; }

        private Biblioteca biblioteca;

        public Form1()
        {
            InitializeComponent();
            biblioteca = new Biblioteca();

            // Configurar columnas del ListView
            lstvLibros.View = View.Details;
            // Inicializa el ComboBox de sucursales
            comboBoxSucursales.Items.Add("Sucursal 1");
            comboBoxSucursales.Items.Add("Sucursal 2");
            comboBoxSucursales.Items.Add("Sucursal 3");
            comboBoxSucursales.SelectedIndex = 0; // Selecciona la primera sucursal por defecto

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Mostrar el nombre y correo del usuario
            lblNombreUsuario.Text = $"Nombre: {NombreUsuario}";
            lblCorreoUsuario.Text = $"Correo: {CorreoUsuario}";
            MessageBox.Show($"Bienvenido, {NombreUsuario} ({CorreoUsuario})", "Bienvenido");
        }
        private void btnaddbook_Click(object sender, EventArgs e)
        {
            string titulo = txtTitulo.Text;
            string autor = txtAutor.Text;
            if (int.TryParse(txtPaginas.Text, out int paginas) && decimal.TryParse(txtPrice.Text, out decimal precio))
            {
                Libro libro = new Libro(titulo, autor, paginas, precio);
                biblioteca.AgregarLibro(libro);
                ActualizarListaLibros();
            }
            else
            {
                MessageBox.Show("Por favor, ingrese datos válidos para páginas y precio.");
            }
        }

        private void ActualizarListaLibros()
        {
            lstvLibros.Items.Clear();
            foreach (var libro in biblioteca.ObtenerLibros())
            {
                ListViewItem item = new ListViewItem(new[] { libro.Titulo, libro.Autor, libro.Paginas.ToString(), libro.Precio.ToString("C") });
                lstvLibros.Items.Add(item);
            }
        }

        private void LimpiarCampos()
        {
            txtTitulo.Clear();
            txtAutor.Clear();
            txtPaginas.Clear();
            txtPrice.Clear();
        }

        private void btnExportJSON_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivos JSON (*.json)|*.json";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Biblioteca.ExportarAJson(biblioteca, saveFileDialog.FileName);
                MessageBox.Show("Biblioteca exportada exitosamente.");
            }
        }

        private void btnExportWord_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivos Word (*.docx)|*.docx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Exportador.ExportarADocx(biblioteca, saveFileDialog.FileName);
                MessageBox.Show("Biblioteca exportada exitosamente a Word.");
            }

        }
        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivos Excel (*.xlsx)|*.xlsx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Exportador.ExportarAExcel(saveFileDialog.FileName, biblioteca.ObtenerLibros());
                MessageBox.Show("Datos exportados exitosamente a Excel.");
            }
        }

        private void btnChargingtxt_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    CargarDesdeTxt(openFileDialog.FileName);
                    MessageBox.Show("Biblioteca cargada exitosamente desde el archivo TXT.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al cargar desde el archivo TXT: " + ex.Message);

            }
        }

        private void btnSavetxt_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    GuardarATxt(saveFileDialog.FileName);
                    MessageBox.Show("Biblioteca guardada exitosamente en el archivo TXT.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al guardar en el archivo TXT: " + ex.Message);

            }
        }
        private void CargarDesdeTxt(string rutaArchivo)
        {
            biblioteca = new Biblioteca();
            string[] lineas = File.ReadAllLines(rutaArchivo);
            foreach (string linea in lineas)
            {
                string[] partes = linea.Split(';');
                if (partes.Length == 4)
                {
                    string titulo = partes[0];
                    string autor = partes[1];
                    if (int.TryParse(partes[2], out int paginas) && decimal.TryParse(partes[3], out decimal precio))
                    {
                        Libro libro = new Libro(titulo, autor, paginas, precio);
                        biblioteca.AgregarLibro(libro);
                    }
                }
            }
            ActualizarListaLibros();
        }
        private void GuardarATxt(string rutaArchivo)
        {
            List<string> lineas = new List<string>();
            foreach (Libro libro in biblioteca.ObtenerLibros())
            {
                lineas.Add($"{libro.Titulo};{libro.Autor};{libro.Paginas};{libro.Precio}");
            }
            File.WriteAllLines(rutaArchivo, lineas);
        }

        private void RegistrarError(Exception ex)
        {
            throw new NotImplementedException();
        }

    

        

        private void btnEliminarLibro_Click(object sender, EventArgs e)
        {
            // Verificar si se ha seleccionado un libro en la lista
            if (lstvLibros.SelectedItems.Count > 0)
            {
                // Obtener el libro seleccionado
                Libro libroAEliminar = (Libro)lstvLibros.SelectedItems[0].Tag; // Suponiendo que has almacenado el libro como Tag del ListViewItem

                // Eliminar el libro de la biblioteca
                biblioteca.EliminarLibro(libroAEliminar);

                // Eliminar el ListViewItem correspondiente de la lista
                lstvLibros.SelectedItems[0].Remove();

                MessageBox.Show("Libro eliminado exitosamente.");
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un libro para eliminar.");
            }
        }
        private void MoverLibroASucursal(Libro libroAMover, string sucursal)
        {
            // Crear un nuevo ítem para el ListView
            ListViewItem nuevoItem = new ListViewItem(sucursal);
            nuevoItem.SubItems.Add(libroAMover.Titulo); // Segunda columna es el título
            nuevoItem.SubItems.Add(libroAMover.Autor);  // Tercera columna es el autor
            nuevoItem.SubItems.Add(libroAMover.Paginas.ToString()); // Cuarta columna es el número de páginas
            nuevoItem.SubItems.Add(libroAMover.Precio.ToString("C")); // Quinta columna es el precio

            // Añadir el nuevo ítem al ListView de sucursales
            lstvTotalLibrosPorSucursal.Items.Add(nuevoItem);
        }

        private void btnMoverLibro_Click(object sender, EventArgs e)
        {
            if (lstvLibros.SelectedItems.Count > 0 && comboBoxSucursales.SelectedItem != null)
            {
                ListViewItem selectedItem = lstvLibros.SelectedItems[0];
                string sucursal = comboBoxSucursales.SelectedItem.ToString();

                string titulo = selectedItem.SubItems[0].Text;
                string autor = selectedItem.SubItems[1].Text;
                int paginas = int.Parse(selectedItem.SubItems[2].Text);
                decimal precio = decimal.Parse(selectedItem.SubItems[3].Text, System.Globalization.NumberStyles.Currency);

                Libro libroAMover = new Libro(titulo, autor, paginas, precio);

                MoverLibroASucursal(libroAMover, sucursal);
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un libro y una sucursal.");
            }

        }

        private void comboBoxSucursales_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lstvTotalLibrosPorSucursal_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lstvLibros_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lstvLibros.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lstvLibros.SelectedItems[0];
                string titulo = selectedItem.SubItems[0].Text;
                string autor = selectedItem.SubItems[1].Text;
                int paginas = int.Parse(selectedItem.SubItems[2].Text);
                decimal precio = decimal.Parse(selectedItem.SubItems[3].Text, System.Globalization.NumberStyles.Currency);

                FormActionBook formAccion = new FormActionBook(titulo, autor, paginas, precio);
                formAccion.ShowDialog();
            }
        }

    }     
}

