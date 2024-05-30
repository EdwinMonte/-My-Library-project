using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_project
{
    
    public class Libro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int Paginas { get; set; }
        public decimal Precio { get; set; }

        public Libro(string titulo, string autor, int paginas, decimal precio)
        {
            Titulo = titulo;
            Autor = autor;
            Paginas = paginas;
            Precio = precio;
        }
        // Constructor sin parámetros
        public Libro()
        {
            Titulo = "Desconocido";
            Autor = "Desconocido";
            Paginas = 0;
            
        }


        // Método que no recibe parámetros ni regresa nada
        public void MostrarInformacion()
        {
            Console.WriteLine($"Título: {Titulo}, Autor: {Autor}, Páginas: {Paginas} Precio: {Precio}");
        }

        // Método que recibe parámetros pero no regresa nada
        public void ActualizarPaginas(int nuevasPaginas)
        {
            Paginas = nuevasPaginas;
        }

        // Método que no recibe parámetros pero regresa algo
        public string ObtenerAutor()
        {
            return Autor;
        }

        // Método que recibe parámetros y regresa algo
        public bool EsLibroLargo(int umbral)
        {
            return Paginas > umbral;
        }

        // Evento para notificar cambios en el libro
        public event EventHandler LibroActualizado;

        // Método para invocar el evento
        protected virtual void OnLibroActualizado()
        {
            LibroActualizado?.Invoke(this, EventArgs.Empty);
        }

      
    }

}
