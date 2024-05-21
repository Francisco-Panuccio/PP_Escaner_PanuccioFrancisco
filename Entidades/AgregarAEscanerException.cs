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

        /// <summary>
        /// Atributos de la excepción.
        /// </summary>
        string nombreMetodo;
        string nombreClase;

        //Constructor

        /// <summary>
        /// Constructor que inicializa los atributos de la excepción con valores determinados.
        /// </summary>
        /// <param name="mensaje">Mensaje de la excepción</param><<
        /// <param name="clase">Clase en la que se produce la excepción</param><<
        /// <param name="metodo">Método en el que se produce la excepción</param><<
        public AgregarAEscanerException(string mensaje, string clase, string metodo) : base(mensaje)
        {
            this.nombreMetodo = metodo;
            this.nombreClase = clase;
        }

        //Propiedades

        /// <summary>
        /// Getter para obtener el valor del atributo privado "nombreMetodo".
        /// </summary>
        public string NombreMetodo
        {
            get => this.nombreMetodo;
        }

        /// <summary>
        /// Getter para obtener el valor del atributo privado "nombreClase".
        /// </summary>
        public string NombreClase
        {
            get => this.nombreClase;
        }

        /// <summary>
        /// Sobreescritura del método ToString para visulizar información de la excepción.
        /// </summary>
        /// <returns>Un string con toda la información de la excepción</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.Message}.");
            sb.AppendLine($"Excepción en el método '{this.NombreMetodo}' de la clase '{this.NombreClase}'.");
            return sb.ToString();
        }
    }
}
