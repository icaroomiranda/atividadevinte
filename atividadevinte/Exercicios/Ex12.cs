using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividadevinte.Exercicios
{
    public class Ex12
    {
        public static void Executar()
        {
            int n = int.Parse(Console.ReadLine());
            int pares = 0;
            for (int i = 0; i < n; i++)
            {
                int v = int.Parse(Console.ReadLine());
                if (v % 2 == 0) pares++;
            }
            Console.WriteLine("Pares: " + pares);
        }
    }
}