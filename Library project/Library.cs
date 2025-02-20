﻿namespace Library_project
{
    using ClosedXML;
    using ClosedXML.Excel;
    using DocumentFormat.OpenXml.Packaging;
    using DocumentFormat.OpenXml;
    using System.IO;
    using System.Text.Json;
    using Xceed.Document.NET;
    using Xceed.Words.NET;
    using DocumentFormat.OpenXml.Wordprocessing;
    using System;
    using DocumentFormat.OpenXml.Spreadsheet;
    using Row = DocumentFormat.OpenXml.Spreadsheet.Row;
    using Cell = DocumentFormat.OpenXml.Spreadsheet.Cell;
    using Text = DocumentFormat.OpenXml.Wordprocessing.Text;

    public class Biblioteca
    {
        private List<Libro> libros;

        public Biblioteca()
        {
            libros = new List<Libro>();
        }

        public List<Libro> ObtenerLibros()
        {
            return libros;
        }

        public void AgregarLibro(Libro libro)
        {
            libros.Add(libro);
        }

        public void EliminarLibro(Libro libro)
        {
            libros.Remove(libro);
        }
       

        // Método estático para exportar la biblioteca a JSON
        public static void ExportarAJson(Biblioteca biblioteca, string rutaArchivo)
        {
            string json = JsonSerializer.Serialize(biblioteca.libros);
            File.WriteAllText(rutaArchivo, json);
        }

        public static void ExportarADocx(string rutaArchivo, List<Libro> libros)
        {
            using (WordprocessingDocument wordDocument = WordprocessingDocument.Create(rutaArchivo, WordprocessingDocumentType.Document))
            {
                MainDocumentPart mainPart = wordDocument.AddMainDocumentPart();
                mainPart.Document = new DocumentFormat.OpenXml.Wordprocessing.Document();
                Body body = mainPart.Document.AppendChild(new Body());

                foreach (var libro in libros)
                {
                    DocumentFormat.OpenXml.Wordprocessing.Paragraph para = body.AppendChild(new DocumentFormat.OpenXml.Wordprocessing.Paragraph());
                    DocumentFormat.OpenXml.Wordprocessing.Run run = para.AppendChild(new DocumentFormat.OpenXml.Wordprocessing.Run());
                    run.AppendChild(new Text($"{libro.Titulo} - {libro.Autor} - {libro.Paginas}- {libro.Precio}"));
                }

                mainPart.Document.Save();
            }
        }
        // Método estático para exportar la biblioteca a XLSX

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
                headerRow.Append(new Cell() { CellValue = new CellValue("Año"), DataType = CellValues.String });
                sheetData.Append(headerRow);

                foreach (var libro in libros)
                {
                    Row row = new Row();
                    row.Append(new Cell() { CellValue = new CellValue(libro.Titulo), DataType = CellValues.String });
                    row.Append(new Cell() { CellValue = new CellValue(libro.Autor), DataType = CellValues.String });
                    row.Append(new Cell() { CellValue = new CellValue(libro.Paginas.ToString()), DataType = CellValues.Number });
                    sheetData.Append(row);
                }

                workbookPart.Workbook.Save();
            }



        }
    }
}

    
    


