﻿
namespace SharpMaster
{
	partial class WriteFloatControl
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.NumericUpDown numericUpDownFloatValue;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.NumericUpDown numericUpDownSlaveAddress;
		private System.Windows.Forms.Button buttonWrite;
		private System.Windows.Forms.NumericUpDown numericUpDownRegisterAddress;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox comboBoxFunctionCode;
		
		/// <summary>
		/// Disposes resources used by the control.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.label3 = new System.Windows.Forms.Label();
			this.numericUpDownFloatValue = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.numericUpDownSlaveAddress = new System.Windows.Forms.NumericUpDown();
			this.buttonWrite = new System.Windows.Forms.Button();
			this.numericUpDownRegisterAddress = new System.Windows.Forms.NumericUpDown();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.comboBoxFunctionCode = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownFloatValue)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownSlaveAddress)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownRegisterAddress)).BeginInit();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(224, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(34, 13);
			this.label3.TabIndex = 19;
			this.label3.Text = "Value";
			// 
			// numericUpDownRegisterValue
			// 
			this.numericUpDownFloatValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.numericUpDownFloatValue.DecimalPlaces = 2;
			this.numericUpDownFloatValue.Increment = new decimal(new int[] {
			1,
			0,
			0,
			65536});
			this.numericUpDownFloatValue.Location = new System.Drawing.Point(224, 17);
			this.numericUpDownFloatValue.Maximum = new decimal(new int[] {
			1000000000,
			0,
			0,
			0});
			this.numericUpDownFloatValue.Minimum = new decimal(new int[] {
			1000000000,
			0,
			0,
			-2147483648});
			this.numericUpDownFloatValue.Name = "numericUpDownRegisterValue";
			this.numericUpDownFloatValue.Size = new System.Drawing.Size(68, 20);
			this.numericUpDownFloatValue.TabIndex = 20;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(87, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(34, 13);
			this.label1.TabIndex = 14;
			this.label1.Text = "Slave";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(150, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(45, 13);
			this.label2.TabIndex = 17;
			this.label2.Text = "Address";
			// 
			// numericUpDownSlaveAddress
			// 
			this.numericUpDownSlaveAddress.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.numericUpDownSlaveAddress.Location = new System.Drawing.Point(87, 17);
			this.numericUpDownSlaveAddress.Maximum = new decimal(new int[] {
			255,
			0,
			0,
			0});
			this.numericUpDownSlaveAddress.Name = "numericUpDownSlaveAddress";
			this.numericUpDownSlaveAddress.Size = new System.Drawing.Size(57, 20);
			this.numericUpDownSlaveAddress.TabIndex = 15;
			// 
			// buttonWrite
			// 
			this.buttonWrite.Dock = System.Windows.Forms.DockStyle.Fill;
			this.buttonWrite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonWrite.Location = new System.Drawing.Point(298, 16);
			this.buttonWrite.Name = "buttonWrite";
			this.buttonWrite.Size = new System.Drawing.Size(68, 22);
			this.buttonWrite.TabIndex = 16;
			this.buttonWrite.Text = "Write";
			this.buttonWrite.UseVisualStyleBackColor = true;
			this.buttonWrite.Click += new System.EventHandler(this.ButtonWriteClick);
			// 
			// numericUpDownRegisterAddress
			// 
			this.numericUpDownRegisterAddress.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.numericUpDownRegisterAddress.Location = new System.Drawing.Point(150, 17);
			this.numericUpDownRegisterAddress.Maximum = new decimal(new int[] {
			65535,
			0,
			0,
			0});
			this.numericUpDownRegisterAddress.Name = "numericUpDownRegisterAddress";
			this.numericUpDownRegisterAddress.Size = new System.Drawing.Size(68, 20);
			this.numericUpDownRegisterAddress.TabIndex = 18;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.AutoSize = true;
			this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.tableLayoutPanel1.ColumnCount = 5;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.Controls.Add(this.comboBoxFunctionCode, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.buttonWrite, 4, 1);
			this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.label3, 3, 0);
			this.tableLayoutPanel1.Controls.Add(this.numericUpDownSlaveAddress, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.label2, 2, 0);
			this.tableLayoutPanel1.Controls.Add(this.numericUpDownFloatValue, 3, 1);
			this.tableLayoutPanel1.Controls.Add(this.numericUpDownRegisterAddress, 2, 1);
			this.tableLayoutPanel1.Controls.Add(this.label4, 0, 0);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.Size = new System.Drawing.Size(369, 41);
			this.tableLayoutPanel1.TabIndex = 21;
			// 
			// comboBoxFunctionCode
			// 
			this.comboBoxFunctionCode.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.comboBoxFunctionCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxFunctionCode.FormattingEnabled = true;
			this.comboBoxFunctionCode.Items.AddRange(new object[] {
			"6 Holding"});
			this.comboBoxFunctionCode.Location = new System.Drawing.Point(3, 16);
			this.comboBoxFunctionCode.Name = "comboBoxFunctionCode";
			this.comboBoxFunctionCode.Size = new System.Drawing.Size(78, 21);
			this.comboBoxFunctionCode.TabIndex = 23;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(3, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(48, 13);
			this.label4.TabIndex = 22;
			this.label4.Text = "Function";
			// 
			// WriteFloatControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "WriteFloatControl";
			this.Size = new System.Drawing.Size(372, 44);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownFloatValue)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownSlaveAddress)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownRegisterAddress)).EndInit();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
