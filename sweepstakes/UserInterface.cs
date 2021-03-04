using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sweepstakes
{
    static class UserInterface
    {
        public static Contestant GetContestantInfo()
        {
            Console.WriteLine("Please enter the first name of the contestant.");
            string first = Console.ReadLine();
            Console.WriteLine("Please enter the Last name of the contestant.");
            string last = Console.ReadLine();
            Console.WriteLine("Please enter the email address of the contestant.");
            string email = Console.ReadLine();
            Contestant contestant = new Contestant(first, last, email, 1);
            return contestant;
        }
        public static string CreateSweepstakesName()
        {
            Console.WriteLine("Please enter the name of the new sweepstakes.");
            string name = Console.ReadLine();
            return name;
        }
    }
}
