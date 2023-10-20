namespace _07.ListManipulationAdvanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            bool changesMade = false;
            string line = default;
            while ((line = Console.ReadLine()) != "end")
            {
                string[] lineTokens = line.Split().ToArray();
                string command = lineTokens[0];

                if (command == "Contains" && lineTokens.Length == 2)
                {
                    int numberToCheck = int.Parse(lineTokens[1]);
                    CheckContains(numbers, numberToCheck);
                }
                else if (command == "PrintEven")
                {
                    CheckEven(numbers);
                }
                else if (command == "PrintOdd")
                {
                    CheckOdd(numbers);
                }
                else if (command == "GetSum")
                {
                    GetSum(numbers);
                }
                else if (command == "Filter" && lineTokens.Length == 3)
                {
                    string condition = lineTokens[1];
                    int numberChecker = int.Parse(lineTokens[2]);
                    Filter(numbers, condition, numberChecker);
                }
                else if (command == "Add")
                {
                    int numberToAdd = int.Parse(lineTokens[1]);
                    numbers.Add(numberToAdd);
                    changesMade = true;
                }
                else if (command == "Insert")
                {
                    int index = int.Parse(lineTokens[1]);
                    int numberToInsert = int.Parse(lineTokens[2]);
                        numbers.Insert(index, numberToInsert);
                        changesMade = true;
                }
                else if (command == "Remove")
                {
                    int numberToRemove = int.Parse(lineTokens[1]);
                    if (numbers.Contains(numberToRemove))
                    {
                        numbers.Remove(numberToRemove);
                        changesMade = true;
                    }
                }
                else if (command == "RemoveAt")
                {
                    int indexToRemove = int.Parse(lineTokens[1]);

                    numbers.RemoveAt(indexToRemove);
                    changesMade = true;
                }
            }

            if (changesMade)
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
        }

        private static void GetSum(List<int> numbers)
        {
            int sum = numbers.Sum();
            Console.WriteLine(sum);
        }

        private static void CheckContains(List<int> numbers, int number)
        {
            if (numbers.Contains(number))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No such number");
            }
        }

        private static void CheckEven(List<int> Even)
        {
            List<int> result = new List<int>();

            for (int i = 0; i < Even.Count; i++)
            {
                if (Even[i] % 2 == 0)
                { result.Add(Even[i]); }
            }
            Console.WriteLine(string.Join(" ", result));
        }

        private static void CheckOdd(List<int> Odd)
        {
            List<int> result = new List<int>();

            for (int i = 0; i < Odd.Count; i++)
            {
                if (Odd[i] % 2 != 0)
                { result.Add(Odd[i]); }
            }
            Console.WriteLine(string.Join(" ", result));
        }

        private static void Filter(List<int> number, string condition, int numberChecker)
        {
            List<int> result = new List<int>();

            for (int i = 0; i < number.Count; i++)
            {
                if (condition == "<" && numberChecker > number[i])
                {
                    result.Add(number[i]);
                }
                else if (condition == ">" && numberChecker < number[i])
                {
                    result.Add(number[i]);
                }
                else if (condition == ">=" && numberChecker <= number[i])
                {
                    result.Add(number[i]);
                }
                else if (condition == "<=" && numberChecker >= number[i])
                {
                    result.Add(number[i]);
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}