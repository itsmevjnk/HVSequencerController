using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HVSequencerController
{
    public class DelayAction : ISeqAction
    {
        public int Duration = 100; // in milliseconds

        public void Execute()
        {
            Thread.Sleep(Duration);
        }

        public override string ToString()
        {
            return $"Wait for {Duration} ms";
        }
    }
}
