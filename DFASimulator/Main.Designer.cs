namespace DFASimulator
{
    partial class Main
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.rtbStates = new System.Windows.Forms.RichTextBox();
			this.runDFA = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.bHighLightAll = new System.Windows.Forms.Button();
			this.lbOutput = new System.Windows.Forms.ListBox();
			this.label3 = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.loadInputText = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.rtbInput = new System.Windows.Forms.RichTextBox();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.rtbStates);
			this.panel1.Controls.Add(this.runDFA);
			this.panel1.Location = new System.Drawing.Point(366, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(188, 366);
			this.panel1.TabIndex = 6;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 6);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(109, 13);
			this.label1.TabIndex = 5;
			this.label1.Text = "Configuração do DFA";
			// 
			// rtbStates
			// 
			this.rtbStates.Location = new System.Drawing.Point(3, 22);
			this.rtbStates.Name = "rtbStates";
			this.rtbStates.Size = new System.Drawing.Size(182, 316);
			this.rtbStates.TabIndex = 4;
			this.rtbStates.Text = "q1;0;q2\nq2;0;q3\nq3;0;halt\nq1;1;q4\nq4;1;q5\nq5;1;halt";
			// 
			// runDFA
			// 
			this.runDFA.Location = new System.Drawing.Point(3, 343);
			this.runDFA.Name = "runDFA";
			this.runDFA.Size = new System.Drawing.Size(182, 23);
			this.runDFA.TabIndex = 9;
			this.runDFA.Text = "Executar DFA";
			this.runDFA.UseVisualStyleBackColor = true;
			this.runDFA.Click += new System.EventHandler(this.runDFA_Click);
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.bHighLightAll);
			this.panel2.Controls.Add(this.lbOutput);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Location = new System.Drawing.Point(560, 3);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(188, 366);
			this.panel2.TabIndex = 7;
			// 
			// bHighLightAll
			// 
			this.bHighLightAll.Location = new System.Drawing.Point(3, 342);
			this.bHighLightAll.Name = "bHighLightAll";
			this.bHighLightAll.Size = new System.Drawing.Size(182, 23);
			this.bHighLightAll.TabIndex = 10;
			this.bHighLightAll.Text = "Destacar Todas";
			this.bHighLightAll.UseVisualStyleBackColor = true;
			this.bHighLightAll.Click += new System.EventHandler(this.bHighLightAll_Click);
			// 
			// lbOutput
			// 
			this.lbOutput.FormattingEnabled = true;
			this.lbOutput.Location = new System.Drawing.Point(3, 22);
			this.lbOutput.Name = "lbOutput";
			this.lbOutput.Size = new System.Drawing.Size(182, 316);
			this.lbOutput.TabIndex = 11;
			this.lbOutput.SelectedIndexChanged += new System.EventHandler(this.lbOutput_SelectedIndexChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(3, 6);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(36, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "Saída";
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.loadInputText);
			this.panel3.Controls.Add(this.label4);
			this.panel3.Controls.Add(this.rtbInput);
			this.panel3.Location = new System.Drawing.Point(2, 3);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(358, 369);
			this.panel3.TabIndex = 7;
			// 
			// loadInputText
			// 
			this.loadInputText.Location = new System.Drawing.Point(3, 343);
			this.loadInputText.Name = "loadInputText";
			this.loadInputText.Size = new System.Drawing.Size(349, 22);
			this.loadInputText.TabIndex = 8;
			this.loadInputText.Text = "Carregar Texto";
			this.loadInputText.UseVisualStyleBackColor = true;
			this.loadInputText.Click += new System.EventHandler(this.loadInputText_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(3, 6);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(88, 13);
			this.label4.TabIndex = 5;
			this.label4.Text = "Texto de entrada";
			// 
			// rtbInput
			// 
			this.rtbInput.DetectUrls = false;
			this.rtbInput.Location = new System.Drawing.Point(3, 22);
			this.rtbInput.Name = "rtbInput";
			this.rtbInput.Size = new System.Drawing.Size(349, 316);
			this.rtbInput.TabIndex = 4;
			this.rtbInput.Text = "1000111\n0011011100\n0001111100";
			this.rtbInput.WordWrap = false;
			this.rtbInput.TextChanged += new System.EventHandler(this.rtbInput_TextChanged);
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(749, 374);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "Main";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Simulador DFA";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtbStates;
        private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox rtbInput;
        private System.Windows.Forms.Button runDFA;
        private System.Windows.Forms.Button bHighLightAll;
        private System.Windows.Forms.Button loadInputText;
		private System.Windows.Forms.ListBox lbOutput;

    }
}

