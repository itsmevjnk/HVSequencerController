namespace HVSequencerController
{
    partial class ControlActionEditForm
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
            ctrlActionOptionsTable = new TableLayoutPanel();
            ctrlActionChannelLabel = new Label();
            ctrlActionVoltageLabel = new Label();
            ctrlActionChannel = new NumericUpDown();
            ctrlActionOff = new RadioButton();
            ctrlActionOn = new RadioButton();
            ctrlActionVoltage = new NumericUpDown();
            tableLayoutPanel1 = new TableLayoutPanel();
            ctrlActionCancel = new Button();
            ctrlActionOk = new Button();
            ctrlActionOptionsTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ctrlActionChannel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ctrlActionVoltage).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // ctrlActionOptionsTable
            // 
            ctrlActionOptionsTable.ColumnCount = 3;
            ctrlActionOptionsTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            ctrlActionOptionsTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            ctrlActionOptionsTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            ctrlActionOptionsTable.Controls.Add(ctrlActionChannelLabel, 0, 0);
            ctrlActionOptionsTable.Controls.Add(ctrlActionVoltageLabel, 0, 1);
            ctrlActionOptionsTable.Controls.Add(ctrlActionChannel, 1, 0);
            ctrlActionOptionsTable.Controls.Add(ctrlActionOff, 1, 1);
            ctrlActionOptionsTable.Controls.Add(ctrlActionOn, 1, 2);
            ctrlActionOptionsTable.Controls.Add(ctrlActionVoltage, 2, 2);
            ctrlActionOptionsTable.Location = new Point(12, 12);
            ctrlActionOptionsTable.Name = "ctrlActionOptionsTable";
            ctrlActionOptionsTable.RowCount = 3;
            ctrlActionOptionsTable.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            ctrlActionOptionsTable.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            ctrlActionOptionsTable.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            ctrlActionOptionsTable.Size = new Size(249, 83);
            ctrlActionOptionsTable.TabIndex = 0;
            // 
            // ctrlActionChannelLabel
            // 
            ctrlActionChannelLabel.Anchor = AnchorStyles.Left;
            ctrlActionChannelLabel.AutoSize = true;
            ctrlActionChannelLabel.Location = new Point(3, 6);
            ctrlActionChannelLabel.Name = "ctrlActionChannelLabel";
            ctrlActionChannelLabel.Size = new Size(54, 15);
            ctrlActionChannelLabel.TabIndex = 0;
            ctrlActionChannelLabel.Text = "Channel:";
            // 
            // ctrlActionVoltageLabel
            // 
            ctrlActionVoltageLabel.Anchor = AnchorStyles.Left;
            ctrlActionVoltageLabel.AutoSize = true;
            ctrlActionVoltageLabel.Location = new Point(3, 33);
            ctrlActionVoltageLabel.Name = "ctrlActionVoltageLabel";
            ctrlActionVoltageLabel.Size = new Size(47, 15);
            ctrlActionVoltageLabel.TabIndex = 1;
            ctrlActionVoltageLabel.Text = "Setting:";
            // 
            // ctrlActionChannel
            // 
            ctrlActionChannel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            ctrlActionOptionsTable.SetColumnSpan(ctrlActionChannel, 2);
            ctrlActionChannel.Location = new Point(77, 3);
            ctrlActionChannel.Maximum = new decimal(new int[] { 4, 0, 0, 0 });
            ctrlActionChannel.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            ctrlActionChannel.Name = "ctrlActionChannel";
            ctrlActionChannel.Size = new Size(169, 23);
            ctrlActionChannel.TabIndex = 2;
            ctrlActionChannel.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // ctrlActionOff
            // 
            ctrlActionOff.Anchor = AnchorStyles.Left;
            ctrlActionOff.AutoSize = true;
            ctrlActionOff.Checked = true;
            ctrlActionOff.Location = new Point(77, 31);
            ctrlActionOff.Name = "ctrlActionOff";
            ctrlActionOff.Size = new Size(42, 19);
            ctrlActionOff.TabIndex = 3;
            ctrlActionOff.TabStop = true;
            ctrlActionOff.Text = "Off";
            ctrlActionOff.UseVisualStyleBackColor = true;
            ctrlActionOff.CheckedChanged += ctrlActionOff_CheckedChanged;
            // 
            // ctrlActionOn
            // 
            ctrlActionOn.Anchor = AnchorStyles.Left;
            ctrlActionOn.AutoSize = true;
            ctrlActionOn.Location = new Point(77, 59);
            ctrlActionOn.Name = "ctrlActionOn";
            ctrlActionOn.Size = new Size(91, 19);
            ctrlActionOn.TabIndex = 4;
            ctrlActionOn.TabStop = true;
            ctrlActionOn.Text = "Voltage (kV):";
            ctrlActionOn.UseVisualStyleBackColor = true;
            ctrlActionOn.CheckedChanged += ctrlActionOn_CheckedChanged;
            // 
            // ctrlActionVoltage
            // 
            ctrlActionVoltage.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            ctrlActionVoltage.DecimalPlaces = 3;
            ctrlActionVoltage.Enabled = false;
            ctrlActionVoltage.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            ctrlActionVoltage.Location = new Point(176, 57);
            ctrlActionVoltage.Maximum = new decimal(new int[] { 7000, 0, 0, 196608 });
            ctrlActionVoltage.Minimum = new decimal(new int[] { 2000, 0, 0, 196608 });
            ctrlActionVoltage.Name = "ctrlActionVoltage";
            ctrlActionVoltage.Size = new Size(70, 23);
            ctrlActionVoltage.TabIndex = 5;
            ctrlActionVoltage.Value = new decimal(new int[] { 2000, 0, 0, 196608 });
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(ctrlActionCancel, 0, 0);
            tableLayoutPanel1.Controls.Add(ctrlActionOk, 1, 0);
            tableLayoutPanel1.Location = new Point(12, 101);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(246, 33);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // ctrlActionCancel
            // 
            ctrlActionCancel.Anchor = AnchorStyles.None;
            ctrlActionCancel.Location = new Point(24, 5);
            ctrlActionCancel.Name = "ctrlActionCancel";
            ctrlActionCancel.Size = new Size(75, 23);
            ctrlActionCancel.TabIndex = 0;
            ctrlActionCancel.Text = "Cancel";
            ctrlActionCancel.UseVisualStyleBackColor = true;
            ctrlActionCancel.Click += ctrlActionCancel_Click;
            // 
            // ctrlActionOk
            // 
            ctrlActionOk.Anchor = AnchorStyles.None;
            ctrlActionOk.Location = new Point(147, 5);
            ctrlActionOk.Name = "ctrlActionOk";
            ctrlActionOk.Size = new Size(75, 23);
            ctrlActionOk.TabIndex = 1;
            ctrlActionOk.Text = "Save";
            ctrlActionOk.UseVisualStyleBackColor = true;
            ctrlActionOk.Click += ctrlActionOk_Click;
            // 
            // ControlActionEditForm
            // 
            AcceptButton = ctrlActionOk;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = ctrlActionCancel;
            ClientSize = new Size(273, 146);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(ctrlActionOptionsTable);
            Name = "ControlActionEditForm";
            Text = "Edit control action";
            Load += ControlActionEditForm_Load;
            ctrlActionOptionsTable.ResumeLayout(false);
            ctrlActionOptionsTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ctrlActionChannel).EndInit();
            ((System.ComponentModel.ISupportInitialize)ctrlActionVoltage).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel ctrlActionOptionsTable;
        private Label ctrlActionChannelLabel;
        private Label ctrlActionVoltageLabel;
        private NumericUpDown ctrlActionChannel;
        private RadioButton ctrlActionOff;
        private RadioButton ctrlActionOn;
        private NumericUpDown ctrlActionVoltage;
        private TableLayoutPanel tableLayoutPanel1;
        private Button ctrlActionCancel;
        private Button ctrlActionOk;
    }
}