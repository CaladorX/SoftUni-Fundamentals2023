namespace _03.Zig_ZagArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // INPUT
            int n = int.Parse(Console.ReadLine());
            string[] firstArr = new string[n];
            string[] secondArr = new string[n];
            bool isFirstSelected = true;

            // OPERATION
            for (int i = 0; i < n; i++)
            {
                string numbers = Console.ReadLine();
                string[] numArr = numbers.Split();

                if (isFirstSelected == true)
                {
                    firstArr[i] = numArr[0];
                    secondArr[i] = numArr[1];
                }
                else
                {
                    firstArr[i] = numArr[1];
                    secondArr[i] = numArr[0];
                }
                
                isFirstSelected = !isFirstSelected;

            }

            //OUTPUT
            Console.WriteLine(string.Join(" ", firstArr));
            Console.WriteLine(string.Join(" ", secondArr));

        }
    }
}