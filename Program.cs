using System;
using System.Collections.Generic;
using coreEscuela.Entidades;
using coreEscuela.Util;
using static System.Console;
namespace coreEscuela
{
    
    class Program
    {
        static void Main(string[] args)
        {
            var engine = new EscuelaEngine();
            engine.Inicializar();
            //Experesión lambda
            //escuela.Cursos.RemoveAll((cur) => cur.Nombre == "301" && cur.Jornada == TiposJornada.Mañana );
            Printer.DibujarTitulo("Bienvenidos a la escuela");
            ImprimirCursosEscuela(engine.Escuela);
            

        }


        private static void ImprimirCursosEscuela(Escuela escuela)
        {
            Printer.DibujarTitulo("Cursos de la escuela");

            if(escuela?.Cursos != null) //Con el signo de interrogación en "escuela" obligamos al codigo a verificar primero la escuela antes de ver los cursos, aplica solo si es null
            {
                foreach (var curso in escuela.Cursos)
                {
                WriteLine($"Nombre {curso.Nombre}, Id {curso.UniqueId}");
                }
            }
                
        }

        private static void ImprimirCursoswhile(Curso[] arregloCursos)
        {
            int contador = 0;
            while (contador < arregloCursos.Length){
                Console.WriteLine($"Nombre {arregloCursos[contador].Nombre}, Id {arregloCursos[contador].UniqueId}");
                contador++;

            }
        }
        private static void ImprimirCursosDowhile(Curso[] arregloCursos)
        {
            int contador = 0;
            do{
                Console.WriteLine($"Nombre {arregloCursos[contador].Nombre}, Id {arregloCursos[contador].UniqueId}");
                contador++;

            }while (contador < arregloCursos.Length);
        }

        private static void ImprimirCursosFor(Curso[] arregloCursos)
        {
            for (int i = 0; i < arregloCursos.Length; i++){
                Console.WriteLine($"Nombre {arregloCursos[i].Nombre}, Id {arregloCursos[i].UniqueId}");   
            }
             
        }

        private static void ImprimirCursosForEach(Curso[] arregloCursos)
        {
            foreach (var curso in arregloCursos){
                Console.WriteLine($"Nombre {curso.Nombre}, Id {curso.UniqueId}");
            } 
        }
    }
}
