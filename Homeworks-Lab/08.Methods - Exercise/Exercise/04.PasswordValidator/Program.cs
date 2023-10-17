using System.Security.AccessControl;

namespace _04.PasswordValidator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pass = Console.ReadLine();

            bool LengthCheck = CheckLength(pass);
            bool symbolCheck = CheckSpecialSymbols(pass);
            bool twoDigitsCheck = CheckForTwoDigits(pass);

            if (!LengthCheck)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }

            if (!symbolCheck)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }

            if (!twoDigitsCheck)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }

            if (LengthCheck && symbolCheck && twoDigitsCheck)
            {
                Console.WriteLine("Password is valid");
            }
        }

        private static bool CheckLength(string pass)
        {
            if (pass.Length < 6 ||  pass.Length > 10)
            {
                return false;
            }    
            return true;
        }

        private static bool CheckSpecialSymbols(string pass)
        {
            foreach (var symbol in pass)
            {
                if (symbol >= 65 && symbol <= 90 ||
                    symbol >= 97 && symbol <= 122 ||
                    symbol >= 48 && symbol <= 57)
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }

            return true;
        }

        private static bool CheckForTwoDigits(string pass)
        {
            int count = 0;
            foreach (var symbol in pass)
            {
                if (symbol >= 48 && symbol <= 57)
                {
                    count++;
                }
            }

            if (count < 2)
            {
                return false;
            }
            return true;
        }
    }
}