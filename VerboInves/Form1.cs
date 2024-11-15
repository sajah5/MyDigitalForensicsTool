using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using FontAwesome.Sharp;
using MyFirstTry1.Forms;
using Color = System.Drawing.Color;

namespace MyFirstTry1
{
    public partial class Form1 : Form
    {
        //Fields
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;

        //Constructor 
        public Form1()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        //Structs 
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(27, 62, 90);
            public static Color color2 = Color.FromArgb(27, 62, 90);
            public static Color color3 = Color.FromArgb(27, 62, 90);
            public static Color color4 = Color.FromArgb(27, 62, 90);

        }
        //Methods
        private void ActivatButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableBotton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(79, 140, 171);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left broder button 
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //Icon Current Child Form
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = color;
            }
        }

        private void DisableBotton()
        {
            if (currentBtn != null)
            {
                //currentBtn.BackColor = Color.FromArgb(50, 22, 100);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                //open only form 
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitleChildForm.Text = childForm.Text;
        }
        private void iconButton2_Click(object sender, EventArgs e)
        {
            ActivatButton(sender, RGBColors.color1);
            OpenChildForm(new Forms.Search());

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void iconButton3_Click(object sender, EventArgs e)
        {


            ActivatButton(sender, RGBColors.color3);
            OpenChildForm(new Forms.Inspection());
        }
        private void iconButton4_Click_1(object sender, EventArgs e)
        {
            ActivatButton(sender, RGBColors.color3);
            OpenChildForm(new Forms.Investigation());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            currentChildForm.Close();
            Reset();
        }
        private void Reset()
        {
            DisableBotton();
            leftBorderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = System.Drawing.Color.FromArgb(27, 61, 87);
            lblTitleChildForm.Text = "Home";
        }
        //Drag Form 
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panelDesktop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {


        }
        private void btnOpenOtherForms_Click(object sender, EventArgs e)
        {
            OpenOtherForms();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        // where you open other forms
        private void OpenOtherForms()
        {
            Forms.Search searchForm = new Forms.Search();
            // Show the Search form and get the filePath
            searchForm.ShowDialog();


        }

        private void lblTitleChildForm_Click(object sender, EventArgs e)
        {

        }
    }
}