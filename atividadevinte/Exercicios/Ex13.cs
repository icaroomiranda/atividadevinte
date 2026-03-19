using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividadevinte.Exercicios
{
    public class Ex13
    {
        public static void Executar()
        {
            int n = int.Parse(Console.ReadLine());
            int soma = 0;
            for (int i = 0; i < n; i++)
                soma += int.Parse(Console.ReadLine());
            Console.WriteLine("Média: " + (soma / (double)n));
        }
    }
}