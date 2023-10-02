namespace _01.Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] wagons = new int[n];
            int sumPeople = 0;

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                wagons[i] = number;
                sumPeople += number;
            }

            Console.WriteLine(string.Join(" ", wagons));
            Console.WriteLine(sumPeople);
        }
    }
}