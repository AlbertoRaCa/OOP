using System;

namespace Programa_basico_Peliculas
{
    class Pelicula
    {
        //Atributos publicos
        public String Titulo;
        public Int16 Ano;
        public string Pais;
        public string Director;        

    }
    class Program
    {
        static void Main(String[] args)
        {
            //Objeto tipo pelicula
            Pelicula p1 = new Pelicula();
            p1.Titulo = "El laberinto del fauno";
            p1.Ano = 2006;
            p1.Pais = "Mexico";
            p1.Director = "Gillermo Del Toro";
            Console.WriteLine("Titulo: {0}\nAno :{1}\n", p1.Titulo, p1.Ano);
            //Console.WriteLine("Titulo: {0}\nAno :{1}\nPais: {2}\nDirector: {3}\n", p1.Titulo, p1.Ano, p1.Pais, p1.Director);

            Pelicula p2 = new Pelicula();
            p2.Titulo = "La forma del agua";
            p2.Ano = 2017;
            p2.Pais = "Estados unidos";
            p2.Director = "Gillermo Del Toro";
            Console.WriteLine("Titulo: {0}\nAno :{1}\n", p2.Titulo, p2.Ano);
            
        }
    }
}
