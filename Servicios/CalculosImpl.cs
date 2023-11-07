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

            //Si se divide por 4, pasará a mirar si es divisible por 100. Y si es divisible (x100), mirará tambien por 400: 
            if ((anyo % 4) != 0)            
                bisiesto = false;
                    
            else if (anyo % 100 == 0) 
            {
                if ((anyo % 400) == 0)                
                    bisiesto = true;
                
                else
                    bisiesto = false;
            }           
                return bisiesto;
            }
    }
}