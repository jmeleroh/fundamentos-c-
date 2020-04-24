using System;
using System.Collections.Generic;
using System.Linq;
using CoreEscuela.Entidades;

namespace CoreEscuela
{
    public class EscuelaEngine
    {
        public Escuela Escuela { get; set; }

        public EscuelaEngine()
        {

        }

        public void Inicializar()
        {
            Escuela = new Escuela("Platzi Academy", 2012, TiposEscuela.PreEscolar,
                pais: "Colombia", ciudad: "Bogotá");
            CargarCursos();
          /*  foreach (var curso in Escuela.Cursos)
            {
                curso.Alumnos.AddRange(CargarAlumnos());
            }
            var listaA = CargarAlumnos();*/
            CargarAsignaturas();
            CargarEvaluaciones();


        }

        private void CargarEvaluaciones()
        {
            throw new NotImplementedException();
        }

        private void CargarAsignaturas()
        {
            foreach (var curso in Escuela.Cursos)
            {
                List<Asignatura> listaAsignaturas = new List<Asignatura>(){
                    new Asignatura{ Nombre ="Matemáticas"},
                    new Asignatura{ Nombre ="Educación Física"},
                    new Asignatura{ Nombre ="Castellano"},
                    new Asignatura{ Nombre ="Ciencias Naturales"}
                };
                curso.Asignaturas = listaAsignaturas;
            }
        }

        private List<Alumno> GenerarAlumnosAlAzar(int cantidad)
        {
            string[] nombre1 = { "Alba", "Felipa", "Eusebio", "Farid", "Donald", "Álvaro", "Nicloás" };
            string[] apellido1 = { "Ruiz", "Sarmiento", "Uribe", "Maduro", "Trump", "Toledo", "Herrera" };
            string[] nombre2 = { "Freddy", "Anabel", "Rick", "Murty", "Silvana", "Diomedes", "Nicomedes", "Teodoro" };

            var listaAlumnos = from n1 in nombre1
                                from n2 in nombre2
                                from a1 in apellido1
                                select new Alumno{ Nombre = $"{n1} {n2} {a1}"};

            return listaAlumnos.OrderBy( (al)=> al.UniqueId  ).Take(cantidad).ToList();
            
        }

        private void CargarCursos()
        {
            // Colecciones
            Escuela.Cursos = new List<Curso>(){
                new Curso(){ Nombre = "101", Jornada= TiposJornada.Mañana},
                new Curso(){ Nombre = "201", Jornada= TiposJornada.Mañana},
                new Curso{ Nombre = "301", Jornada= TiposJornada.Mañana},
                new Curso{ Nombre = "401", Jornada= TiposJornada.Mañana},
                new Curso{ Nombre = "501", Jornada= TiposJornada.Mañana}
            };
            Random rnd = new Random();
            
            foreach (var curso in Escuela.Cursos)
            {                
                int cantidadRandom = rnd.Next(5,20);
                curso.Alumnos = GenerarAlumnosAlAzar(cantidadRandom);
            }
        }
        /*Escuela.Cursos.Add(new Curso{ Nombre = "301", Jornada= TiposJornada.Mañana});
        ListaCursos.Add(new Curso{ Nombre = "501", Jornada= TiposJornada.Mañana});

        var ListaCursos2 = new List<Curso>(){
            new Curso(){ Nombre = "401"},
            new Curso(){ Nombre = "501"},
        };

        // Addrange añade nuevos elementos a una la lista de otra lista
        //ListaCursos.AddRange(ListaCursos2);

        Escuela.Cursos = ListaCursos;

        // También podemos hacerlo directamente sin listas

        Escuela.Cursos = new List<Curso>(){
             new Curso() { Nombre="101", Jornada= TiposJornada.Mañana}
         };

         // Quitar valores

         //ListaCursos.Clear();            
        ListaCursos.RemoveAll(Predicado);

        static bool Predicado(Curso curobj)
        {
        return curobj.Nombre=="301";
        }

         //Delegado
        ListaCursos.RemoveAll(delegate(Curso cur){
              return cur.Nombre == "301";
         });

        // Lambda 
        ListaCursos.RemoveAll((Curso cur) => cur.Nombre == "301" && cur.Jornada == TiposJornada.Mañana);


         Escuela.Cursos.Add(new Curso { Nombre="201", Jornada= TiposJornada.Mañana});
         Escuela.Cursos.AddRange(ListaCursos);
         */

    }


}
