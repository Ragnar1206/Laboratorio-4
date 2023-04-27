using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ejercicio 1");
            Console.WriteLine("ingrese un numero");
            int x = Convert.ToInt32(Console.ReadLine());
            if (x == 0)
            {
                Console.WriteLine("RESULTADO: Cero");
            }
            else if (x > 0)
            {
                Console.WriteLine("RESULTADO: Positivo");
            }
            else if (x < 0)
            {
                Console.WriteLine("RESULTADO: Negativo");
            }
            else
            {
                Console.WriteLine("error" + x + "no es un numero");
            }
            Console.WriteLine("Ejercicio 2");

            Console.Write("Ingrese un número de día (1-7): ");
            int numeroDia = int.Parse(Console.ReadLine());

            if (numeroDia < 1 || numeroDia > 7)
            {
                Console.WriteLine("Error: El número a ingresar debe estar contenido entre 1 y 7");
            }
            else
            {
                string dia;
                switch (numeroDia)
                {
                    case 1:
                        dia = "lunes";
                        break;
                    case 2:
                        dia = "martes";
                        break;
                    case 3:
                        dia = "miércoles";
                        break;
                    case 4:
                        dia = "jueves";
                        break;
                    case 5:
                        dia = "viernes";
                        break;
                    case 6:
                        dia = "sábado";
                        break;
                    default:
                        dia = "domingo";
                        break;
                }
                Console.WriteLine("DIA: " + dia);
            }
            Console.ReadKey();
        }
    }

}

