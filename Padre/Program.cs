using System;
using System.Collections.Generic;

namespace Padre
{
    class Componente
    {
        public string n = nombre;
        //referencia
        public Contenedor padre;

        //constructor
        public Componente(string nombre, Contenedor padre)
        {
            this.nombre = nombre;
            this.padre = padre;

            public void imprime()
            {
                Console.WriteLine($"Soy (nombre) y mi padre es (padre.nombre)");
            }
        }
    }
    class Contenedor
    {
        public string nombre;
        public List<Componente> componentes = new List<Componente>();

        public Contenedor(string nombre)
        {
            this.nombre = nombre;
            //estos componentes estan contenidos en el contenedor
            componentes.Add(new Componente("primero", this));
            componentes.Add(new Componente("segundo", this));
            componentes.Add(new Componente("tercero", this));
        }
        public void imprime()
        {
            foreach(var hijo in componentes)
            {
                hijo.imprime();
            }   
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Contenedor padre1 = new Contenedor("Contenedor 1");
            Contenedor padre1 = new Contenedor("Contenedor 2");

            padre1.imprime();
            Console.WriteLine("-----------------------------");
            padre2.imprime();
        }
    }
}
