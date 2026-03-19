using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividadevinte.Exercicios
{

    public class Ex06
    {
        public static void Executar()
        {
            int n = int.Parse(Console.ReadLine());
            int a = 0, b = 1;

            for (int i = 0; i < n; i++)
            {
                Console.Write(a + " ");
                int temp = a + b;
                a = b;
                b = temp;
            }
        }
    }
}