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
    public partial class Investigation : Form
    {
        public Investigation()
        {
            InitializeComponent();
            DisplayFilePath();
        }
        public Investigation(Search searchForm, string file)
        {
            InitializeComponent();
            string file3 = Search.FilePath;
        }
        private void DisplayFilePath()
        {



        }

        private void Investigation_Load(object sender, EventArgs e)
        {

        }
        private void SendFilePathToPython1()
        {
            // Get the file path
            string filePath = Search.FilePath;

            // Define the REST client
            var baseUri = new Uri("http://127.0.0.1:8010");
            var client = new RestClient(baseUri);

            // Define the request with the correct endpoint
            var endpoint = new Uri(baseUri, "/Artifact");
            var request = new RestRequest(endpoint, Method.Post);

            // Set the request content type
            request.AddHeader("Content-Type", "application/json");

            // Set the request body with the file path
            request.AddJsonBody(new { docxFilePath = filePath });

            // Execute the request
            var response = client.Execute(request);

            // Handle the response if needed
            if (response.IsSuccessful)
            {
                // Do something with the response
                MessageBox.Show("Results Ready, Click 'Ok' to view the Results");
                //var result2 = Newtonsoft.Json.JsonConvert.DeserializeObject<dynamic>(response.Content);
                var Result2 = response.Content;
                DisplayResultsInReport3(Result2); // Use the result here
            }
            else
            {
                // Handle the error
                MessageBox.Show($"Error {response.ErrorMessage}");
            }
        }

        private void DisplayResultsInReport3(dynamic results2)
        {
            // Create an instance of the Result form
            Result3 resultForm = new Result3();

            // Display the results in the Result form
            resultForm.DisplayResults3(results2);

            // Show the Result form
            resultForm.Show();

        }
        private void SendFilePathToPython2()
        {
            // Get the file path
            string filePath = Search.FilePath;

            // Define the REST client
            var baseUri = new Uri("http://127.0.0.1:8020");
            var client = new RestClient(baseUri);

            // Define the request with the correct endpoint
            var endpoint = new Uri(baseUri, "/compare_words");
            var request = new RestRequest(endpoint, Method.Post);

            // Set the request content type
            request.AddHeader("Content-Type", "application/json");

            // Set the request body with the file path
            request.AddJsonBody(new { docxFilePath = filePath }); // Use docxFilePath

            // Execute the request
            var response = client.Execute(request);

            // Handle the response if needed
            if (response.IsSuccessful)
            {
                // Do something with the response
                MessageBox.Show("Results Ready, Click 'Ok' to view the Result");
                var results = Newtonsoft.Json.JsonConvert.DeserializeObject<dynamic>(response.Content);
                DisplayResultsInReport2(results);
            }
            else
            {
                // Handle the error
                MessageBox.Show($"Error {response.ErrorMessage}");
            }
        }

        private void DisplayResultsInReport2(dynamic results)
        {
            // Create an instance of the Result form
            if (results != null)
            {
                // Create an instance of the Result form
                Result2 resultForm = new Result2();

                // Display the results in the Result form
                resultForm.DisplayResults2(results);

                // Show the Result form
                resultForm.Show();
            }
            else
            {
                MessageBox.Show("No results to display. Perform the preprocessing first.");
            }


        }
        private void iconButtonExtractArtifact_Click(object sender, EventArgs e)
        {
            // Call the method to send the file path to Python
            SendFilePathToPython1();
        }

        private void textBoxFilePath1_TextChanged(object sender, EventArgs e)
        {

        }

        private void iconButtonWordList_Click(object sender, EventArgs e)
        {
            SendFilePathToPython2();
        }
    }
}
