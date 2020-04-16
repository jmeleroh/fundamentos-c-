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
            var curso1 = new Curso(){
                Nombre="101"
            };
            var curso2 = new Curso(){
                Nombre="201"
            };
            var curso3 = new Curso(){
                Nombre="301"
            };            

            // Arreglos
            var arregloCursos = new Curso[3];
            arregloCursos[0] = new Curso(){
                Nombre = "101"
            };
            arregloCursos[1] = curso2;
            
            arregloCursos[2] = new Curso{
                Nombre = "301"
            };
            System.Console.WriteLine("Presione enter para continuar");
            Console.ReadLine();
            ImprimirCursos(arregloCursos);
            ImprimirCursosforeach(arregloCursos);
           
            /*Console.WriteLine(escuela);
            System.Console.WriteLine("==========");
            System.Console.WriteLine(curso1.Nombre + "," + curso1.UniqueId);
            System.Console.WriteLine($"{curso2.Nombre}, {curso2.UniqueId}");
            System.Console.WriteLine($"{curso3.Nombre}, {curso3.UniqueId}");*/
        }

        private static void ImprimirCursos(Curso[] arregloCursos)
        {
            int cont=0;
            while (cont < arregloCursos.Length)
            {
                System.Console.WriteLine(arregloCursos[cont].Nombre);
                cont++;
            }
        }
        private static void ImprimirCursosFor(Curso[] arregloCursos)
        {
           for (int i = 0; i < arregloCursos.Length; i++)
            {
                System.Console.WriteLine(arregloCursos[i].Nombre);
            }
        }
        private static void ImprimirCursosDoWhile(Curso[] arregloCursos)
        {
            int i=0;
           do
           {
               System.Console.WriteLine(arregloCursos[i].Nombre);
               i++;
           } while (i< arregloCursos.Length);
        }
        private static void ImprimirCursosforeach(Curso[] arregloCursos)
        {
            foreach (var nombre in arregloCursos)
            {
                System.Console.WriteLine(nombre.UniqueId);
            }
        }
    }
}
