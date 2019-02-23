using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace RandomNumberFile
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void writeButton_Click(object sender, EventArgs e)
		{
			int numberOfNumbers;
			
			if(int.TryParse(numbersTextBox.Text, out numberOfNumbers) && numberOfNumbers > 0)
			{//if input is valid
				if (saveFile.ShowDialog() == DialogResult.OK)
				{
					StreamWriter numberFile;
					numberFile = File.CreateText(saveFile.FileName);

					Random random = new Random();

					for (int count = 1; count <= numberOfNumbers; count++)
					{
						numberFile.WriteLine(random.Next(100) + 1);
					}
					numberFile.Close();
				}
			}
			else
			{
				MessageBox.Show("Number must be a positive integer");
			}
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			numbersTextBox.Focus();
		}
	}
}
