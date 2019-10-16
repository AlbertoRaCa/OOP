using System;
using System.Collections.Generic;

namespace Figuras
{
    abstract class Figura//1
    {
        private int Ancho, Alto;
        protected int px, py;//eje x y los cuales son la coordenada
        protected string Color_Relleno, Color_Borde;//Borde es de 1 pixel

        //se pueden poner valores por default como color de relleno, borde
        public Figura(int Ancho, int Alto, int px, int py, string Color_Borde, string Color_Relleno)
        {
            this.Ancho = A;//todos los demas
        }

        //metodo dibuja no requiere parametros ya que esta dentro de la clase
        /*abstract se utiliza para que al heredar clase Figura se utiliza el metodo por default
        La clase deve ser abstracta y no se puede crear objeto tipo Figura*/
        public abstract void dibuja();
    }
    class Rectangulo:Figura//2
    {
        public Rectangulo(int Ancho, int Alto, int px, int py, string Color_Borde, string Color_Relleno):base(int Ancho, int Alto, int px, int py, string Color_Borde, string Color_Relleno)
        {
            this...
        }
        public override void dibuja()
        {
            Console.WriteLine("Se dibuja un rectangulo color {0} en x:{1} y y:{2}", Color_Relleno, px, py);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Figura f = new Figura(10, 10); no se puede por que figura es una clase abstacta
            //Se puede crear Lista tipo Figura y anadirlos
            List<Figura> figuras = List<Figura>();
            figuras.Add(new Rectangulo(10, 10));
            Console.WriteLine("Hello World!");
        }
    }
}
