using System;
using System.Collections.Generic;

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
        public string Direccion { get => direccion;}
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
            //...
            foreach (Habitacion h in listaHabitaciones)
            {
                suma += h.MostrarPrecioPintura();
            }
            // Pie
            Console.WriteLine("                                                                  ------");
            Console.WriteLine("                                             TOTAL Euros Pintura: {0}", suma);

        }

    }
}
