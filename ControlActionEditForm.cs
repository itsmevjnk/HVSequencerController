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
    public partial class ControlActionEditForm : Form
    {
        private ControlAction _action;

        public ControlActionEditForm(ControlAction action)
        {
            InitializeComponent();
            _action = action;
        }

        private void ControlActionEditForm_Load(object sender, EventArgs e)
        {
            ctrlActionChannel.Value = _action.Channel + 1;
            if (_action.Voltage < Device.VOLTAGE_MIN)
            {
                /* channel off */
                ctrlActionOff.Checked = true;
            }
            else
            {
                /* channel on */
                ctrlActionOn.Checked = true;
                ctrlActionVoltage.Value = _action.Voltage;
            }
        }

        private void ctrlActionOff_CheckedChanged(object sender, EventArgs e)
        {
            if (ctrlActionOff.Checked) ctrlActionVoltage.Enabled = false;
        }

        private void ctrlActionOn_CheckedChanged(object sender, EventArgs e)
        {
            if (ctrlActionOn.Checked) ctrlActionVoltage.Enabled = true;
        }

        private void ctrlActionCancel_Click(object sender, EventArgs e)
        {
            Close(); // close this form
        }

        private void ctrlActionOk_Click(object sender, EventArgs e)
        {
            _action.Channel = (int)(ctrlActionChannel.Value - 1);
            if (ctrlActionOff.Checked) _action.Voltage = 0m; // turn off
            else _action.Voltage = ctrlActionVoltage.Value; // turn on
            Close();
        }
    }
}
