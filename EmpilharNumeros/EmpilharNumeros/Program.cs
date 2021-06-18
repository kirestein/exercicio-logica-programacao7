using System;

namespace EmpilharNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            int numero;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Informe um número");
                numero = int.Parse(Console.ReadLine());

                array[i] = numero;
            }

            Console.WriteLine("Posição inicial da pilha.");

            foreach (int value in array) Console.WriteLine("[" + value + "]");


            Array.Reverse(array);

            Console.WriteLine("Posição invertida da pilha.");
            foreach (int value in array) Console.WriteLine("[" + value + "]");


            Console.ReadKey();
        }
    }
}
