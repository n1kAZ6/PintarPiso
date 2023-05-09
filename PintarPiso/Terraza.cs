
using System;

namespace PintarPiso
{
    class Terraza : Habitacion
    {
        //Atributos
        double mPretil;

        //Constructor
        public Terraza(string nombre, double mPared, int numPuertas, int numVentanas, int tipoPintura, double mPretil) : base(nombre, mPared, numPuertas, numVentanas, tipoPintura)
        {
            this.mPretil = mPretil;
        }
        public Terraza(string nombre, double mPared, int numPuertas, int numVentanas, double mPretil) : base(nombre, mPared, numPuertas, numVentanas)
        {
            this.mPretil = mPretil;
        }

        //Propiedades básicas
        public double MPretil { get => mPretil;}

        //Propiedad especial
        public override double SuperficiePintar => base.SuperficiePintar + mPretil * 1.5;

        //Métodos
        public override double MostrarPrecioPintura()
        {
            Pintura pintura = CatalogoPinturas.ListaPintura[TipoPintura];
            double precio = SuperficiePintar * pintura.PrecioM2;
            Console.WriteLine("   {0}{1}\t{2}\t{3}\t{4}\t{5}\t{6}\t  {7}", Util.CuadraTexto(Nombre,11)
                                                                         , Util.CuadraTexto(MPared.ToString(),9)
                                                                         , NumPuertas
                                                                         , NumVentanas
                                                                         , pintura.NombreColor
                                                                         , pintura.PrecioM2
                                                                         , mPretil
                                                                         , precio);
            return precio;
        }
    }
}
