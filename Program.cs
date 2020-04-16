using System;
using CoreEscuela.Entidades;

namespace Etapa1
{
    class Program
    {
        static void Main(string[] args)
        {
            var escuela = new Escuela("Platzi Academy", 2012, TiposEscuela.PreEscolar,
            pais:"Colombia", ciudad:"Bogotá");            
            var curso1 = new Curso();
            {
                curso1.Nombre="101";

            }
            Console.WriteLine(escuela);
        }
    }
}
