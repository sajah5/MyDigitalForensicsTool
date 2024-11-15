namespace MyFirstTry1.Forms
{
    partial class Investigation
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
            iconButtonExtractArtifact = new FontAwesome.Sharp.IconButton();
            iconButtonWordList = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            SuspendLayout();
            // 
            // iconButtonExtractArtifact
            // 
            iconButtonExtractArtifact.BackColor = Color.FromArgb(27, 61, 87);
            iconButtonExtractArtifact.BackgroundImageLayout = ImageLayout.Zoom;
            iconButtonExtractArtifact.FlatStyle = FlatStyle.Flat;
            iconButtonExtractArtifact.Font = new Font("Courier New", 12F, FontStyle.Bold, GraphicsUnit.Point);
            iconButtonExtractArtifact.ForeColor = Color.FromArgb(231, 231, 231);
            iconButtonExtractArtifact.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButtonExtractArtifact.IconColor = Color.Black;
            iconButtonExtractArtifact.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonExtractArtifact.Location = new Point(475, 314);
            iconButtonExtractArtifact.Name = "iconButtonExtractArtifact";
            iconButtonExtractArtifact.Size = new Size(332, 40);
            iconButtonExtractArtifact.TabIndex = 1;
            iconButtonExtractArtifact.Text = "Click to Extract Artifact";
            iconButtonExtractArtifact.UseVisualStyleBackColor = false;
            iconButtonExtractArtifact.Click += iconButtonExtractArtifact_Click;
            // 
            // iconButtonWordList
            // 
            iconButtonWordList.BackColor = Color.FromArgb(27, 61, 87);
            iconButtonWordList.Cursor = Cursors.Hand;
            iconButtonWordList.FlatStyle = FlatStyle.Flat;
            iconButtonWordList.Font = new Font("Courier New", 12F, FontStyle.Bold, GraphicsUnit.Point);
            iconButtonWordList.ForeColor = Color.FromArgb(231, 231, 231);
            iconButtonWordList.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButtonWordList.IconColor = Color.Black;
            iconButtonWordList.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonWordList.Location = new Point(475, 388);
            iconButtonWordList.Name = "iconButtonWordList";
            iconButtonWordList.Size = new Size(332, 40);
            iconButtonWordList.TabIndex = 2;
            iconButtonWordList.Text = "Click to Extract Keyword";
            iconButtonWordList.UseVisualStyleBackColor = false;
            iconButtonWordList.Click += iconButtonWordList_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Courier New", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(27, 61, 87);
            label1.Location = new Point(357, 235);
            label1.Name = "label1";
            label1.Size = new Size(614, 27);
            label1.TabIndex = 3;
            label1.Text = "Select the type of data you want to extract";
            // 
            // Investigation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(231, 231, 231);
            ClientSize = new Size(1076, 493);
            Controls.Add(label1);
            Controls.Add(iconButtonWordList);
            Controls.Add(iconButtonExtractArtifact);
            Name = "Content Analysis";
            Text = "Content Analysis";
            Load += Investigation_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private FontAwesome.Sharp.IconButton iconButtonExtractArtifact;
        private FontAwesome.Sharp.IconButton iconButtonWordList;
        private Label label1;
    }
}