using System;

namespace Duracion
{
    class Duracion
    {
        private int Horas;
        private int Minutos;
        private int Segundos;

        public void SetHoras(int Horas)
        {
            this.Horas = Horas;
        } 
        public int GetHoras()
        {
            return this.Horas;
        }

        public Duracion(int Horas, int Minutos, int Segundos)
    {
        this.Horas = Horas;
        this.Minutos = Minutos;
        this.Segundos = Segundos;
    }
    
    public void imprime()
    {
        Console.WriteLine("Horas: {0}\nMinutos: {1}\nSegundos: {2}\n", this.Horas, this.Minutos, this.Segundos);
    }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Duracion Pelicula = new Duracion(2,30,0);
            D.imprime();
        }
    }
}
