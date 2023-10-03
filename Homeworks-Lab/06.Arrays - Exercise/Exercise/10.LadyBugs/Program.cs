using System.Data;

namespace _10.LadyBugs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long fieldLength = int.Parse(Console.ReadLine());
            int[] bugPlace = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            long[] field = new long[fieldLength];

            for (int i = 0; i < bugPlace.Length; i++)
            {
                int currentIndex = bugPlace[i];

                if (currentIndex >= 0 && currentIndex < field.Length)
                {
                    field[currentIndex] = 1;
                }
            }

            string command = "";

            while ((command = Console.ReadLine()) != "end")
            {
                string[] arguments = command.Split();

                int bugIndex = int.Parse(arguments[0]);
                string direcetion = arguments[1];
                int flyLength = int.Parse(arguments[2]);

                if (bugIndex < 0 || bugIndex > field.Length - 1 || field[bugIndex] == 0)
                {
                    continue;
                }

                field[bugIndex] = 0;
                int landIndex;

                switch (direcetion)
                {
                    case "right":
                        landIndex = bugIndex + flyLength;

                        if (landIndex > field.Length - 1 )
                        {
                            continue;
                        }

                        if (field[landIndex] == 1)
                        {
                            while (field[landIndex] == 1)
                            {
                                landIndex += flyLength;
                                if (landIndex > field.Length - 1)
                                {
                                    break;
                                }
                            }
                        }

                        if (landIndex <= field.Length - 1)
                        {
                            field[landIndex] = 1;
                        }

                        break;
                    case "left":
                        landIndex = bugIndex - flyLength;

                        if (landIndex < 0)
                        {
                            continue;
                        }

                        if (field[landIndex] == 1)
                        {
                            while (field[landIndex] == 1)
                            {
                                landIndex -= flyLength;
                                if (landIndex < 0)
                                {
                                    break;
                                }
                            }
                        }

                        if (landIndex >= 0)
                        {
                            field[landIndex] = 1;
                        }
                        break;
                }
            }
            Console.WriteLine(string.Join(" ", field));
        }
    }
}