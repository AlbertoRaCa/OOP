using System;
using System.Collections.Generic;

namespace Tarea3
{
    class Pelicula
    {
        private String Titulo;
        private Int16 Ano;
        

        public void SetTitulo(String Titulo)
        {
            this.Titulo = Titulo;
        }
        public String GetTitulo()
        {
            return this.Titulo;
        }
        public void SetAno(Int16 Ano)
        {
            this.Ano = Ano;
        }
        public Int16 GetAno()
        {
            return this.Ano;
        }


        public Pelicula()
        {

        }
        public Pelicula(String Titulo, Int16 Ano)
        {
            this.Titulo = Titulo;
            this.Ano = Ano;
        }


        public void imprime()
        {
            Console.WriteLine("Titulo: {0}\nAno: {1}\n", this.Titulo, this.Ano);
        }

    }
    class Program
    {
        static void Main(String[] args)
        {
            Pelicula p1 = new Pelicula();
            p1.SetTitulo("El laberinto del fauno");
            p1.SetAno(2006);

            p1.imprime();
            
            Pelicula p2 = new Pelicula();
            p2.SetTitulo("La forma del agua");
            p2.SetAno(2017);

            p2.imprime();
        }
    }
}
