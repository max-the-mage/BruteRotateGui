namespace BruteRotateGui
{
    partial class Form1
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
            this.userText = new System.Windows.Forms.TextBox();
            this.rotations = new System.Windows.Forms.NumericUpDown();
            this.characterOutput = new System.Windows.Forms.TextBox();
            this.primeOutput = new System.Windows.Forms.TextBox();
            this.rotateButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.rotations)).BeginInit();
            this.SuspendLayout();
            // 
            // userText
            // 
            this.userText.Location = new System.Drawing.Point(12, 12);
            this.userText.Multiline = true;
            this.userText.Name = "userText";
            this.userText.Size = new System.Drawing.Size(776, 202);
            this.userText.TabIndex = 0;
            // 
            // rotations
            // 
            this.rotations.Location = new System.Drawing.Point(12, 220);
            this.rotations.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.rotations.Name = "rotations";
            this.rotations.Size = new System.Drawing.Size(371, 20);
            this.rotations.TabIndex = 1;
            // 
            // characterOutput
            // 
            this.characterOutput.Location = new System.Drawing.Point(12, 246);
            this.characterOutput.Multiline = true;
            this.characterOutput.Name = "characterOutput";
            this.characterOutput.ReadOnly = true;
            this.characterOutput.Size = new System.Drawing.Size(776, 202);
            this.characterOutput.TabIndex = 2;
            // 
            // primeOutput
            // 
            this.primeOutput.Location = new System.Drawing.Point(12, 454);
            this.primeOutput.Multiline = true;
            this.primeOutput.Name = "primeOutput";
            this.primeOutput.ReadOnly = true;
            this.primeOutput.Size = new System.Drawing.Size(776, 202);
            this.primeOutput.TabIndex = 3;
            // 
            // rotateButton
            // 
            this.rotateButton.Location = new System.Drawing.Point(389, 220);
            this.rotateButton.Name = "rotateButton";
            this.rotateButton.Size = new System.Drawing.Size(399, 20);
            this.rotateButton.TabIndex = 4;
            this.rotateButton.Text = "Rotate";
            this.rotateButton.UseVisualStyleBackColor = true;
            this.rotateButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 667);
            this.Controls.Add(this.rotateButton);
            this.Controls.Add(this.primeOutput);
            this.Controls.Add(this.characterOutput);
            this.Controls.Add(this.rotations);
            this.Controls.Add(this.userText);
            this.Name = "Form1";
            this.Text = "BruteRotateGUI";
            ((System.ComponentModel.ISupportInitialize)(this.rotations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox userText;
        private System.Windows.Forms.NumericUpDown rotations;
        private System.Windows.Forms.TextBox characterOutput;
        private System.Windows.Forms.TextBox primeOutput;
        private System.Windows.Forms.Button rotateButton;
    }
}

