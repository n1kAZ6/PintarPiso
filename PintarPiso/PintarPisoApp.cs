// Alumno:

using System;
using System.Collections.Generic;

namespace PintarPiso
{
	public class PintarPisoApp
	{
		static void Main(string[] args)
		{

            //new ¿? ("Salón", 20.5, 2, 3);
            //new ¿? ("Dormi1",15,1,1,2);
            //new ¿? ("Terraza1", 4.0,1,1,3,10);

            CatalogoPinturas.ListaPintura.Add(new Pintura("Blanco", 4.5));
            CatalogoPinturas.ListaPintura.Add(new Pintura("Verde", 3.8));
            CatalogoPinturas.ListaPintura.Add(new Pintura("Salmón", 8.5));
            CatalogoPinturas.ListaPintura.Add(new Pintura("Beige", 7.2));
            CatalogoPinturas.ListaPintura.Add(new Pintura("Amarillo", 6.2));

            int opcion;

            do
            {
                opcion = Util.Menu();
                Console.Clear();
                switch (opcion)
                {
                    case 1: // Mostrar las pinturas
                        CatalogoPinturas.Mostrar();
                        break;
                    case 2: // Mostrar los recintos y sus precios

                        break;
                    case 3: // Añadir Recinto

                        break;
                    case 4: // Eliminar Recinto

                        break;
                }

                // falta aquí algo
                if (opcion != 0)
                {
                    Console.WriteLine("\n\n\n\nPulsa una tecla para volver al Menú");
                    Console.ReadKey();
                }

            } while (opcion != 0);
		}
	}
}
