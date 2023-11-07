using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5_JCB.Servicios
{
    internal interface PedidaDatosIntf
    {
        /// <summary>
        /// Metodo que pedira el mes a calcular sus días:
        /// </summary>
        /// JCb - 071123
        /// <returns>Mes del año</returns>
        public int pedirMes();

        /// <summary>
        /// Metodo que pedira el año a mirar:
        /// </summary>
        /// JCb - 071123
        /// <returns>El año a mirar el mes</returns>
        public int pedirAnyo();
    }
}
