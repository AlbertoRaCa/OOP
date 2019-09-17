using System;
using System.Collections.Generic;

namespace Tarea3
{
    class Pelicula
    {
        public string Titulo;
        public Int16 Ano;
        public string Pais;
        public string Director;

    }
    class Program
    {
        static void Main(string[] args)
        {
            Pelicula p1 = new Pelicula();
            p1.Titulo = "El laberinto del fauno";
            p1.Ano = 2006;
            p1.Pais = "Mexico";
            p1.Director = "Guillermo del Toro";

            //Console.WriteLine("Titulo: {0}\nAno: {1}\nPais: {2}\nDirector: {3}\n", p1.Titulo, p1.Ano, p1.Pais, p1.Director);
            Console.WriteLine("Titulo: {0}\nAno: {1}\n", p1.Titulo, p1.Ano);

            
            Pelicula p2 = new Pelicula();
            p2.Titulo = "La forma del agua";
            p2.Ano = 2017;
            p2.Pais = "Estados Unidos";
            p2.Director = "Guillermo del Toro";

            Console.WriteLine("Titulo: {0}\nAno: {1}\n", p2.Titulo, p2.Ano);

        }
    }
}
