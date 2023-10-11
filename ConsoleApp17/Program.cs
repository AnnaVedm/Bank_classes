using System;
using System.Diagnostics.CodeAnalysis;

namespace Классы_Анютка_счёт_в_банке
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank schet = new Bank();

            schet.otkryt_shet();
            schet.output();

            while (true) //Цикл для вывода программы
            {
                schet.operation_schet();
                Console.WriteLine("\nХотите выйти из программы? \n1.Да\n2.Нет");
                int user_choise1 = Convert.ToInt32(Console.ReadLine());

                if (user_choise1 == 1) // Выход из программы
                {
                    Console.Clear();
                    break;
                }
                else
                {
                    Console.Clear();
                    schet.operation_schet();
                }
            }

        }
    }
   
}
