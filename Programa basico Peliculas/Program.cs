using System;

namespace Programa_basico_Peliculas
{
    class Pelicula
    {
        //Atributos
        private String Titulo;
        private Int16 Ano;
        public string Pais;
        public string Director;

        //Metodos get set para utilizar atributos privados en otras clases
        public void SetTitulo(string Titulo)
        {
            this.Titulo = Titulo;
        } 
        public string GetTitulo()
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

        //Primer constructor
        public Pelicula()
        {

        }
        //Segundo constructor
        public Pelicula(String Titulo, Int16 Ano)
        {
            this.Titulo = Titulo;
            this.Ano = Ano;
        }

        //metodo imprime
        public void imprime()
        {
            Console.WriteLine("Titulo: {0}\nAno: {1}\n", this.Titulo, this.Ano);
        }
    }
    class Program
    {
        static void Main(String[] args)
        {
            //Objeto tipo pelicula
            Pelicula p1 = new Pelicula();
            p1.SetTitulo("El laberinto del fauno");
            p1.SetAno(2006);

            p1.imprime();
            //p1.Pais = "Mexico";
            //p1.Director = "Gillermo Del Toro";
            //Console.WriteLine("Titulo: {0}\nAno :{1}\n", p1.GetTitulo(), p1.GetAno());
            //Console.WriteLine("Titulo: {0}\nAno :{1}\nPais: {2}\nDirector: {3}\n", p1.Titulo, p1.Ano, p1.Pais, p1.Director);

            Pelicula p2 = new Pelicula();
            p2.SetTitulo("La forma del agua");
            p2.SetAno(2017);

            p2.imprime();
            //p2.Pais = "Estados unidos";
            //p2.Director = "Gillermo Del Toro";
            //Console.WriteLine("Titulo: {0}\nAno :{1}\n", p2.GetTitulo(), p2.GetAno());
            
        }
    }
}
