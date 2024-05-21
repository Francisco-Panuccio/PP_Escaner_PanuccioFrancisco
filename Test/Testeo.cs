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
            /*---Libros---*/
            Libro l1 = new Libro("Yerma", "García Lorca, Federico", 1995, "1114", "22222", 27);
            Libro l2_similar_l1 = new Libro("Yerma", "García Lorca, Federico", 1997, "1115", "22223", 30);
            Libro l3_similar_l1 = new Libro("Yermo", "García Perez, Francisco", 1998, "1114", "22221", 35);
            Libro l4_similar_l1 = new Libro("Ermoy", "García García, Eduardo", 2000, "1121", "22222", 37);
            Libro l5 = new Libro("Titulo", "Autor", 1960, "ISBN-44-978-84-8427-757-6", "LLA", 200);
            Libro l6 = new Libro("Titulo_2", "Autor_2", 2001, "ISBN-33-977-84-8427-757-6", "LLC", 400);

            /*---Mapas---*/
            Mapa m1 = new Mapa("Ciudad Autónoma de Buenos Aires", "Instituto de Geografía", 2022, "", "8888", 30, 20);
            Mapa m2_similar_m1 = new Mapa("Ciudad Autónoma de Buenos Aires", "Instituto de Geografía", 2022, "", "7777", 30, 20);
            Mapa m3_similar_m1 = new Mapa("Boliiva", "Geografía", 2000, "", "8888", 50, 80);
            Mapa m4 = new Mapa("Titulo3", "Autor3", 1850, "", "LLC", 20, 90);

            /*---Escáneres---*/
            Escaner e_libro = new Escaner("HP", Escaner.TipoDoc.Libro);
            Escaner e_mapa = new Escaner("EPSON", Escaner.TipoDoc.Mapa);

            /*---Pruebas---*/

            //[Comprobación de Agregado de Libros y Mapas]
            /*
            Console.WriteLine($"Libro: {e_libro + l1}");
            Console.WriteLine($"Libro: {e_libro + l2_similar_l1}");
            Console.WriteLine($"Libro: {e_libro + l3_similar_l1}");
            Console.WriteLine($"Libro: {e_libro + l4_similar_l1}");
            Console.WriteLine($"Libro: {e_libro + l5}");
            Console.WriteLine($"Libro: {e_libro + l6}\n");

            Console.WriteLine($"Mapa: {e_mapa + m1}");
            Console.WriteLine($"Mapa: {e_mapa + m2_similar_m1}");
            Console.WriteLine($"Mapa: {e_mapa + m3_similar_m1}");
            Console.WriteLine($"Mapa: {e_mapa + m4}");
            */

            //[Libros y Mapas Similares]
            /*
            Console.WriteLine($"Libro: {l1 == l4_similar_l1}");
            Console.WriteLine($"Libro: {l1 == l2_similar_l1}");
            Console.WriteLine($"Libro: {l1 == l5}\n");

            Console.WriteLine($"Mapa: {m1 == m2_similar_m1}");
            Console.WriteLine($"Mapa: {m1 == m4}");
            */

            //[Libros y Mapas Diferentes]
            /*
            Console.WriteLine($"Libro: {l1 != l4_similar_l1}");
            Console.WriteLine($"Libro: {l1 != l2_similar_l1}");
            Console.WriteLine($"Libro: {l1 != l5}\n");

            Console.WriteLine($"Mapa: {m1 != m2_similar_m1}");
            Console.WriteLine($"Mapa: {m1 != m4}");
            */

            //[Avanzar Estado]
            /*
            Console.WriteLine(l1.Estado);
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
            Console.WriteLine($"6) {l1.ToString()}");
            */       

            //[Informes]
            /*
            bool a = (e_libro + l1);
            bool b = (e_libro + l5);
            bool c = (e_mapa + m1);

            int ext;
            int cant;
            string res;

            Informes.MostrarDistribuidos(e_libro, out ext, out cant, out res);
            Console.WriteLine($"Extensión: {ext}\n\nCantidad: {cant}\n\nResumen: {res}");
            */

            //[Excepciones]
            /*
            bool d = (e_mapa + l1);
            bool e = (e_libro + m4);
            */
        }
    }
}