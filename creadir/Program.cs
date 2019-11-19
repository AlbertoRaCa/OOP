using System;
using System.IO;

namespace creadir
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Captura el folder a crear");
            //ruta
            string directorio = Console.WriteLine();
            //condicion
            if(Directory.Exist(directorio))
            {
                Console.WriteLine("Ya existe");   
            }
            else
                {
                    Directory.CreaDiectory(directorio);
                }

            Directory.CreaDiectory(directorio);
        }
    }
}
