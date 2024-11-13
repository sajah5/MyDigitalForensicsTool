using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using DocumentFormat.OpenXml.Spreadsheet;
using RestSharp;

namespace MyFirstTry1.Forms
{
    public partial class Inspection : Form
    {
        private Search searchForm;

        public Inspection()
        {
            
            InitializeComponent();
            DisplayFilePath();
        }

        public Inspection(Search searchForm, string file)
        {
            InitializeComponent();
            string file2 = Search.FilePath;
        }

        private void DisplayFilePath()
        {

        }

        private void SendFilePathToPython()
        {
            // Get the file path
            string filePath = Search.FilePath;

            // Define the REST client
            var baseUri = new Uri("http://127.0.0.1:8000");
            var client = new RestClient(baseUri);

            // Define the request with the correct endpoint
            var endpoint = new Uri(baseUri, "/process_file");
            var request = new RestRequest(endpoint, Method.Post);
            request.Timeout = (int)TimeSpan.FromMinutes(5).TotalMilliseconds;
            // Set the request content type
            request.AddHeader("Content-Type", "application/json");

            // Set the request body with the file path
            request.AddJsonBody(new { filePath });

            // Execute the request
            var response = client.Execute(request);

            // Handle the response if needed
            if (response.IsSuccessful)
            {
                // Do something with the response
                // Extract results from the response and pass them to the Report form
                MessageBox.Show("Results Ready, Click 'Ok' to view the Results");


                var results = Newtonsoft.Json.JsonConvert.DeserializeObject<dynamic>(response.Content);
                DisplayResultsInReport(results);
            }
            else
            {
                // Handle the error
                MessageBox.Show($"Error {response.ErrorMessage}");
            }
        }

        private void DisplayResultsInReport(dynamic results)
        {
            // Create an instance of the Result form
            if (results != null)
            {
                // Create an instance of the Result form
                Result resultForm = new Result();

                // Display the results in the Result form
                resultForm.DisplayResults(results);

                // Show the Result form
                resultForm.Show();
            }
            else
            {
                MessageBox.Show("No results to display. Perform the preprocessing first.");
            }


        }





        private void iconButton1_Click(object sender, EventArgs e)
        {
            // Call the method to send the file path to Python
            SendFilePathToPython();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
        }

        private void Inspection_Load(object sender, EventArgs e)
        {
        }
    }
}

