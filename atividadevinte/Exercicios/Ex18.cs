using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividadevinte.Exercicios
{
    public class Ex18
    {
        public static void Executar()
        {
            int n = int.Parse(Console.ReadLine());
            int invertido = 0;
            while (n > 0)
            {
                invertido = invertido * 10 + (n % 10);
                n /= 10;
            }
            Console.WriteLine(invertido);
        }
    }
}
