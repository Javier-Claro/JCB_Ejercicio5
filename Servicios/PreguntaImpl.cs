using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5_JCB.Servicios
{
    internal class PreguntaImpl : PreguntaIntf
    {
        public bool preguntarSeguir()
        {
            bool seguir;
            string letra;
            do
            {
                Console.Write("\n\n\t¿Desea seguir con los cálculos? ('s' = si    'n' = no): ");
                letra = Convert.ToString(Console.ReadLine());

                Console.Clear();

                //Se controla que la opción exista y no sea algo aleatorio:
                if (letra != "s" && letra != "n")
                {
                    Console.WriteLine("\n\t[info] - La opcion escrita lo existe.");
                }

                if (letra == "s")
                    seguir = true;
                else
                    seguir = false;

            } while (letra != "s" && letra != "n");

            return seguir;
        }
    }
}
