using ClosedXML.Excel;

namespace Library_project
{
    internal static class Program
    {
       
        public static void ExportarAExcel(Biblioteca biblioteca, string rutaArchivo)
        {
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Libros");

                worksheet.Cell("A1").Value = "Título";
                worksheet.Cell("B1").Value = "Autor";
                worksheet.Cell("C1").Value = "Páginas";

                int row = 2;
                foreach (Libro libro in biblioteca.ObtenerLibros())
                {
                    worksheet.Cell($"A{row}").Value = libro.Titulo;
                    worksheet.Cell($"B{row}").Value = libro.Autor;
                    worksheet.Cell($"C{row}").Value = libro.Paginas;
                    row++;
                }

                workbook.SaveAs(rutaArchivo);
            }
        }
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Mostrar el formulario de bienvenida primero
            using (FormBienvenida formBienvenida = new FormBienvenida())
            {
                if (formBienvenida.ShowDialog() == DialogResult.OK)
                {
                    // Pasar los datos del usuario al formulario principal
                    Form1 formPrincipal = new Form1
                    {
                        NombreUsuario = formBienvenida.Nombre,
                        CorreoUsuario = formBienvenida.Correo
                    };

                    Application.Run(formPrincipal);
                }
            }
        }
    }
}