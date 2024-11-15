namespace MyFirstTry1.Forms
{
    partial class Result2
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
            label1 = new Label();
            richTextBoxOutput = new RichTextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Cursor = Cursors.Hand;
            label1.Font = new Font("Courier New", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(231, 231, 231);
            label1.Location = new Point(110, 70);
            label1.Name = "label1";
            label1.Size = new Size(573, 34);
            label1.TabIndex = 0;
            label1.Text = "Here are the extracted keywords";
            label1.Click += label1_Click;
            // 
            // richTextBoxOutput
            // 
            richTextBoxOutput.BackColor = Color.FromArgb(231, 231, 231);
            richTextBoxOutput.Location = new Point(31, 120);
            richTextBoxOutput.Margin = new Padding(3, 4, 3, 4);
            richTextBoxOutput.Name = "richTextBoxOutput";
            richTextBoxOutput.Size = new Size(743, 308);
            richTextBoxOutput.TabIndex = 2;
            richTextBoxOutput.Text = "";
            richTextBoxOutput.TextChanged += richTextBoxOutput_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("hooge 05_54", 23.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(231, 231, 231);
            label2.Location = new Point(219, 9);
            label2.Name = "label2";
            label2.Size = new Size(362, 50);
            label2.TabIndex = 3;
            label2.Text = "VerboInves";
            label2.Click += label2_Click;
            // 
            // Result2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(27, 61, 87);
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(richTextBoxOutput);
            Controls.Add(label1);
            Name = "Result2";
            Text = "Keyword Search result";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RichTextBox richTextBoxOutput;
        private Label label2;
    }
}