using System;
using System.Collections.Generic;
using System.Linq;
using coreEscuela.Entidades;

namespace coreEscuela
{
    public class EscuelaEngine
    {
        

        public EscuelaEngine(Escuela escuela) 
        {
            this.Escuela = escuela;
               
        }
                public Escuela Escuela { get; set; }

        //Constructor de Escuela.Engine
        public EscuelaEngine(){
            //Inicializamos Escuela
           
        }

        public void Inicializar()
        {
            Escuela = new Escuela("Platzi Academy", 2012, TiposEscuela.Primaria,
                                pais: "Colombia", ciudad: "Bogota");

            CargarCursos();
            CargarAsiganturas();
            CargarEvaluaciones();
        }

        private void CargarEvaluaciones(){

            

            foreach (var curso in Escuela.Cursos)
            {
                foreach (var alumno in curso.Alumno)
                {
                    foreach (var asignatura in curso.Asignaturas)
                    {
                        var notas = new Random();
                        for (int i = 0; i < 5; i++)
                        {
                            var eva = new Evaluacion{
                                Asignatura = asignatura,
                                Nombre = $"{asignatura.Nombre} Ev#{i + 1}",
                                Nota = (float)(5 * notas.NextDouble()),
                                Alumno = alumno
                            };
                            alumno.Evaluaciones.Add(eva);
                        }
                        
                        
                    }
                }
            }
            
        }

        private void CargarAsiganturas(){
            foreach (var curso in Escuela.Cursos)
            {
                List<Asignatura> listaAsignaturas = new List<Asignatura>(){
                    new Asignatura{Nombre = "Matemáticas"},
                    new Asignatura{Nombre = "Educación Fisica"},
                    new Asignatura{Nombre = "Castellano"},
                    new Asignatura{Nombre = "Ciencias Naturales"},
                };
                curso.Asignaturas = listaAsignaturas;
                
            };
        }

        private List<Alumno> GenerarAlumnosAzar(int Cantidad){
        // Definimos los arreglos que van a almacenar los alumnos
            string[] nombre1 = { "Alba", "Felipa", "Eusebio", "Farid", "Donald", "Alvaro", "Nicolás" };
            string[] apellido1 = { "Ruiz", "Sarmiento", "Uribe", "Maduro", "Trump", "Toledo", "Herrera" };
            string[] nombre2 = { "Freddy", "Anabel", "Rick", "Morty", "Silvana", "Diomedes", "Nicomedes", "Teodoro" };

            var listaAlumnos = from n1 in nombre1
                               from n2 in nombre2
                               from a1 in apellido1
                               select new Alumno{Nombre=$"{n1} {n2} {a1}"};
            return listaAlumnos.OrderBy((alumno) => alumno.UniqueId ).Take(Cantidad).ToList();
        }

        private void CargarCursos(){
            Escuela.Cursos = new List<Curso>(){
                new Curso{Nombre = "101", Jornada = TiposJornada.Mañana},
                new Curso{Nombre = "201", Jornada = TiposJornada.Mañana},
                new Curso{Nombre = "301", Jornada = TiposJornada.Mañana},
                new Curso{Nombre = "401", Jornada = TiposJornada.Mañana},
                new Curso{Nombre = "501", Jornada = TiposJornada.Mañana}
            };

            Random NumerosAleatorio = new Random();
            foreach (var curso in Escuela.Cursos)
            {
                int cantidadRandom = NumerosAleatorio.Next(5, 20);

                curso.Alumno = GenerarAlumnosAzar(cantidadRandom);
            }
        }
    }
}