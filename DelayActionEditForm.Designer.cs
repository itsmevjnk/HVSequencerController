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
    partial class DelayActionEditForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            delayActionOptionsTable = new TableLayoutPanel();
            delayActionDurLabel = new Label();
            delayActionDur = new NumericUpDown();
            tableLayoutPanel2 = new TableLayoutPanel();
            delayActionButtonsTable = new TableLayoutPanel();
            delayActionCancel = new Button();
            delayActionOk = new Button();
            delayActionOptionsTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)delayActionDur).BeginInit();
            delayActionButtonsTable.SuspendLayout();
            SuspendLayout();
            // 
            // delayActionOptionsTable
            // 
            delayActionOptionsTable.ColumnCount = 2;
            delayActionOptionsTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38.15261F));
            delayActionOptionsTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 61.84739F));
            delayActionOptionsTable.Controls.Add(delayActionDurLabel, 0, 0);
            delayActionOptionsTable.Controls.Add(delayActionDur, 1, 0);
            delayActionOptionsTable.Location = new Point(12, 12);
            delayActionOptionsTable.Name = "delayActionOptionsTable";
            delayActionOptionsTable.RowCount = 1;
            delayActionOptionsTable.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            delayActionOptionsTable.Size = new Size(249, 38);
            delayActionOptionsTable.TabIndex = 0;
            // 
            // delayActionDurLabel
            // 
            delayActionDurLabel.Anchor = AnchorStyles.Left;
            delayActionDurLabel.AutoSize = true;
            delayActionDurLabel.Location = new Point(3, 11);
            delayActionDurLabel.Name = "delayActionDurLabel";
            delayActionDurLabel.Size = new Size(83, 15);
            delayActionDurLabel.TabIndex = 0;
            delayActionDurLabel.Text = "Duration (ms):";
            // 
            // delayActionDur
            // 
            delayActionDur.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            delayActionDur.Increment = new decimal(new int[] { 100, 0, 0, 0 });
            delayActionDur.Location = new Point(98, 7);
            delayActionDur.Maximum = new decimal(new int[] { -1, -1, -1, 0 });
            delayActionDur.Name = "delayActionDur";
            delayActionDur.Size = new Size(148, 23);
            delayActionDur.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.Size = new Size(200, 100);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // delayActionButtonsTable
            // 
            delayActionButtonsTable.ColumnCount = 2;
            delayActionButtonsTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            delayActionButtonsTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            delayActionButtonsTable.Controls.Add(delayActionCancel, 0, 0);
            delayActionButtonsTable.Controls.Add(delayActionOk, 1, 0);
            delayActionButtonsTable.Location = new Point(12, 56);
            delayActionButtonsTable.Name = "delayActionButtonsTable";
            delayActionButtonsTable.RowCount = 1;
            delayActionButtonsTable.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            delayActionButtonsTable.Size = new Size(249, 30);
            delayActionButtonsTable.TabIndex = 1;
            // 
            // delayActionCancel
            // 
            delayActionCancel.Anchor = AnchorStyles.None;
            delayActionCancel.Location = new Point(24, 3);
            delayActionCancel.Name = "delayActionCancel";
            delayActionCancel.Size = new Size(75, 23);
            delayActionCancel.TabIndex = 0;
            delayActionCancel.Text = "Cancel";
            delayActionCancel.UseVisualStyleBackColor = true;
            delayActionCancel.Click += delayActionCancel_Click;
            // 
            // delayActionOk
            // 
            delayActionOk.Anchor = AnchorStyles.None;
            delayActionOk.Location = new Point(149, 3);
            delayActionOk.Name = "delayActionOk";
            delayActionOk.Size = new Size(75, 23);
            delayActionOk.TabIndex = 1;
            delayActionOk.Text = "Save";
            delayActionOk.UseVisualStyleBackColor = true;
            delayActionOk.Click += delayActionOk_Click;
            // 
            // DelayActionEditForm
            // 
            AcceptButton = delayActionOk;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = delayActionCancel;
            ClientSize = new Size(273, 98);
            Controls.Add(delayActionButtonsTable);
            Controls.Add(delayActionOptionsTable);
            Name = "DelayActionEditForm";
            Text = "Edit delay action";
            Load += DelayActionEditForm_Load;
            delayActionOptionsTable.ResumeLayout(false);
            delayActionOptionsTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)delayActionDur).EndInit();
            delayActionButtonsTable.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel delayActionOptionsTable;
        private TableLayoutPanel tableLayoutPanel2;
        private Label delayActionDurLabel;
        private NumericUpDown delayActionDur;
        private TableLayoutPanel delayActionButtonsTable;
        private Button delayActionCancel;
        private Button delayActionOk;
    }
}