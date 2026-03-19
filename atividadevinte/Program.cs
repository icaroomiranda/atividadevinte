using atividadevinte.Exercicios;
using System;

class Program
{
    static void Main()
    {
        int opcao;

        do
        {
            Console.WriteLine("\n= MENU =");
            Console.WriteLine("1 - Ex01");
            Console.WriteLine("2 - Ex02");
            Console.WriteLine("3 - Ex03");
            Console.WriteLine("4 - Ex04");
            Console.WriteLine("5 - Ex05");
            Console.WriteLine("6 - Ex06");
            Console.WriteLine("7 - Ex07");
            Console.WriteLine("8 - Ex08");
            Console.WriteLine("9 - Ex09");
            Console.WriteLine("10 - Ex10");
            Console.WriteLine("11 - Ex11");
            Console.WriteLine("12 - Ex12");
            Console.WriteLine("13 - Ex13");
            Console.WriteLine("14 - Ex14");
            Console.WriteLine("15 - Ex15");
            Console.WriteLine("16 - Ex16");
            Console.WriteLine("17 - Ex17");
            Console.WriteLine("18 - Ex18");
            Console.WriteLine("19 - Ex19");
            Console.WriteLine("20 - Ex20");
            Console.WriteLine("0 - Sair");
            Console.Write("Escolha: ");

            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1: Ex01.Executar(); break;
                case 2: Ex02.Executar(); break;
                case 3: Ex03.Executar(); break;
                case 4: Ex04.Executar(); break;
                case 5: Ex05.Executar(); break;
                case 6: Ex06.Executar(); break;
                case 7: Ex07.Executar(); break;
                case 8: Ex08.Executar(); break;
                case 9: Ex09.Executar(); break;
                case 10: Ex10.Executar(); break;
                case 11: Ex11.Executar(); break;
                case 12: Ex12.Executar(); break;
                case 13: Ex13.Executar(); break;
                case 14: Ex14.Executar(); break;
                case 15: Ex15.Executar(); break;
                case 16: Ex16.Executar(); break;
                case 17: Ex17.Executar(); break;
                case 18: Ex18.Executar(); break;
                case 19: Ex19.Executar(); break;
                case 20: Ex20.Executar(); break;
            }

        } while (opcao != 0);
    }
}