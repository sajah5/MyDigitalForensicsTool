namespace MyFirstTry1.Forms
{
    partial class Inspection
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
            iconButton1 = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            SuspendLayout();
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.FromArgb(27, 61, 87);
            iconButton1.Cursor = Cursors.Hand;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.Font = new Font("Courier New", 12F, FontStyle.Bold, GraphicsUnit.Point);
            iconButton1.ForeColor = Color.FromArgb(231, 231, 231);
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.Location = new Point(475, 314);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(332, 40);
            iconButton1.TabIndex = 0;
            iconButton1.Text = "Start Inspection";
            iconButton1.UseVisualStyleBackColor = false;
            iconButton1.Click += iconButton1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Courier New", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(27, 61, 87);
            label1.Location = new Point(326, 257);
            label1.Name = "label1";
            label1.Size = new Size(656, 27);
            label1.TabIndex = 1;
            label1.Text = "Click here to initiate the document inspection";
            // 
            // PreProcess
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(231, 231, 231);
            ClientSize = new Size(994, 513);
            Controls.Add(label1);
            Controls.Add(iconButton1);
            Name = "Document Inspection";
            Text = "Document Inspection";
            Load += Inspection_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton iconButton1;
        private Label label1;
    }
}