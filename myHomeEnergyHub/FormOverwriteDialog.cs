using System;
using System.Windows.Forms;

namespace myHomeEnergyHub
{
    public enum OverwriteChoice
    {
        Overwrite,
        Skip,
        OverwriteAll,
        SkipAll
    }

    public partial class FormOverwriteDialog : Form
    {
        public OverwriteChoice Choice { get; private set; }

        public FormOverwriteDialog(string message)
        {
            InitializeComponent();
            lblMessage.Text = message;
        }

        private void btnOverwrite_Click(object sender, EventArgs e)
        {
            Choice = OverwriteChoice.Overwrite;
            Close();
        }

        private void btnSkip_Click(object sender, EventArgs e)
        {
            Choice = OverwriteChoice.Skip;
            Close();
        }

        private void btnOverwriteAll_Click(object sender, EventArgs e)
        {
            Choice = OverwriteChoice.OverwriteAll;
            Close();
        }

        private void btnSkipAll_Click(object sender, EventArgs e)
        {
            Choice = OverwriteChoice.SkipAll;
            Close();
        }
    }

}
