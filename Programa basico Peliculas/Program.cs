using System;
using System.Collections.Generic;

namespace Programa_basico_Peliculas
{
    class Pelicula
    {
        //Atributos
        private String Titulo;
        private Int16 Ano;

        //Como no se usan y no quiero que se imprima en letras amarillas
        //puse como comentarios los atributos pais & director
        //public string Pais;
        //public string Director;
        
        //Atributo tipo lista
        private List<Actor> actores = new List<Actor>();

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

        //Metodo imprime
        public void imprime()
        {
            Console.WriteLine("Titulo: {0}\nAno: {1}\n", this.Titulo, this.Ano);
        }

        //Metodo agregar actor a la Lista
        public void AgregarActor(Actor actor) 
        {
			actores.Add(actor);
		}

        //Metodo imprime lista
		public void ImprimeActores() 
        {
			foreach(Actor actor in actores)
            {
                Console.WriteLine("Actor: {0}\nAno: {1}\n", actor.Nombre, actor.Ano);
            }
        }
    }

    //Clase Actor
    class Actor
	{
		public string Nombre;
		public Int16 Ano;
		public Actor(string Nombre, Int16 Ano) 
        {
			this.Nombre = Nombre;
			this.Ano = Ano;
		}
	}
    class Program
    {
        static void Main(String[] args)
        {
            Pelicula p1 = new Pelicula("La La Land", 2016);
            p1.AgregarActor(new Actor("Ryan Gosling", 1980));
            p1.AgregarActor(new Actor("Emma Stone", 1988));

            p1.ImprimeActores();
        }
    } 
}
