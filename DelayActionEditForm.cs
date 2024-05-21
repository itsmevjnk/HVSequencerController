using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HVSequencerController
{
    public partial class DelayActionEditForm : Form
    {
        private DelayAction _action;

        public DelayActionEditForm(DelayAction action)
        {
            InitializeComponent();
            _action = action;
        }

        private void DelayActionEditForm_Load(object sender, EventArgs e)
        {
            delayActionDur.Value = _action.Duration;
        }

        private void delayActionCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void delayActionOk_Click(object sender, EventArgs e)
        {
            _action.Duration = (int)delayActionDur.Value;
            Close();
        }
    }
}
