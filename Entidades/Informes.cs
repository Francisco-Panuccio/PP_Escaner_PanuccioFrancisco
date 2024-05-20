using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Entidades.Documento;

namespace Entidades
{
    public static class Informes
    {
        //Métodos
        static void MostrarDocumentosPorEstado(Escaner e, Documento.Paso estado, out int extension, out int cantidad, out string resumen)
        {
            extension = 0;
            cantidad = 0;
            resumen = "";
            foreach (Documento doc in e.ListaDocumentos)
            {
                if (doc.Estado == estado)
                {
                    if (doc is Libro)
                    {
                        extension += ((Libro)doc).NumPaginas;
                    }
                    else 
                    {
                        extension += ((Mapa)doc).Superficie;
                    }                     
                    cantidad++;
                    resumen += ($"\n{doc.ToString()}");
                }
            }
        }

        public static void MostrarDistribuidos(Escaner e, out int extension, out int cantidad, out string resumen)
        {
            MostrarDocumentosPorEstado(e, Paso.Distribuido, out extension, out cantidad, out resumen);
        }

        public static void MostrarEnEscaner(Escaner e, out int extension, out int cantidad, out string resumen)
        {
            MostrarDocumentosPorEstado(e, Paso.EnEscaner, out extension, out cantidad, out resumen);
        }

        public static void MostrarEnRevision(Escaner e, out int extension, out int cantidad, out string resumen)
        {
            MostrarDocumentosPorEstado(e, Paso.EnRevision, out extension, out cantidad, out resumen);
        }

        public static void MostrarTerminados(Escaner e, out int extension, out int cantidad, out string resumen)
        {
            MostrarDocumentosPorEstado(e, Paso.Terminado, out extension, out cantidad, out resumen);
        }
    }
}