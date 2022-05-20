using System;

namespace EXERCICIO_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] VetorA = new int[5];
            int[] VetorB = new int[5];
            int[] VetorC = new int[5];
            
            for (int i = 0; i < VetorA.Length; i++)
            {
                Console.WriteLine("Informe o valor" + i);
                VetorA[i] = Convert.ToInt32(Console.ReadLine());

            }
            for (int i = 0; i < VetorB.Length; i++)
            {
                Console.WriteLine("Informe o valor" + i);
                VetorB[i] = Convert.ToInt32(Console.ReadLine());
              
            }

            for (int i = 0; i < VetorC.Length; i++)
            {
                VetorC[i] = VetorA[i] * VetorB[i];

                Console.WriteLine("Resultado é " + VetorC[i]);
            }


        }
    }

}

