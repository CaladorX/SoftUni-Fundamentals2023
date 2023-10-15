namespace _11.Mathoperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            string Ooperator = Console.ReadLine();
            int b = int.Parse(Console.ReadLine());

            double result = Calculate(a,Ooperator,b);
            Console.WriteLine(result);

        }

        private static double Calculate(int a, string Ooperator, int b)
        {
            double result = 0;

            switch (Ooperator)
            {
                case "+":
                    result = a + b;
                    break;
                case "-":
                    result = a - b;
                    break;
                case "*":
                    result = a * b;
                    break;
                case "/":
                    result = a / b;
                    break;
                case "%":
                    result = a % b;
                    break;
            }
            return result;
        }
    }
}