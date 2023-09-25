namespace _01.IntegerOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            int FourthNumber = int.Parse(Console.ReadLine());

            int firstOp = firstNumber + secondNumber;
            int secondOp = firstOp / thirdNumber;
            int thirdOp = secondOp * FourthNumber;

            Console.WriteLine(thirdOp);
        }
    }
}