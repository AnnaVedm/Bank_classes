using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Классы_Анютка_счёт_в_банке
{
    class Bank
    {
        private int shet; //Счёт пользователя
        private int shet1; // Счёт для перевода
        private string FIO;
        private double dengi;// Деньги пользователя
        private double dengi1; // Деньги, которые мы переводим

        public void otkryt_shet()
        {
            Random rnd = new Random();
            shet = rnd.Next(123235746, 234365687);
            Console.Write($"Здравствуйте! Приветствуем вас в банке Анютка! Спасибо, что выбрали нас. \nВот ваш номер счёта:{shet}");

            Console.Write("\nВведите ваше ФИО: ");
            FIO = Console.ReadLine();

            Console.Write("Введите изначальное количество денег, которое положите на счёт(Руб): ");
            dengi = Convert.ToSingle(Console.ReadLine());
        }

        public void output()
        {
            Console.WriteLine($"\nИНФОРМАЦИЯ О СЧЁТЕ");
            Console.WriteLine($"Номер счёта:{shet}");
            Console.WriteLine($"ФИО владельца:{FIO}");
            Console.WriteLine($"Количество денег на счёте:{dengi} руб");
        }
        public void operation_schet()
        {
            Console.WriteLine("\nВыберите действие:\n1.Положить деньги на счёт\n2.Снять деньги со счёта\n3.Обнулить счёт\n4.Перенести сумму с одного счёта на другой.\n5.Ничего не делать ");
            int user_choice = Convert.ToInt32(Console.ReadLine());

            if (user_choice == 1)
            {
                dob();
            }
            else if (user_choice == 2)
            {
                umen();
            }
            else if (user_choice == 3)
            {
                obnul();
            }
            else if (user_choice == 4)
            {
                perenos();
            }
            else
            {
                Console.WriteLine("Вы выбрали ничего не делать с деньгами на вашем счете. Вот информация о вашем текущем счёте: ");
                output();
            }
        }
        public void dob()
        {
            Console.Clear();
            Console.WriteLine("Сколько денег вы хотите добавить?");
            float sum = sum = (float)Convert.ToDouble(Console.ReadLine()); //Переменная прибавки денег

            dengi += sum;

            Console.WriteLine($"Теперь на вашем счете {dengi} руб. Вот информация о вашем текущем счёте:");
            output();
        }
        public void umen()
        {
            Console.Clear();
            Console.WriteLine("Сколько денег вы хотите вывести со счёта?");
            float minus = minus = (float)Convert.ToDouble(Console.ReadLine()); //Переменная вывода денег

            dengi -= minus;

            Console.WriteLine($"Теперь на вашем счете {dengi} руб. Вот информация о вашем текущем счёте:");
            output();
        }
        public void obnul()
        {
            Console.Clear();
            Console.WriteLine("Вы выбрали обнуление счёта.");
            double obnulenie = dengi; //Приравниваем деньги пользователя к обнулению
            dengi -= obnulenie; //Вычитаем друг из друга. Обнуляем
            Console.WriteLine($"Теперь на вашем счете {dengi} руб. Вот информация о вашем текущем счёте:");
            output();
        }
        public void perenos()
        {
            Console.Clear();
            Console.WriteLine("Введите номер счёта, куда хотите перевести деньги");
            shet1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите количество денег для перевода");
            dengi1 = Convert.ToInt32(Console.ReadLine());

            if (dengi1 > dengi) //Проверка на кол-во денег на счёте
            {
                Console.WriteLine($"На вашем счёте недостаточно средств для перевода на данную сумму. Количество денег на вашем счёте {dengi} руб");
                operation_schet();
            }
            else
            {
                Console.Clear();
                string move = "Перевод денег..."; //Динамичное сообщение о переводе денег

                for (int j = 0; j < 1; j++)
                {
                    for (int i = 0; i < move.Length; i++)
                    {
                        Console.Write(move[i]);
                        Thread.Sleep(200);
                    }
                    Console.Clear();

                    dengi -= dengi1; //Перевод

                    Console.WriteLine($"Деньги доставлены на счёт: {shet1}");
                    Console.WriteLine($"Теперь на вашем счете {dengi} руб. Вот информация о вашем текущем счёте: ");
                    output();
                }
            }
        }
    }
}
