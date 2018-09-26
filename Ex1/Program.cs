using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Maiores");
            Console.WriteLine("---------");

            int n = 0;
            int qtdeMaiores69 = 0;

            int i = 1;
            while (i <= 6)
            {
                Console.Write("Digite o " + i + "º numero: ");
                n = Convert.ToInt32(Console.ReadLine());

                if (n > 69)
                {
                    qtdeMaiores69++;
                }
                i++;
            }
            Console.WriteLine("Qtde de maiores que 69: " + qtdeMaiores69);
            Console.ReadKey();
        }
    }
}
