using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Libro : Documento
    {
        //Campo
        int numPaginas;

        //Constructor
        public Libro(string titulo, string autor, int anio, string numNormalizado, string codebar, int numPaginas) : base(titulo, autor, anio, numNormalizado, codebar)
        {
            this.numPaginas = numPaginas;
        }

        //Propiedades
        public string ISBN
        {
            get => this.NumNormalizado;
        }

        public int NumPaginas
        {
            get => this.numPaginas;
        }

        //Operadores
        public static bool operator !=(Libro l1, Libro l2)
        {
            return !(l1 == l2);
        }

        public static bool operator ==(Libro l1, Libro l2)
        {
            return ((l1.Barcode == l2.Barcode) || (l1.ISBN == l2.ISBN) || ((l1.Titulo == l2.Titulo) && (l1.Autor == l2.Autor)));
        }

        //Método
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            int lenght = base.ToString().IndexOf("Código")-1;
            sb.Append($"{base.ToString()}");
            sb.Insert(lenght, $"\nISBN: {this.ISBN}");
            sb.AppendLine($"Número de Páginas: {this.NumPaginas}.");
            return sb.ToString();
        }
    }
}
