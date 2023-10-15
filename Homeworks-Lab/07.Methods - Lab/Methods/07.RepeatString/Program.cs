namespace _07.RepeatString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int counts = int.Parse(Console.ReadLine());

            string result = RepeatString(text, counts);
            Console.WriteLine(result);
        }

        private static string RepeatString(string text, int counts)
        {
            string newText = "";
            for (int i = 0; i < counts; i++)
            {
                newText += text;
            }
            return newText;
        }
    }
}