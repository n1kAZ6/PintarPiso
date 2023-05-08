using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PintarPiso
{
    class CatalogoPinturas
    {
        //Atributos
        static List<Pintura>listaPintura = new List<Pintura>();

        //Propiedad básica lectura
        public static List<Pintura> ListaPintura { get => listaPintura; }

        public static void Mostrar()   //<-- falta algo
        {
            Console.WriteLine("\n--------- PRESENTACION LISTA DE PINTURAS ----------\n");
            Console.WriteLine("\tid\tColor\tprecioM2");
            Console.WriteLine("\t--\t-----\t--------");

            for (int i=0;i<listaPintura.Count;i++)             
                Console.WriteLine("\t{0}\t{1} {2}", i, Util.CuadraTexto(listaPintura[i].NombreColor,8), listaPintura[i].PrecioM2);
            
        }
    }
}
