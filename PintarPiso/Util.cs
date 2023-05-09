using System;
using System.Collections.Generic;

namespace PintarPiso
{
	public class Util  
	{
        public static int Menu()
        {
            int opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("\n\n\n\n\t\t\tAlumno: Nicolás Álvarez Zapata");
                Console.WriteLine("\t\t\t╔══════════════════════════════╗");
                Console.WriteLine("\t\t\t║             MENU             ║");
                Console.WriteLine("\t\t\t╠══════════════════════════════╣");
                Console.WriteLine("\t\t\t║                              ║");
                Console.WriteLine("\t\t\t║    1.- Lista de pinturas     ║");
                Console.WriteLine("\t\t\t║    2.- Presentar Precios     ║");
                Console.WriteLine("\t\t\t║                              ║");
                Console.WriteLine("\t\t\t║    3.- Añadir Recinto        ║");
                Console.WriteLine("\t\t\t║    4.- Eliminar Recinto      ║");
                Console.WriteLine("\t\t\t║                              ║");
                Console.WriteLine("\t\t\t║          0) Salir            ║");
                Console.WriteLine("\t\t\t║                              ║");
                Console.WriteLine("\t\t\t╚══════════════════════════════╝");
                Console.Write("\t\t\t¿Opción?");
                opcion = Console.ReadKey(true).KeyChar - '0';

                if(opcion < 0 || opcion > 4) 
                { 
                    Console.WriteLine("\n\t** Error la opcion introducida no se encuentra entre 0 y 4 **");
                    Pausa("continuar");
                }
            } while (opcion < 0 || opcion > 4);

            return opcion;
        }


        public static int CapturaEntero(string mensaje, int min, int max)
        {
            int valor = 0;
            bool esCorrecto = false;
            do
            {
                Console.Write("\n\t{0} ({1}..{2}): ", mensaje, min, max);
                esCorrecto = Int32.TryParse(Console.ReadLine(), out valor);
                if (!esCorrecto || valor < min || valor > max)
                    Console.WriteLine("\n\t** Error ** Debe ser un entero de {0} a {1}  **", min, max);
            }
            while (!esCorrecto || valor < min || valor > max);

            return valor;
        }
        public static double CapturaDouble(string mensaje, int min, int max)
        {
            double valor = 0;
            bool esCorrecto = false;
            do
            {
                Console.Write("\n\t{0} ({1}..{2}): ", mensaje, min, max);
                esCorrecto = Double.TryParse(Console.ReadLine(), out valor);
                if (!esCorrecto || valor < min || valor > max)
                    Console.WriteLine("\n\t** Error ** Debe ser un entero de {0} a {1}  **", min, max);
            }
            while (!esCorrecto || valor < min || valor > max);

            return valor;
        }
        public static string CuadraTexto(string texto, int numCaracteres)
        {
            if(texto.Length>numCaracteres)
                return texto.Substring(0, numCaracteres);

            while (texto.Length < numCaracteres)
                texto += " ";

            return texto;
        }
        public static bool PreguntaSiNo(string pregunta)
        {
            char respuesta;
            do
            {
                Console.Write("\n\t{0}?: ", pregunta);
                respuesta = Console.ReadKey().KeyChar;

                if(respuesta != 'S' && respuesta != 's' && respuesta != 'N' && respuesta != 'n')
                    Console.WriteLine("\n\n\t** Error ** Debes responder con S o N (S=si / N=no) **");

            } while (respuesta != 'S' && respuesta != 's' && respuesta != 'N' && respuesta != 'n');

            if(respuesta == 'S' || respuesta == 's')
                return true;
            else
                return false;


        }
        public static void Pausa(string mensaje)
        {
            Console.WriteLine("\n\tPulse una tecla para {0}",mensaje);
            Console.ReadKey(true);
        }
    }
}
