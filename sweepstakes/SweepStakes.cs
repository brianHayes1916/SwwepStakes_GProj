using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sweepstakes
{
    class SweepStakes
    {
        public string name;
        Dictionary<int, Contestant> contestants;

        public SweepStakes(string name)
        {
            this.name = name;
            contestants = new Dictionary<int, Contestant>();
        }

        public void RegisterContestant(Contestant contestant)
        {
            contestants.Add(contestant.registrationNumber, contestant);
        }

        public Contestant PickWinner()
        {
            contestants
        }

        public void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine($"The contestant's name is {contestant.firstName} {contestant.lastName}.");
            Console.WriteLine($"Their email is {contestant.emailAddress} and their registration number is {contestant.registrationNumber}.");
        }
    }
}
