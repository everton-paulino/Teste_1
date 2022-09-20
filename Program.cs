using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Indice = 13;
            int Soma = 0;
            int K = 0;
            



            while (K < Indice)
            {
                     
                Soma = Soma + K;
                K = K + 1;
                Console.WriteLine(Soma);


            }

            Console.ReadLine();

        }
    }
}
