using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Привет!");

            // Вводим доход
            int debitSumm = 0;
          

            for (int i = 0; i<10; i++)
            {
                string debit = "";                

                Console.Write("Введите доход: ");
                debit = Console.ReadLine();
                
                int debitInt;
                int.TryParse(debit, out debitInt);
                debitSumm += debitInt;
              
            }
            Console.WriteLine("Ваш доход:" + debitSumm.ToString());
            Console.WriteLine();

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
            Console.WriteLine("Ваш расход: " + creditSumm.ToString());
            Console.WriteLine();


            /* Подсчет баланса
               Вывод на экран текущего состояния дел */                 
            int balance = debitSumm - creditSumm;
            Console.WriteLine("Ваш баланс: " + balance.ToString());

            if(balance > 0)
            {
                Console.WriteLine("Вы хороший пёс!");
            } else
            {
                Console.WriteLine("Вы плохой пёс!");
            }

        }
    }
}
