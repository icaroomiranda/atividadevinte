using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividadevinte.Exercicios
{

    public class Ex02
    {
        public static void Executar()
        {
            Console.Write("X: ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("Y: ");
            int y = int.Parse(Console.ReadLine());

            int soma = 0;

            for (int i = x + 1; i < y; i++)
                if (i % 2 != 0)
                    soma += i;

            Console.WriteLine("Soma = " + soma);
        }
    }
}