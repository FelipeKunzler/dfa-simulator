using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.IO;
using System.Text;

namespace DFASimulator
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

		private bool canClearOutput = true;

		private void runDFA_Click(object sender, EventArgs e)
		{
			rtbInput.SelectionStart = 0;
			rtbInput.SelectionLength = rtbInput.TextLength;
			rtbInput.SelectionBackColor = Color.White;

			DFA DFA = new DFA(State.ConvertLinesToStates(rtbStates.Lines), rtbInput.Lines);
			lbOutput.Items.Clear();
			lbOutput.Items.AddRange(DFA.Run());

			bHighLightAll_Click(null, null);
		}

		private void lbOutput_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (lbOutput.SelectedItem != null)
			{
				this.canClearOutput = false;

				rtbInput.SelectionStart = 0;
				rtbInput.SelectionLength = rtbInput.TextLength;
				rtbInput.SelectionBackColor = Color.White;
				this.HighlightWord(lbOutput.SelectedItem.ToString());

				this.canClearOutput = true;
			}
		}

		private void HighlightWord(string value)
		{
			Regex regex = new Regex(@"\d+");
			Match match = regex.Match(value);

			int row = Convert.ToInt32(match.Value);
			int column = Convert.ToInt32(match.NextMatch().Value);

			rtbInput.SelectionStart = GetFirstCharIndexFromLine(rtbInput, row) + column + row;
			rtbInput.SelectionLength = value.Split('-')[1].Length - 1;
			rtbInput.SelectionBackColor = Color.Yellow;
		}

		private static int GetFirstCharIndexFromLine(RichTextBox box, int row)
		{
			int index = -1;
			if (box.Lines.Length >= row)
			{
				index = 0;
				for (int i = 0; i < row; i++)
				{
					index += box.Lines[i].Length;
				}
			}

			return index;
		}

		private void rtbInput_TextChanged(object sender, EventArgs e)
		{
			if (this.canClearOutput)
			{
				lbOutput.Items.Clear();
			}
		}

		private void bHighLightAll_Click(object sender, EventArgs e)
		{
			this.canClearOutput = false;
		
			rtbInput.SelectionStart = 0;
			rtbInput.SelectionLength = rtbInput.TextLength;
			rtbInput.SelectionBackColor = Color.White;
			lbOutput.SelectedIndex = -1;
			
			foreach (var item in lbOutput.Items)
			{
				this.HighlightWord(item.ToString());
			}

			this.canClearOutput = true;
		}

		private void loadInputText_Click(object sender, EventArgs e)
		{
			OpenFileDialog dialog = new OpenFileDialog();
			dialog.Filter = "TXT files|*.txt";
			if (dialog.ShowDialog() == DialogResult.OK)
			{
				string fileData = dialog.FileName;
				StreamReader sr = new StreamReader(fileData, Encoding.Default);
				rtbInput.Text = sr.ReadToEnd();
				sr.Close();
			}
		}
    }
}
