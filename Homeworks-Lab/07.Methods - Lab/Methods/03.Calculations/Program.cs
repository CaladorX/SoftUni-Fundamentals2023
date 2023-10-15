namespace _03.Calculations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string math = Console.ReadLine();
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());

            switch (math)
            {
                case "add":
                    add(numberOne, numberTwo); 
                    break;
                case "subtract":
                    subtract(numberOne, numberTwo);
                    break;
                case "multiply":
                    multiply(numberOne, numberTwo);
                    break;
                case "divide":
                    divide(numberOne, numberTwo);
                    break;
            }


        }

        static void add(int numberOne, int numberTwo)
        {
            Console.WriteLine(numberOne + numberTwo);
        }

        static void subtract(int numberOne, int numberTwo)
        {
            Console.WriteLine(numberOne - numberTwo);
        }

        static void multiply(int numberOne, int numberTwo)
        {
            Console.WriteLine(numberOne * numberTwo);
        }

        static void divide(int numberOne, int numberTwo)
        {
            Console.WriteLine(numberOne / numberTwo);
        }
    }
}