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
            //Dependacy starts in the constructor by saying we need a class that is a ISweepstakesManager
            //to be instasiated
            manager = sweepstakesManager;
        }

        public void CreateSweepstakes()
        {
            string sweepName = UserInterface.CreateSweepstakesName();
            SweepStakes sweepStakes = new SweepStakes(sweepName);
            manager.InsertSweepstakes(sweepStakes);
            //This is really where the dependancy injection is evident
            //All IsweepstakesManagers have this method so even though stack and queue add values very differntly
            //they are interchangable here.
        } 
    }
}
