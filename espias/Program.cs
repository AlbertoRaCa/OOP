using System;

namespace espias
{
    class Persona
    {
        public string nombre;
        public string apellido;

        public Persona()
        {
            nombre = "Fulano";
            apellido = "De Tal";
        }   
    }
    class Annonymus
    {
        public static void anonimiza(Persona p)
        {
            p.nombre = "xxxxxxx";
            p.apellido = "xxxxxxx";
        }
    }
    public static void cambia(ref Persona p)
    {// se cambia el a otro nombre
        p = new Persona();
        p.nombre = "new";
    }
    class Program
    {
        static void Main(string[] args)
        {       //referencia a p
            Persona p = new Persona();
            Console.WriteLine(p.nombre);

            //el tipo de dato que se envia es por referencia
            Annonymus.cambia(p.nombre);
            Annonymus.anonimiza(ref p);
            Console.WriteLine(p.nombre);

            
        }
    }
}
