using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividadevinte.Exercicios
{

    public class Ex04
    {
        public static void Executar()
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(n % 2 == 0 ? "PAR" : "IMPAR");
        }
    }
}