/*
 * Copyright 2024 Thanh Vinh Nguyen (itsmevjnk)
 * This file is part of HVSequencerController.
 * 
 * HVSequencerController is free software: you can redistribute it 
 * and/or modify it under the terms of the GNU General Public License
 * as published by the Free Software Foundation, either version 3 of
 * the License, or (at your option) any later version.

 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.

 * You should have received a copy of the GNU General Public License
 * along with this program.  If not, see <http://www.gnu.org/licenses/>.
 */

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
