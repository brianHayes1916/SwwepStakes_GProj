using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sweepstakes
{
    class MarketingFirm
    {
        private ISweepstakesManager manager;

        public MarketingFirm(ISweepstakesManager sweepstakesManager)
        {
            manager = sweepstakesManager;
        }

        public void CreateSweepstakes()
        {
            string sweepName = UserInterface.CreateSweepstakesName();
            SweepStakes sweepStakes = new SweepStakes(sweepName);
            manager.InsertSweepstakes(sweepStakes);
        } 
    }
}
