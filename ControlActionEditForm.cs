using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Windows.Forms;

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
