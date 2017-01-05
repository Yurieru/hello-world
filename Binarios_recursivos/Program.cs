using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binarios_recursivos
{
    class Program
    {
        static void Main(string[] args)
        {
            int Dec;
            string bin;
            Console.WriteLine("Introduce un numero decimal entero");
            Dec = Convert.ToInt32(Console.ReadLine());
            bin = tip(Dec);
            Console.WriteLine("el numero en binario es:  " + bin);
            Console.ReadKey();
        }

        public static string tip(int n)
        {
            string respuesta=(n%2).ToString();
            if (n < 2)
            {
                respuesta = (n % 2).ToString();
            }
            else
            {
                respuesta =proceso(n / 2)+respuesta;
            }
            return respuesta;
        }

        public static int proceso(int n)
        {
            int respuesta = n % 2;
            if (n < 2)
            {
                respuesta = n % 2;
            }
            else
            {
                respuesta += 10 * proceso(n / 2);
            }
            return respuesta;
        }

    }
}
