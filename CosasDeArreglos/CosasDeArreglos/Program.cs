using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosasDeArreglos
{
    class Program
    {
        static void Main(string[] args)
        {
            Tools tools = new Tools();

            Console.WriteLine("Consecutivo de un array");


            #region Ejemplo 1
            Console.WriteLine("Ejemplo 1");
            List<List<int>> arreglo = new List<List<int>>();
            List<int> itema1 = new List<int>();
            itema1.Add(1);
            itema1.Add(2);

            List<int> itema2 = new List<int>();
            itema2.Add(1);

            List<int> itema3 = new List<int>();
            itema3.Add(1);
            itema3.Add(2);
            itema3.Add(3);
            itema3.Add(4);
            itema3.Add(5);

            List<int> itema4 = new List<int>();
            itema4.Add(1);
            itema4.Add(2);
            itema4.Add(3);
            itema4.Add(4);
            itema4.Add(5);
            itema4.Add(6);

            List<int> itema5 = new List<int>();
            itema5.Add(1);
            itema5.Add(2);
            itema5.Add(3);
            itema5.Add(4);
            itema5.Add(5);
            itema5.Add(6);

            arreglo.Add(itema1);
            arreglo.Add(itema2);
            arreglo.Add(itema3);
            arreglo.Add(itema4);
            arreglo.Add(itema5);

            //Consecutivo del arreglo

            Console.WriteLine("El consecutivo de mi primer arreglo en la posicion 3 es " + tools.Consecutivo(arreglo,2));
            Console.WriteLine("-------------------------------");
            Console.WriteLine("");
            Console.WriteLine("");
            #endregion


            #region Ejemplo 2
            List<List<int>> arreglo2 = new List<List<int>>();
            List<int> itemb1 = new List<int>();
            itemb1.Add(1);
            itemb1.Add(2);
            itemb1.Add(3);
            itemb1.Add(4);

            List<int> itemb2 = new List<int>();
            itemb2.Add(1);
            itemb2.Add(2);

            List<int> itemb3 = new List<int>();
            itemb3.Add(1);

            List<int> itemb4 = new List<int>();
            itemb4.Add(1);
            itemb4.Add(2);
            itemb4.Add(3);

            List<int> itemb5 = new List<int>();
            itemb5.Add(1);
            itemb5.Add(2);
            itemb5.Add(3);
            itemb5.Add(4);
            itemb5.Add(5);

            List<int> itemb6 = new List<int>();
            itemb6.Add(2);
            itemb6.Add(1);
            itemb6.Add(3);
            itemb6.Add(4);
            itemb6.Add(5);

            arreglo2.Add(itema1);
            arreglo2.Add(itema2);
            arreglo2.Add(itema3);
            arreglo2.Add(itema4);
            arreglo2.Add(itema5);
            arreglo2.Add(itemb6);


            Console.WriteLine("Ejemplo 2");
            Console.WriteLine("Tamaño del arreglo2 es " + tools.TamanoArreglo(arreglo2));
            Console.WriteLine("-------------------------------");
            Console.WriteLine("");
            Console.WriteLine("");
            #endregion

            #region Ejemplo 3
            List<List<int>> arreglo3 = new List<List<int>>();
            Console.WriteLine("Cuando el arreglo no tiene nada");
            Console.WriteLine("El tamaño del arreglo3 es: " + tools.TamanoArreglo(arreglo3));
            Console.WriteLine("-------------------------------");
            Console.WriteLine("");
            Console.WriteLine("");
            #endregion



            Console.ReadKey();
        }
    }
}
