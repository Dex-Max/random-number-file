namespace RandomNumberFile
{
	partial class MainForm
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
			this.generateLabel = new System.Windows.Forms.Label();
			this.numbersTextBox = new System.Windows.Forms.TextBox();
			this.writeButton = new System.Windows.Forms.Button();
			this.openButton = new System.Windows.Forms.Button();
			this.numbersLabel = new System.Windows.Forms.Label();
			this.totalLabel = new System.Windows.Forms.Label();
			this.numbersListBox = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// generateLabel
			// 
			this.generateLabel.AutoSize = true;
			this.generateLabel.Location = new System.Drawing.Point(93, 56);
			this.generateLabel.Name = "generateLabel";
			this.generateLabel.Size = new System.Drawing.Size(111, 13);
			this.generateLabel.TabIndex = 0;
			this.generateLabel.Text = "Numbers to Generate:";
			// 
			// numbersTextBox
			// 
			this.numbersTextBox.Location = new System.Drawing.Point(210, 53);
			this.numbersTextBox.Name = "numbersTextBox";
			this.numbersTextBox.Size = new System.Drawing.Size(71, 20);
			this.numbersTextBox.TabIndex = 1;
			// 
			// writeButton
			// 
			this.writeButton.Location = new System.Drawing.Point(310, 51);
			this.writeButton.Name = "writeButton";
			this.writeButton.Size = new System.Drawing.Size(113, 23);
			this.writeButton.TabIndex = 2;
			this.writeButton.Text = "Generate and Save";
			this.writeButton.UseVisualStyleBackColor = true;
			// 
			// openButton
			// 
			this.openButton.Location = new System.Drawing.Point(105, 133);
			this.openButton.Name = "openButton";
			this.openButton.Size = new System.Drawing.Size(75, 23);
			this.openButton.TabIndex = 3;
			this.openButton.Text = "Open";
			this.openButton.UseVisualStyleBackColor = true;
			// 
			// numbersLabel
			// 
			this.numbersLabel.AutoSize = true;
			this.numbersLabel.Location = new System.Drawing.Point(102, 197);
			this.numbersLabel.Name = "numbersLabel";
			this.numbersLabel.Size = new System.Drawing.Size(104, 13);
			this.numbersLabel.TabIndex = 4;
			this.numbersLabel.Text = "Number of Numbers:";
			// 
			// totalLabel
			// 
			this.totalLabel.AutoSize = true;
			this.totalLabel.Location = new System.Drawing.Point(102, 250);
			this.totalLabel.Name = "totalLabel";
			this.totalLabel.Size = new System.Drawing.Size(91, 13);
			this.totalLabel.TabIndex = 5;
			this.totalLabel.Text = "Total of Numbers:";
			// 
			// numbersListBox
			// 
			this.numbersListBox.FormattingEnabled = true;
			this.numbersListBox.Location = new System.Drawing.Point(303, 133);
			this.numbersListBox.Name = "numbersListBox";
			this.numbersListBox.Size = new System.Drawing.Size(120, 147);
			this.numbersListBox.TabIndex = 6;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(532, 335);
			this.Controls.Add(this.numbersListBox);
			this.Controls.Add(this.totalLabel);
			this.Controls.Add(this.numbersLabel);
			this.Controls.Add(this.openButton);
			this.Controls.Add(this.writeButton);
			this.Controls.Add(this.numbersTextBox);
			this.Controls.Add(this.generateLabel);
			this.Name = "MainForm";
			this.Text = "Random Number File";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label generateLabel;
		private System.Windows.Forms.TextBox numbersTextBox;
		private System.Windows.Forms.Button writeButton;
		private System.Windows.Forms.Button openButton;
		private System.Windows.Forms.Label numbersLabel;
		private System.Windows.Forms.Label totalLabel;
		private System.Windows.Forms.ListBox numbersListBox;
	}
}

