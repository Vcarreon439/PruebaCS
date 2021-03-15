using System;
using System.Reflection;
using System.Diagnostics;

namespace ConsolaC_Sharp
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Este es un ejecutable que exporta funciones
            Console.WriteLine("Este es el saludo:");
            Console.WriteLine(Saludo());
            Console.WriteLine();
            Console.WriteLine("Esta es la versión: {0}", FileVersion);
            Console.WriteLine("\nPulsa Intro para terminar");
            Console.ReadLine();
        }


        // Dos métodos estáticos para mostrar el saludo
        public static string Saludo()
        {
            return "Saludo desde la librería de C# {Consola}";
        }
        public static string Saludo(string nombre)
        {
            return "Hola " + nombre + ", desde la librería de C# {Consola}";
        }

        // Propiedad de solo lectura para mostrar la versión
        // del ensamblado (la numeración de Windows)
        public static string FileVersion
        {
            get
            {
                Assembly ensamblado = Assembly.GetExecutingAssembly();
                FileVersionInfo fvi =
                FileVersionInfo.GetVersionInfo(ensamblado.Location);
                return fvi.FileVersion + "{Consola}";
            }
        }
    }
}
