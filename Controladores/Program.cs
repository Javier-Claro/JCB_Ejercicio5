using Ejercicio5_JCB.Servicios;
using System;

namespace Ejercicio5_JCB.Controladores
{
    class Program
    {
        /// <summary>
        /// Metodo principal por el que empieza el programa
        /// </summary>
        /// JCb - 071123
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            PedidaDatosIntf datos = new PedidaDatosImpl();
            CalculosIntf calc = new CalculosImpl();
            PreguntaIntf continuar = new PreguntaImpl();

            int anyo, mes;
            bool bisiesto, seguir;

            do
            {
                mes = datos.pedirMes();
                anyo = datos.pedirAnyo();               

                //Varios resultados dentro de un mismo case, ya que varios meses tiene los mismos días:
                switch (mes)
                {
                    case (1 or 3 or 5 or 7 or 8 or 10 or 12):

                        Console.WriteLine("\n\n\t\t\t\t\t[info] - Dias del mes indicado: 31");
                        break;

                    case (4 or 6 or 9 or 11):

                        Console.WriteLine("\n\n\t\t\t\t\t[info] - Dias del mes indicado: 30");
                        break;

                    case 2:

                        bisiesto = calc.bisiesto(anyo);

                        if (bisiesto == true)
                        {
                            Console.WriteLine("\n\n\t\t\t\t\t[info] - Dias del mes indicado: 29");
                        }
                        else
                        {
                            Console.WriteLine("\n\n\t\t\t\t\t[info] - Dias del mes indicado: 28");
                        }
                        break;
                }
                seguir = continuar.preguntarSeguir();

            } while (seguir == true);

            Console.WriteLine("\n\n\t\t\t\t\t[info] - Muchas gracias, tenga buen día.");
        }
    }
}