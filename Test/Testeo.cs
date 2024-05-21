using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Test
{
    internal class Testeo
    {
        static void Main(string[] args)
        {
            //Test de Libros
            Libro l1 = new Libro("Yerma", "García Lorca, Federico", 1995, "1114", "22222", 27);
            Libro l2 = new Libro("Yerma", "García Lorca, Federico", 1995, "1115", "22223", 27);
            Libro l3 = new Libro("Titulo2", "Autor2", 1960, "ISBN-44-978-84-8427-757-6", "LLA", 200);
            Libro l4 = new Libro("Titulo3", "Autor3", 2000, "ISBN-33-977-84-8427-757-6", "LLD", 400);
            Libro l5 = new Libro("Titulo4", "Autor4", 1920, "ISBN-13-978-84-8427-757-6", "LLE", 200);

            //Test de Mapas
            Mapa m1 = new Mapa("Ciudad Autónoma de Buenos Aires", "Instituto de Geografía", 2022, "", "8888", 30, 20);
            Mapa m2 = new Mapa("Ciudad Autónoma de Buenos Aires", "Instituto de Geografía", 2022, "", "8888", 30, 20);
            Mapa m3 = new Mapa("Titulo3", "Autor3", 1850, "", "LLC", 20, 90);

            //Test de Informes

            //Test de Escaneres
            Escaner e1 = new Escaner("HP", Escaner.TipoDoc.Libro);
            Escaner e2 = new Escaner("EPSON", Escaner.TipoDoc.Mapa);

            //Pruebas

            //Avanzar Estado
            /*Console.WriteLine(l1.Estado);
            Console.WriteLine($"1) {l1.ToString()}");
            Console.WriteLine(l1.AvanzarEstado());
            Console.WriteLine(l1.Estado);
            Console.WriteLine($"2) {l1.ToString()}");
            Console.WriteLine(l1.AvanzarEstado());
            Console.WriteLine(l1.Estado);
            Console.WriteLine($"3) {l1.ToString()}");
            Console.WriteLine(l1.AvanzarEstado());
            Console.WriteLine(l1.Estado);
            Console.WriteLine($"4) {l1.ToString()}");
            Console.WriteLine(l1.AvanzarEstado());
            Console.WriteLine(l1.Estado);
            Console.WriteLine($"5) {l1.ToString()}");
            Console.WriteLine(l1.AvanzarEstado());
            Console.WriteLine(l1.Estado);
            Console.WriteLine($"6) {l1.ToString()}");*/

            //Documentos en Inicio
            /*Console.WriteLine("Documentos en Inicio\n");
            Console.WriteLine($"Libro 1 Estado: {l1.Estado}\n");
            Console.WriteLine($"{l1.ToString()}");
            Console.WriteLine($"Mapa 1 Estado: {m1.Estado}\n");
            Console.WriteLine($"{m1.ToString()}");
            Console.WriteLine($"Libro 2 Estado: {l2.Estado}\n");
            Console.WriteLine($"{l2.ToString()}");*/

            //Informes
            /*bool a = (e1 + l1);
            bool b = (e1 + l4);
            bool c = (e2 + m1);

            int ext;
            int cant;
            string res;

            Informes.MostrarDistribuidos(e1, out ext, out cant, out res);
            Console.WriteLine($"Extensión: {ext}\n\nCantidad: {cant}\n\nResumen: {res}");*/

            //Excepciones
            /*bool d = (e2 + l1);
            bool e = (e1 + l2);*/
        }
    }
}