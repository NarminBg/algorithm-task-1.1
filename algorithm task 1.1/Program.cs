namespace algorithm_task_1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int month, year;
            if (number >= 1 && number <= 1188)
            {
                year = number / 12;
                month = number % 12;
                Console.WriteLine($"{year} il, {month} ay");
            }
        }
    }
}