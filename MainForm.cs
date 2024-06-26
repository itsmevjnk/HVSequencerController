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

using System.ComponentModel;

namespace HVSequencerController
{
    public partial class MainForm : Form
    {
        Device device = new Device(); // HV sequencer device
        BindingList<ISeqAction> seqActions = new BindingList<ISeqAction>(); // list of actions (for sequential actions)

        /* update list of available ports */
        private void UpdatePortsMenu()
        {
            devicePort.Items.Clear();
            devicePort.Items.AddRange(Device.GetPorts());
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            /* initialise ports menu */
            UpdatePortsMenu();
            if (devicePort.Items.Count > 0) devicePort.SelectedIndex = 0; // select first port if available

            seqActionsList.DataSource = seqActions;
        }

        public MainForm()
        {
            InitializeComponent();

            device.OnDataReceived.Add(data =>
            {
                deviceOutput.Invoke(() =>
                {
                    deviceOutput.AppendText(data);
                });
            });
        }

        private void UpdateQuickChannelVoltage(int channel)
        {
            Button toggle; NumericUpDown voltSel; decimal voltValue;
            switch (channel)
            {
                case 0: toggle = ch1Toggle; voltSel = ch1QuickVolt; voltValue = device.Ch1Volt; break;
                case 1: toggle = ch2Toggle; voltSel = ch2QuickVolt; voltValue = device.Ch2Volt; break;
                case 2: toggle = ch3Toggle; voltSel = ch3QuickVolt; voltValue = device.Ch3Volt; break;
                case 3: toggle = ch4Toggle; voltSel = ch4QuickVolt; voltValue = device.Ch4Volt; break;
                default: throw new InvalidOperationException($"Invalid channel {channel} selected");
            }

            if (voltValue >= Device.VOLTAGE_MIN)
            {
                /* channel is on */
                voltSel.Value = voltValue;
                toggle.Text = $"Turn OFF CH{channel + 1}";
            }
            else
            {
                /* channel is off */
                toggle.Text = $"Turn ON CH{channel + 1}";
            }
        }

        private void UpdateQuickVoltages()
        {
            for (int ch = 0; ch < 4; ch++) UpdateQuickChannelVoltage(ch);
        }

        private void deviceToggleConnect_Click(object sender, EventArgs e)
        {
            deviceToggleConnect.Enabled = false; // disable button until we're done
            if (!device.Connected)
            {
                /* connect to device */
                try
                {
                    deviceOutput.Text = ""; // clear output box
                    device.Connect(devicePort.Text, int.Parse(deviceSpeed.Text));
                    device.Reset(); UpdateQuickVoltages();
                    deviceToggleConnect.Text = "Disconnect";
                    devicePort.Enabled = false; deviceSpeed.Enabled = false; // disable menu options so user can't change them
                    actionTabs.Enabled = true; // enable action tabs
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while connecting to device:{Environment.NewLine}{ex.GetType()}: {ex.Message}", "Connection error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                /* disconnect from device */
                device.Disconnect();
                devicePort.Enabled = true; deviceSpeed.Enabled = true;
                actionTabs.Enabled = false;
                deviceToggleConnect.Text = "Connect";
            }
            deviceToggleConnect.Enabled = true;
        }

        private void deviceSpeed_TextUpdate(object sender, EventArgs e)
        {
            /* input validation */
            int baud; // discarded
            deviceToggleConnect.Enabled = int.TryParse(deviceSpeed.Text, out baud); // disable connect button if we're entering invalid baud rate
        }

        private void devicePort_DropDown(object sender, EventArgs e)
        {
            UpdatePortsMenu();
        }

        private void ch1Toggle_Click(object sender, EventArgs e)
        {
            if (device.Ch1Volt < Device.VOLTAGE_MIN) device.Ch1Volt = ch1QuickVolt.Value; // turn on channel
            else device.Ch1Volt = 0m; // turn off channel
            UpdateQuickChannelVoltage(0); // update
        }

        private void ch2Toggle_Click(object sender, EventArgs e)
        {
            if (device.Ch2Volt < Device.VOLTAGE_MIN) device.Ch2Volt = ch2QuickVolt.Value; // turn on channel
            else device.Ch2Volt = 0m; // turn off channel
            UpdateQuickChannelVoltage(1); // update
        }

        private void ch3Toggle_Click(object sender, EventArgs e)
        {
            if (device.Ch3Volt < Device.VOLTAGE_MIN) device.Ch3Volt = ch3QuickVolt.Value; // turn on channel
            else device.Ch3Volt = 0m; // turn off channel
            UpdateQuickChannelVoltage(2); // update
        }

        private void ch4Toggle_Click(object sender, EventArgs e)
        {
            if (device.Ch4Volt < Device.VOLTAGE_MIN) device.Ch4Volt = ch4QuickVolt.Value; // turn on channel
            else device.Ch4Volt = 0m; // turn off channel
            UpdateQuickChannelVoltage(3); // update
        }

        private void ch1QuickVolt_ValueChanged(object sender, EventArgs e)
        {
            if (device.Ch1Volt >= Device.VOLTAGE_MIN) device.Ch1Volt = ch1QuickVolt.Value; // update if channel is already on
        }

        private void ch2QuickVolt_ValueChanged(object sender, EventArgs e)
        {
            if (device.Ch2Volt >= Device.VOLTAGE_MIN) device.Ch2Volt = ch2QuickVolt.Value; // update if channel is already on
        }

        private void ch3QuickVolt_ValueChanged(object sender, EventArgs e)
        {
            if (device.Ch3Volt >= Device.VOLTAGE_MIN) device.Ch3Volt = ch3QuickVolt.Value; // update if channel is already on
        }

        private void ch4QuickVolt_ValueChanged(object sender, EventArgs e)
        {
            if (device.Ch4Volt >= Device.VOLTAGE_MIN) device.Ch4Volt = ch4QuickVolt.Value; // update if channel is already on
        }

        private void creditsLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            /* show copyright info */
            MessageBox.Show(
                "HVSequencerController - Controller software for HV sequencer\r\nCopyright 2024 Thanh Vinh Nguyen\r\n\r\nThis program is free software: you can redistribute it and/or modify it under the terms of the GNU General Public License as published by the Free Software Foundation, either version 3 of the License, or (at your option) any later version.\r\n\r\nThis program is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU General Public License for more details.\r\n\r\nYou should have received a copy of the GNU General Public License along with this program.  If not, see <http://www.gnu.org/licenses/>.",
                "About HVSequencerController",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void seqActionsAddDelayItem_Click(object sender, EventArgs e)
        {
            int index = seqActionsList.SelectedIndex + 1; // add to index after our selected index (-1 if nothing was selected)
            seqActions.Insert(index, new DelayAction());
            seqActionsRun.Enabled = true; // there's an item so we can run now
            seqActionsList.SetSelected(index, true); // select last item
            seqActionsEditItem_Click(sender, e); // open edit dialog
        }

        private void seqActionsAddCtrlItem_Click(object sender, EventArgs e)
        {
            int index = seqActionsList.SelectedIndex + 1; // add to index after our selected index (-1 if nothing was selected)
            seqActions.Insert(index, new ControlAction(device)); // add to last
            seqActionsRun.Enabled = true;
            seqActionsList.SetSelected(index, true); // select last item
            seqActionsEditItem_Click(sender, e); // open edit dialog
        }

        private void seqActionsDelItem_Click(object sender, EventArgs e)
        {
            int selectedItem = seqActionsList.SelectedIndex;
            seqActions.RemoveAt(selectedItem); // and delete it
            if (seqActions.Count == 0) seqActionsRun.Enabled = false; // no actions to run
        }

        private void seqActionsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            seqActionsDelItem.Enabled = (seqActionsList.SelectedIndex >= 0); // enable delete only if an item is selected
            seqActionsEditItem.Enabled = (seqActionsDelItem.Enabled && seqActions[seqActionsList.SelectedIndex] is not ResetAction); // enable edit if we're selecting an item that's not reset action (because it is not editable)
            seqActionsMoveItemUp.Enabled = (seqActionsList.SelectedIndex > 0); // we can move any item that's not the first one up
            seqActionsMoveItemDown.Enabled = (seqActionsList.SelectedIndex < seqActions.Count - 1); // and we can move any item that's not the last one down
        }

        private void seqActionsMoveItemUp_Click(object sender, EventArgs e)
        {
            int selectedItem = seqActionsList.SelectedIndex;
            var temp = seqActions[selectedItem];
            seqActions[selectedItem] = seqActions[selectedItem - 1]; seqActions[selectedItem - 1] = temp;
            seqActionsList.SetSelected(selectedItem - 1, true); // move our selection up too
        }

        private void seqActionsMoveItemDown_Click(object sender, EventArgs e)
        {
            int selectedItem = seqActionsList.SelectedIndex;
            var temp = seqActions[selectedItem];
            seqActions[selectedItem] = seqActions[selectedItem + 1]; seqActions[selectedItem + 1] = temp;
            seqActionsList.SetSelected(selectedItem + 1, true); // move our selection down too
        }

        private void seqActionsRun_Click(object sender, EventArgs e)
        {
            new Thread(() =>
            {
                actionTabs.Invoke(() => { actionTabs.Enabled = false; }); // disable tabs so we can't do anything else
                foreach (var action in seqActions) action.Execute(); // execute each action
                actionTabs.Invoke(() => { actionTabs.Enabled = true; });
            }).Start(); // start in new thread (so we don't block our UI)
        }

        private void seqActionsEditItem_Click(object sender, EventArgs e)
        {
            var selectedAction = seqActions[seqActionsList.SelectedIndex];

            if (selectedAction is ControlAction) new ControlActionEditForm((ControlAction)selectedAction).ShowDialog();
            else if (selectedAction is DelayAction) new DelayActionEditForm((DelayAction)selectedAction).ShowDialog();
            else throw new InvalidOperationException("Selected item is neither ControlAction nor DelayAction");

            seqActionsList.DrawMode = DrawMode.OwnerDrawFixed; seqActionsList.DrawMode = DrawMode.Normal; // force refresh
        }

        private void seqActionsAddResetItem_Click(object sender, EventArgs e)
        {
            int index = seqActionsList.SelectedIndex + 1; // add to index after our selected index (-1 if nothing was selected)
            seqActions.Insert(index, new ResetAction(device)); // add to last
            seqActionsRun.Enabled = true;
            seqActionsList.SetSelected(index, true); // select last item
        }

        private void seqActionsList_DoubleClick(object sender, EventArgs e)
        {
            if (seqActionsEditItem.Enabled) seqActionsEditItem_Click(sender, e); // treat double click as edit
        }
    }
}
