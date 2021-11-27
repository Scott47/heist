using System;
using System.Collections.Generic;

namespace Heist
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank regionsOnGallatin = new Bank();
            Hacker rob = new Hacker();
            LockSpecialist janet = new LockSpecialist();
            Muscle janine = new Muscle();

            List<IRobber> rolodex = new List<IRobber>()
            {
                rob, janet, janine
            };
        }
    }
}
