using System;
using static System.Console;
namespace CoreEscuela.Util
{
    // Con static no se pueden crear nuevas instancias
    public static class Printer
    {
        public static void DibujarLinea(int tam = 10)
        {
            var linea  = "".PadLeft(tam, '=');
            WriteLine(linea);
        }
        public static void WriteTitle(string titulo)
        {
            DibujarLinea();
            WriteLine(titulo);
            DibujarLinea();
        }

        public static void Beep(int hrz= 2000, int tiempo= 500, int cantidad=1)
        {
            while (cantidad-- > 0)
            {                
                Console.Beep(hrz, tiempo);
            }
        }
    }
}
