using System;

namespace laboratorio_1
{
    class Persona
    {
        public string nombre;
        public string apellido;

        public Persona(string aNombre, string aApellido)
        {
            nombre = aNombre;
            apellido = aApellido;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Lanzar());
        }

        static int Lanzar()
        {
            Random Num = new Random();
            return Num.Next(0,3);
        }
    
    }
}
