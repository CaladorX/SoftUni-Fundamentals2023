namespace _01.ExperienceGaining
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double experience = double.Parse(Console.ReadLine());
            int battles = int.Parse(Console.ReadLine());
            double expBar = 0;
            int battleNum = 0;
            bool isEnough = false;

            for (int i = 1; i <= battles; i++)
            {
                double expPerBattle = double.Parse(Console.ReadLine());

                battleNum++;

                if (i % 3 == 0)
                {
                    expPerBattle *= 1.15;
                }

                if (i % 5 == 0)
                {
                    expPerBattle *= 0.90;
                }

                if (i % 15 == 0)
                {
                    expPerBattle *= 1.05;
                }

                expBar += expPerBattle;

                if (expBar >= experience)
                {
                    isEnough = true;
                    break;
                }

            }

            if (isEnough)
            {
                Console.WriteLine($"Player successfully collected his needed experience for {battleNum} battles.");
            }
            else
            {
                double neededExp = experience - expBar;
                Console.WriteLine($"Player was not able to collect the needed experience, {neededExp:f2} more needed.");
            }          
        }
    }
}