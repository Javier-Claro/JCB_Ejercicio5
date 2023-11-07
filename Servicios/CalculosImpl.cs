using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5_JCB.Servicios
{
    internal class CalculosImpl : CalculosIntf
    {
            public bool bisiesto(int anyo)
            {

            bool bisiesto = true;

            //Si se divide por 4, pasará mirar si es divisible por 100. Y si no es divisible (100), mirará por 400: 
            if ((anyo % 4) != 0)
            {
                bisiesto = false;
            }        
            else if (anyo % 100 == 0) 
            {
                bisiesto = false;
            }
            else if ((anyo % 400) == 0)
            {
                bisiesto = true;
            }
                return bisiesto;
            }
    }
}