using System;
using System.Net.Http;
using System.Windows.Forms;
using DocumentFormat.OpenXml.Packaging;

namespace MyFirstTry1.Forms
{
    public partial class Search : Form
    {
        public static string FilePath { get; set; }

        public Search()
        {
            InitializeComponent();
            DisplayFilePath(); // Call the method to display filePath
        }

        private void DisplayFilePath()
        {
            // Assuming you have a Label named lblFilePath on your form

        }

        private void btnSelectFile_Click_1(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Word Documents (*.docx, *.docm)|*.docx;*.docm|All Files (*.*)|*.*";


                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;  // Get the file path

                    try
                    {
                        using (WordprocessingDocument doc = WordprocessingDocument.Open(filePath, false))
                        {
                            MessageBox.Show("You can continue to the next process, The file does not contain a password");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("The file contain a password");
                        PasswordUnlocking passwordUnlocking = new PasswordUnlocking();
                        passwordUnlocking.Show();
                        Console.WriteLine("The file contain a password");
                        Console.WriteLine("Error: " + ex.Message);
                    }

                    // Set the FilePath property
                    FilePath = filePath;

                    DisplayFilePath();

                }
            }
        }

        // Add a method to open the PreProcess form
        private void InspectionForm()
        {
            if (!string.IsNullOrEmpty(FilePath))
            {
                Inspection InspectionForm = new Inspection(this, FilePath);
                InspectionForm.Show();
            }
            else
            {
                MessageBox.Show("Please select a file first.");
            }
        }

        // Call this method when you want to open the Pre-Process form
        private void btnOpenPreProcess_Click(object sender, EventArgs e)
        {
            InspectionForm();
        }

        private void lblFilePath_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}




