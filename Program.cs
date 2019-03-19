using System;

namespace CoreEscuela
{
    //Definimos la clase escuela
    class Escuela{
        public string nombre;
        public string direccion;
        public int añoFundacion;
        public string ceo;

        public void Timbrar(){
            //Metodo Timbrar
            Console.Beep(2000,3000);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Instanciando mi objeto
            var miEscuela = new Escuela();
            miEscuela.nombre = "Platzi School";
            miEscuela.direccion = "Guatemala";
            miEscuela.añoFundacion = 2019;
            Console.WriteLine("TIMBRE");
            miEscuela.Timbrar();
            //Console.WriteLine("Hello World!");
        }
    }
}
