using System;
using System.Collections.Generic;
using CoreEscuela.Entidades;
using static System.Console;

namespace Etapa1
{
    class Program
    {
        static void Main(string[] args)
        {
            var escuela = new Escuela("Platzi Academy", 2012, TiposEscuela.PreEscolar,
            pais: "Colombia", ciudad: "Bogotá");
            var curso1 = new Curso()
            {
                Nombre = "101"
            };
            var curso2 = new Curso()
            {
                Nombre = "201"
            };
            var curso3 = new Curso()
            {
                Nombre = "301"
            };

            // Arreglos

            var arregloCursos = new Curso[3];
            arregloCursos[0] = new Curso()
            {
                Nombre = "101"
            };
            arregloCursos[1] = curso2;

            arregloCursos[2] = new Curso
            {
                Nombre = "301"
            };

            var arregloCursos2 = new Curso[3]{
                new Curso()
                {
                    Nombre = "101"
                },
                new Curso()
                {
                    Nombre = "201"
                },
                new Curso()
                {
                    Nombre = "301"
                }
            };

            Curso[] arregloCursos3 =  {
                new Curso(){ Nombre = "101"},
                new Curso(){ Nombre = "201"},
                new Curso(){ Nombre = "301"}
            };

            // Colecciones

            var ListaCursos = new List<Curso>();

            escuela.Cursos = arregloCursos3;

            System.Console.WriteLine("Presione enter para continuar");
            Console.ReadLine();
            ImprimirCursos(arregloCursos);
            ImprimirCursosforeach(arregloCursos);
            ImprimirCursosEscuela(escuela);

            /*Console.WriteLine(escuela);
            System.Console.WriteLine("==========");
            System.Console.WriteLine(curso1.Nombre + "," + curso1.UniqueId);
            System.Console.WriteLine($"{curso2.Nombre}, {curso2.UniqueId}");
            System.Console.WriteLine($"{curso3.Nombre}, {curso3.UniqueId}");*/
        }

        private static void ImprimirCursosEscuela(Escuela escuela)
        {
            System.Console.WriteLine("============");
            System.Console.WriteLine("Cursos de la Escuela");
            System.Console.WriteLine("============");
            // escuela?.Cursos verifica si escuela es null, si es null no continua
            if(escuela?.Cursos == null){
                return;
            }
            else{
            foreach (var curso in escuela.Cursos)
            {
            // Al usar using static System no hace falta System.Console
               WriteLine($"Nombre: {escuela.Nombre}");
            }
            }
        }

        private static void ImprimirCursos(Curso[] arregloCursos)
        {
            int cont = 0;
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
            int i = 0;
            do
            {
                System.Console.WriteLine(arregloCursos[i].Nombre);
                i++;
            } while (i < arregloCursos.Length);
        }
        private static void ImprimirCursosforeach(Curso[] arregloCursos)
        {
            foreach (var curso in arregloCursos)
            {
                System.Console.WriteLine(curso.UniqueId);
            }
        }

    }
}
