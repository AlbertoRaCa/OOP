using System;

namespace Duracion
{
    class Duracion
    {
        private int Horas;
        private int Minutos;
        private int Segundos;

        public Duracion(int Horas, int Minutos, int Segundos)
    {
        this.Horas = Horas;
        this.Minutos = Minutos;
        this.Segundos = Segundos;
    }
    public void imprime()
    {
        int H;
        int M;
        int S;
        H = (Horas*3600);
        M = (Minutos*60);
        S = Segundos;
        Console.WriteLine("Horas: {0}\nMinutos: {1}\nSegundos: {2}", H, M, S);
        //Console.WriteLine("Horas en segundos: {0}\n", H);
    }
    
    /*public void imprime()
    {
        Console.WriteLine("Horas: {0}\nMinutos: {1}\nSegundos: {2}", this.Horas, this.Minutos, this.Segundos);
    }*/
    }
    class Program
    {
        static void Main(string[] args)
        {
            Duracion Pelicula = new Duracion(2,15,12);
            Console.WriteLine("Pelicula");
            Pelicula.imprime();
            Duracion Cancion = new Duracion(0,2,15);
            Console.WriteLine("\nCancion");
            Cancion.imprime();
            Duracion Partido = new Duracion(2,2,15);
            Console.WriteLine("\nPartido");
            Partido.imprime();
        }
    }
}
