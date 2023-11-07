using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5_JCB.Servicios
{
    internal interface CalculosIntf
    {
        /// <summary>
        /// Metodo que calcula si es año seleccionado es bisiesto o no:
        /// </summary>
        /// JCb - 071123
        /// <param name="anyo"></param>
        /// <returns></returns>
        public bool bisiesto(int anyo);
    }
}
