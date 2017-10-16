using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosasDeArreglos
{
    public class Tools
    {
        public int Consecutivo (IEnumerable<IEnumerable<int>> array,int posicion)
        {
            int consecutivo = 0;
            if (array != null && array.Count() > 0)
            {
                var valores = array.ToArray()[posicion];
                consecutivo = valores.Count() + 1;
            }
            return consecutivo;
        }

        public int TamanoArreglo(IEnumerable<IEnumerable<int>> array)
        {
            int tamano = 0;
            if (array != null && array.Count() > 0)
            {
                tamano =  array.Count();
            }
            return tamano;
        }
    }
}
