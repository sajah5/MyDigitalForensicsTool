namespace MyFirstTry1.Forms
{
    partial class Search
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
            btnSelectFile = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnSelectFile
            // 
            btnSelectFile.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnSelectFile.AutoSize = true;
            btnSelectFile.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSelectFile.BackColor = Color.FromArgb(27, 61, 87);
            btnSelectFile.Cursor = Cursors.Hand;
            btnSelectFile.DialogResult = DialogResult.Retry;
            btnSelectFile.FlatStyle = FlatStyle.Flat;
            btnSelectFile.Font = new Font("Courier New", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSelectFile.ForeColor = Color.FromArgb(249, 249, 249);
            btnSelectFile.Location = new Point(538, 358);
            btnSelectFile.Name = "btnSelectFile";
            btnSelectFile.Size = new Size(274, 35);
            btnSelectFile.TabIndex = 0;
            btnSelectFile.Text = "UPLOAD File from HERE";
            btnSelectFile.UseVisualStyleBackColor = false;
            btnSelectFile.Click += btnSelectFile_Click_1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Courier New", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(27, 61, 87);
            label1.Location = new Point(491, 287);
            label1.Name = "label1";
            label1.Size = new Size(362, 27);
            label1.TabIndex = 1;
            label1.Text = "Choose the file to start ";
            label1.Click += label1_Click;
            // 
            // Search
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(231, 231, 231);
            ClientSize = new Size(997, 609);
            Controls.Add(label1);
            Controls.Add(btnSelectFile);
            Name = "Search";
            Text = "Search";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSelectFile;
        private Label label1;
    }
}