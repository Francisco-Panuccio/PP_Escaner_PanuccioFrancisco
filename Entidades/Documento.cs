using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Documento
    {
        //Tipos Anidados
        public enum Paso
        {
            Inicio,
            Distribuido,
            EnEscaner,
            EnRevision,
            Terminado
        }

        //Campos
        int anio;
        string autor;
        string barcode;
        Paso estado = Paso.Inicio;
        string numNormalizado;
        string titulo;

        //Constructor
        public Documento(string titulo, string autor, int anio, string numNormalizado, string barcode)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.anio = anio;
            this.numNormalizado = numNormalizado;
            this.barcode = barcode;
        }

        //Propiedades
        public int Anio
        {
            get => this.anio;
        }

        public string Autor
        {
            get => this.autor;
        }

        public string Barcode
        {
            get => this.barcode;
        }

        public Paso Estado
        {
            get => this.estado;
        }

        protected string NumNormalizado
        {
            get => this.numNormalizado;
        }

        public string Titulo
        {
            get => this.titulo;
        }

        //Métodos
        public bool AvanzarEstado()
        {
            bool retorno;
            if (this.estado == Paso.Terminado)
            {
                retorno = false;
            }
            else
            {
                switch (this.estado)
                {
                    case Paso.Inicio:
                        this.estado = Paso.Distribuido;
                        break;

                    case Paso.Distribuido:
                        this.estado = Paso.EnEscaner;
                        break;

                    case Paso.EnEscaner:
                        this.estado = Paso.EnRevision;
                        break;

                    case Paso.EnRevision:
                        this.estado = Paso.Terminado;
                        break;

                    default:
                        this.estado = Paso.Inicio;
                        break;
                }
                retorno = true;
            }
            return retorno;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Título: {this.titulo}");
            sb.AppendLine($"Autor: {this.autor}");
            sb.AppendLine($"Año: {this.anio}");
            sb.AppendLine($"Código de Barras: {this.barcode}");
            return sb.ToString();
        }
    }
}