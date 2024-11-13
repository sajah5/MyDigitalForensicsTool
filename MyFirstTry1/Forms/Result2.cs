using System;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace MyFirstTry1.Forms
{
    public partial class Result2 : Form
    {
        public Result2()
        {
            InitializeComponent();
        }

        public void DisplayResults2(dynamic results)
        {
            try
            {
                // Assuming results is a JSON string
                JObject resultObject = JObject.Parse(results.result.ToString());

                // Check if there are any results
                if (resultObject.HasValues)
                {
                    richTextBoxOutput.Text = "Words from the word list found in the Word file:";

                    foreach (var pair in resultObject)
                    {
                        string word = pair.Key;
                        var info = pair.Value;

                        richTextBoxOutput.AppendText($"\n\nWord: {word}");
                        richTextBoxOutput.AppendText($"\nTotal repetitions: {info["count"]}");
                        richTextBoxOutput.AppendText("\nLocations:");

                        foreach (var location in info["locations"])
                        {
                            int paragraphNum = (int)location[0]; // Adjust the index based on your JSON structure
                            string line = location[1].ToString(); // Assuming "line" is the second element in the array

                            richTextBoxOutput.AppendText($"\n Line: {paragraphNum}, Paragraph: {line}");
                        }
                    }
                }
                else
                {
                    richTextBoxOutput.Text = "No results found.";
                }
            }
            catch (Exception ex)
            {
                richTextBoxOutput.Text = $"Error processing results: {ex.Message}";
            }
        }




        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label2word_Click(object sender, EventArgs e)
        {

        }

        private void richTextBoxOutput_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}



