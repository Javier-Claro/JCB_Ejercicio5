using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5_JCB.Servicios
{
    internal class PedidaDatosImpl : PedidaDatosIntf
    {
        public int pedirMes()
        {
            int mes;
            do { 
            Console.Write("\n\tIndique un mes del año: ");
            mes = Convert.ToInt32(Console.ReadLine());

                Console.Clear();

                //Se controla que sea un mes existente:
                if (mes < 1 || mes > 12)
                    Console.WriteLine("\n\t[info] - El mes de año indicado no existe.");

            }while (mes < 1 || mes >12);

            return mes;
        }

        public int pedirAnyo()
        {
            int anyo;
            do {
                Console.Write("\n\tIndique el año: ");
                anyo = Convert.ToInt32(Console.ReadLine());

                Console.Clear();

                //Se controla que NO sea un año negativo:
                if (anyo < 0)
                {
                    Console.WriteLine("\n\t[info] - Un año nunca puede ser negativo.");
                }
                
            } while (anyo < 0);

            return anyo;
        }
    }
}
