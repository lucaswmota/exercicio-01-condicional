using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01Condicional
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Digite o Primeiro Numero: ");
            double n1 = double.Parse(Console.ReadLine());

            Console.Write("Digite o Segundo numero: ");
            double n2 = double.Parse(Console.ReadLine());

            if (n1<n2)
            {
                Console.WriteLine("O Segundo Número é maior.");
            }
            else if (n1>n2)
            {
                Console.WriteLine("O Primeiro Número é Maior.");
            }
            else
            {
                Console.WriteLine("Os dois números sao iguais.");
            }
            Console.ReadKey();
        }
    }
}
