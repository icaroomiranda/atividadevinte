using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividadevinte.Exercicios
{

    public class Ex07
    {
        public static void Executar()
        {
            int n = int.Parse(Console.ReadLine());
            int f = 1;

            for (int i = 1; i <= n; i++)
                f *= i;

            Console.WriteLine(f);
        }
    }
}
