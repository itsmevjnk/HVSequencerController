using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HVSequencerController
{
    public class ResetAction : ISeqAction
    {
        private Device _device;
        public ResetAction(Device device)
        {
            _device = device;
        }

        public void Execute()
        {
            _device.Reset();
        }

        public override string ToString()
        {
            return "Reset channels";
        }
    }
}
