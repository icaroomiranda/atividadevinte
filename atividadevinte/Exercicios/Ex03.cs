using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividadevinte.Exercicios
{
    public class Ex03
    {
        public static void Executar()
        {
            Console.Write("Número: ");
            int n = int.Parse(Console.ReadLine());

            if (n >= 0 && n <= 25) Console.WriteLine("[0,25]");
            else if (n <= 50) Console.WriteLine("[25,50]");
            else if (n <= 75) Console.WriteLine("[50,75]");
            else if (n <= 100) Console.WriteLine("[75,100]");
            else Console.WriteLine("Fora");
        }
    }
}