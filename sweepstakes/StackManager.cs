using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sweepstakes
{
    class StackManager : ISweepstakesManager
    {
        private Stack<SweepStakes> sweepStack;

        public StackManager()
        {
            sweepStack = new Stack<SweepStakes>();
        }
        SweepStakes ISweepstakesManager.GetSweepStakes()
        {
            SweepStakes sweepStakesHolder = sweepStack.Pop();
            return sweepStakesHolder;
        }

        void ISweepstakesManager.InsertSweepstakes(SweepStakes sweepStakes)
        {
            sweepStack.Push(sweepStakes);
        }
    }
}
