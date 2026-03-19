using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividadevinte.Exercicios
{
    public class Ex17
    {
        public static void Executar()
        {
            int n = int.Parse(Console.ReadLine());
            int cont = 0;
            for (int i = 1; i <= n; i++)
                if (n % i == 0) cont++;
            Console.WriteLine(cont == 2 ? "PRIMO" : "NAO PRIMO");
        }
    }
}