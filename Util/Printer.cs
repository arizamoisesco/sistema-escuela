using static System.Console;

namespace coreEscuela.Util
{
    public class Printer
    {
        public static void  DibujarLinea(int tam = 10){
            //Usar comilllas simples representa un solo caracter
            var linea = "".PadRight(tam,'=');
            WriteLine(linea);
        }

        public static void  DibujarTitulo(string titulo){
            DibujarLinea(titulo.Length + 4);
            WriteLine($"| {titulo} |");
            DibujarLinea(titulo.Length + 4);
        }
    }
}