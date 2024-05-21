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
