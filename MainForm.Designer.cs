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
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            deviceSetupGroup = new GroupBox();
            deviceSetupTable = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            devicePort = new ComboBox();
            deviceSpeed = new ComboBox();
            deviceToggleConnect = new Button();
            actionTabs = new TabControl();
            quickActionTab = new TabPage();
            quickActionsTable = new TableLayoutPanel();
            ch4QuickVolt = new NumericUpDown();
            ch3QuickVolt = new NumericUpDown();
            ch2QuickVolt = new NumericUpDown();
            ch1QuickVolt = new NumericUpDown();
            ch4QuickVoltLabel = new Label();
            ch2QuickVoltLabel = new Label();
            ch3QuickVoltLabel = new Label();
            ch4Toggle = new Button();
            ch3Toggle = new Button();
            ch2Toggle = new Button();
            ch1Toggle = new Button();
            ch1QuickVoltLabel = new Label();
            seqActionsTab = new TabPage();
            seqActionsHorizTable = new TableLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            seqActionsAddDelayItem = new Button();
            seqActionsAddCtrlItem = new Button();
            seqActionsRun = new Button();
            seqActionsMoveItemDown = new Button();
            seqActionsMoveItemUp = new Button();
            seqActionsDelItem = new Button();
            seqActionsEditItem = new Button();
            seqActionsAddResetItem = new Button();
            seqActionsList = new ListBox();
            deviceOutputGroup = new GroupBox();
            deviceOutput = new TextBox();
            creditsLabel = new LinkLabel();
            deviceSetupGroup.SuspendLayout();
            deviceSetupTable.SuspendLayout();
            actionTabs.SuspendLayout();
            quickActionTab.SuspendLayout();
            quickActionsTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ch4QuickVolt).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ch3QuickVolt).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ch2QuickVolt).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ch1QuickVolt).BeginInit();
            seqActionsTab.SuspendLayout();
            seqActionsHorizTable.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            deviceOutputGroup.SuspendLayout();
            SuspendLayout();
            // 
            // deviceSetupGroup
            // 
            deviceSetupGroup.Controls.Add(deviceSetupTable);
            deviceSetupGroup.Location = new Point(12, 318);
            deviceSetupGroup.Name = "deviceSetupGroup";
            deviceSetupGroup.Size = new Size(776, 106);
            deviceSetupGroup.TabIndex = 0;
            deviceSetupGroup.TabStop = false;
            deviceSetupGroup.Text = "Device settings";
            // 
            // deviceSetupTable
            // 
            deviceSetupTable.ColumnCount = 4;
            deviceSetupTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            deviceSetupTable.ColumnStyles.Add(new ColumnStyle());
            deviceSetupTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            deviceSetupTable.ColumnStyles.Add(new ColumnStyle());
            deviceSetupTable.Controls.Add(label1, 0, 0);
            deviceSetupTable.Controls.Add(label2, 2, 0);
            deviceSetupTable.Controls.Add(devicePort, 1, 0);
            deviceSetupTable.Controls.Add(deviceSpeed, 3, 0);
            deviceSetupTable.Controls.Add(deviceToggleConnect, 0, 1);
            deviceSetupTable.Location = new Point(6, 22);
            deviceSetupTable.Name = "deviceSetupTable";
            deviceSetupTable.RowCount = 2;
            deviceSetupTable.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            deviceSetupTable.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            deviceSetupTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            deviceSetupTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            deviceSetupTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            deviceSetupTable.Size = new Size(764, 78);
            deviceSetupTable.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(3, 12);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 0;
            label1.Text = "Serial port";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(385, 12);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 1;
            label2.Text = "Baud rate";
            // 
            // devicePort
            // 
            devicePort.Anchor = AnchorStyles.None;
            devicePort.FormattingEnabled = true;
            devicePort.Location = new Point(104, 8);
            devicePort.Name = "devicePort";
            devicePort.Size = new Size(275, 23);
            devicePort.TabIndex = 2;
            devicePort.DropDown += devicePort_DropDown;
            // 
            // deviceSpeed
            // 
            deviceSpeed.Anchor = AnchorStyles.None;
            deviceSpeed.FormattingEnabled = true;
            deviceSpeed.Items.AddRange(new object[] { "300", "600", "1200", "2400", "4800", "9600", "14400", "19200", "28800", "31250", "38400", "57600", "115200" });
            deviceSpeed.Location = new Point(486, 8);
            deviceSpeed.Name = "deviceSpeed";
            deviceSpeed.Size = new Size(275, 23);
            deviceSpeed.TabIndex = 3;
            deviceSpeed.Text = "9600";
            deviceSpeed.TextUpdate += deviceSpeed_TextUpdate;
            // 
            // deviceToggleConnect
            // 
            deviceToggleConnect.Anchor = AnchorStyles.None;
            deviceSetupTable.SetColumnSpan(deviceToggleConnect, 4);
            deviceToggleConnect.Location = new Point(323, 47);
            deviceToggleConnect.Name = "deviceToggleConnect";
            deviceToggleConnect.Size = new Size(118, 23);
            deviceToggleConnect.TabIndex = 4;
            deviceToggleConnect.Text = "Connect";
            deviceToggleConnect.UseVisualStyleBackColor = true;
            deviceToggleConnect.Click += deviceToggleConnect_Click;
            // 
            // actionTabs
            // 
            actionTabs.Controls.Add(quickActionTab);
            actionTabs.Controls.Add(seqActionsTab);
            actionTabs.Enabled = false;
            actionTabs.Location = new Point(12, 12);
            actionTabs.Name = "actionTabs";
            actionTabs.SelectedIndex = 0;
            actionTabs.Size = new Size(500, 300);
            actionTabs.TabIndex = 2;
            // 
            // quickActionTab
            // 
            quickActionTab.Controls.Add(quickActionsTable);
            quickActionTab.Location = new Point(4, 24);
            quickActionTab.Name = "quickActionTab";
            quickActionTab.Padding = new Padding(3);
            quickActionTab.Size = new Size(492, 272);
            quickActionTab.TabIndex = 0;
            quickActionTab.Text = "Quick actions";
            quickActionTab.UseVisualStyleBackColor = true;
            // 
            // quickActionsTable
            // 
            quickActionsTable.ColumnCount = 4;
            quickActionsTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            quickActionsTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            quickActionsTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            quickActionsTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            quickActionsTable.Controls.Add(ch4QuickVolt, 3, 3);
            quickActionsTable.Controls.Add(ch3QuickVolt, 1, 3);
            quickActionsTable.Controls.Add(ch2QuickVolt, 3, 1);
            quickActionsTable.Controls.Add(ch1QuickVolt, 1, 1);
            quickActionsTable.Controls.Add(ch4QuickVoltLabel, 2, 3);
            quickActionsTable.Controls.Add(ch2QuickVoltLabel, 2, 1);
            quickActionsTable.Controls.Add(ch3QuickVoltLabel, 0, 3);
            quickActionsTable.Controls.Add(ch4Toggle, 2, 2);
            quickActionsTable.Controls.Add(ch3Toggle, 0, 2);
            quickActionsTable.Controls.Add(ch2Toggle, 2, 0);
            quickActionsTable.Controls.Add(ch1Toggle, 0, 0);
            quickActionsTable.Controls.Add(ch1QuickVoltLabel, 0, 1);
            quickActionsTable.Location = new Point(6, 6);
            quickActionsTable.Name = "quickActionsTable";
            quickActionsTable.RowCount = 4;
            quickActionsTable.RowStyles.Add(new RowStyle(SizeType.Percent, 35F));
            quickActionsTable.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            quickActionsTable.RowStyles.Add(new RowStyle(SizeType.Percent, 35F));
            quickActionsTable.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            quickActionsTable.Size = new Size(480, 260);
            quickActionsTable.TabIndex = 0;
            // 
            // ch4QuickVolt
            // 
            ch4QuickVolt.Anchor = AnchorStyles.None;
            ch4QuickVolt.DecimalPlaces = 3;
            ch4QuickVolt.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            ch4QuickVolt.Location = new Point(348, 229);
            ch4QuickVolt.Maximum = new decimal(new int[] { 7000, 0, 0, 196608 });
            ch4QuickVolt.Minimum = new decimal(new int[] { 2000, 0, 0, 196608 });
            ch4QuickVolt.Name = "ch4QuickVolt";
            ch4QuickVolt.Size = new Size(120, 23);
            ch4QuickVolt.TabIndex = 10;
            ch4QuickVolt.Value = new decimal(new int[] { 2000, 0, 0, 196608 });
            ch4QuickVolt.ValueChanged += ch4QuickVolt_ValueChanged;
            // 
            // ch3QuickVolt
            // 
            ch3QuickVolt.Anchor = AnchorStyles.None;
            ch3QuickVolt.DecimalPlaces = 3;
            ch3QuickVolt.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            ch3QuickVolt.Location = new Point(108, 229);
            ch3QuickVolt.Maximum = new decimal(new int[] { 7000, 0, 0, 196608 });
            ch3QuickVolt.Minimum = new decimal(new int[] { 2000, 0, 0, 196608 });
            ch3QuickVolt.Name = "ch3QuickVolt";
            ch3QuickVolt.Size = new Size(120, 23);
            ch3QuickVolt.TabIndex = 9;
            ch3QuickVolt.Value = new decimal(new int[] { 2000, 0, 0, 196608 });
            ch3QuickVolt.ValueChanged += ch3QuickVolt_ValueChanged;
            // 
            // ch2QuickVolt
            // 
            ch2QuickVolt.Anchor = AnchorStyles.None;
            ch2QuickVolt.DecimalPlaces = 3;
            ch2QuickVolt.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            ch2QuickVolt.Location = new Point(348, 99);
            ch2QuickVolt.Maximum = new decimal(new int[] { 7000, 0, 0, 196608 });
            ch2QuickVolt.Minimum = new decimal(new int[] { 2000, 0, 0, 196608 });
            ch2QuickVolt.Name = "ch2QuickVolt";
            ch2QuickVolt.Size = new Size(120, 23);
            ch2QuickVolt.TabIndex = 8;
            ch2QuickVolt.Value = new decimal(new int[] { 2000, 0, 0, 196608 });
            ch2QuickVolt.ValueChanged += ch2QuickVolt_ValueChanged;
            // 
            // ch1QuickVolt
            // 
            ch1QuickVolt.Anchor = AnchorStyles.None;
            ch1QuickVolt.DecimalPlaces = 3;
            ch1QuickVolt.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            ch1QuickVolt.Location = new Point(108, 99);
            ch1QuickVolt.Maximum = new decimal(new int[] { 7000, 0, 0, 196608 });
            ch1QuickVolt.Minimum = new decimal(new int[] { 2000, 0, 0, 196608 });
            ch1QuickVolt.Name = "ch1QuickVolt";
            ch1QuickVolt.Size = new Size(120, 23);
            ch1QuickVolt.TabIndex = 1;
            ch1QuickVolt.Value = new decimal(new int[] { 2000, 0, 0, 196608 });
            ch1QuickVolt.ValueChanged += ch1QuickVolt_ValueChanged;
            // 
            // ch4QuickVoltLabel
            // 
            ch4QuickVoltLabel.Anchor = AnchorStyles.Left;
            ch4QuickVoltLabel.AutoSize = true;
            ch4QuickVoltLabel.Location = new Point(243, 233);
            ch4QuickVoltLabel.Name = "ch4QuickVoltLabel";
            ch4QuickVoltLabel.Size = new Size(73, 15);
            ch4QuickVoltLabel.TabIndex = 7;
            ch4QuickVoltLabel.Text = "Voltage (kV):";
            // 
            // ch2QuickVoltLabel
            // 
            ch2QuickVoltLabel.Anchor = AnchorStyles.Left;
            ch2QuickVoltLabel.AutoSize = true;
            ch2QuickVoltLabel.Location = new Point(243, 103);
            ch2QuickVoltLabel.Name = "ch2QuickVoltLabel";
            ch2QuickVoltLabel.Size = new Size(73, 15);
            ch2QuickVoltLabel.TabIndex = 6;
            ch2QuickVoltLabel.Text = "Voltage (kV):";
            // 
            // ch3QuickVoltLabel
            // 
            ch3QuickVoltLabel.Anchor = AnchorStyles.Left;
            ch3QuickVoltLabel.AutoSize = true;
            ch3QuickVoltLabel.Location = new Point(3, 233);
            ch3QuickVoltLabel.Name = "ch3QuickVoltLabel";
            ch3QuickVoltLabel.Size = new Size(73, 15);
            ch3QuickVoltLabel.TabIndex = 5;
            ch3QuickVoltLabel.Text = "Voltage (kV):";
            // 
            // ch4Toggle
            // 
            ch4Toggle.Anchor = AnchorStyles.None;
            quickActionsTable.SetColumnSpan(ch4Toggle, 2);
            ch4Toggle.Location = new Point(300, 147);
            ch4Toggle.Name = "ch4Toggle";
            ch4Toggle.Size = new Size(119, 56);
            ch4Toggle.TabIndex = 3;
            ch4Toggle.Text = "Turn ON CH4";
            ch4Toggle.UseVisualStyleBackColor = true;
            ch4Toggle.Click += ch4Toggle_Click;
            // 
            // ch3Toggle
            // 
            ch3Toggle.Anchor = AnchorStyles.None;
            quickActionsTable.SetColumnSpan(ch3Toggle, 2);
            ch3Toggle.Location = new Point(60, 147);
            ch3Toggle.Name = "ch3Toggle";
            ch3Toggle.Size = new Size(119, 56);
            ch3Toggle.TabIndex = 2;
            ch3Toggle.Text = "Turn ON CH3";
            ch3Toggle.UseVisualStyleBackColor = true;
            ch3Toggle.Click += ch3Toggle_Click;
            // 
            // ch2Toggle
            // 
            ch2Toggle.Anchor = AnchorStyles.None;
            quickActionsTable.SetColumnSpan(ch2Toggle, 2);
            ch2Toggle.Location = new Point(300, 17);
            ch2Toggle.Name = "ch2Toggle";
            ch2Toggle.Size = new Size(119, 56);
            ch2Toggle.TabIndex = 1;
            ch2Toggle.Text = "Turn ON CH2";
            ch2Toggle.UseVisualStyleBackColor = true;
            ch2Toggle.Click += ch2Toggle_Click;
            // 
            // ch1Toggle
            // 
            ch1Toggle.Anchor = AnchorStyles.None;
            quickActionsTable.SetColumnSpan(ch1Toggle, 2);
            ch1Toggle.Location = new Point(60, 17);
            ch1Toggle.Name = "ch1Toggle";
            ch1Toggle.Size = new Size(119, 56);
            ch1Toggle.TabIndex = 0;
            ch1Toggle.Text = "Turn ON CH1";
            ch1Toggle.UseVisualStyleBackColor = true;
            ch1Toggle.Click += ch1Toggle_Click;
            // 
            // ch1QuickVoltLabel
            // 
            ch1QuickVoltLabel.Anchor = AnchorStyles.Left;
            ch1QuickVoltLabel.AutoSize = true;
            ch1QuickVoltLabel.Location = new Point(3, 103);
            ch1QuickVoltLabel.Name = "ch1QuickVoltLabel";
            ch1QuickVoltLabel.Size = new Size(73, 15);
            ch1QuickVoltLabel.TabIndex = 4;
            ch1QuickVoltLabel.Text = "Voltage (kV):";
            // 
            // seqActionsTab
            // 
            seqActionsTab.Controls.Add(seqActionsHorizTable);
            seqActionsTab.Location = new Point(4, 24);
            seqActionsTab.Name = "seqActionsTab";
            seqActionsTab.Padding = new Padding(3);
            seqActionsTab.Size = new Size(492, 272);
            seqActionsTab.TabIndex = 1;
            seqActionsTab.Text = "Sequential actions";
            seqActionsTab.UseVisualStyleBackColor = true;
            // 
            // seqActionsHorizTable
            // 
            seqActionsHorizTable.ColumnCount = 2;
            seqActionsHorizTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            seqActionsHorizTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            seqActionsHorizTable.Controls.Add(tableLayoutPanel1, 1, 0);
            seqActionsHorizTable.Controls.Add(seqActionsList, 0, 0);
            seqActionsHorizTable.Location = new Point(6, 6);
            seqActionsHorizTable.Name = "seqActionsHorizTable";
            seqActionsHorizTable.RowCount = 1;
            seqActionsHorizTable.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            seqActionsHorizTable.Size = new Size(480, 260);
            seqActionsHorizTable.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(seqActionsAddDelayItem, 0, 1);
            tableLayoutPanel1.Controls.Add(seqActionsAddCtrlItem, 0, 0);
            tableLayoutPanel1.Controls.Add(seqActionsRun, 0, 7);
            tableLayoutPanel1.Controls.Add(seqActionsMoveItemDown, 0, 6);
            tableLayoutPanel1.Controls.Add(seqActionsMoveItemUp, 0, 5);
            tableLayoutPanel1.Controls.Add(seqActionsDelItem, 0, 4);
            tableLayoutPanel1.Controls.Add(seqActionsEditItem, 0, 3);
            tableLayoutPanel1.Controls.Add(seqActionsAddResetItem, 0, 2);
            tableLayoutPanel1.Location = new Point(387, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 8;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.Size = new Size(90, 244);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // seqActionsAddDelayItem
            // 
            seqActionsAddDelayItem.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            seqActionsAddDelayItem.Location = new Point(3, 33);
            seqActionsAddDelayItem.Name = "seqActionsAddDelayItem";
            seqActionsAddDelayItem.Size = new Size(84, 23);
            seqActionsAddDelayItem.TabIndex = 6;
            seqActionsAddDelayItem.Text = "Add delay";
            seqActionsAddDelayItem.UseVisualStyleBackColor = true;
            seqActionsAddDelayItem.Click += seqActionsAddDelayItem_Click;
            // 
            // seqActionsAddCtrlItem
            // 
            seqActionsAddCtrlItem.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            seqActionsAddCtrlItem.Location = new Point(3, 3);
            seqActionsAddCtrlItem.Name = "seqActionsAddCtrlItem";
            seqActionsAddCtrlItem.Size = new Size(84, 23);
            seqActionsAddCtrlItem.TabIndex = 0;
            seqActionsAddCtrlItem.Text = "Add control";
            seqActionsAddCtrlItem.UseVisualStyleBackColor = true;
            seqActionsAddCtrlItem.Click += seqActionsAddCtrlItem_Click;
            // 
            // seqActionsRun
            // 
            seqActionsRun.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            seqActionsRun.Enabled = false;
            seqActionsRun.Location = new Point(3, 215);
            seqActionsRun.Name = "seqActionsRun";
            seqActionsRun.Size = new Size(84, 23);
            seqActionsRun.TabIndex = 5;
            seqActionsRun.Text = "Execute";
            seqActionsRun.UseVisualStyleBackColor = true;
            seqActionsRun.Click += seqActionsRun_Click;
            // 
            // seqActionsMoveItemDown
            // 
            seqActionsMoveItemDown.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            seqActionsMoveItemDown.Enabled = false;
            seqActionsMoveItemDown.Location = new Point(3, 183);
            seqActionsMoveItemDown.Name = "seqActionsMoveItemDown";
            seqActionsMoveItemDown.Size = new Size(84, 23);
            seqActionsMoveItemDown.TabIndex = 4;
            seqActionsMoveItemDown.Text = "Move down";
            seqActionsMoveItemDown.UseVisualStyleBackColor = true;
            seqActionsMoveItemDown.Click += seqActionsMoveItemDown_Click;
            // 
            // seqActionsMoveItemUp
            // 
            seqActionsMoveItemUp.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            seqActionsMoveItemUp.Enabled = false;
            seqActionsMoveItemUp.Location = new Point(3, 153);
            seqActionsMoveItemUp.Name = "seqActionsMoveItemUp";
            seqActionsMoveItemUp.Size = new Size(84, 23);
            seqActionsMoveItemUp.TabIndex = 3;
            seqActionsMoveItemUp.Text = "Move up";
            seqActionsMoveItemUp.UseVisualStyleBackColor = true;
            seqActionsMoveItemUp.Click += seqActionsMoveItemUp_Click;
            // 
            // seqActionsDelItem
            // 
            seqActionsDelItem.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            seqActionsDelItem.Enabled = false;
            seqActionsDelItem.Location = new Point(3, 123);
            seqActionsDelItem.Name = "seqActionsDelItem";
            seqActionsDelItem.Size = new Size(84, 23);
            seqActionsDelItem.TabIndex = 2;
            seqActionsDelItem.Text = "Remove";
            seqActionsDelItem.UseVisualStyleBackColor = true;
            seqActionsDelItem.Click += seqActionsDelItem_Click;
            // 
            // seqActionsEditItem
            // 
            seqActionsEditItem.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            seqActionsEditItem.Enabled = false;
            seqActionsEditItem.Location = new Point(3, 93);
            seqActionsEditItem.Name = "seqActionsEditItem";
            seqActionsEditItem.Size = new Size(84, 23);
            seqActionsEditItem.TabIndex = 1;
            seqActionsEditItem.Text = "Edit";
            seqActionsEditItem.UseVisualStyleBackColor = true;
            seqActionsEditItem.Click += seqActionsEditItem_Click;
            // 
            // seqActionsAddResetItem
            // 
            seqActionsAddResetItem.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            seqActionsAddResetItem.Location = new Point(3, 63);
            seqActionsAddResetItem.Name = "seqActionsAddResetItem";
            seqActionsAddResetItem.Size = new Size(84, 23);
            seqActionsAddResetItem.TabIndex = 7;
            seqActionsAddResetItem.Text = "Add reset";
            seqActionsAddResetItem.UseVisualStyleBackColor = true;
            seqActionsAddResetItem.Click += seqActionsAddResetItem_Click;
            // 
            // seqActionsList
            // 
            seqActionsList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            seqActionsList.FormattingEnabled = true;
            seqActionsList.ItemHeight = 15;
            seqActionsList.Location = new Point(3, 3);
            seqActionsList.Name = "seqActionsList";
            seqActionsList.Size = new Size(378, 244);
            seqActionsList.TabIndex = 1;
            seqActionsList.SelectedIndexChanged += seqActionsList_SelectedIndexChanged;
            seqActionsList.DoubleClick += seqActionsList_DoubleClick;
            // 
            // deviceOutputGroup
            // 
            deviceOutputGroup.Controls.Add(deviceOutput);
            deviceOutputGroup.Location = new Point(518, 36);
            deviceOutputGroup.Name = "deviceOutputGroup";
            deviceOutputGroup.Size = new Size(270, 276);
            deviceOutputGroup.TabIndex = 3;
            deviceOutputGroup.TabStop = false;
            deviceOutputGroup.Text = "Device output";
            // 
            // deviceOutput
            // 
            deviceOutput.Location = new Point(6, 22);
            deviceOutput.Multiline = true;
            deviceOutput.Name = "deviceOutput";
            deviceOutput.ReadOnly = true;
            deviceOutput.Size = new Size(255, 248);
            deviceOutput.TabIndex = 0;
            // 
            // creditsLabel
            // 
            creditsLabel.AutoSize = true;
            creditsLabel.Location = new Point(12, 427);
            creditsLabel.Name = "creditsLabel";
            creditsLabel.Size = new Size(513, 15);
            creditsLabel.TabIndex = 4;
            creditsLabel.TabStop = true;
            creditsLabel.Text = "© 2024 itsmevjnk (Thanh Vinh Nguyen) - https://github.com/itsmevjnk/HVSequencerController";
            creditsLabel.LinkClicked += creditsLabel_LinkClicked;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(creditsLabel);
            Controls.Add(deviceOutputGroup);
            Controls.Add(actionTabs);
            Controls.Add(deviceSetupGroup);
            Name = "MainForm";
            Text = "HV Sequencer Controller";
            Load += MainForm_Load;
            deviceSetupGroup.ResumeLayout(false);
            deviceSetupTable.ResumeLayout(false);
            deviceSetupTable.PerformLayout();
            actionTabs.ResumeLayout(false);
            quickActionTab.ResumeLayout(false);
            quickActionsTable.ResumeLayout(false);
            quickActionsTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ch4QuickVolt).EndInit();
            ((System.ComponentModel.ISupportInitialize)ch3QuickVolt).EndInit();
            ((System.ComponentModel.ISupportInitialize)ch2QuickVolt).EndInit();
            ((System.ComponentModel.ISupportInitialize)ch1QuickVolt).EndInit();
            seqActionsTab.ResumeLayout(false);
            seqActionsHorizTable.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            deviceOutputGroup.ResumeLayout(false);
            deviceOutputGroup.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox deviceSetupGroup;
        private TableLayoutPanel deviceSetupTable;
        private Label label1;
        private Label label2;
        private ComboBox devicePort;
        private ComboBox deviceSpeed;
        private Button deviceToggleConnect;
        private TabControl actionTabs;
        private TabPage quickActionTab;
        private TabPage seqActionsTab;
        private GroupBox deviceOutputGroup;
        private TextBox deviceOutput;
        private TableLayoutPanel quickActionsTable;
        private Button ch1Toggle;
        private Button ch2Toggle;
        private Button ch3Toggle;
        private Button ch4Toggle;
        private Label ch1QuickVoltLabel;
        private Label ch4QuickVoltLabel;
        private Label ch2QuickVoltLabel;
        private Label ch3QuickVoltLabel;
        private NumericUpDown ch4QuickVolt;
        private NumericUpDown ch3QuickVolt;
        private NumericUpDown ch2QuickVolt;
        private NumericUpDown ch1QuickVolt;
        private LinkLabel creditsLabel;
        private TableLayoutPanel seqActionsHorizTable;
        private TableLayoutPanel tableLayoutPanel1;
        private Button seqActionsAddCtrlItem;
        private Button seqActionsEditItem;
        private Button seqActionsDelItem;
        private Button seqActionsMoveItemUp;
        private Button seqActionsMoveItemDown;
        private Button seqActionsRun;
        private ListBox seqActionsList;
        private Button seqActionsAddDelayItem;
        private Button seqActionsAddResetItem;
    }
}
