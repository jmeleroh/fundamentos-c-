using System.Collections.Generic;
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

             // Colecciones

            Escuela.Cursos = new List<Curso>(){
                new Curso(){ Nombre = "101", Jornada= TiposJornada.Mañana},
                new Curso(){ Nombre = "201", Jornada= TiposJornada.Mañana},
                new Curso{ Nombre = "301", Jornada= TiposJornada.Mañana},
                new Curso{ Nombre = "401", Jornada= TiposJornada.Mañana},
                new Curso{ Nombre = "501", Jornada= TiposJornada.Mañana}
            };

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
}