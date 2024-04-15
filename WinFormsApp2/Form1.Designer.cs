namespace WinFormsApp2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ucLedBoard1 = new ucLedBoard();
            numericUpDown1 = new NumericUpDown();
            textBox1 = new TextBox();
            ucLedBoard2 = new ucLedBoard();
            ucLedBoard3 = new ucLedBoard();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // ucLedBoard1
            // 
            ucLedBoard1.BackColor = SystemColors.WindowText;
            ucLedBoard1.DisplayText = "";
            ucLedBoard1.LedCount = 5;
            ucLedBoard1.Location = new Point(12, 262);
            ucLedBoard1.Name = "ucLedBoard1";
            ucLedBoard1.Size = new Size(405, 111);
            ucLedBoard1.TabIndex = 3;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(12, 229);
            numericUpDown1.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(35, 27);
            numericUpDown1.TabIndex = 4;
            numericUpDown1.Value = new decimal(new int[] { 5, 0, 0, 0 });
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(53, 229);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 5;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // ucLedBoard2
            // 
            ucLedBoard2.DisplayText = "";
            ucLedBoard2.LedCount = 4;
            ucLedBoard2.Location = new Point(263, 84);
            ucLedBoard2.Name = "ucLedBoard2";
            ucLedBoard2.Size = new Size(324, 111);
            ucLedBoard2.TabIndex = 6;
            // 
            // ucLedBoard3
            // 
            ucLedBoard3.DisplayText = "";
            ucLedBoard3.LedCount = 5;
            ucLedBoard3.Location = new Point(383, 229);
            ucLedBoard3.Name = "ucLedBoard3";
            ucLedBoard3.Size = new Size(405, 111);
            ucLedBoard3.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ucLedBoard3);
            Controls.Add(ucLedBoard2);
            Controls.Add(textBox1);
            Controls.Add(numericUpDown1);
            Controls.Add(ucLedBoard1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ucLedBoard ucLedBoard1;
        private NumericUpDown numericUpDown1;
        private TextBox textBox1;
        private ucLedBoard ucLedBoard2;
        private ucLedBoard ucLedBoard3;
    }
}