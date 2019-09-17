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

        public void imprime()
        {
            Console.WriteLine("Pelicula: {0}\nAno: {1}\nPais: {2}\nDirector: {3}\n", Titulo, Ano, Pais, Director);
        }
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

            p1.imprime();

            Pelicula p2 = new Pelicula();
            p2.Titulo = "La forma del agua";
            p2.Ano = 2017;
            p2.Pais = "Estados Unidos";
            p2.Director = "Guillermo del Toro";

            p2.imprime();
        }
    }
}
