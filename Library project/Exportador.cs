using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.Wordprocessing;
using Run = DocumentFormat.OpenXml.Wordprocessing.Run;
using Text = DocumentFormat.OpenXml.Wordprocessing.Text;

namespace Library_project
{
    public static class Exportador
    {
        public static void ExportarADocx(Biblioteca biblioteca, string filePath)
        {
            using (WordprocessingDocument wordDocument = WordprocessingDocument.Create(filePath, WordprocessingDocumentType.Document))
            {
                MainDocumentPart mainPart = wordDocument.AddMainDocumentPart();
                mainPart.Document = new Document();
                Body body = mainPart.Document.AppendChild(new Body());

                foreach (var libro in biblioteca.ObtenerLibros())
                {
                    // Crear un párrafo para cada campo del libro
                    Paragraph tituloParrafo = new Paragraph(new Run(new Text("Título: " + libro.Titulo)));
                    Paragraph autorParrafo = new Paragraph(new Run(new Text("Autor: " + libro.Autor)));
                    Paragraph paginasParrafo = new Paragraph(new Run(new Text("Páginas: " + libro.Paginas)));
                    Paragraph precioParrafo = new Paragraph(new Run(new Text("Precio: " + libro.Precio.ToString("C"))));

                    // Añadir los párrafos al cuerpo del documento
                    body.Append(tituloParrafo);
                    body.Append(autorParrafo);
                    body.Append(paginasParrafo);
                    body.Append(precioParrafo);

                    // Añadir un espacio entre libros
                    body.Append(new Paragraph(new Run(new Text(""))));
                }

                mainPart.Document.Save();
            }
        }
        public static void ExportarAExcel(string rutaArchivo, List<Libro> libros)
        {
            using (SpreadsheetDocument document = SpreadsheetDocument.Create(rutaArchivo, SpreadsheetDocumentType.Workbook))
            {
                WorkbookPart workbookPart = document.AddWorkbookPart();
                workbookPart.Workbook = new Workbook();
                Sheets sheets = workbookPart.Workbook.AppendChild(new Sheets());

                WorksheetPart worksheetPart = workbookPart.AddNewPart<WorksheetPart>();
                SheetData sheetData = new SheetData();
                worksheetPart.Worksheet = new Worksheet(sheetData);

                Sheet sheet = new Sheet()
                {
                    Id = workbookPart.GetIdOfPart(worksheetPart),
                    SheetId = 1,
                    Name = "Libros"
                };
                sheets.Append(sheet);

                Row headerRow = new Row();
                headerRow.Append(new Cell() { CellValue = new CellValue("Título"), DataType = CellValues.String });
                headerRow.Append(new Cell() { CellValue = new CellValue("Autor"), DataType = CellValues.String });
                headerRow.Append(new Cell() { CellValue = new CellValue("Páginas"), DataType = CellValues.String });
                headerRow.Append(new Cell() { CellValue = new CellValue("Precio"), DataType = CellValues.String });
                sheetData.Append(headerRow);

                foreach (var libro in libros)
                {
                    Row row = new Row();
                    row.Append(new Cell() { CellValue = new CellValue(libro.Titulo), DataType = CellValues.String });
                    row.Append(new Cell() { CellValue = new CellValue(libro.Autor), DataType = CellValues.String });
                    row.Append(new Cell() { CellValue = new CellValue(libro.Paginas.ToString()), DataType = CellValues.Number });
                    row.Append(new Cell() { CellValue = new CellValue(libro.Precio.ToString()), DataType = CellValues.Number });
                    sheetData.Append(row);
                }

                workbookPart.Workbook.Save();
            }
        }
    }
}
