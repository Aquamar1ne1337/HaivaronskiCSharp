namespace HaivaronskiCSharp
{
    public static class ListUtils
    {
        private static Random random = new Random();
        public static List<int> GenerateList(int lenght)
        {
            var values = new List<int>();

            for (int i = 0; i < lenght; i++)
            {
                values.Add(random.Next(0, 100));
            }
            return values;
        }

        public static IEnumerable<int> TakeMultiplesOfThree(IEnumerable<int> numbers)
        {
            foreach (int number in numbers)
            {
                if (number % 3 == 0)
                {
                    yield return number;
                }
            }
        }
    }
}