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
    public void imprimetotal()
    {
        int M;
        int S;
        M = (Horas*60)+(Minutos*60);
        S = (Horas*60*60)+(Minutos*60)+(Segundos);
        Console.WriteLine("\nTotal en minutos: {0}\nTotal en segundos: {1}", M, S);
        //Console.WriteLine("Horas en segundos: {0}\n", H);
    }
    
    public void imprime()
    {
        Console.WriteLine("Horas: {0}\nMinutos: {1}\nSegundos: {2}", this.Horas, this.Minutos, this.Segundos);
    }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Duracion Pelicula = new Duracion(2,15,12);
            Console.WriteLine("Pelicula\n");
            Pelicula.imprime();
            Pelicula.imprimetotal();
            


            /*Duracion Cancion = new Duracion(0,2,15);
            Console.WriteLine("\nCancion");
            Cancion.imprime();
            Duracion Partido = new Duracion(2,2,15);
            Console.WriteLine("\nPartido");
            Partido.imprime();*/
        }
    }
}
