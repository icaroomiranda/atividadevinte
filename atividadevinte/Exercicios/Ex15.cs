using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividadevinte.Exercicios
{
    public class Ex15
    {
        public static void Executar()
        {
            int n = int.Parse(Console.ReadLine());
            int soma = 0;
            for (int i = 1; i <= n; i++)
                if (i % 2 == 0) soma += i;
            Console.WriteLine(soma);
        }
    }
}