using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5_JCB.Servicios
{
    internal interface PreguntaIntf
    {
        /// <summary>
        /// Metodo que preguntará al usuario si quiere seguir o no:
        /// </summary>
        /// JCb - 071123
        /// <returns>La respuesta sobre si seguir preguntando o parar</returns>
        public bool preguntarSeguir();
    }
}
