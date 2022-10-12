namespace Задание_5._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            Random rnd = new Random();
            while (true)
            {
                Console.WriteLine("Составляем список из 10 шестизначных чисел: ");
                List<int> values = new List<int>(n);
                for (int i = 0; i < n; i++)
                {
                    int x = rnd.Next(100000, 999999);
                    values.Add(x);
                }
                OutputOnDisplay(values);
                Console.WriteLine("\nОставляем только нечётные: ");
                values.RemoveAll(i => i % 2 == 0);
                OutputOnDisplay(values);
                Console.ReadLine();
            }
        }
        private static void OutputOnDisplay(List<int> values)  //выводим на экран элементы листа
        {
            foreach (int i in values)
            {
                Console.Write(i + "\t");
            }
            Console.WriteLine();
        }
    }
}