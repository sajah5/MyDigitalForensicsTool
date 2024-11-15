namespace MyFirstTry1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            panel3 = new Panel();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            panel5 = new Panel();
            iconButton4 = new FontAwesome.Sharp.IconButton();
            panel4 = new Panel();
            iconButton3 = new FontAwesome.Sharp.IconButton();
            panelTitleBar = new Panel();
            btnMinimize = new Button();
            btnClose = new Button();
            lblTitleChildForm = new Label();
            iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            panelShadow = new Panel();
            panelDesktop = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconCurrentChildForm).BeginInit();
            panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(88, 156, 190);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel5);
            panel1.ForeColor = Color.FromArgb(249, 111, 169);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(244, 868);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(4, 17);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(229, 216);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(88, 156, 190);
            panel3.Controls.Add(iconButton2);
            panel3.ForeColor = Color.FromArgb(227, 192, 255);
            panel3.Location = new Point(0, 243);
            panel3.Name = "panel3";
            panel3.Size = new Size(244, 73);
            panel3.TabIndex = 2;
            // 
            // iconButton2
            // 
            iconButton2.BackColor = Color.FromArgb(88, 156, 190);
            iconButton2.Dock = DockStyle.Top;
            iconButton2.FlatAppearance.BorderColor = Color.FromArgb(19, 19, 87);
            iconButton2.FlatAppearance.BorderSize = 0;
            iconButton2.FlatStyle = FlatStyle.Flat;
            iconButton2.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point);
            iconButton2.ForeColor = Color.FromArgb(231, 231, 231);
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.FileWord;
            iconButton2.IconColor = Color.FromArgb(231, 231, 231);
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconButton2.IconSize = 50;
            iconButton2.ImageAlign = ContentAlignment.TopLeft;
            iconButton2.Location = new Point(0, 0);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(244, 63);
            iconButton2.TabIndex = 0;
            iconButton2.TabStop = false;
            iconButton2.Text = "Search";
            iconButton2.TextAlign = ContentAlignment.MiddleLeft;
            iconButton2.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton2.UseVisualStyleBackColor = false;
            iconButton2.Click += iconButton2_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(88, 156, 190);
            panel5.Controls.Add(iconButton4);
            panel5.ForeColor = Color.MidnightBlue;
            panel5.Location = new Point(0, 400);
            panel5.Name = "panel5";
            panel5.Size = new Size(244, 73);
            panel5.TabIndex = 3;
            // 
            // iconButton4
            // 
            iconButton4.BackColor = Color.FromArgb(88, 156, 190);
            iconButton4.Dock = DockStyle.Top;
            iconButton4.FlatAppearance.BorderSize = 0;
            iconButton4.FlatStyle = FlatStyle.Flat;
            iconButton4.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            iconButton4.ForeColor = Color.FromArgb(231, 231, 231);
            iconButton4.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            iconButton4.IconColor = Color.FromArgb(231, 231, 231);
            iconButton4.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconButton4.IconSize = 50;
            iconButton4.ImageAlign = ContentAlignment.TopLeft;
            iconButton4.Location = new Point(0, 0);
            iconButton4.Name = "iconButton4";
            iconButton4.Size = new Size(244, 59);
            iconButton4.TabIndex = 1;
            iconButton4.Text = "Content Analysis";
            iconButton4.TextAlign = ContentAlignment.MiddleLeft;
            iconButton4.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton4.UseVisualStyleBackColor = false;
            iconButton4.Click += iconButton4_Click_1;
            // 
            // panel4
            // 
            panel4.BackColor = Color.MidnightBlue;
            panel4.Controls.Add(iconButton3);
            panel4.ForeColor = Color.MidnightBlue;
            panel4.Location = new Point(0, 322);
            panel4.Name = "panel4";
            panel4.Size = new Size(244, 61);
            panel4.TabIndex = 2;
            // 
            // iconButton3
            // 
            iconButton3.BackColor = Color.FromArgb(88, 156, 190);
            iconButton3.Dock = DockStyle.Top;
            iconButton3.FlatAppearance.BorderSize = 0;
            iconButton3.FlatStyle = FlatStyle.Flat;
            iconButton3.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            iconButton3.ForeColor = Color.FromArgb(231, 231, 231);
            iconButton3.IconChar = FontAwesome.Sharp.IconChar.WaveSquare;
            iconButton3.IconColor = Color.FromArgb(231, 231, 231);
            iconButton3.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconButton3.IconSize = 50;
            iconButton3.ImageAlign = ContentAlignment.TopLeft;
            iconButton3.Location = new Point(0, 0);
            iconButton3.Name = "iconButton3";
            iconButton3.Size = new Size(244, 61);
            iconButton3.TabIndex = 1;
            iconButton3.Text = "Document Inspection";
            iconButton3.TextAlign = ContentAlignment.MiddleLeft;
            iconButton3.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton3.UseVisualStyleBackColor = false;
            iconButton3.Click += iconButton3_Click;
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = Color.FromArgb(231, 231, 231);
            panelTitleBar.Controls.Add(btnMinimize);
            panelTitleBar.Controls.Add(btnClose);
            panelTitleBar.Controls.Add(lblTitleChildForm);
            panelTitleBar.Controls.Add(iconCurrentChildForm);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.ForeColor = Color.FromArgb(27, 61, 87);
            panelTitleBar.Location = new Point(0, 0);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(1158, 74);
            panelTitleBar.TabIndex = 5;
            panelTitleBar.MouseDown += panelTitleBar_MouseDown;
            // 
            // btnMinimize
            // 
            btnMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimize.FlatAppearance.BorderSize = 0;
            btnMinimize.FlatStyle = FlatStyle.Flat;
            btnMinimize.Font = new Font("Open Sans Semibold", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnMinimize.ForeColor = Color.FromArgb(27, 61, 87);
            btnMinimize.Location = new Point(1076, 0);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(39, 58);
            btnMinimize.TabIndex = 4;
            btnMinimize.Text = "___";
            btnMinimize.UseVisualStyleBackColor = true;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Open Sans Semibold", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnClose.ForeColor = Color.FromArgb(27, 61, 87);
            btnClose.Location = new Point(1121, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(25, 38);
            btnClose.TabIndex = 2;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // lblTitleChildForm
            // 
            lblTitleChildForm.AutoSize = true;
            lblTitleChildForm.Font = new Font("Franklin Gothic Demi", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitleChildForm.ForeColor = Color.FromArgb(27, 61, 87);
            lblTitleChildForm.Location = new Point(322, 37);
            lblTitleChildForm.Name = "lblTitleChildForm";
            lblTitleChildForm.Size = new Size(63, 25);
            lblTitleChildForm.TabIndex = 1;
            lblTitleChildForm.Text = "Home";
            lblTitleChildForm.Click += lblTitleChildForm_Click;
            // 
            // iconCurrentChildForm
            // 
            iconCurrentChildForm.BackColor = Color.FromArgb(231, 231, 231);
            iconCurrentChildForm.ForeColor = Color.FromArgb(27, 61, 87);
            iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.House;
            iconCurrentChildForm.IconColor = Color.FromArgb(27, 61, 87);
            iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconCurrentChildForm.IconSize = 43;
            iconCurrentChildForm.Location = new Point(273, 30);
            iconCurrentChildForm.Name = "iconCurrentChildForm";
            iconCurrentChildForm.Size = new Size(43, 44);
            iconCurrentChildForm.TabIndex = 0;
            iconCurrentChildForm.TabStop = false;
            // 
            // panelShadow
            // 
            panelShadow.BackColor = Color.FromArgb(231, 231, 231);
            panelShadow.Dock = DockStyle.Top;
            panelShadow.ForeColor = Color.FromArgb(249, 111, 169);
            panelShadow.Location = new Point(0, 74);
            panelShadow.Name = "panelShadow";
            panelShadow.Size = new Size(1158, 9);
            panelShadow.TabIndex = 6;
            // 
            // panelDesktop
            // 
            panelDesktop.BackColor = Color.FromArgb(231, 231, 231);
            panelDesktop.BorderStyle = BorderStyle.FixedSingle;
            panelDesktop.Controls.Add(label1);
            panelDesktop.Controls.Add(pictureBox1);
            panelDesktop.Dock = DockStyle.Fill;
            panelDesktop.ForeColor = Color.FromArgb(249, 111, 169);
            panelDesktop.Location = new Point(0, 0);
            panelDesktop.Name = "panelDesktop";
            panelDesktop.Size = new Size(1158, 770);
            panelDesktop.TabIndex = 7;
            panelDesktop.UseWaitCursor = true;
            panelDesktop.Paint += panelDesktop_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("hooge 05_54", 23.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(27, 61, 87);
            label1.Location = new Point(537, 540);
            label1.Name = "label1";
            label1.Size = new Size(362, 50);
            label1.TabIndex = 1;
            label1.Text = "VerboInves";
            label1.UseWaitCursor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(400, 79);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(595, 533);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.UseWaitCursor = true;
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.AliceBlue;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1158, 770);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Controls.Add(panelShadow);
            Controls.Add(panelTitleBar);
            Controls.Add(panelDesktop);
            Font = new Font("Andalus", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.RoyalBlue;
            Name = "Form1";
            Text = "VerboInves";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel3.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panelTitleBar.ResumeLayout(false);
            panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconCurrentChildForm).EndInit();
            panelDesktop.ResumeLayout(false);
            panelDesktop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public Panel panel1;
        private Panel panel3;
        private FontAwesome.Sharp.IconButton iconButton2;
        private Panel panel5;
        private FontAwesome.Sharp.IconButton iconButton4;
        private Panel panel4;
        private FontAwesome.Sharp.IconButton iconButton3;
        private Panel panelTitleBar;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private Label lblTitleChildForm;
        private Panel panelShadow;
        private Panel panelDesktop;
        private Button btnClose;
        private Button btnMinimize;
        private PictureBox pictureBox3;
        private PictureBox pictureBox1;
        private Label label1;
    }
}