/*Crear una aplicación que solicite la temperatura diaria promedio para el lapso de una
semana (7 días). Al finalizar se debe informar cual es la temperatura mínima registrada, cual la
máxima y a que numero de día corresponde en cada caso.*/

using System;

namespace Ej3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor=ConsoleColor.DarkMagenta;
            Console.Clear();

            int temp = 0, dias = 1, minima, maxima, promedio=0, masfrio=0, mascalor=0;
           
            Console.WriteLine("Bienbenido al Sistema de Registro de Temperaturas");
            Console.WriteLine("Ingrese la Temperatura del dia {0}", dias);
            temp = Convert.ToInt32(Console.ReadLine());
            float promedioTotal=0.0f;
            maxima= temp;
            minima = temp;
            Console.Clear();

            for (dias = 2; dias <=7; dias++)
            {
                Console.WriteLine("Ingrese la Temperatura del dia {0}", dias);
                temp = Convert.ToInt32(Console.ReadLine());
                promedio= promedio+temp;

                 if(temp < minima)
                {
                    minima = temp;
                    masfrio = dias;
                }
                
                else 
                {
                    maxima = temp;
                    mascalor = dias;
                }
                
               Console.Clear();
            }
            promedioTotal= promedio / dias;
            Console.WriteLine("La temperatura Minima fue de {0} ,correspondiente al dia {1} ", minima, masfrio);
            Console.WriteLine("Latemperatura maxima fue de {0} , correspondiente al dia {1}  ", maxima, mascalor);
            Console.WriteLine("El promedio de temperatura de esos dias fue de: {0} ", promedioTotal);
            Console.WriteLine("{0} " , dias);
           










        }
    }
}
