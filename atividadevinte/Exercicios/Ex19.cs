using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividadevinte.Exercicios
{
    public class Ex19
    {
        public static void Executar()
        {
            int n = int.Parse(Console.ReadLine());
            int soma = 0;
            while (n != 0)
            {
                soma += n % 10;
                n /= 10;
            }
            Console.WriteLine(soma);
        }
    }
}