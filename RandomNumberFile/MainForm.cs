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

//Program: Random Number File Writer and Reader
//Developer: Randall Kim
//Date: 2/22/2019
//Description: Writes random numbers to a file and reads numbers from files

namespace RandomNumberFile
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void writeButton_Click(object sender, EventArgs e)
		{//write numbers and save
			int numberOfNumbers;
			
			if(int.TryParse(numbersTextBox.Text, out numberOfNumbers) && numberOfNumbers > 0)
			{//if input is valid
				if (saveFile.ShowDialog() == DialogResult.OK)
				{
					StreamWriter numberFile;
					numberFile = File.CreateText(saveFile.FileName);

					Random random = new Random();

					for (int count = 1; count <= numberOfNumbers; count++)
					{//write numbers
						numberFile.WriteLine(random.Next(100) + 1);
					}
					numberFile.Close();
				}
			}//end if input is valid
			else
			{//input is not valid
				MessageBox.Show("Number must be a positive integer");
			}
		}//end write click

		private void openButton_Click(object sender, EventArgs e)
		{//OpenFileDialog
			int total = 0;
			int numberOfNumbers = 0;
			int currentNumber;

			if(openFile.ShowDialog() == DialogResult.OK)
			{
				StreamReader numberFile;
				numberFile = File.OpenText(openFile.FileName);
				try
				{
					numbersListBox.Items.Clear();
					while (!numberFile.EndOfStream)
					{
						currentNumber = int.Parse(numberFile.ReadLine());
						numberOfNumbers++;
						total += currentNumber;
						numbersListBox.Items.Add(currentNumber);
					}//end while
					numberFile.Close();
					numbersLabel.Text = "Number of Numbers: " + numberOfNumbers;
					totalLabel.Text = "Total of Numbers: " + total;
				}//end try
				catch(Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}//end if dialogresult = ok
		}//end open click

		private void MainForm_Load(object sender, EventArgs e)
		{//form load
			numbersTextBox.Focus();
		}//end form load
	}//end form class
}//end namespace
