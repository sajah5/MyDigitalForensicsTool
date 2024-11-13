namespace MyFirstTry1.Forms
{
    partial class Result3
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
            labelArtifact = new Label();
            richTextBoxResults = new RichTextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // labelArtifact
            // 
            labelArtifact.AutoSize = true;
            labelArtifact.Font = new Font("Courier New", 18F, FontStyle.Bold, GraphicsUnit.Point);
            labelArtifact.ForeColor = Color.FromArgb(231, 231, 231);
            labelArtifact.Location = new Point(105, 71);
            labelArtifact.Name = "labelArtifact";
            labelArtifact.Size = new Size(591, 34);
            labelArtifact.TabIndex = 0;
            labelArtifact.Text = "Here are the extracted artifacts";
            labelArtifact.Click += labelArtifact_Click;
            // 
            // richTextBoxResults
            // 
            richTextBoxResults.BackColor = Color.FromArgb(231, 231, 231);
            richTextBoxResults.Font = new Font("Courier New", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point);
            richTextBoxResults.ForeColor = Color.FromArgb(27, 61, 87);
            richTextBoxResults.Location = new Point(31, 120);
            richTextBoxResults.Margin = new Padding(3, 4, 3, 4);
            richTextBoxResults.Name = "richTextBoxResults";
            richTextBoxResults.Size = new Size(743, 308);
            richTextBoxResults.TabIndex = 1;
            richTextBoxResults.Text = "";
            richTextBoxResults.TextChanged += richTextBoxResults_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("hooge 05_54", 23.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(231, 231, 231);
            label1.Location = new Point(219, 9);
            label1.Name = "label1";
            label1.Size = new Size(362, 50);
            label1.TabIndex = 2;
            label1.Text = "VerboInves";
            // 
            // Result3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(27, 61, 87);
            ClientSize = new Size(800, 451);
            Controls.Add(label1);
            Controls.Add(richTextBoxResults);
            Controls.Add(labelArtifact);
            Name = "Result3";
            Text = "Result3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelArtifact;
        private RichTextBox richTextBoxResults;
        private Label label1;
    }
}