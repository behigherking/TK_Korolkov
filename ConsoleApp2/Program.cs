using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TK_Korolkov;

    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите баллы за задание 1 (0-10) ");
            string ex1 = Console.ReadLine();

            Console.WriteLine("Введите баллы за задание 2 (0-50) ");
            string ex2 = Console.ReadLine();

            Console.WriteLine("Введите баллы за задание 3 (0-30) ");
            string ex3 = Console.ReadLine();

            Console.WriteLine("Введите баллы за задание 4 (0-10) ");
            string ex4 = Console.ReadLine();

            Console.WriteLine(GetMark(ex1, ex2, ex3, ex4));
            Console.ReadKey();

        }

        public static string GetMark(string _ex1, string _ex2, string _ex3, string _ex4)
        {

            int ex1, ex2, ex3, ex4;
            if (!int.TryParse(_ex1, out ex1) || !int.TryParse(_ex2, out ex2) || !int.TryParse(_ex3, out ex3) || !int.TryParse(_ex4, out ex4))
            {
                return "Некорректные значения!";
            }

            if (ex1 > 10)
            {
                return "Максимально количество баллов для 1 задания 10!!!";
            }

            if (ex2 > 50)
            {
                return "Максимально количество баллов для 2 задания 50!!!";
            }

            if (ex3 > 30)
            {
                return "Максимально количество баллов для 3 задания 30!!!";
            }

            if (ex4 > 10)
            {
                return "Максимально количество баллов для 4 задания 10!!!";
            }

            int result = (int)(ex1 + ex2 + ex3 + ex4);


            if (result < 20)
            {
                return $"Всего баллов: {result}. Оценка: 2";
            }

            else if (result < 40)
            {
                return $"Всего баллов: {result}. Оценка: 3";
            }

            else if (result < 70)
            {
                return $"Всего баллов: {result}. Оценка: 4";
            }
            else
            {
                return $"Всего баллов: {result}. Оценка: 5";
            }
        }
    }
}
