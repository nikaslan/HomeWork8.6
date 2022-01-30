using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork8._6._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            HashSet<int> numbers = new HashSet<int>(); // инициализируем Hash массив

            while (true)
            {
                Console.WriteLine("Введите целое число:");
                
                if (Int32.TryParse(Console.ReadLine(), out int newNumber)) // считываем строку введенную пользователем и пытаемся получить из нее число
                {
                    AddToHash(numbers, newNumber);
                }
                else Console.WriteLine("Вы ввели некорректное значение."); // если ввели не число
                Console.WriteLine("Нажмите Enter для продолжения."); // просто пауза после каждой итерации, чтобы прочитать вывод
                Console.ReadLine();
                Console.Clear(); // очищаем консоль и повторяем цикл ввода числа
            }
            
        }

        static HashSet<int> AddToHash(HashSet<int> hash, int num)
        {
            if(hash.Contains(num))
            {
                Console.WriteLine($"Число {num} уже было добавленно в список ранее."); 
            }
            else
            {
                hash.Add(num);
                Console.WriteLine($"Число {num} успешно добавленно в список.");
            }
                     
            return hash;
        }
    }
}
