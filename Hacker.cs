using System;

namespace Heist
{
    public class Hacker : IRobber
    {
        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public int PercentageCut { get; set; }
        public Hacker(string name, int skillLevel, int percentageCut)
        {
            Name = name;
            SkillLevel = skillLevel;
            PercentageCut = percentageCut;
        }
        public void PerformSkill(Bank bank)
        {
            bank.AlarmScore = bank.AlarmScore - SkillLevel;
            Console.WriteLine($"{Name} is disabling the alarm system. Security is decreased by 50 points.");
            if (bank.AlarmScore < 0)
            {
                Console.WriteLine($"{Name} has disabled the alarm system!");
            }
        }

    }
}