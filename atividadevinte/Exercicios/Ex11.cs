using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividadevinte.Exercicios
{
    public class Ex11
    {
        public static void Executar()
        {
            int n = int.Parse(Console.ReadLine());
            int maior = int.MinValue;
            for (int i = 0; i < n; i++)
            {
                int v = int.Parse(Console.ReadLine());
                if (v > maior) maior = v;
            }
            Console.WriteLine("Maior: " + maior);
        }
    }
}