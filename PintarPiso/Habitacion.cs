using System;

namespace PintarPiso
{
	public class Habitacion
	{
        //Atributos
        string nombre;  // Nombre de la habitación
        double mPared;  // metros de pared de la habitación
        int numPuertas; // Número de puertas de 2 x 0.80 m2
        int numVentanas;// Número de ventanas de 1x1 m2
        int tipoPintura;// id del tipo de pintura en el catálogo [0..4]

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

        //Métodos
        public virtual double MostrarPrecioPintura()
        {

            Pintura pintura = CatalogoPinturas.ListaPintura[tipoPintura];
            double precio = SuperficiePintar * pintura.PrecioM2;
            Console.WriteLine("   {0}{1}\t{2}\t{3}\t{4}\t{5}\t\t  {6}",Util.CuadraTexto(nombre,11)
                                                                      ,Util.CuadraTexto(mPared.ToString(),9)
                                                                      ,numPuertas
                                                                      ,numVentanas
                                                                      , pintura.NombreColor
                                                                      , pintura.PrecioM2,precio);

            return precio;
        }

    }	
}
