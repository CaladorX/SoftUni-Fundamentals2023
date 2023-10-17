namespace _02.VowelsCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            

            string vowelsCount = Vowels(word);
            Console.WriteLine(vowelsCount);
        }

        static string Vowels(string text)
        {
            int count = 0;
            text = text.ToLower();

            foreach (char character in text)
            {
                if (IsVowel(character))
                {
                    count++;
                }
            }
            return count.ToString();
        }

        static bool IsVowel(char character)
        {
            // Define a list of vowels (both uppercase and lowercase)
            string vowels = "aeiouAEIOU";

            return vowels.Contains(character);
        }
    }
}