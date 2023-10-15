namespace _06._CalculateRectangleArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            double result = Result(a, b);

            Console.WriteLine(result);
        }

        static double Result(double a, double b)
        {
            return a * b;
        }
    }
}