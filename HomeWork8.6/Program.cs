using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork8._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            List<int> randomNums = FillInList(); // инициализируем список случайных чисел
            Console.WriteLine("Следующий список чисел был сгенерирован:");
            PrintList(randomNums);
            randomNums = ModifyList(randomNums); // модифицируем список, удаляя значения, согласно условиям
            Console.WriteLine("После удаления значений меньше 25, но больше 50, получился следующий список:");
            PrintList(randomNums);
            Console.ReadLine();
        }
        /// <summary>
        /// Создание списка и заполнение его случайными числами от 0 до 100
        /// </summary>
        /// <returns>возвращаем сгенерированный список</returns>
        static List<int> FillInList ()
        {
            Random rand = new Random();
            
            List<int> tempList = new List<int>();

            for (int i = 0; i < 100; i++)
            {
                int j = rand.Next(100);
                tempList.Add(j);
            }

            return tempList;
        }
        /// <summary>
        /// выводим список в консоль
        /// </summary>
        /// <param name="tempList">передаем список для вывода</param>
        static void PrintList(List<int> tempList)
        {
            Console.WriteLine("\n");
            foreach (var i in tempList)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine("\n");
        }

        /// <summary>
        /// Изменяем список, удаляя значения, которые находятся между 25 и 50
        /// </summary>
        /// <param name="tempList">передаем начальный список</param>
        /// <returns>возвращаем модифицированный список</returns>
        static List<int> ModifyList(List<int> tempList)
        {
            for(int i = 0; i< tempList.Count; i++)
            {
                if (tempList[i] > 25 && tempList[i] < 50)
                {
                    tempList.RemoveAt(i);
                    i--; // чтобы на следующей итерации цикла мы снова прочитали i-ый элемент, т.к. он изменился после удаления предыдущего значения
                }
            }
            return tempList;
        }
    }
}
