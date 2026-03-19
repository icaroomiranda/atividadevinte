using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividadevinte.Exercicios
{
    using System;

    public class Ex01
    {
        public static void Executar()
        {
            Console.Write("Digite um número: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i += 2)
                Console.WriteLine(i);
        }
    }
}