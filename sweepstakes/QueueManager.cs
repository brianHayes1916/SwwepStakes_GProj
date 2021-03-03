using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sweepstakes
{
    class QueueManager : ISweepstakesManager
    {
        private Queue<SweepStakes> sweepStakes;

        public QueueManager()
        {
            sweepStakes = new Queue<SweepStakes>();
        }

        public SweepStakes GetSweepStakes()
        {
            throw new NotImplementedException();
        }

        public void InsertSweepstakes(SweepStakes sweepStakes)
        {

        }
    }
}
