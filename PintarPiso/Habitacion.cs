using System;

namespace PintarPiso
{
	public class Habitacion
	{
        //Atributos
        string nombre;  // Nombre de la habitaci�n
        double mPared;  // metros de pared de la habitaci�n
        int numPuertas; // N�mero de puertas de 2 x 0.80 m2
        int numVentanas;// N�mero de ventanas de 1x1 m2
        int tipoPintura;// id del tipo de pintura en el cat�logo [0..4]

        //Constructor
        public Habitacion(string nombre, double mPared, int numPuertas, int numVentanas, int tipoPintura)
        {
            this.nombre = nombre;
            this.mPared = mPared;
            this.numPuertas = numPuertas;
            this.numVentanas = numVentanas;
            this.tipoPintura = tipoPintura;
        }

        public Habitacion(string nombre, double mPared, int numPuertas, int numVentanas)
        {
            this.nombre = nombre;
            this.mPared = mPared;
            this.numPuertas = numPuertas;
            this.numVentanas = numVentanas;
            tipoPintura = 0;
        }

        //Propiedades
        public string Nombre { get => nombre;}
        public double MPared { get => mPared; }
        public int NumPuertas { get => numPuertas;}
        public int NumVentanas { get => numVentanas; }
        public int TipoPintura { get => tipoPintura; }

        //Propiedad especial
        public virtual double SuperficiePintar
        {
            get => mPared * 2.5 - numPuertas * 1.6 - numVentanas;
        }

        //M�todos
        public virtual double MostrarPrecioPintura()
        {

            Pintura pintura = CatalogoPinturas.ListaPintura[tipoPintura];

            Console.WriteLine("   {0}{1}\t{2}\t{3}\t{4}\t{5}\t\t  {6}",nombre,mPared,numPuertas,numPuertas,numVentanas, pintura.Mostrar());

            return SuperficiePintar * pintura.PrecioM2;
        }

    }	
}
