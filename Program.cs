using System;

namespace Diseño_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int estado;
            Fecha[] vectorFecha = new Fecha[3];

            vectorFecha[0] = new Fecha(12, 4, 2019);

            vectorFecha[1] = new Fecha(7, 5, 2019);

            vectorFecha[2] = new Fecha(23, 6, 2019);

            foreach (Fecha fecha in vectorFecha)
            {
                Console.WriteLine("\nDatos de la Fecha");

                fecha.MostrarFecha();

                estado = fecha.ValidarFecha();

                if (estado == -1)
                {
                    Console.WriteLine("El dia es incorrecto {0}", fecha.DD);
                }

                if (estado == -2)
                {
                    Console.WriteLine("El mes es incorrecto {0}", fecha.MM);
                }

                if (estado == -3)
                {
                    Console.WriteLine("El a#o es menor a cero {0}", fecha.AA);
                }

                if (estado != 0)
                {
                    Console.ReadKey();

                    return;
                }
            }

            Console.WriteLine("\nCompara los tres atributos de la primera fecha y los tres atributos de segunda fecha enviados como parametros");
            estado = vectorFecha[0].CompararFecha(vectorFecha[1].DD, vectorFecha[1].MM, vectorFecha[1].AA);

            if (estado == 1)
            {
                Console.WriteLine("La primera {0}/{1}/{2} es mayor a la segunda {3}/{4}/{5}", vectorFecha[0].DD, vectorFecha[0].MM, vectorFecha[0].AA, vectorFecha[1].DD, vectorFecha[1].MM, vectorFecha[1].AA);
            }
            else
            {
                if (estado == -1)
                {
                    Console.WriteLine("La segunda {0}/{1}/{2} es mayor a la primera {3}/{4}/{5}", vectorFecha[1].DD, vectorFecha[1].MM, vectorFecha[1].AA, vectorFecha[0].DD, vectorFecha[0].MM, vectorFecha[0].AA);
                }
                else
                {
                    Console.WriteLine("La primera {0}/{1}/{2} es igual a la segunda {3}/{4}/{5}", vectorFecha[0].DD, vectorFecha[0].MM, vectorFecha[0].AA, vectorFecha[1].DD, vectorFecha[1].MM, vectorFecha[1].AA);
                }
            }

            Console.WriteLine("\nCompara los tres atributos de la primera fecha y envio la tercera fecha");
            estado = vectorFecha[0].CompararFecha(vectorFecha[2]);

            if (estado == 1)
            {
                Console.WriteLine("La primera {0}/{1}/{2} es mayor a la tercera {3}/{4}/{5}", vectorFecha[0].DD, vectorFecha[0].MM, vectorFecha[0].AA, vectorFecha[2].DD, vectorFecha[2].MM, vectorFecha[2].AA);
            }
            else
            {
                if (estado == -1)
                {
                    Console.WriteLine("La tercera {0}/{1}/{2} es mayor a la primera {3}/{4}/{5}", vectorFecha[2].DD, vectorFecha[2].MM, vectorFecha[2].AA, vectorFecha[0].DD, vectorFecha[0].MM, vectorFecha[0].AA);
                }
                else
                {
                    Console.WriteLine("La primera {0}/{1}/{2} es igual a la tercera {3}/{4}/{5}", vectorFecha[0].DD, vectorFecha[0].MM, vectorFecha[0].AA, vectorFecha[2].DD, vectorFecha[2].MM, vectorFecha[2].AA);
                }
            }

            Console.WriteLine("\nCompara los tres atributos de la segunda fecha y envio la tercera fecha");
            estado = vectorFecha[1].CompararFecha(vectorFecha[2]);

            if (estado == 1)
            {
                Console.WriteLine("La segunda {0}/{1}/{2} es mayor a la tercera {3}/{4}/{5}", vectorFecha[1].DD, vectorFecha[1].MM, vectorFecha[1].AA, vectorFecha[2].DD, vectorFecha[2].MM, vectorFecha[2].AA);
            }
            else
            {
                if (estado == -1)
                {
                    Console.WriteLine("La tercera {0}/{1}/{2} es mayor a la segunda {3}/{4}/{5}", vectorFecha[2].DD, vectorFecha[2].MM, vectorFecha[2].AA, vectorFecha[1].DD, vectorFecha[1].MM, vectorFecha[1].AA);
                }
                else
                {
                    Console.WriteLine("La segunda {0}/{1}/{2} es igual a la tercera {3}/{4}/{5}", vectorFecha[1].DD, vectorFecha[1].MM, vectorFecha[1].AA, vectorFecha[2].DD, vectorFecha[2].MM, vectorFecha[2].AA);
                }
            }

            Console.ReadKey();

            return;
        }
    }
}
