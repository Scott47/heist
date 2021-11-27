using System;

namespace Heist
{
    public class LockSpecialist : IRobber
    {
        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public int PercentageCut { get; set; }
        public LockSpecialist(string name, int skillLevel, int percentageCut)
        {
            Name = name;
            SkillLevel = skillLevel;
            PercentageCut = percentageCut;
        }
        public void PerformSkill(Bank bank)
        {
            bank.VaultScore = bank.VaultScore - SkillLevel;
            Console.WriteLine($"{Name} is picking the Vault lock, vault security has decreased by 50 points.");
            if (bank.VaultScore < 0)
            {
                Console.WriteLine($"{Name} has cracked the Vault!");
            }
        }
    }
}