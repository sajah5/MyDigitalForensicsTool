using DocumentFormat.OpenXml.EMMA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstTry1.Forms
{
    public partial class Result : Form
    {
        private dynamic results;

        public Result()
        {
            InitializeComponent();

        }
        public void DisplayResults(dynamic results)
        {
            this.results = results;

            LabelVBA.Text = results.vba_code.ToString();
            labelHash.Text = results.hash_value;

            
            labelAuthor.Text = results.metadata.author ?? "X";

            labelCreated.Text = results.metadata.created ?? "X";
            labelLastModifiedBy.Text = results.metadata.last_modified_by ?? "X";
            labelmodified.Text = results.metadata.modified ?? "X";
            labelsize.Text = results.metadata.size ?? "X";
            labelcomments.Text = results.metadata.comments ?? "X";
            labelcontent_status.Text = results.metadata.content_status ?? "X";
            labeltitle.Text = results.metadata.title ?? "X";
            labelkeywords.Text = results.metadata.keywords ?? "X";
            labelsubject.Text = results.metadata.subject ?? "X";
            labelcategory.Text = results.metadata.category ?? "X";
            labelpages.Text = results.metadata.pages;
            labelwords.Text = results.metadata.words ?? "X";
            labelwatermark.Text = results.metadata.watermark ?? "X";
        }
        private void LabelVBA_Click(object sender, EventArgs e)
        {

        }

        private void labelHash_Click(object sender, EventArgs e)
        {

        }

        private void labelAuthor_Click(object sender, EventArgs e)
        {

        }

        private void labelCreated_Click(object sender, EventArgs e)
        {

        }

        private void labelLastModifiedBy_Click(object sender, EventArgs e)
        {

        }

        private void labelmodified_Click(object sender, EventArgs e)
        {

        }

        private void labelsize_Click(object sender, EventArgs e)
        {

        }

        private void labelcomments_Click(object sender, EventArgs e)
        {

        }

        private void labelcontent_status_Click(object sender, EventArgs e)
        {

        }

        private void labeltitle_Click(object sender, EventArgs e)
        {

        }

        private void labelkeywords_Click(object sender, EventArgs e)
        {

        }

        private void labelsubject_Click(object sender, EventArgs e)
        {

        }

        private void labelcategory_Click(object sender, EventArgs e)
        {

        }

        private void labelpages_Click(object sender, EventArgs e)
        {

        }

        private void labelwords_Click(object sender, EventArgs e)
        {

        }

        private void labelwatermark_Click(object sender, EventArgs e)
        {

        }

        private void Artifact_Click(object sender, EventArgs e)
        {

        }

        private void labelWordList_Click(object sender, EventArgs e)
        {

        }

        private void labelmodified_Click_1(object sender, EventArgs e)
        {

        }

        private void labelsize_Click_1(object sender, EventArgs e)
        {

        }

        private void Result_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
