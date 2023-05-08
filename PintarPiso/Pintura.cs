using System;

namespace PintarPiso
{
	public class Pintura
	{
        //Atributos
        string nombreColor;
        double precioM2;

        //Constructor
        public Pintura(string nombreColor, double precioM2)
        {
            this.nombreColor = nombreColor;
            this.precioM2 = precioM2;
        }

        //Propiedades
        public string NombreColor { get => nombreColor; }
        public double PrecioM2 { get => precioM2; }

        //Métodos
        public string Mostrar() => String.Format("\t{0}{1}", Util.CuadraTexto(nombreColor, 10), precioM2);

    }
}
