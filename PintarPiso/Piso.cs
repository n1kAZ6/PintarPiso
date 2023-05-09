using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;

namespace PintarPiso
{
    class Piso
    {
        //Atributos
        string direccion;
        List<Habitacion> listaHabitaciones = new List<Habitacion>();

        //Constructor
        public Piso(string direccion)
        {
            this.direccion = direccion;
        }

        //Propiedades
        public string Direccion { get => direccion; }
        public List<Habitacion> ListaHabitaciones { get => listaHabitaciones; }

        //Métodos
        public void AñadirHabitacion(Habitacion h)
        {
            listaHabitaciones.Add(h);
        }
        public void MostrarRecintos()
        {
            double suma = 0;
            // cabecera
            Console.WriteLine("\n   -- Precio de pintura del piso: {0} --\n", Direccion);
            Console.WriteLine("   Recinto    ------ PARED -------      -- PINTURA --   PRETIL    TOTAL");
            Console.WriteLine("   Nombre     metros   nºP     nºV      Color  Precio   metros    Precio");
            Console.WriteLine("   -------    ------   ---     ---      -----  ------   ------    ------");

            foreach (Habitacion h in listaHabitaciones)
                suma += h.MostrarPrecioPintura();

            // Pie
            Console.WriteLine("                                                                  ------");
            Console.WriteLine("                                             TOTAL Euros Pintura: {0}", Math.Round(suma, 2));

        }
        public void AñadirRecinto()
        {
            Console.WriteLine("\n   -- Añadir nuevo recinto en el piso: {0} --\n", Direccion);

            string nombre;
            double mPared, mPretil;
            int numPuertas, numVentanas, tipoPintura;

            Console.Write("\n\tNombre del nuevo recinto?: ");
            nombre = Console.ReadLine();

            foreach (Habitacion h in listaHabitaciones)
            {
                while (h.Nombre == nombre) 
                {
                    Console.WriteLine("\n\tYa hay un recinto con el mismo nombre y no puede haber dos recintos iguales");
                    Console.Write("\n\tIntroduce otro nombre distinto para el nuevo recinto: ");
                    nombre = Console.ReadLine();
                }
            }

            mPared = Util.CapturaDouble("Metros de la pared? ", 3, 300);
            numPuertas = Util.CapturaEntero("Número de puertas? ", 1, 10);
            numVentanas = Util.CapturaEntero("Número de ventanas? ", 1, 5);
            CatalogoPinturas.Mostrar();
            tipoPintura = Util.CapturaEntero("Que tipo de pintura desea? ", 0, CatalogoPinturas.ListaPintura.Count - 1);

            if (Util.PreguntaSiNo("\n\tEs una terraza lo que quiere añadir  (S=si / N=no)"))
            {
                mPretil = Util.CapturaDouble("Metros del pretil?", 1, 5);
                AñadirHabitacion(new Terraza(nombre, mPared, numPuertas, numVentanas, tipoPintura, mPretil));
                Console.WriteLine("\n\n\tTerraza creada correctamente!");

            }
            else 
            {
                AñadirHabitacion(new Habitacion(nombre, mPared, numPuertas, numVentanas, tipoPintura));
                Console.WriteLine("\n\tHabitación creada correctamente!");
            }

        }
        public void EliminarRecinto()
        {
            Console.Write("\n\tNombre del recinto a eliminar?: ");
            string nombre = Console.ReadLine();
            bool seHaEliminado=false;

            for (int i=0;i<listaHabitaciones.Count;i++)
            {
                if (listaHabitaciones[i].Nombre == nombre)
                {
                    listaHabitaciones.Remove(listaHabitaciones[i]);
                    Console.WriteLine("\n\n\tRecinto con nombre {0} eliminado correctamente!",nombre);
                    seHaEliminado = true;
                }
                
            }

            if(!seHaEliminado)
                Console.WriteLine("\n\n\tEn el piso de {1} no se encuentra un recinto con nombre {0}!",nombre,direccion);

        }

    }
}
