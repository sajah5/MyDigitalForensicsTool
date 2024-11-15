namespace MyFirstTry1.Forms
{
    partial class PasswordUnlocking
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
            iconButton1 = new FontAwesome.Sharp.IconButton();
            iconButtonMaskAttack = new FontAwesome.Sharp.IconButton();
            iconButtonRuleBasedAttack = new FontAwesome.Sharp.IconButton();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Courier New", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(231, 231, 231);
            label1.Location = new Point(105, 71);
            label1.Name = "label1";
            label1.Size = new Size(735, 34);
            label1.TabIndex = 0;
            label1.Text = "Choose the method to unlock the document";
            label1.Click += label1_Click;
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.FromArgb(231, 231, 231);
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.Font = new Font("Courier New", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            iconButton1.ForeColor = Color.FromArgb(27, 61, 87);
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.Location = new Point(293, 163);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(306, 29);
            iconButton1.TabIndex = 1;
            iconButton1.Text = "Dictionry-Based attack ";
            iconButton1.UseVisualStyleBackColor = false;
            iconButton1.Click += iconButton1_Click;
            // 
            // iconButtonMaskAttack
            // 
            iconButtonMaskAttack.BackColor = Color.FromArgb(231, 231, 231);
            iconButtonMaskAttack.FlatStyle = FlatStyle.Flat;
            iconButtonMaskAttack.Font = new Font("Courier New", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            iconButtonMaskAttack.ForeColor = Color.FromArgb(27, 61, 87);
            iconButtonMaskAttack.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButtonMaskAttack.IconColor = Color.Black;
            iconButtonMaskAttack.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonMaskAttack.Location = new Point(293, 214);
            iconButtonMaskAttack.Name = "iconButtonMaskAttack";
            iconButtonMaskAttack.Size = new Size(306, 29);
            iconButtonMaskAttack.TabIndex = 3;
            iconButtonMaskAttack.Text = "Mask Attack ";
            iconButtonMaskAttack.UseVisualStyleBackColor = false;
            iconButtonMaskAttack.Click += iconButtonMaskAttack_Click;
            // 
            // iconButtonRuleBasedAttack
            // 
            iconButtonRuleBasedAttack.BackColor = Color.FromArgb(231, 231, 231);
            iconButtonRuleBasedAttack.FlatStyle = FlatStyle.Flat;
            iconButtonRuleBasedAttack.Font = new Font("Courier New", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            iconButtonRuleBasedAttack.ForeColor = Color.FromArgb(27, 61, 87);
            iconButtonRuleBasedAttack.IconChar = FontAwesome.Sharp.IconChar.None;
            iconButtonRuleBasedAttack.IconColor = Color.Black;
            iconButtonRuleBasedAttack.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonRuleBasedAttack.Location = new Point(293, 266);
            iconButtonRuleBasedAttack.Name = "iconButtonRuleBasedAttack";
            iconButtonRuleBasedAttack.Size = new Size(306, 29);
            iconButtonRuleBasedAttack.TabIndex = 4;
            iconButtonRuleBasedAttack.Text = "Rule-Based Attack";
            iconButtonRuleBasedAttack.UseVisualStyleBackColor = false;
            iconButtonRuleBasedAttack.Click += iconButtonRuleBasedAttack_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("hooge 05_54", 23.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(231, 231, 231);
            label2.Location = new Point(260, 9);
            label2.Name = "label2";
            label2.Size = new Size(362, 50);
            label2.TabIndex = 5;
            label2.Text = "VerboInves";
            // 
            // PasswordUnlocking
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(27, 61, 87);
            ClientSize = new Size(914, 600);
            Controls.Add(label2);
            Controls.Add(iconButtonRuleBasedAttack);
            Controls.Add(iconButtonMaskAttack);
            Controls.Add(iconButton1);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "PasswordUnlocking";
            Text = "PasswordUnlocking";
            Load += PasswordUnlocking_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButtonMaskAttack;
        private FontAwesome.Sharp.IconButton iconButtonRuleBasedAttack;
        private Label label2;
    }
}