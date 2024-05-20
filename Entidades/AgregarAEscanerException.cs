using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class AgregarAEscanerException : Exception
    {
        //Campos
        string nombreMetodo;
        string nombreClase;

        //Constructor
        public AgregarAEscanerException(string mensaje, string clase, string metodo, Exception innerException)
            : base(mensaje, innerException)
        {
            this.nombreMetodo = metodo;
            this.nombreClase = clase;
        }

        public AgregarAEscanerException(string mensaje, string clase, string metodo)
            : this(mensaje, clase, metodo, null) { }

        //Propiedades
        public string NombreMetodo
        {
            get => this.nombreMetodo;
        }

        public string NombreClase
        {
            get => this.nombreClase;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.Message}.");
            sb.AppendLine($"Excepción en el método '{this.NombreMetodo}' de la clase '{this.NombreClase}'.");
            return sb.ToString();
        }
    }
}
