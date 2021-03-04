using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sweepstakes
{
    class SweepStakes
    {
        public int numberOfContestants;
        public string name;
        Dictionary<int, Contestant> contestants;

        public SweepStakes(string name)
        {
            numberOfContestants = 0;
            this.name = name;
            contestants = new Dictionary<int, Contestant>();
        }

        public void RegisterContestant()
        {
            Contestant contestant = UserInterface.GetContestantInfo();
            numberOfContestants++;
            contestant.registrationNumber = numberOfContestants;
            contestants.Add(numberOfContestants, contestant);
        }

        public Contestant PickWinner()
        {
            Random random = new Random();
            int holder = random.Next(1, numberOfContestants);
            Contestant winner = contestants[holder];
            return winner;
        }

        public void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine($"The contestant's name is {contestant.firstName} {contestant.lastName}.");
            Console.WriteLine($"Their email is {contestant.emailAddress} and their registration number is {contestant.registrationNumber}.");
        }
    }
}
