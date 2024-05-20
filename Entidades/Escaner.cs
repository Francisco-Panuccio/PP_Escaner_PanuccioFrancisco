using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Escaner
    {
        //Tipos Anidados
        public enum Departamento
        {
            Nulo,
            Mapoteca,
            ProcesosTecnicos
        }

        public enum TipoDoc
        {
            Libro,
            Mapa
        }

        //Campos
        List<Documento> listaDocumentos;
        Departamento locacion;
        string marca;
        TipoDoc tipo;

        //Propiedades
        public List<Documento> ListaDocumentos
        {
            get => this.listaDocumentos;
        }

        public Departamento Locacion
        {
            get => this.locacion;
        }

        public string Marca
        {
            get => this.marca;
        }
        public TipoDoc Tipo
        {
            get => this.tipo;
        }

        //Constructor
        public Escaner(string marca, TipoDoc tipo)
        {
            this.marca = marca;
            this.tipo = tipo;
            this.listaDocumentos = new List<Documento>();
            if (this.tipo == TipoDoc.Mapa)
            {
                this.locacion = Departamento.Mapoteca;
            }
            else if (this.tipo == TipoDoc.Libro)
            {
                this.locacion = Departamento.ProcesosTecnicos;
            }
            else
            {
                this.locacion = Departamento.Nulo;
            }
        }

        //Operadores
        public static bool operator !=(Escaner e, Documento d)
        {
            return !(e == d);
        }

        public static bool operator +(Escaner e, Documento d)
        {
            bool retorno = false;
            if ((e != d) && (d.Estado == Documento.Paso.Inicio))
            {
                e.CambiarEstadoDocumento(d);
                e.listaDocumentos.Add(d);
                retorno = true;
            }
            return retorno;
        }

        public static bool operator ==(Escaner e, Documento d)
        {
            bool retorno = false;
            TipoDoc tipoDocumento = d is Libro ? TipoDoc.Libro : TipoDoc.Mapa;
            try 
            {
                if (e.Tipo == tipoDocumento)
                {
                    foreach (Documento doc in e.listaDocumentos)
                    {
                        if ((d is Libro && ((Libro)doc == (Libro)d)) || (d is Mapa && ((Mapa)doc == (Mapa)d)))
                        {
                            retorno = true;
                            throw new AgregarAEscanerException("Documento Duplicado", "Escaner.cs", "Operador ==");
                        }                      
                    }
                }
                else
                {
                    throw new AgregarAEscanerException("Escáner Incorrecto", "Escaner.cs", "Operador ==");
                }
            }
            catch (AgregarAEscanerException ee)
            {
                Console.WriteLine(ee);
            }
            return retorno;
        }

        //Método
        public bool CambiarEstadoDocumento(Documento d)
        {
            return d.AvanzarEstado();
        }
    }
}