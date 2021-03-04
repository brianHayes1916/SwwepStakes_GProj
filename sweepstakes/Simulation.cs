using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sweepstakes
{
    class Simulation
    {
        public void CreateMarketingFirm()
        {
            bool validChoice = false;
            while (validChoice == false)
            {
                string input = UserInterface.PickDataType();
                if (input == "1")
                {
                    QueueManager queueManager = new QueueManager();
                    MarketingFirm marketingFirm = new MarketingFirm(queueManager);
                    validChoice = true;
                }
                else if (input == "2")
                {
                    StackManager stackManager = new StackManager();
                    MarketingFirm marketingFirm = new MarketingFirm(stackManager);
                    validChoice = true;
                }
                else
                {
                    Console.WriteLine("Invalid input try again.");
                }
            }
        }
    }
}
