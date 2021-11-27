using System;

namespace Heist
{
    public class Muscle : IRobber
    {
        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public int PercentageCut { get; set; }
        public void PerformSkill(Bank bank)
        {
            bank.SecurityGuardScore = bank.SecurityGuardScore = SkillLevel;
            Console.WriteLine($"{Name} is taking care of the security guard. SecurityGuardScore has been reduced by 50 points!");
            if (bank.SecurityGuardScore < 0)
            {
                Console.WriteLine($"{Name} has taken care of the security guard!");
            }
        }
    }
}