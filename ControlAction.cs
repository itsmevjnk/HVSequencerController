using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HVSequencerController
{
    public class ControlAction : ISeqAction
    {
        public int Channel = 0;
        public decimal Voltage = 0m; // 0 = off

        private Device _device;
        public ControlAction(Device device) {  _device = device; }

        public void Execute()
        {
            switch (Channel)
            {
                case 0: _device.Ch1Volt = Voltage; break;
                case 1: _device.Ch2Volt = Voltage; break;
                case 2: _device.Ch3Volt = Voltage; break;
                case 3: _device.Ch4Volt = Voltage; break;
                default: throw new InvalidOperationException($"Invalid channel {Channel + 1}");
            }
        }

        public override string ToString()
        {
            if (Voltage < Device.VOLTAGE_MIN) return $"Turn off channel {Channel + 1}";
            return $"Set channel {Channel + 1} to {Voltage:0.000} kV";
        }
    }
}
