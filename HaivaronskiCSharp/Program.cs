using System;
        
namespace HaivaronskiCSharp
{
    public class Program
    {
        private const string testName = "Вячеслав";
        static void Main(string[] args)
        {
            FirstTask();
            SecondTask();
            ThirdTask();
        }

        public static void FirstTask()
        {
            Console.Write("Введите число: ");
            string input = Console.ReadLine();

            bool parseResult = int.TryParse(input, out var number);
            if (parseResult)
            {
                if (number > 7)
                    Console.WriteLine("Привет");
            }
            else 
                Console.WriteLine("Вы ввели не число.");
        }

        public static void SecondTask()
        {
            Console.Write("Введите имя: ");
            var name = Console.ReadLine();
            if (string.Equals(name, testName, StringComparison.OrdinalIgnoreCase))
                Console.WriteLine("Привет, {0}", testName);
            else 
                Console.WriteLine("Нет такого имени");
        }

        public static void ThirdTask()
        {
            Console.Write("Введите размер массива: ");

            var array = new List<int> { };

            try
            {
                var lenght = Convert.ToInt32(Console.ReadLine());
                if (lenght < 0)
                    throw new ArgumentException();
                else 
                    array = ListUtils.GenerateList(lenght);
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Размер массива не может быть нулевым либо отрицательным");
            }
            catch (FormatException)
            {
                Console.WriteLine("Вы ввели не число.");
            }

            var arrayInts = string.Join(' ', array);
            var result = string.Join(' ', ListUtils.TakeMultiplesOfThree(array));

            Console.WriteLine("Ваш массив: {0} ", arrayInts);
            Console.WriteLine("Числа, кратные 3: {0} ", result);
        }
    }
}