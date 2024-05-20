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
            button1 = new Button();
            label3 = new Label();
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
            scriptedActionTab = new TabPage();
            deviceOutputGroup = new GroupBox();
            deviceOutput = new TextBox();
            deviceSetupGroup.SuspendLayout();
            deviceSetupTable.SuspendLayout();
            actionTabs.SuspendLayout();
            quickActionTab.SuspendLayout();
            quickActionsTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ch4QuickVolt).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ch3QuickVolt).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ch2QuickVolt).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ch1QuickVolt).BeginInit();
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
            deviceSetupTable.Controls.Add(button1, 0, 1);
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
            // 
            // deviceSpeed
            // 
            deviceSpeed.Anchor = AnchorStyles.None;
            deviceSpeed.FormattingEnabled = true;
            deviceSpeed.Location = new Point(486, 8);
            deviceSpeed.Name = "deviceSpeed";
            deviceSpeed.Size = new Size(275, 23);
            deviceSpeed.TabIndex = 3;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            deviceSetupTable.SetColumnSpan(button1, 4);
            button1.Location = new Point(323, 47);
            button1.Name = "button1";
            button1.Size = new Size(118, 23);
            button1.TabIndex = 4;
            button1.Text = "Connect";
            button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Enabled = false;
            label3.Location = new Point(12, 427);
            label3.Name = "label3";
            label3.Size = new Size(389, 15);
            label3.TabIndex = 1;
            label3.Text = "(C) 2024 itsmevjnk (Thanh Vinh Nguyen) - https://github.com/itsmevjnk";
            // 
            // actionTabs
            // 
            actionTabs.Controls.Add(quickActionTab);
            actionTabs.Controls.Add(scriptedActionTab);
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
            ch4QuickVolt.Maximum = new decimal(new int[] { 7, 0, 0, 0 });
            ch4QuickVolt.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            ch4QuickVolt.Name = "ch4QuickVolt";
            ch4QuickVolt.Size = new Size(120, 23);
            ch4QuickVolt.TabIndex = 10;
            ch4QuickVolt.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // ch3QuickVolt
            // 
            ch3QuickVolt.Anchor = AnchorStyles.None;
            ch3QuickVolt.DecimalPlaces = 3;
            ch3QuickVolt.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            ch3QuickVolt.Location = new Point(108, 229);
            ch3QuickVolt.Maximum = new decimal(new int[] { 7, 0, 0, 0 });
            ch3QuickVolt.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            ch3QuickVolt.Name = "ch3QuickVolt";
            ch3QuickVolt.Size = new Size(120, 23);
            ch3QuickVolt.TabIndex = 9;
            ch3QuickVolt.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // ch2QuickVolt
            // 
            ch2QuickVolt.Anchor = AnchorStyles.None;
            ch2QuickVolt.DecimalPlaces = 3;
            ch2QuickVolt.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            ch2QuickVolt.Location = new Point(348, 99);
            ch2QuickVolt.Maximum = new decimal(new int[] { 7, 0, 0, 0 });
            ch2QuickVolt.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            ch2QuickVolt.Name = "ch2QuickVolt";
            ch2QuickVolt.Size = new Size(120, 23);
            ch2QuickVolt.TabIndex = 8;
            ch2QuickVolt.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // ch1QuickVolt
            // 
            ch1QuickVolt.Anchor = AnchorStyles.None;
            ch1QuickVolt.DecimalPlaces = 3;
            ch1QuickVolt.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            ch1QuickVolt.Location = new Point(108, 99);
            ch1QuickVolt.Maximum = new decimal(new int[] { 7, 0, 0, 0 });
            ch1QuickVolt.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            ch1QuickVolt.Name = "ch1QuickVolt";
            ch1QuickVolt.Size = new Size(120, 23);
            ch1QuickVolt.TabIndex = 1;
            ch1QuickVolt.Value = new decimal(new int[] { 2, 0, 0, 0 });
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
            // scriptedActionTab
            // 
            scriptedActionTab.Location = new Point(4, 24);
            scriptedActionTab.Name = "scriptedActionTab";
            scriptedActionTab.Padding = new Padding(3);
            scriptedActionTab.Size = new Size(492, 272);
            scriptedActionTab.TabIndex = 1;
            scriptedActionTab.Text = "Sequential actions";
            scriptedActionTab.UseVisualStyleBackColor = true;
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
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(deviceOutputGroup);
            Controls.Add(actionTabs);
            Controls.Add(label3);
            Controls.Add(deviceSetupGroup);
            Name = "MainForm";
            Text = "HV Sequencer Controller";
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
        private Button button1;
        private Label label3;
        private TabControl actionTabs;
        private TabPage quickActionTab;
        private TabPage scriptedActionTab;
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
    }
}
