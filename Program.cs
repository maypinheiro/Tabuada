using System;

namespace Tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Diguite um Número: ");
            int n1= int.Parse(Console.ReadLine());
            
            if(ValidaNumero(n1))
             Tabuada(n1);
            else
                Console.WriteLine("Diguite um número maior que 2 e menor que 1000");
        }

        public static bool ValidaNumero( int n1) {
            if (n1 > 2 && n1 < 1000)
                return true;
            else
                return false;
        }

        public static void Tabuada(int n1)
        {
            for (int i = 1; i <= 10; i++)
                Console.WriteLine($"{i} x {n1} = " + n1 * i);
        }
    }
}
