using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestSharp;
using System.IO;
using DocumentFormat.OpenXml.Spreadsheet;

namespace MyFirstTry1.Forms
{
    public partial class PasswordUnlocking : Form
    {
        public PasswordUnlocking(string filePath)
        {
            InitializeComponent();
        }

        public PasswordUnlocking()
        {
            InitializeComponent();
            DisplayFilePath();
        }

        private void DisplayFilePath()
        {
            string filePath = Search.FilePath;

        }

        private void SendFilePathToPython3()
        {
            string filePath = Search.FilePath;

            var baseUri = new Uri("http://127.0.0.1:8030");
            var client = new RestClient(baseUri);

            var endpoint = new Uri(baseUri, "/process_file");
            var request = new RestRequest(endpoint, Method.Post);

            request.AddHeader("Content-Type", "application/json");
            request.AddJsonBody(new { docxFilePath = filePath }); // Use consistent naming

            var response = client.Execute(request);

            if (response.IsSuccessful)
            {
                var results = Newtonsoft.Json.JsonConvert.DeserializeObject<dynamic>(response.Content);
                
                MessageBox.Show("The file was opened successfully" );
            }
            else
            {
                MessageBox.Show($"Error {response.ErrorMessage}");
                // Provide more context in the error message
            }
        }
        private void SendFilePathToPython4()
        {
            string filePath = Search.FilePath;

            var baseUri = new Uri("http://127.0.0.1:8040");
            var client = new RestClient(baseUri);

            var endpoint = new Uri(baseUri, "/process_file");
            var request = new RestRequest(endpoint, Method.Post);

            request.AddHeader("Content-Type", "application/json");
            request.AddJsonBody(new { docxFilePath = filePath }); // Use consistent naming
            request.Timeout = (int)TimeSpan.FromMinutes(5).TotalMilliseconds;

            var response = client.Execute(request);

            if (response.IsSuccessful)
            {
                var results = Newtonsoft.Json.JsonConvert.DeserializeObject<dynamic>(response.Content);
                MessageBox.Show("The file was opened successfully");
                // DisplayResultsInReport(results);
            }
            else
            {
                MessageBox.Show($"Error {response.ErrorMessage}");
                // Provide more context in the error message
            }
        }
        private void SendFilePathToPython5()
        {
            string filePath = Search.FilePath;

            var baseUri = new Uri("http://127.0.0.1:8050");
            var client = new RestClient(baseUri);

            var endpoint = new Uri(baseUri, "/process_file");
            var request = new RestRequest(endpoint, Method.Post);

            request.AddHeader("Content-Type", "application/json");
            request.AddJsonBody(new { docxFilePath = filePath }); // Use consistent naming

            var response = client.Execute(request);

            if (response.IsSuccessful)
            {
                var results = Newtonsoft.Json.JsonConvert.DeserializeObject<dynamic>(response.Content);
                MessageBox.Show("The file was opened successfully");
            }
            else
            {
                MessageBox.Show($"Error {response.ErrorMessage}");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            SendFilePathToPython3();
        }

        private void PasswordUnlocking_Load(object sender, EventArgs e)
        {
        }

        private void iconButtonMaskAttack_Click(object sender, EventArgs e)
        {
            SendFilePathToPython4();
        }

        private void iconButtonRuleBasedAttack_Click(object sender, EventArgs e)
        {
            SendFilePathToPython5();
        }

        private void textBoxFilePath3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

