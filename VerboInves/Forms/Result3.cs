using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Collections.Generic;

namespace MyFirstTry1.Forms
{
    public partial class Result3 : Form
    {
        public Result3()
        {
            InitializeComponent();
        }
        public class ExtractionResult
        {
            public List<string> mentioned_professional_names { get; set; }
            public List<string> mentioned_female_names { get; set; }
            public List<string> mentioned_male_names { get; set; }
            public List<string> mentioned_usernames { get; set; }
            public List<string> mentioned_passwords { get; set; }
            public List<string> mentioned_phone_numbers { get; set; }
            public List<string> mentioned_emails { get; set; }
            public List<string> mentioned_hashes { get; set; }
            public List<string> mentioned_dates { get; set; }
            public List<string> mentioned_clock_hours { get; set; }
            public List<string> mentioned_cities { get; set; }
            public List<string> mentioned_coordinates { get; set; }
            public List<string> mentioned_ipv4_addresses { get; set; }
            public List<string> mentioned_ipv6_addresses { get; set; }
            public List<string> mentioned_mac_addresses { get; set; }
            public List<string> mentioned_device_os { get; set; }
            public List<string> mentioned_hyperlinks { get; set; }
            public List<string> mentioned_websites { get; set; }



        }
        public void DisplayResults3(dynamic results)
        {
            // Deserialize JSON result
            var extractionResult = JsonConvert.DeserializeObject<ExtractionResult>(results);

            // Display the results in the RichTextBox
            richTextBoxResults.AppendText("Display Possible Identity Data\n");
            richTextBoxResults.AppendText("\n");
            DisplayInRichTextBox("mentioned_professional_names:", extractionResult.mentioned_professional_names);
            DisplayInRichTextBox("mentioned_female_names:", extractionResult.mentioned_female_names);
            DisplayInRichTextBox("mentioned_male_names:", extractionResult.mentioned_male_names);

            richTextBoxResults.AppendText("Display Possible Login Data\n");
            richTextBoxResults.AppendText("\n");
            DisplayInRichTextBox("mentioned_usernames:", extractionResult.mentioned_usernames);
            DisplayInRichTextBox("mentioned_passwords:", extractionResult.mentioned_passwords);

            richTextBoxResults.AppendText("Display Possible Personal Data\n");
            richTextBoxResults.AppendText("\n");
            DisplayInRichTextBox("mentioned_phone_numbers:", extractionResult.mentioned_phone_numbers);
            DisplayInRichTextBox("mentioned_emails:", extractionResult.mentioned_emails);
            DisplayInRichTextBox("mentioned_hashes:", extractionResult.mentioned_hashes);

            richTextBoxResults.AppendText("Display Geolocation and Timeline Data\n");
            richTextBoxResults.AppendText("\n");
            DisplayInRichTextBox("mentioned_dates:", extractionResult.mentioned_dates);
            DisplayInRichTextBox("mentioned_clock_hours:", extractionResult.mentioned_clock_hours);
            DisplayInRichTextBox("mentioned_cities:", extractionResult.mentioned_cities);
            DisplayInRichTextBox("mentioned_coordinates:", extractionResult.mentioned_coordinates);

            richTextBoxResults.AppendText("Display Possible Online Activity Data\n");
            richTextBoxResults.AppendText("\n");
            DisplayInRichTextBox("mentioned_hyperlinks:", extractionResult.mentioned_hyperlinks);
            DisplayInRichTextBox("mentioned_websites:", extractionResult.mentioned_websites);

            richTextBoxResults.AppendText("Display Possible Device Identification Data\n");
            richTextBoxResults.AppendText("\n");
            DisplayInRichTextBox("mentioned_ipv4_addresses:", extractionResult.mentioned_ipv4_addresses);
            DisplayInRichTextBox("mentioned_ipv6_addresses:", extractionResult.mentioned_ipv6_addresses);
            DisplayInRichTextBox("mentioned_mac_addresses:", extractionResult.mentioned_mac_addresses);
            DisplayInRichTextBox("mentioned_device_os:", extractionResult.mentioned_device_os);

        }

        private void DisplayInRichTextBox(string category, List<string> data)
        {
            richTextBoxResults.AppendText($"{category}\n");


            foreach (var item in data)
            {
                richTextBoxResults.AppendText($"{item}\n");
            }

            richTextBoxResults.AppendText("\n\n");
        }

        private void labelArtifact_Click(object sender, EventArgs e)
        {
        }

        private void richTextBoxResults_TextChanged(object sender, EventArgs e)
        {
        }
    }
}






