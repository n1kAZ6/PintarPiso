
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
    }
}
