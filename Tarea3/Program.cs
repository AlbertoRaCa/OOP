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
            p1.Titulo = "Gantz";
            p1.Ano = 2010;
            p1.Pais = "Japon";
            p1.Director = "Taro Kawazu";

            p1.imprime();
        }
    }
}
