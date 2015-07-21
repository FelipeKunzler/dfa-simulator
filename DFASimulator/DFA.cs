using System.Collections.Generic;

namespace DFASimulator
{
	public class DFA
	{
		private int currentIndex;
		private string nextState;
		private int startIndexWord;
		private string initialState;
		private string word;

		public DFA(State[] states, string[] input)
		{
			this.States = states;
			this.Input = input;
		}

		public State[] States { get; set; }

		public string[] Input { get; set; }
		
		public string[] Run()
		{
			List<string> output = new List<string>();
			if (this.Input.Length > 0 && this.States != null && this.States.Length > 0)
			{
				for (int i = 0; i < this.Input.Length; i++)
				{
					this.currentIndex = 0;
					this.startIndexWord = -1;
					this.initialState = this.States[0].Name;
					this.word = string.Empty;
					this.nextState = initialState;

					foreach (char c in this.Input[i])
					{
						// Le o proximo char e armazena halted se a palavra foi encontrada.
						int endIndexWord = this.ReadNext(c);

						this.currentIndex++;

						// Se uma palavra foi encontrada, armazena o index inicial da mesma.
						if (endIndexWord >= 0)
						{
							output.Add(string.Format("Linha: {0}, Coluna: {1} - {2}", i, this.startIndexWord, this.word));
							this.startIndexWord = -1;
							this.word = string.Empty;
							this.nextState = this.initialState;
						}
					}
				}
			}

			return output.ToArray();
		}

		private int ReadNext(char c)
		{
			foreach (State state in this.States)
			{
				// Aceita o estado caso o nome seja o mesmo, o char seja o esperado e o próximo estado NÃO seja o estado inicial (significa que estamos lendo a palavra novamente).
				if (state.Name == this.nextState && state.ExpectedChar == c && state.NextStateName != this.initialState)
				{
					this.nextState = state.NextStateName;

					// Só armazana o initial index caso a palavra não esteja sendo lida atualmente.
					this.startIndexWord = this.startIndexWord == -1 ? this.currentIndex : this.startIndexWord;
					this.word += c;

					if (state.NextStateName == "halt")
					{
						return this.currentIndex;
					}

					return -1;
				}
			}

			this.startIndexWord = -1;
			this.word = string.Empty;

			// Se a palavra não foi encontada, permita tentar novamente com o estado inicial.
			if (this.nextState != this.initialState)
			{
				this.nextState = this.initialState;
				return this.ReadNext(c);
			}

			return -1;
		}
	}
}