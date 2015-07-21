namespace DFASimulator
{
	using System.Collections.Generic;
	using System.Windows.Forms;

	public class State
	{
		public string Name { get; set; }
		public string NextStateName { get; set; }
		public char ExpectedChar { get; set; }

		public static State[] ConvertLinesToStates(string[] lines)
		{
			List<State> states = new List<State>();
			foreach (string line in lines)
			{
				if (string.IsNullOrEmpty(line))
				{
					continue;
				}

				State state = new State();
				string[] fields = line.Split(';');
				if (fields.Length == 3 && !string.IsNullOrEmpty(fields[0]) && !string.IsNullOrEmpty(fields[2]))
				{
					state.Name = fields[0];
					state.ExpectedChar = fields[1][0];
					state.NextStateName = fields[2];
				}
				else
				{
					MessageBox.Show("Erro na sintaxe da Configuração do DFA.", "Simulador DFA", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return new List<State>().ToArray();
				}

				states.Add(state);
			}

			return states.ToArray();
		}
	}
}
