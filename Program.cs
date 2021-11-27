using System;
using System.Collections.Generic;

namespace Heist
{
    class Program
    {
        static void Main(string[] args)
        {
            AddCrewMember();
        }
        public static void AddCrewMember()
        {
            Bank regionsOnGallatin = new Bank();
            Hacker cassie = new Hacker("Cassie", 100, 20);
            Hacker myriam = new Hacker("Myriam", 100, 20);
            LockSpecialist mario = new LockSpecialist("Mario", 100, 15);
            LockSpecialist jasmin = new LockSpecialist("Jasmin", 100, 25);
            Muscle erica = new Muscle("Erica", 100, 10);
            Muscle andres = new Muscle("Andres", 100, 10);

            List<IRobber> rolodex = new List<IRobber>()
            {
                cassie, myriam, mario, jasmin, erica, andres
            };
            Console.WriteLine("Welcome to Heist! Let's build a crew and clock some dough.");
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("Here is a list of our current crew:");
            foreach (IRobber robber in rolodex)
            {
                Console.WriteLine(robber.Name);
            }
            Console.WriteLine("Enter the name of a new crew member");
            string crewmember = Console.ReadLine();
            Console.WriteLine($"Enter the number of {crewmember}'s specialty");
            Console.WriteLine("1. Hacker \n2. LockSpecialist\n3. Muscle");
            string newMemberSpecialty = Console.ReadLine();
            Console.WriteLine($"Enter {crewmember}'s SkillLevel from 1-100");
            int skillLevel = int.Parse(Console.ReadLine());
            Console.WriteLine($"What is {crewmember}'s cut?");
            int percentageCut = int.Parse(Console.ReadLine());
            Console.WriteLine("Is there any one else you'd like to add to this crew? Y/N?");
            string addAnotherCrewMember = Console.ReadLine().ToLower();
            if (addAnotherCrewMember == "y")
            {
                AddCrewMember();
            };
            if (newMemberSpecialty == "1")
            {
                Hacker newCrewMember = new Hacker(crewmember, skillLevel, percentageCut);
                rolodex.Add(newCrewMember);
            }
            if (newMemberSpecialty == "2")
            {
                LockSpecialist newCrewMember = new LockSpecialist(crewmember, skillLevel, percentageCut);
                rolodex.Add(newCrewMember);
            }
            if (newMemberSpecialty == "3")
            {
                Muscle newCrewMember = new Muscle(crewmember, skillLevel, percentageCut);
                rolodex.Add(newCrewMember);
            }

        }
    }
}
