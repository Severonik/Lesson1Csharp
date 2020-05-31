using System;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {   

            
            DirectoryInfo di = new DirectoryInfo("Data");

            //Удаляем предыдущую директорию
            if (di.Exists)
                di.Delete(true);

            // Создаем директорию
            di.Create();

            // Создаем файл для записи
            StreamWriter sw = File.CreateText("Data\\money.txt");

            Console.WriteLine("Привет!");

            // Вводим доход
            int debitSumm = 0;


            for (int i = 0; i < 10; i++)
            {
                string debit = "";

                Console.Write("Введите доход: ");
                debit = Console.ReadLine();

                int debitInt;
                int.TryParse(debit, out debitInt);
                debitSumm += debitInt;

            }
            Console.WriteLine();
            sw.WriteLine("Ваш доход:" + debitSumm.ToString());
            sw.WriteLine();

            // Вводим расход
            int creditSumm = 0;
            
            for(int i = 0; i<10; i++)
            {
                string credit = "";

                Console.Write("Введите расход: ");
                credit = Console.ReadLine();
                
                int creditInt;
                int.TryParse(credit, out creditInt);
                creditSumm += creditInt;
            }
            sw.WriteLine("Ваш расход: " + creditSumm.ToString());
            sw.WriteLine();


            /* Подсчет баланса
               Вывод на экран текущего состояния дел */                 
            int balance = debitSumm - creditSumm;
            sw.WriteLine("Ваш баланс: " + balance.ToString());

            if(balance > 0)
            {
                sw.WriteLine("Вы хороший пёс!");
            } else
            {
                sw.WriteLine("Вы плохой пёс!");
            }

            // Закрываем файл
            sw.Close();
        }
    }
}
