// Alumno:

using System;
using System.Collections.Generic;

namespace PintarPiso
{
	public class PintarPisoApp
	{
		static void Main(string[] args)
		{

            Piso apartamento = new Piso("Bellavista, 9 9ºB");

            Habitacion h1 = new Habitacion ("Salón", 20.5, 2, 3);
            Habitacion h2 = new Habitacion ("Dormi1",15,1,1,2);
            Terraza t1 = new Terraza ("Terraza1", 4.0,1,1,3,10);

            apartamento.AñadirHabitacion(h1);
            apartamento.AñadirHabitacion(h2);
            apartamento.AñadirHabitacion(t1);

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
                    case 1: 
                        CatalogoPinturas.Mostrar();
                        break;
                    case 2: 
                        apartamento.MostrarRecintos();
                        break;
                    case 3: 
                        apartamento.AñadirRecinto();
                        break;
                    case 4: 
                        apartamento.EliminarRecinto();
                        break;
                }

                if (opcion != 0)                
                    Util.Pausa("volver al Menú");
 
            } while (opcion != 0);

            Util.Pausa("salir");
		}
	}
}
